// <copyright file="ClientCsv.cs" company="Wavenet">
// Copyright (c) Wavenet. All rights reserved.
// </copyright>

namespace Wavenet.Poc.Sandbox.Data.Fake.Model
{
    using System;
    using System.Linq;

    /// <summary>
    /// Client from a csv.
    /// </summary>
    public class ClientCsv
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
        /// Gets or sets the Id.
        /// </summary>
        /// <value>The Id.</value>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether gets or sets the IsConfidential.
        /// </summary>
        /// <value>The IsConfidential.</value>
        public bool IsConfidential { get; set; }

        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        /// <value>The Name.</value>
        public string Name { get; set; }

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