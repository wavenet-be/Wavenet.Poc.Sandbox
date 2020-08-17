// <copyright file="Address.cs" company="Wavenet">
// Copyright (c) Wavenet. All rights reserved.
// </copyright>

namespace Wavenet.Poc.Sandbox.Core
{
    using System;
    using System.Linq;

    /// <summary>
    /// Represent and address.
    /// </summary>
    public class Address
    {
        /// <summary>
        /// Gets or sets the City.
        /// </summary>
        /// <value>The City.</value>
        public string City { get; set; }

        /// <summary>
        /// Gets or sets the Country.
        /// </summary>
        /// <value>The Country.</value>
        public string Country { get; set; }

        /// <summary>
        /// Gets or sets the Street.
        /// </summary>
        /// <value>The Street.</value>
        public string Street { get; set; }

        /// <summary>
        /// Gets or sets the ZipCode.
        /// </summary>
        /// <value>The ZipCode.</value>
        public string ZipCode { get; set; }
    }
}