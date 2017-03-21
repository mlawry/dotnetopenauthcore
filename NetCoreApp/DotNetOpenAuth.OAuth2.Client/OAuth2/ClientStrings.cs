
namespace DotNetOpenAuth.OAuth2
{
    using System;


    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    internal class ClientStrings
    {
        /// <summary>
        ///   Looks up a localized string similar to Access token has expired and cannot be automatically refreshed..
        /// </summary>
        internal static string AccessTokenRefreshFailed
        {
            get
            {
                return "Access token has expired and cannot be automatically refreshed.";
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Authorization has expired..
        /// </summary>
        internal static string AuthorizationExpired
        {
            get
            {
                return "Authorization has expired.";
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Unexpected OAuth authorization response received with callback and client state that does not match an expected value..
        /// </summary>
        internal static string AuthorizationResponseUnexpectedMismatch
        {
            get
            {
                return "Unexpected OAuth authorization response received with callback and client state that does not match an expected value.";
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Failed to obtain access token.  Authorization Server reports reason: {0}.
        /// </summary>
        internal static string CannotObtainAccessTokenWithReason
        {
            get
            {
                return "Failed to obtain access token.  Authorization Server reports reason: {0}";
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Unexpected response Content-Type {0}.
        /// </summary>
        internal static string UnexpectedResponseContentType
        {
            get
            {
                return "Unexpected response Content-Type {0}";
            }
        }
    }
}
