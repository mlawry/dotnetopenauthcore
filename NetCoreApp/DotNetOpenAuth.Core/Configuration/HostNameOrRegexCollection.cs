//-----------------------------------------------------------------------
// <copyright file="HostNameOrRegexCollection.cs" company="Outercurve Foundation">
//     Copyright (c) Outercurve Foundation. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace DotNetOpenAuth.Configuration
{
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using Validation;

    /// <summary>
    /// Represents a collection of child elements that describe host names either as literal host names or regex patterns.
    /// </summary>
    public class HostNameOrRegexCollection
    {
        protected List<HostNameElement> mStringList;


        /// <summary>
        /// Initializes a new instance of the <see cref="HostNameOrRegexCollection"/> class.
        /// </summary>
        public HostNameOrRegexCollection()
        {
            mStringList = new List<HostNameElement>();
        }


        public HostNameOrRegexCollection(IEnumerable<HostNameElement> array)
        {
            mStringList = new List<HostNameElement>(array);
        }

        /// <summary>
        /// Gets all the members of the collection assuming they are all literal host names.
        /// </summary>
        internal IEnumerable<string> KeysAsStrings
        {
            get
            {
                foreach (HostNameElement element in mStringList)
                {
                    yield return element.Name;
                }
            }
        }

        /// <summary>
        /// Gets all the members of the collection assuming they are all host names regex patterns.
        /// </summary>
        public IEnumerable<Regex> KeysAsRegexs
        {
            get
            {
                foreach (HostNameElement element in mStringList)
                {
                    if (element.Name != null)
                    {
                        yield return new Regex(element.Name);
                    }
                }
            }
        }

        /// <summary>
        /// Creates a new child host name element.
        /// </summary>
        /// <returns>
        /// A new <see cref="T:System.Configuration.ConfigurationElement"/>.
        /// </returns>
        protected HostNameElement CreateNewElement()
        {
            return new HostNameElement();
        }

        /// <summary>
        /// Gets the element key for a specified configuration element.
        /// </summary>
        /// <param name="element">The <see cref="T:System.Configuration.ConfigurationElement"/> to return the key for.</param>
        /// <returns>
        /// An <see cref="T:System.Object"/> that acts as the key for the specified <see cref="T:System.Configuration.ConfigurationElement"/>.
        /// </returns>
        protected object GetElementKey(HostNameElement element)
        {
            Requires.NotNull(element, "element");
            return (element.Name) ?? string.Empty;
        }
    }
}
