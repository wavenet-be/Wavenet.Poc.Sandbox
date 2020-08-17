// <copyright file="InjectionConfig.cs" company="Wavenet">
// Copyright (c) Wavenet. All rights reserved.
// </copyright>

namespace Wavenet.Poc.Sandbox.Web
{
    using System;
    using System.Linq;
    using System.Web.Http;

    using AutoMapper;

    using LightInject;

    using Wavenet.Poc.Sandbox.Business;
    using Wavenet.Poc.Sandbox.Business.Concrete;
    using Wavenet.Poc.Sandbox.Data;
    using Wavenet.Poc.Sandbox.Data.Fake;
    using Wavenet.Poc.Sandbox.Data.Fake.Model;

    /// <summary>
    /// Register IoC into the project.
    /// </summary>
    public static class InjectionConfig
    {
        /// <summary>
        /// Registers the specified configuration.
        /// </summary>
        /// <param name="config">The configuration.</param>
        public static void Register(HttpConfiguration config)
        {
            var container = new ServiceContainer();

            container.RegisterBusiness();
            container.RegisterData();
            container.CreateMapper();

            container.RegisterApiControllers();
            container.EnableWebApi(GlobalConfiguration.Configuration);
        }

        private static void RegisterBusiness(this ServiceContainer container)
        {
            container.Register<IAdminDomain, AdminDomain>();
            container.Register<IUserDomain, UserDomain>();
        }

        private static void RegisterData(this ServiceContainer container)
        {
            container.Register<IClientRepository, ClientRepository>();
        }

        private static void CreateMapper(this ServiceContainer container)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Core.Client, Model.ClientSummary>();
                cfg.CreateMap<Core.Client, Model.Client>();
                cfg.CreateMap<Core.Address, Model.Address>();

                cfg.AddProfile<FakeCsvProfile>();
            });

            var mapper = config.CreateMapper();

            container.RegisterInstance(mapper);
        }
    }
}