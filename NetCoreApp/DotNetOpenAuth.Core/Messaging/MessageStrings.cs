
namespace DotNetOpenAuth.Messaging
{
    using System;

    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>

    public class MessagingStrings
    {

        private MessagingStrings()
        {
        }

        /// <summary>
        ///   Looks up a localized string similar to Argument&apos;s {0}.{1} property is required but is empty or null..
        /// </summary>
        public static string ArgumentPropertyMissing
        {
            get
            {
                return "Argument's {0}.{1} property is required but is empty or null.";
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Unable to send all message data because some of it requires multi-part POST, but IMessageWithBinaryData.SendAsMultipart was false..
        /// </summary>
        public static string BinaryDataRequiresMultipart
        {
            get
            {
                return "Unable to send all message data because some of it requires multi-part POST, but IMessageWithBinaryData.SendAsMultipart was false.";
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to HttpContext.Current is null.  There must be an ASP.NET request in process for this operation to succeed..
        /// </summary>
        public static string CurrentHttpContextRequired
        {
            get
            {
                return "HttpContext.Current is null.  There must be an ASP.NET request in process for this operation to succeed.";
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to DataContractSerializer could not be initialized on message type {0}.  Is it missing a [DataContract] attribute?.
        /// </summary>
        public static string DataContractMissingFromMessageType
        {
            get
            {
                return "DataContractSerializer could not be initialized on message type {0}.  Is it missing a [DataContract] attribute?";
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to DataContractSerializer could not be initialized on message type {0} because the DataContractAttribute.Namespace property is not set..
        /// </summary>
        public static string DataContractMissingNamespace
        {
            get
            {
                return "DataContractSerializer could not be initialized on message type {0} because the DataContractAttribute.Namespace property is not set.";
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Decoding failed due to data corruption..
        /// </summary>
        public static string DataCorruptionDetected
        {
            get
            {
                return "Decoding failed due to data corruption.";
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to An instance of type {0} was expected, but received unexpected derived type {1}..
        /// </summary>
        public static string DerivedTypeNotExpected
        {
            get
            {
                return "An instance of type {0} was expected, but received unexpected derived type {1}.";
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The directed message&apos;s Recipient property must not be null..
        /// </summary>
        public static string DirectedMessageMissingRecipient
        {
            get
            {
                return "The directed message's Recipient property must not be null.";
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The given set of options is not supported by this web request handler..
        /// </summary>
        public static string DirectWebRequestOptionsNotSupported
        {
            get
            {
                return "The given set of options is not supported by this web request handler.";
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Unable to instantiate the message part encoder/decoder type {0}..
        /// </summary>
        public static string EncoderInstantiationFailed
        {
            get
            {
                return "Unable to instantiate the message part encoder/decoder type {0}.";
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Error while deserializing message {0}..
        /// </summary>
        public static string ErrorDeserializingMessage
        {
            get
            {
                return "Error while deserializing message {0}.";
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Error occurred while sending a direct message or getting the response..
        /// </summary>
        public static string ErrorInRequestReplyMessage
        {
            get
            {
                return "Error occurred while sending a direct message or getting the response.";
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to This exception was not constructed with a root request message that caused it..
        /// </summary>
        public static string ExceptionNotConstructedForTransit
        {
            get
            {
                return "This exception was not constructed with a root request message that caused it.";
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to This exception must be instantiated with a recipient that will receive the error message, or a direct request message instance that this exception will respond to..
        /// </summary>
        public static string ExceptionUndeliverable
        {
            get
            {
                return "This exception must be instantiated with a recipient that will receive the error message, or a direct request message instance that this exception will respond to.";
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Expected {0} message but received no recognizable message..
        /// </summary>
        public static string ExpectedMessageNotReceived
        {
            get
            {
                return "Expected {0} message but received no recognizable message.";
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The message part {0} was expected in the {1} message but was not found..
        /// </summary>
        public static string ExpectedParameterWasMissing
        {
            get
            {
                return "The message part {0} was expected in the {1} message but was not found.";
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The message expired at {0} and it is now {1}..
        /// </summary>
        public static string ExpiredMessage
        {
            get
            {
                return "The message expired at {0} and it is now {1}.";
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Failed to add extra parameter &apos;{0}&apos; with value &apos;{1}&apos;..
        /// </summary>
        public static string ExtraParameterAddFailure
        {
            get
            {
                return "Failed to add extra parameter '{0}' with value '{1}'.";
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to At least one of GET or POST flags must be present..
        /// </summary>
        public static string GetOrPostFlagsRequired
        {
            get
            {
                return "At least one of GET or POST flags must be present.";
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to This method requires a current HttpContext.  Alternatively, use an overload of this method that allows you to pass in information without an HttpContext..
        /// </summary>
        public static string HttpContextRequired
        {
            get
            {
                return "This method requires a current HttpContext.  Alternatively, use an overload of this method that allows you to pass in information without an HttpContext.";
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Messages that indicate indirect transport must implement the {0} interface..
        /// </summary>
        public static string IndirectMessagesMustImplementIDirectedProtocolMessage
        {
            get
            {
                return "Messages that indicate indirect transport must implement the {0} interface.";
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Insecure web request for &apos;{0}&apos; aborted due to security requirements demanding HTTPS..
        /// </summary>
        public static string InsecureWebRequestWithSslRequired
        {
            get
            {
                return "Insecure web request for '{0}' aborted due to security requirements demanding HTTPS.";
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The {0} message required protections {{{1}}} but the channel could only apply {{{2}}}..
        /// </summary>
        public static string InsufficientMessageProtection
        {
            get
            {
                return "The {0} message required protections {{{1}}} but the channel could only apply {{{2}}}.";
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The customized binding element ordering is invalid..
        /// </summary>
        public static string InvalidCustomBindingElementOrder
        {
            get
            {
                return "The customized binding element ordering is invalid.";
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Some part(s) of the message have invalid values: {0}.
        /// </summary>
        public static string InvalidMessageParts
        {
            get
            {
                return "Some part(s) of the message have invalid values: {0}";
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The incoming message had an invalid or missing nonce..
        /// </summary>
        public static string InvalidNonceReceived
        {
            get
            {
                return "The incoming message had an invalid or missing nonce.";
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to An item with the same key has already been added..
        /// </summary>
        public static string KeyAlreadyExists
        {
            get
            {
                return "An item with the same key has already been added.";
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Message too large for a HTTP GET, and HTTP POST is not allowed for this message type..
        /// </summary>
        public static string MessageExceedsGetSizePostNotAllowed
        {
            get
            {
                return "Message too large for a HTTP GET, and HTTP POST is not allowed for this message type.";
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The {0} message does not support extensions..
        /// </summary>
        public static string MessageNotExtensible
        {
            get
            {
                return "The {0} message does not support extensions.";
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The value for {0}.{1} on member {1} was expected to derive from {2} but was {3}..
        /// </summary>
        public static string MessagePartEncoderWrongType
        {
            get
            {
                return "The value for {0}.{1} on member {1} was expected to derive from {2} but was {3}.";
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Error while reading message &apos;{0}&apos; parameter &apos;{1}&apos; with value &apos;{2}&apos;..
        /// </summary>
        public static string MessagePartReadFailure
        {
            get
            {
                return "Error while reading message '{0}' parameter '{1}' with value '{2}'.";
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Message parameter &apos;{0}&apos; with value &apos;{1}&apos; failed to base64 decode..
        /// </summary>
        public static string MessagePartValueBase64DecodingFault
        {
            get
            {
                return "Message parameter '{0}' with value '{1}' failed to base64 decode.";
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Error while preparing message &apos;{0}&apos; parameter &apos;{1}&apos; for sending..
        /// </summary>
        public static string MessagePartWriteFailure
        {
            get
            {
                return "Error while preparing message '{0}' parameter '{1}' for sending.";
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to This message has a timestamp of {0}, which is beyond the allowable clock skew for in the future..
        /// </summary>
        public static string MessageTimestampInFuture
        {
            get
            {
                return "This message has a timestamp of {0}, which is beyond the allowable clock skew for in the future.";
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Missing decryption key for bucket &quot;{0}&quot; handle &quot;{1}&quot;.
        /// </summary>
        public static string MissingDecryptionKeyForHandle
        {
            get
            {
                return "Missing decryption key for bucket '{0}' handle '{1}'";
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to A non-empty string was expected..
        /// </summary>
        public static string NonEmptyStringExpected
        {
            get
            {
                return "A non-empty string was expected.";
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to A message response is already queued for sending in the response stream..
        /// </summary>
        public static string QueuedMessageResponseAlreadyExists
        {
            get
            {
                return "A message response is already queued for sending in the response stream.";
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to This message has already been processed.  This could indicate a replay attack in progress..
        /// </summary>
        public static string ReplayAttackDetected
        {
            get
            {
                return "This message has already been processed.  This could indicate a replay attack in progress.";
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to This channel does not support replay protection..
        /// </summary>
        public static string ReplayProtectionNotSupported
        {
            get
            {
                return "This channel does not support replay protection.";
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The following message parts had constant value requirements that were unsatisfied: {0}.
        /// </summary>
        public static string RequiredMessagePartConstantIncorrect
        {
            get
            {
                return "The following message parts had constant value requirements that were unsatisfied: {0}";
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The following required non-empty parameters were empty in the {0} message: {1}.
        /// </summary>
        public static string RequiredNonEmptyParameterWasEmpty
        {
            get
            {
                return "The following required non-empty parameters were empty in the {0} message: {1}";
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The following required parameters were missing from the {0} message: {1}.
        /// </summary>
        public static string RequiredParametersMissing
        {
            get
            {
                return "The following required parameters were missing from the {0} message: {1}";
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The binding element offering the {0} protection requires other protection that is not provided..
        /// </summary>
        public static string RequiredProtectionMissing
        {
            get
            {
                return "The binding element offering the {0} protection requires other protection that is not provided.";
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The list is empty..
        /// </summary>
        public static string SequenceContainsNoElements
        {
            get
            {
                return "The list is empty.";
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The list contains a null element..
        /// </summary>
        public static string SequenceContainsNullElement
        {
            get
            {
                return "The list contains a null element.";
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to An HttpContext.Current.Session object is required..
        /// </summary>
        public static string SessionRequired
        {
            get
            {
                return "An HttpContext.Current.Session object is required.";
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Message signature was incorrect..
        /// </summary>
        public static string SignatureInvalid
        {
            get
            {
                return "Message signature was incorrect.";
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to This channel does not support signing messages.  To support signing messages, a derived Channel type must override the Sign and IsSignatureValid methods..
        /// </summary>
        public static string SigningNotSupported
        {
            get
            {
                return "This channel does not support signing messages.  To support signing messages, a derived Channel type must override the Sign and IsSignatureValid methods.";
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to This message factory does not support message type(s): {0}.
        /// </summary>
        public static string StandardMessageFactoryUnsupportedMessageType
        {
            get
            {
                return "This message factory does not support message type(s): {0}";
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The stream must have a known length..
        /// </summary>
        public static string StreamMustHaveKnownLength
        {
            get
            {
                return "The stream must have a known length.";
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The stream&apos;s CanRead property returned false..
        /// </summary>
        public static string StreamUnreadable
        {
            get
            {
                return "The stream's CanRead property returned false.";
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The stream&apos;s CanWrite property returned false..
        /// </summary>
        public static string StreamUnwritable
        {
            get
            {
                return "The stream's CanWrite property returned false.";
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Expected at most 1 binding element to apply the {0} protection, but more than one applied..
        /// </summary>
        public static string TooManyBindingsOfferingSameProtection
        {
            get
            {
                return "Expected at most 1 binding element to apply the {0} protection, but more than one applied.";
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The maximum allowable number of redirects were exceeded while requesting &apos;{0}&apos;..
        /// </summary>
        public static string TooManyRedirects
        {
            get
            {
                return "The maximum allowable number of redirects were exceeded while requesting '{0}'.";
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Unexpected buffer length..
        /// </summary>
        public static string UnexpectedBufferLength
        {
            get
            {
                return "Unexpected buffer length.";
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The array must not be empty..
        /// </summary>
        public static string UnexpectedEmptyArray
        {
            get
            {
                return "The array must not be empty.";
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The empty string is not allowed..
        /// </summary>
        public static string UnexpectedEmptyString
        {
            get
            {
                return "The empty string is not allowed.";
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Expected direct response to use HTTP status code {0} but was {1} instead..
        /// </summary>
        public static string UnexpectedHttpStatusCode
        {
            get
            {
                return "Expected direct response to use HTTP status code {0} but was {1} instead.";
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Message parameter &apos;{0}&apos; had unexpected value &apos;{1}&apos;..
        /// </summary>
        public static string UnexpectedMessagePartValue
        {
            get
            {
                return "Message parameter '{0}' had unexpected value '{1}'.";
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Expected message {0} parameter &apos;{1}&apos; to have value &apos;{2}&apos; but had &apos;{3}&apos; instead..
        /// </summary>
        public static string UnexpectedMessagePartValueForConstant
        {
            get
            {
                return "Expected message {0} parameter '{1}' to have value '{2}' but had '{3}' instead.";
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Expected message {0} but received {1} instead..
        /// </summary>
        public static string UnexpectedMessageReceived
        {
            get
            {
                return "Expected message {0} but received {1} instead.";
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Unexpected message type received..
        /// </summary>
        public static string UnexpectedMessageReceivedOfMany
        {
            get
            {
                return "Unexpected message type received.";
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to A null key was included and is not allowed..
        /// </summary>
        public static string UnexpectedNullKey
        {
            get
            {
                return "A null key was included and is not allowed.";
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to A null or empty key was included and is not allowed..
        /// </summary>
        public static string UnexpectedNullOrEmptyKey
        {
            get
            {
                return "A null or empty key was included and is not allowed.";
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to A null value was included for key &apos;{0}&apos; and is not allowed..
        /// </summary>
        public static string UnexpectedNullValue
        {
            get
            {
                return "A null value was included for key '{0}' and is not allowed.";
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The type {0} or a derived type was expected, but {1} was given..
        /// </summary>
        public static string UnexpectedType
        {
            get
            {
                return "The type {0} or a derived type was expected, but {1} was given.";
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to {0} property has unrecognized value {1}..
        /// </summary>
        public static string UnrecognizedEnumValue
        {
            get
            {
                return "{0} property has unrecognized value {1}.";
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The URL &apos;{0}&apos; is rated unsafe and cannot be requested this way..
        /// </summary>
        public static string UnsafeWebRequestDetected
        {
            get
            {
                return "The URL '{0}' is rated unsafe and cannot be requested this way.";
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to This blob is not a recognized encryption format..
        /// </summary>
        public static string UnsupportedEncryptionAlgorithm
        {
            get
            {
                return "This blob is not a recognized encryption format.";
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to '{0}' is not a recognized hash algorithm.
        /// </summary>
        public static string UnsupportedHashAlgorithm
        {
            get
            {
                return "'{0}' is not a recognized hash algorithm.";
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The HTTP verb &apos;{0}&apos; is unrecognized and unsupported..
        /// </summary>
        public static string UnsupportedHttpVerb
        {
            get
            {
                return "The HTTP verb '{0}' is unrecognized and unsupported.";
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; messages cannot be received with HTTP verb &apos;{1}&apos;..
        /// </summary>
        public static string UnsupportedHttpVerbForMessageType
        {
            get
            {
                return "'{0}' messages cannot be received with HTTP verb '{1}'.";
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Redirects on POST requests that are to untrusted servers is not supported..
        /// </summary>
        public static string UntrustedRedirectsOnPOSTNotSupported
        {
            get
            {
                return "Redirects on POST requests that are to untrusted servers is not supported.";
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Web request to &apos;{0}&apos; failed..
        /// </summary>
        public static string WebRequestFailed
        {
            get
            {
                return "Web request to '{0}' failed.";
            }
        }
    }
}
