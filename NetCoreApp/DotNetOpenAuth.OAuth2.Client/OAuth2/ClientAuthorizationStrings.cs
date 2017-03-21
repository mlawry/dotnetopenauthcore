
namespace DotNetOpenAuth.OAuth2
{
    using System;


    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    internal class ClientAuthorizationStrings
    {
        /// <summary>
        ///   Looks up a localized string similar to The request message type {0} should not be responded to with a refresh token..
        /// </summary>
        internal static string RefreshTokenInappropriateForRequestType
        {
            get
            {
                return "The request message type {0} should not be responded to with a refresh token.";
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The Authorization Server&apos;s token endpoint generated error {0}: &apos;{1}&apos;.
        /// </summary>
        internal static string TokenEndpointErrorFormat
        {
            get
            {
                return "The Authorization Server's token endpoint generated error {0}: '{1}'";
            }
        }
    }
}
