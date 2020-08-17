// <copyright file="AdminDomain.cs" company="Wavenet">
// Copyright (c) Wavenet. All rights reserved.
// </copyright>

namespace Wavenet.Poc.Sandbox.Business.Concrete
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Wavenet.Poc.Sandbox.Core;
    using Wavenet.Poc.Sandbox.Data;

    /// <summary>
    /// Domain that manage admin actions.
    /// </summary>
    public class AdminDomain : IAdminDomain
    {
        private readonly IClientRepository clientRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminDomain" /> class.
        /// </summary>
        /// <param name="clientRepository">The repository for client actions.</param>
        public AdminDomain(IClientRepository clientRepository)
        {
            this.clientRepository = clientRepository;
        }

        /// <inheritdoc />
        public List<Client> GetAllClients()
        {
            return this.clientRepository.GetAll(true);
        }

        /// <inheritdoc />
        public Client GetClient(int clientId)
        {
            return this.clientRepository.Get(clientId);
        }
    }
}