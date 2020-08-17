// <copyright file="IClientRepository.cs" company="Wavenet">
// Copyright (c) Wavenet. All rights reserved.
// </copyright>

namespace Wavenet.Poc.Sandbox.Data
{
    using System.Collections.Generic;

    using Wavenet.Poc.Sandbox.Core;

    /// <summary>
    /// Repository to manage the clients.
    /// </summary>
    public interface IClientRepository
    {
        /// <summary>
        /// Get all the clients.
        /// </summary>
        /// <param name="includeConfidential">Include confidentials items.</param>
        /// <returns>The list of all knowns clients.</returns>
        List<Client> GetAll(bool includeConfidential);

        /// <summary>
        /// Get a specific client information.
        /// </summary>
        /// <param name="id">The id of the client.</param>
        /// <returns>The client from database.</returns>
        Client Get(int id);
    }
}