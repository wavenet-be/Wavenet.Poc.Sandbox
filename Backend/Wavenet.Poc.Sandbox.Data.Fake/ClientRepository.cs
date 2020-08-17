// <copyright file="ClientRepository.cs" company="Wavenet">
// Copyright (c) Wavenet. All rights reserved.
// </copyright>

namespace Wavenet.Poc.Sandbox.Data.Fake
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Linq;

    using AutoMapper;

    using CsvHelper;

    using Wavenet.Poc.Sandbox.Core;
    using Wavenet.Poc.Sandbox.Data.Fake.Model;

    /// <summary>
    /// Repository to manage the clients.
    /// </summary>
    public class ClientRepository : IClientRepository
    {
        private readonly IMapper mapper;

        private List<Client> clients;

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientRepository" /> class.
        /// </summary>
        /// <param name="mapper">The mapper.</param>
        public ClientRepository(IMapper mapper)
        {
            this.mapper = mapper;
        }

        /// <inheritdoc />
        public Client Get(int id)
        {
            return this.ReadFromFile().SingleOrDefault(x => x.Id == id);
        }

        /// <inheritdoc />
        public List<Client> GetAll(bool includeConfidential)
        {
            var data = this.ReadFromFile();

            if (includeConfidential)
            {
                return data;
            }

            return data.Where(x => x.IsConfidential == false).ToList();
        }

        private List<Client> ReadFromFile()
        {
            if (this.clients != null)
            {
                return this.clients;
            }

            using (var reader = new StreamReader("c:\\DEV\\TMP\\Wavenet.Poc.Sandbox\\Backend\\Wavenet.Poc.Sandbox.Web\\App_Data\\Fake\\clients.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Configuration.Delimiter = "|";
                var records = csv.GetRecords<ClientCsv>().ToList();
                this.clients = this.mapper.Map<List<Client>>(records);
                return this.clients;
            }
        }
    }
}