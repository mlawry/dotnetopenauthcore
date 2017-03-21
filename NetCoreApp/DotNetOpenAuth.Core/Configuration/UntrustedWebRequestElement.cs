//-----------------------------------------------------------------------
// <copyright file="UntrustedWebRequestElement.cs" company="Outercurve Foundation">
//     Copyright (c) Outercurve Foundation. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace DotNetOpenAuth.Configuration {
	using System;

	/// <summary>
	/// Represents the section of a .config file where security policies regarding web requests
	/// to user-provided, untrusted servers is controlled.
	/// </summary>
	public class UntrustedWebRequestElement {

        /// <summary>
        /// Gets or sets the read/write timeout after which an HTTP request will fail.
        /// </summary>
        public virtual TimeSpan ReadWriteTimeout { get; set; } = TimeSpan.FromSeconds(5);

        /// <summary>
        /// Gets or sets the timeout after which an HTTP request will fail.
        /// </summary>
        public virtual TimeSpan Timeout { get; set; } = TimeSpan.FromSeconds(30);

        /// <summary>
        /// Gets or sets the maximum bytes to read from an untrusted web server.
        /// </summary>
        public virtual int MaximumBytesToRead { get; set; } = 1024 * 1024;

        /// <summary>
        /// Gets or sets the maximum redirections that will be followed before an HTTP request fails.
        /// </summary>
		public virtual int MaximumRedirections { get; set; } = 10;

        /// <summary>
        /// Gets or sets the collection of hosts on the whitelist.
        /// </summary>
        public virtual HostNameOrRegexCollection WhitelistHosts { get; set; } = new HostNameOrRegexCollection();

        /// <summary>
        /// Gets or sets the collection of hosts on the blacklist.
        /// </summary>
		public virtual HostNameOrRegexCollection BlacklistHosts { get; set; } = new HostNameOrRegexCollection();

        /// <summary>
        /// Gets or sets the collection of regular expressions that describe hosts on the whitelist.
        /// </summary>
        public virtual HostNameOrRegexCollection WhitelistHostsRegex { get; set; } = new HostNameOrRegexCollection();

        /// <summary>
        /// Gets or sets the collection of regular expressions that describe hosts on the blacklist.
        /// </summary>
		public virtual HostNameOrRegexCollection BlacklistHostsRegex { get; set; } = new HostNameOrRegexCollection();
    }
}
