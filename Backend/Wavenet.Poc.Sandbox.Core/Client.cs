// <copyright file="Client.cs" company="Wavenet">
// Copyright (c) Wavenet. All rights reserved.
// </copyright>

namespace Wavenet.Poc.Sandbox.Core
{
    using System;
    using System.Linq;

    /// <summary>
    /// Represents a client.
    /// </summary>
    public class Client
    {
        /// <summary>
        /// Gets or sets the Address.
        /// </summary>
        /// <value>The Address.</value>
        public Address Address { get; set; }

        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        /// <value>The Id.</value>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether gets or sets the client is restricted to certain roles.
        /// </summary>
        /// <value>The RestrictedAccess.</value>
        public bool IsConfidential { get; set; }

        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        /// <value>The Name.</value>
        public string Name { get; set; }
    }
}