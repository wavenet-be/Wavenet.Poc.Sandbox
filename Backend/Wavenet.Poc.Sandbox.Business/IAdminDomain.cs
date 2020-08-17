// <copyright file="IAdminDomain.cs" company="Wavenet">
// Copyright (c) Wavenet. All rights reserved.
// </copyright>

namespace Wavenet.Poc.Sandbox.Business
{
    using System.Collections.Generic;

    using Wavenet.Poc.Sandbox.Core;

    /// <summary>
    /// Domain that manage admin actions.
    /// </summary>
    public interface IAdminDomain
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