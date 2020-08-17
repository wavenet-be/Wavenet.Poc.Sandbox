// <copyright file="UserDomain.cs" company="Wavenet">
// Copyright (c) Wavenet. All rights reserved.
// </copyright>

namespace Wavenet.Poc.Sandbox.Business.Concrete
{
    using System.Collections.Generic;

    using Wavenet.Poc.Sandbox.Core;
    using Wavenet.Poc.Sandbox.Data;

    /// <summary>
    /// Manage all action for a user.
    /// </summary>
    public class UserDomain : IUserDomain
    {
        private readonly IClientRepository clientRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserDomain"/> class.
        /// </summary>
        /// <param name="clientRepository">The repository for client actions.</param>
        public UserDomain(IClientRepository clientRepository)
        {
            this.clientRepository = clientRepository;
        }

        /// <inheritdoc />
        public List<Client> GetAllClients()
        {
            return this.clientRepository.GetAll(false);
        }

        /// <inheritdoc />
        public Client GetClient(int clientId)
        {
            var client = this.clientRepository.Get(clientId);

            if (client.IsConfidential)
            {
                return null;
            }

            return client;
        }
    }
}