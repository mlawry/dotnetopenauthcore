using DotNetOpenAuth.Loggers;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetOpenAuth.Configuration
{
    /// <summary>
    /// Assign your own populated configuration element instances to static properties of this class,
    /// and their values will be picked up when required.
    /// </summary>
    public class DotNetOpenAuthConfiguration
    {
        private static MessagingElement sMessagingElement = new MessagingElement();


        public static ILog Logger
        {
            get; set;
        }


        public static MessagingElement MessagingElement
        {
            get
            {
                return sMessagingElement ?? new MessagingElement();
            }
            set
            {
                sMessagingElement = value;
            }
        }
    }
}
