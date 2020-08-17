// <copyright file="Global.asax.cs" company="Wavenet">
// Copyright (c) Wavenet. All rights reserved.
// </copyright>

namespace Wavenet.Poc.Sandbox.Web
{
    using System;
    using System.Linq;
    using System.Web;
    using System.Web.Http;

    /// <summary>
    /// Start the application.
    /// </summary>
    public class Global : HttpApplication
    {
        /// <summary>
        /// Start the application.
        /// </summary>
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            GlobalConfiguration.Configure(InjectionConfig.Register);
        }
    }
}