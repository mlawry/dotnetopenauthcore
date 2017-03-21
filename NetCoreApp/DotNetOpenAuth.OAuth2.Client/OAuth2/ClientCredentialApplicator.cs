//-----------------------------------------------------------------------
// <copyright file="ClientCredentialApplicator.cs" company="Andrew Arnott">
//     Copyright (c) Andrew Arnott. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace DotNetOpenAuth.OAuth2 {
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Net;
	using System.Net.Http;
	using System.Text;
	using DotNetOpenAuth.Messaging;
	using DotNetOpenAuth.OAuth2.Messages;
	using Validation;

	/// <summary>
	/// A base class for extensions that apply client authentication to messages for the authorization server in specific ways.
	/// </summary>
	public abstract class ClientCredentialApplicator {
		/// <summary>
		/// Initializes a new instance of the <see cref="ClientCredentialApplicator"/> class.
		/// </summary>
		protected ClientCredentialApplicator() {
		}

		/// <summary>
		/// Transmits the secret the client shares with the authorization server as a parameter in the POST entity payload.
		/// </summary>
		/// <param name="clientSecret">The secret the client shares with the authorization server.</param>
		/// <returns>The credential applicator to provide to the <see cref="ClientBase"/> instance.</returns>
		public static ClientCredentialApplicator PostParameter(string clientSecret) {
			Requires.NotNullOrEmpty(clientSecret, "clientSecret");
			return new PostParameterApplicator(clientSecret);
		}

		/// <summary>
		/// Transmits the client identifier and secret in the HTTP Authorization header via HTTP Basic authentication.
		/// </summary>
		/// <param name="credential">The client id and secret.</param>
		/// <returns>The credential applicator to provide to the <see cref="ClientBase"/> instance.</returns>
		public static ClientCredentialApplicator NetworkCredential(NetworkCredential credential) {
			Requires.NotNull(credential, "credential");
			return new NetworkCredentialApplicator(credential);
		}

		/// <summary>
		/// Transmits the client identifier and secret in the HTTP Authorization header via HTTP Basic authentication.
		/// </summary>
		/// <param name="clientSecret">The secret the client shares with the authorization server.</param>
		/// <returns>The credential applicator to provide to the <see cref="ClientBase"/> instance.</returns>
		public static ClientCredentialApplicator NetworkCredential(string clientSecret) {
			Requires.NotNullOrEmpty(clientSecret, "clientSecret");
			return new NetworkCredentialApplicator(clientSecret);
		}

		/// <summary>
		/// Never transmits a secret.  Useful for anonymous clients or clients unable to keep a secret.
		/// </summary>
		/// <returns>The credential applicator to provide to the <see cref="ClientBase"/> instance.</returns>
		public static ClientCredentialApplicator NoSecret() {
			return null;
		}

		/// <summary>
		/// Applies the client identifier and (when applicable) the client authentication to an outbound message.
		/// </summary>
		/// <param name="clientIdentifier">The identifier by which the authorization server should recognize this client.</param>
		/// <param name="request">The outbound message to apply authentication information to.</param>
		/// <remarks>
		/// Different types of outbound message should have the credentials applied differently.
		/// The most common types of outbound messages (ie the most common interfaces implemented by 'request' are):
		/// 
		/// + IHttpDirectRequest: credentials applied to HTTP header.
		/// + AuthenticatedClientRequestBase: credentials applied to client_id and client_secret
		/// + AccessTokenRequestBase: in addition to above, included grant_type, scope, etc.
		/// 
		/// You may have to test the 'request' parameter to see which interfaces it implements or which classes
		/// it inherits in order to work out how to apply the credentials.
		/// </remarks>
		public virtual void ApplyClientCredential(string clientIdentifier, IAccessTokenRequest request)
		{
		}

		/// <summary>
		/// Applies the client identifier and (when applicable) the client authentication to an outbound message.
		/// </summary>
		/// <param name="clientIdentifier">The identifier by which the authorization server should recognize this client.</param>
		/// <param name="request">The outbound message to apply authentication information to.</param>
		public virtual void ApplyClientCredential(string clientIdentifier, HttpRequestMessage request) {
		}

		/// <summary>
		/// Authenticates the client via HTTP Basic.
		/// </summary>
		private class NetworkCredentialApplicator : ClientCredentialApplicator {
			/// <summary>
			/// The client identifier and secret.
			/// </summary>
			private readonly NetworkCredential credential;

			/// <summary>
			/// The client secret.
			/// </summary>
			private readonly string clientSecret;

			/// <summary>
			/// Initializes a new instance of the <see cref="NetworkCredentialApplicator"/> class.
			/// </summary>
			/// <param name="clientSecret">The client secret.</param>
			internal NetworkCredentialApplicator(string clientSecret) {
				Requires.NotNullOrEmpty(clientSecret, "clientSecret");
				this.clientSecret = clientSecret;
			}

			/// <summary>
			/// Initializes a new instance of the <see cref="NetworkCredentialApplicator"/> class.
			/// </summary>
			/// <param name="credential">The client credential.</param>
			internal NetworkCredentialApplicator(NetworkCredential credential) {
				Requires.NotNull(credential, "credential");
				this.credential = credential;
			}

			/// <summary>
			/// Applies the client identifier and (when applicable) the client authentication to an outbound message.
			/// </summary>
			/// <param name="clientIdentifier">The identifier by which the authorization server should recognize this client.</param>
			/// <param name="request">The outbound message to apply authentication information to.</param>
			public override void ApplyClientCredential(string clientIdentifier, IAccessTokenRequest request)
			{
				var authRequest = request as AuthenticatedClientRequestBase;
				if (authRequest != null)
				{
					// When using network credentials, the client authentication is not done as standard message parts.
					authRequest.ClientIdentifier = null;
					authRequest.ClientSecret = null;
				}
			}

			/// <summary>
			/// Applies the client identifier and (when applicable) the client authentication to an outbound message.
			/// </summary>
			/// <param name="clientIdentifier">The identifier by which the authorization server should recognize this client.</param>
			/// <param name="request">The outbound message to apply authentication information to.</param>
			public override void ApplyClientCredential(string clientIdentifier, HttpRequestMessage request) {
				if (clientIdentifier != null) {
					if (this.credential != null) {
						ErrorUtilities.VerifyHost(
							string.Equals(this.credential.UserName, clientIdentifier, StringComparison.Ordinal),
							"Client identifiers \"{0}\" and \"{1}\" do not match.",
							this.credential.UserName,
							clientIdentifier);
					}

					// HttpWebRequest ignores the Credentials property until the remote server returns a 401 Unauthorized.
					// So we also set the HTTP Authorization request header directly.
					OAuthUtilities.ApplyHttpBasicAuth(request.Headers, clientIdentifier, this.clientSecret);
				}
			}
		}

		/// <summary>
		/// Authenticates the client via a client_secret parameter in the message.
		/// </summary>
		private class PostParameterApplicator : ClientCredentialApplicator {
			/// <summary>
			/// The client secret.
			/// </summary>
			private readonly string secret;

			/// <summary>
			/// Initializes a new instance of the <see cref="PostParameterApplicator"/> class.
			/// </summary>
			/// <param name="clientSecret">The client secret.</param>
			internal PostParameterApplicator(string clientSecret) {
				Requires.NotNullOrEmpty(clientSecret, "clientSecret");
				this.secret = clientSecret;
			}

			/// <summary>
			/// Applies the client identifier and (when applicable) the client authentication to an outbound message.
			/// </summary>
			/// <param name="clientIdentifier">The identifier by which the authorization server should recognize this client.</param>
			/// <param name="request">The outbound message to apply authentication information to.</param>
			public override void ApplyClientCredential(string clientIdentifier, IAccessTokenRequest request)
			{
				var authRequest = request as AuthenticatedClientRequestBase;
				if (authRequest != null)
				{
					if (clientIdentifier != null)
					{
						authRequest.ClientSecret = this.secret;
					}
				}
			}
		}

		/// <summary>
		/// YTML: A hack to store an IAssertionProvider as a ClientCredentialApplicator.
		/// </summary>
		internal class AssertionProviderApplicator : ClientCredentialApplicator
		{
			internal AssertionProviderApplicator(IAssertionProvider ap)
			{
				this.AssertionProvider = ap;
			}

			public IAssertionProvider AssertionProvider { get; private set; }
		}
	}
}
