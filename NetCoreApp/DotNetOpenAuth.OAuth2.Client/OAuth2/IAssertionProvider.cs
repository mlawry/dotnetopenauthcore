//-----------------------------------------------------------------------
// <copyright file="AccessTokenAssertionRequest.cs" company="YTML Consulting">
//     Copyright (c) YTML Consulting Pty Ltd. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetOpenAuth.OAuth2
{
    /// <summary>
    /// Used by the AccessTokenAssertionRequest class to obtain the assertion details when creating the
    /// request message.
    /// </summary>
    public interface IAssertionProvider
    {
        /// <summary>
        /// Gets value of the 'assertion' key.
        /// </summary>
        string AssertionValue { get; }

        /// <summary>
        /// Gets value of the 'grant_type' key.
        /// </summary>
        string GrantType { get; }
    }
}
