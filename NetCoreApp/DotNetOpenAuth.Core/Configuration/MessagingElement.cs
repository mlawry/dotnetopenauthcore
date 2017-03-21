//-----------------------------------------------------------------------
// <copyright file="MessagingElement.cs" company="Outercurve Foundation">
//     Copyright (c) Outercurve Foundation. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace DotNetOpenAuth.Configuration
{
    using System;

    /// <summary>
    /// Represents the &lt;messaging&gt; element in the host's .config file.
    /// </summary>
    public class MessagingElement
    {

        /// <summary>
        /// Gets the actual maximum message lifetime that a program should allow.
        /// </summary>
        /// <value>The sum of the <see cref="MaximumMessageLifetime"/> and 
        /// <see cref="MaximumClockSkew"/> property values.</value>
        public virtual TimeSpan MaximumMessageLifetime
        {
            get { return this.MaximumMessageLifetimeNoSkew + this.MaximumClockSkew; }
        }

        /// <summary>
        /// Gets or sets the maximum lifetime of a private symmetric secret,
        /// that may be used for signing or encryption.
        /// </summary>
        /// <value>The default value is 28 days (twice the age of the longest association).</value>
        public virtual TimeSpan PrivateSecretMaximumAge
        {
            get; set;
        } = TimeSpan.FromDays(28);

        /// <summary>
        /// Gets or sets the time between a message's creation and its receipt
        /// before it is considered expired.
        /// </summary>
        /// <value>
        /// The default value value is 3 minutes.
        /// </value>
        /// <remarks>
        /// 	<para>Smaller timespans mean lower tolerance for delays in message delivery.
        /// Larger timespans mean more nonces must be stored to provide replay protection.</para>
        /// 	<para>The maximum age a message implementing the
        /// <see cref="IExpiringProtocolMessage"/> interface can be before
        /// being discarded as too old.</para>
        /// 	<para>This time limit should NOT take into account expected 
        /// time skew for servers across the Internet.  Time skew is added to
        /// this value and is controlled by the <see cref="MaximumClockSkew"/> property.</para>
        /// </remarks>
        public virtual TimeSpan MaximumMessageLifetimeNoSkew
        {
            get; set;
        } = TimeSpan.FromMinutes(3);

        /// <summary>
        /// Gets or sets the maximum clock skew.
        /// </summary>
        /// <value>The default value is 10 minutes.</value>
        /// <remarks>
        /// 	<para>Smaller timespans mean lower tolerance for 
        /// time variance due to server clocks not being synchronized.
        /// Larger timespans mean greater chance for replay attacks and
        /// larger nonce caches.</para>
        /// 	<para>For example, if a server could conceivably have its
        /// clock d = 5 minutes off UTC time, then any two servers could have
        /// their clocks disagree by as much as 2*d = 10 minutes. </para>
        /// </remarks>
        public virtual TimeSpan MaximumClockSkew
        {
            get; set;
        } = TimeSpan.FromMinutes(10);

        /// <summary>
        /// Gets or sets a value indicating whether SSL requirements within the library are disabled/relaxed.
        /// Use for TESTING ONLY.
        /// </summary>
        public virtual bool RelaxSslRequirements
        {
            get; set;
        } = false;

        /// <summary>
        /// Gets or sets a value indicating whether messaging rules are strictly
        /// adhered to.
        /// </summary>
        /// <value><c>true</c> by default.</value>
        /// <remarks>
        /// Strict will require that remote parties adhere strictly to the specifications,
        /// even when a loose interpretation would not compromise security.
        /// <c>true</c> is a good default because it shakes out interoperability bugs in remote services
        /// so they can be identified and corrected.  But some web sites want things to Just Work
        /// more than they want to file bugs against others, so <c>false</c> is the setting for them.
        /// </remarks>
        public virtual bool Strict
        {
            get; set;
        } = true;

        /// <summary>
        /// Gets or sets the configuration for the UntrustedWebRequestHandler class.
        /// </summary>
        /// <value>The untrusted web request.</value>
        public virtual UntrustedWebRequestElement UntrustedWebRequest
        {
            get; set;
        } = new UntrustedWebRequestElement();

        /// <summary>
        /// Gets or sets the maximum allowable size for a 301 Redirect response before we send
        /// a 200 OK response with a scripted form POST with the parameters instead
        /// in order to ensure successfully sending a large payload to another server
        /// that might have a maximum allowable size restriction on its GET request.
        /// </summary>
        /// <value>The default value is 2048.</value>
        public virtual int MaximumIndirectMessageUrlLength
        {
            get; set;
        } = 2048;

        /// <summary>
        /// Gets or sets the embedded resource retrieval provider.
        /// </summary>
        /// <value>
        /// The embedded resource retrieval provider.
        /// </value>
        public virtual TypeConfigurationElement<IEmbeddedResourceRetrieval> EmbeddedResourceRetrievalProvider
        {
            get; set;
        } = new TypeConfigurationElement<IEmbeddedResourceRetrieval>();
    }

}
