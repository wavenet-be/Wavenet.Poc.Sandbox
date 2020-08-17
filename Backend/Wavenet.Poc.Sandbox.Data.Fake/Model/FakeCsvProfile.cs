// <copyright file="FakeCsvProfile.cs" company="Wavenet">
// Copyright (c) Wavenet. All rights reserved.
// </copyright>

namespace Wavenet.Poc.Sandbox.Data.Fake.Model
{
    using System;
    using System.Linq;

    using AutoMapper;

    using Wavenet.Poc.Sandbox.Core;

    /// <summary>
    /// Map data to core.
    /// </summary>
    public class FakeCsvProfile : Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FakeCsvProfile" /> class.
        /// </summary>
        public FakeCsvProfile()
        {
            this.CreateMap<ClientCsv, Client>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(source => source.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(source => source.Name))
                .ForMember(dest => dest.IsConfidential, opt => opt.MapFrom(source => source.IsConfidential))
                .ForMember(dest => dest.Address, opt => opt.MapFrom(source => new Address
                {
                    City = source.City,
                    Country = source.Country,
                    Street = source.Street,
                    ZipCode = source.ZipCode,
                }));
        }
    }
}