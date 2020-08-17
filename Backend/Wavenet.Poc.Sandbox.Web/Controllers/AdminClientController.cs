// <copyright file="AdminClientController.cs" company="Wavenet">
// Copyright (c) Wavenet. All rights reserved.
// </copyright>

namespace Wavenet.Poc.Sandbox.Web.Controllers.Admin
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Http;

    using AutoMapper;

    using Wavenet.Poc.Sandbox.Business;
    using Wavenet.Poc.Sandbox.Web.Model;

    /// <summary>
    /// Manage all data for clients.
    /// </summary>
    public class AdminClientController : ApiController
    {
        private readonly IAdminDomain adminDomain;
        private readonly IMapper mapper;

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminClientController" /> class.
        /// </summary>
        /// <param name="adminDomain">The domain managing admin actions.</param>
        /// <param name="mapper">The configured mapper.</param>
        public AdminClientController(IAdminDomain adminDomain, IMapper mapper)
        {
            this.adminDomain = adminDomain;
            this.mapper = mapper;
        }

        /// <summary>
        /// Get all the clients.
        /// </summary>
        /// <returns>The list of all clients.</returns>
        [HttpGet]
        [Route("api/admin/client/list")]
        public List<ClientSummary> GetAll()
        {
            var clients = this.adminDomain.GetAllClients();
            return this.mapper.Map<List<ClientSummary>>(clients);
        }
    }
}