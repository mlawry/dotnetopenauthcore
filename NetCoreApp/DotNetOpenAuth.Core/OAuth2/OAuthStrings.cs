
namespace DotNetOpenAuth.OAuth2
{
    using System;


    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    public class OAuthStrings
    {
        /// <summary>
        ///   Looks up a localized string similar to The value for message part &quot;{0}&quot; must be an absolute URI..
        /// </summary>
        public static string AbsoluteUriRequired
        {
            get
            {
                return "The value for message part '{0}' must be an absolute URI.";
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The access token contains characters that must not appear in the HTTP Authorization header..
        /// </summary>
        internal static string AccessTokenInvalidForHttpAuthorizationHeader
        {
            get
            {
                return "The access token contains characters that must not appear in the HTTP Authorization header.";
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to At least one parameter is required for the Bearer scheme in its WWW-Authenticate header..
        /// </summary>
        internal static string BearerTokenUnauthorizedAtLeastOneParameterRequired
        {
            get
            {
                return "At least one parameter is required for the Bearer scheme in its WWW-Authenticate header.";
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to This message can only be sent over HTTPS..
        /// </summary>
        public static string HttpsRequired
        {
            get
            {
                return "This message can only be sent over HTTPS.";
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The scope token &quot;{0}&quot; contains illegal characters or is empty..
        /// </summary>
        internal static string InvalidScopeToken
        {
            get
            {
                return "The scope token '{0}' contains illegal characters or is empty.";
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Refresh tokens should not be granted without the request including an access grant..
        /// </summary>
        internal static string NoGrantNoRefreshToken
        {
            get
            {
                return "Refresh tokens should not be granted without the request including an access grant.";
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The &apos;{0}&apos; parameter contains the illegal character &apos;{1}&apos;..
        /// </summary>
        internal static string ParameterContainsIllegalCharacters
        {
            get
            {
                return "The '{0}' parameter contains the illegal character '{1}'.";
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The return value of {0}.{1} should never be null..
        /// </summary>
        internal static string ResultShouldNotBeNull
        {
            get
            {
                return "The return value of {0}.{1} should never be null.";
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Individual scopes may not contain spaces..
        /// </summary>
        internal static string ScopesMayNotContainSpaces
        {
            get
            {
                return "Individual scopes may not contain spaces.";
            }
        }
    }
}
