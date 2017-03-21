//-----------------------------------------------------------------------
// <copyright file="AccessTokenAssertionRequest.cs" company="YTML Consulting">
//     Copyright (c) YTML Consulting Pty Ltd. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using DotNetOpenAuth.Messaging;
using DotNetOpenAuth.Messaging.Reflection;
using DotNetOpenAuth.OAuth2.ChannelElements;
using System;
using System.Collections.Generic;
using System.Net.Http;
using Validation;

namespace DotNetOpenAuth.OAuth2.Messages
{
    /// <summary>
    /// A request for access token conforming to the assertion framework for OAuth 2.0 (https://tools.ietf.org/html/rfc7521#section-4.1),
    /// which operates in the context of OAuth2 extension grant authorisation flow (https://tools.ietf.org/html/rfc6749#section-4.5).
    /// 
    /// Instead of sending client_id and client_secret, a JSON Web Token (JWT) may be used (ie the assertion)
    /// (https://tools.ietf.org/html/rfc7523). The JWT should be signed so that it can be used to authenticate the
    /// (non-user affiliated) client at the same time authorisation is performed.
    /// </summary>
    public class AccessTokenAssertionRequest : MessageBase, IAccessTokenRequestInternal, IAuthorizationCarryingRequest
    {
        //private readonly System.Net.Http.Headers.HttpRequestHeaders mHttpHeaders = new HttpRequestMessage().Headers;

        private IAccessTokenResult mAccessTokenResult;
        private DateTime mAccessTokenResultAssignedTime;
        private IAssertionProvider mAssertionProvider;


        /// <summary>
        /// Constructor for receiving a request.
        /// </summary>
        /// <param name="tokenEndpoint"></param>
        /// <param name="version"></param>
        internal AccessTokenAssertionRequest(Uri tokenEndpoint, Version version)
            : base(version, MessageTransport.Direct, tokenEndpoint)
        {
            mAssertionProvider = new MyAssertionStorage();
            this.HttpMethods = HttpDeliveryMethods.PostRequest;
            this.Scope = new HashSet<string>(OAuthUtilities.ScopeStringComparer);
        }

        /// <summary>
        /// Constructor for sending a request.
        /// An IAssertionProvider must be given so that assertion data can be queried from it.
        /// </summary>
        /// <param name="assertProv"></param>
        /// <param name="tokenEndpoint"></param>
        /// <param name="version"></param>
        internal AccessTokenAssertionRequest(IAssertionProvider assertProv, Uri tokenEndpoint, Version version)
            : base(version, MessageTransport.Direct, tokenEndpoint)
        {
            Requires.NotNull(assertProv, "assertProv");
            mAssertionProvider = assertProv;
            this.HttpMethods = HttpDeliveryMethods.PostRequest;
            this.Scope = new HashSet<string>(OAuthUtilities.ScopeStringComparer);
        }

        /// <summary>
        /// Gets the type of the grant by querying our assertion provider.
        /// Unlike the grant_type of client credentials grant, this value is variable depending on the assertion used.
        /// </summary>
        [MessagePart(Protocol.grant_type, IsRequired = true)]
        public virtual string GrantType
        {
            get
            {
                // When sending an assertion request, we ask the external assertion provider for the value.
                return mAssertionProvider.GrantType;
            }
            internal set
            {
                // When receiving an assertion request, our constructor uses MyAssertionStorage as the assertion provider.
                ((MyAssertionStorage)mAssertionProvider).GrantType = value;
            }
        }

        /// <summary>
        /// Get the actual assertion value used for authorisation and authentication.
        /// </summary>
        [MessagePart(Protocol.assertion, IsRequired = true)]
        public virtual string AssertionValue
        {
            get
            {
                // When sending an assertion request, we ask the external assertion provider for the value.
                return mAssertionProvider.AssertionValue;
            }
            internal set
            {
                // When receiving an assertion request, our constructor uses MyAssertionStorage as the assertion provider.
                ((MyAssertionStorage)mAssertionProvider).AssertionValue = value;
            }
        }


        #region IAccessTokenRequestInternal
        /// <summary>
        /// Access token created will be assigned to this property.
        /// The time that this property is assigned will be the this.AuthorizationDescription.UtcIssued value.
        /// </summary>
        public IAccessTokenResult AccessTokenResult
        {
            get
            {
                return mAccessTokenResult;
            }
            set
            {
                mAccessTokenResult = value;
                if (value == null)
                {
                    mAccessTokenResultAssignedTime = DateTime.MinValue;
                }
                else
                {
                    mAccessTokenResultAssignedTime = DateTime.UtcNow;
                }
            }
        }

        /// <summary>
        /// Initially false until authenticated by a IAuthorizationServerHost.
        /// </summary>
        public bool ClientAuthenticated
        {
            get;
            set;
        }

        /// <summary>
        /// client_id is optional, so this is initially null unless set by the request.
        /// </summary>
        public string ClientIdentifier
        {
            get;
            set;
        }

        /// <summary>
        /// Always returns null.
        /// </summary>
        public string UserName
        {
            get { return null; }
        }

        /// <summary>
        /// This property is initially an empty set.
        /// </summary>
        public HashSet<string> Scope
        {
            get;
            private set;
        }
        #endregion

        #region IAuthorizationCarryingRequest
        /// <summary>
        /// Returns a description of the authorisation based on the values present in this request.
        /// Depending on when this property is accessed, the object returned is different.
        /// </summary>
        public IAuthorizationDescription AuthorizationDescription
        {
            get
            {
                // Because set is not immutable, we create a new instance.
                var scope = new HashSet<string>(OAuthUtilities.ScopeStringComparer);
                scope.AddRange(this.Scope);
                return new MyAuthorizationDescription(this.ClientIdentifier, this.UserName, mAccessTokenResultAssignedTime, scope);
            }
        }
        #endregion

        private class MyAssertionStorage : IAssertionProvider
        {
            public string AssertionValue
            {
                get;
                set;
            }

            public string GrantType
            {
                get;
                set;
            }
        }

        private class MyAuthorizationDescription : IAuthorizationDescription
        {
            public MyAuthorizationDescription(string client_id, string user_id, DateTime issued, HashSet<string> scope)
            {
                this.ClientIdentifier = client_id;
                this.User = user_id;
                this.UtcIssued = issued;
                this.Scope = scope;
            }

            public string ClientIdentifier { get; private set; }

            public DateTime UtcIssued { get; private set; }

            public string User { get; private set; }

            public HashSet<string> Scope { get; private set; }
        }

    }
}
