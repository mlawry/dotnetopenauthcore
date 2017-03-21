//-----------------------------------------------------------------------
// <copyright file="HostNameElement.cs" company="Outercurve Foundation">
//     Copyright (c) Outercurve Foundation. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace DotNetOpenAuth.Configuration {

	/// <summary>
	/// Represents the name of a single host or a regex pattern for host names.
	/// </summary>
	public class HostNameElement {

		/// <summary>
		/// Initializes a new instance of the <see cref="HostNameElement"/> class.
		/// </summary>
		public HostNameElement() {
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="HostNameElement"/> class.
		/// </summary>
		/// <param name="name">The default value of the <see cref="Name"/> property.</param>
		public HostNameElement(string name) {
			this.Name = name;
		}

		/// <summary>
		/// Gets or sets the name of the host on the white or black list.
		/// </summary>
		public virtual string Name { get; set; }
	}
}
