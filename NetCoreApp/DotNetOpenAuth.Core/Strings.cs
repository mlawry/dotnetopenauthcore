
namespace DotNetOpenAuth {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    internal class Strings {
        
        internal Strings() {
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The configuration-specified type {0} must be public, and is not..
        /// </summary>
        internal static string ConfigurationTypeMustBePublic {
            get {
                return "The configuration-specified type {0} must be public, and is not.";
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The configuration XAML reference to {0} requires a current HttpContext to resolve..
        /// </summary>
        internal static string ConfigurationXamlReferenceRequiresHttpContext {
            get {
                return "The configuration XAML reference to {0} requires a current HttpContext to resolve.";
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The current IHttpHandler is not one of types: {0}.  An embedded resource URL provider must be set in your .config file..
        /// </summary>
        internal static string EmbeddedResourceUrlProviderRequired {
            get {
                return "The current IHttpHandler is not one of types: {0}.  An embedded resource URL provider must be set in your .config file.";
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The empty string is not allowed..
        /// </summary>
        internal static string EmptyStringNotAllowed {
            get {
                return "The empty string is not allowed.";
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The provided data could not be decrypted. If the current application is deployed in a web farm configuration, ensure that the &apos;decryptionKey&apos; and &apos;validationKey&apos; attributes are explicitly specified in the &lt;machineKey&gt; configuration section..
        /// </summary>
        internal static string Generic_CryptoFailure {
            get {
                return "The provided data could not be decrypted. If the current application is deployed in a web farm configuration, ensure that the 'decryptionKey' and 'validationKey' attributes are explicitly specified in the <machineKey> configuration section.";
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The HostFactories property must be set first..
        /// </summary>
        internal static string HostFactoriesRequired {
            get {
                return "The HostFactories property must be set first.";
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The argument has an unexpected value..
        /// </summary>
        internal static string InvalidArgument {
            get {
                return "The argument has an unexpected value.";
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The property {0} must be set before this operation is allowed..
        /// </summary>
        internal static string RequiredPropertyNotYetPreset {
            get {
                return "The property {0} must be set before this operation is allowed.";
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This object contains a response body, which is not supported..
        /// </summary>
        internal static string ResponseBodyNotSupported {
            get {
                return "This object contains a response body, which is not supported.";
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No current HttpContext was detected, so an {0} instance must be explicitly provided or specified in the .config file.  Call the constructor overload that takes an {0}..
        /// </summary>
        internal static string StoreRequiredWhenNoHttpContextAvailable {
            get {
                return "No current HttpContext was detected, so an {0} instance must be explicitly provided or specified in the .config file.  Call the constructor overload that takes an {0}.";
            }
        }
    }
}
