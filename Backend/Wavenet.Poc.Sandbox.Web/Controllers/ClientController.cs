// <copyright file="ClientController.cs" company="Wavenet">
// Copyright (c) Wavenet. All rights reserved.
// </copyright>

namespace Wavenet.Poc.Sandbox.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Web.Http;
    using System.Web.Http.Cors;

    using AutoMapper;

    using Wavenet.Poc.Sandbox.Business;
    using Wavenet.Poc.Sandbox.Web.Model;

    /// <summary>
    /// Manage all data for clients.
    /// </summary>
    [EnableCors("*", "*", "*")]
    public class ClientController : ApiController
    {
        private readonly IMapper mapper;
        private readonly IUserDomain userDomain;

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientController" /> class.
        /// </summary>
        /// <param name="userDomain">The domain managing user actions.</param>
        /// <param name="mapper">The configured mapper.</param>
        public ClientController(IUserDomain userDomain, IMapper mapper)
        {
            this.userDomain = userDomain;
            this.mapper = mapper;
        }

        /// <summary>
        /// Get all the clients.
        /// </summary>
        /// <param name="clientId">The id to get.</param>
        /// <returns>The list of all clients.</returns>
        [HttpGet]
        [Route("api/client/{clientId}")]
        public Client Get(int clientId)
        {
            var client = this.userDomain.GetClient(clientId);

            if (client == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            return this.mapper.Map<Client>(client);
        }

        /// <summary>
        /// Get all the clients.
        /// </summary>
        /// <returns>The list of all clients.</returns>
        [HttpGet]
        [Route("api/client/list")]
        public List<ClientSummary> GetAll()
        {
            var clients = this.userDomain.GetAllClients();
            return this.mapper.Map<List<ClientSummary>>(clients);
        }
    }
}