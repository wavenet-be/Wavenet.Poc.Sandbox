// <copyright file="IUserDomain.cs" company="Wavenet">
// Copyright (c) Wavenet. All rights reserved.
// </copyright>

namespace Wavenet.Poc.Sandbox.Business
{
    using System.Collections.Generic;

    using Wavenet.Poc.Sandbox.Core;

    /// <summary>
    /// Manage all action for a user.
    /// </summary>
    public interface IUserDomain
    {
        /// <summary>
        /// Get all clients without any filter.
        /// </summary>
        /// <returns>The list of all client.</returns>
        List<Client> GetAllClients();

        /// <summary>
        /// Gets a specific client, if authorized.
        /// </summary>
        /// <param name="clientId">The client to get.</param>
        /// <returns>The informations about the client.</returns>
        Client GetClient(int clientId);
    }
}