// <copyright file="HostingController.cs" company="Wavenet">
// Copyright (c) Wavenet. All rights reserved.
// </copyright>

namespace Wavenet.Poc.Sandbox.Web.Controllers
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Web.Http;

    /// <summary>
    /// Some simple method to check the hosting.
    /// </summary>
    public class HostingController : ApiController
    {
        /// <summary>
        /// Gets the version of the application.
        /// </summary>
        /// <returns>The version of the application.</returns>
        [HttpGet]
        [Route("api/hosting/version")]
        public string GetVersion()
        {
            return Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }
    }
}