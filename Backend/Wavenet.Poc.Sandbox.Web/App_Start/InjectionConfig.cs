// <copyright file="InjectionConfig.cs" company="Wavenet">
// Copyright (c) Wavenet. All rights reserved.
// </copyright>

namespace Wavenet.Poc.Sandbox.Web
{
    using System;
    using System.Linq;
    using System.Web.Http;

    using LightInject;

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

            container.RegisterApiControllers();
            container.EnableWebApi(GlobalConfiguration.Configuration);
        }

        private static void RegisterBusiness(this ServiceContainer container)
        {
        }

        private static void RegisterData(this ServiceContainer container)
        {
        }
    }
}