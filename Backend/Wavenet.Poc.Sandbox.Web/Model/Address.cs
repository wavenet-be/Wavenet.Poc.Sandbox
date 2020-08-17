// <copyright file="Address.cs" company="Wavenet">
// Copyright (c) Wavenet. All rights reserved.
// </copyright>

namespace Wavenet.Poc.Sandbox.Web.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// Represent and address.
    /// </summary>
    [DataContract]
    public class Address
    {
        /// <summary>
        /// Gets or sets the City.
        /// </summary>
        /// <value>The City.</value>
        [StringLength(500)]
        [Required]
        [DataMember(Name = "city")]
        public string City { get; set; }

        /// <summary>
        /// Gets or sets the Country.
        /// </summary>
        /// <value>The Country.</value>
        [StringLength(500)]
        [Required]
        [DataMember(Name = "country")]
        public string Country { get; set; }

        /// <summary>
        /// Gets or sets the Street.
        /// </summary>
        /// <value>The Street.</value>
        [StringLength(4000)]
        [Required]
        [DataMember(Name = "street")]
        public string Street { get; set; }

        /// <summary>
        /// Gets or sets the ZipCode.
        /// </summary>
        /// <value>The ZipCode.</value>
        [StringLength(50)]
        [Required]
        [DataMember(Name = "zipCode")]
        public string ZipCode { get; set; }
    }
}