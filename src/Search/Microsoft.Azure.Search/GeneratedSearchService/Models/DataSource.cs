// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Search.Models
{
    using Azure;
    using Search;
    using Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Represents a datasource definition in Azure Search, which can be used
    /// to configure an indexer.
    /// </summary>
    public partial class DataSource
    {
        /// <summary>
        /// Initializes a new instance of the DataSource class.
        /// </summary>
        public DataSource() { }

        /// <summary>
        /// Initializes a new instance of the DataSource class.
        /// </summary>
        /// <param name="name">The name of the datasource.</param>
        /// <param name="type">The type of the datasource.</param>
        /// <param name="credentials">Credentials for the datasource.</param>
        /// <param name="container">The data container for the
        /// datasource.</param>
        /// <param name="description">The description of the
        /// datasource.</param>
        /// <param name="dataChangeDetectionPolicy">The data change detection
        /// policy for the datasource.</param>
        /// <param name="dataDeletionDetectionPolicy">The data deletion
        /// detection policy for the datasource.</param>
        /// <param name="eTag">The ETag of the DataSource.</param>
        public DataSource(string name, DataSourceType type, DataSourceCredentials credentials, DataContainer container, string description = default(string), DataChangeDetectionPolicy dataChangeDetectionPolicy = default(DataChangeDetectionPolicy), DataDeletionDetectionPolicy dataDeletionDetectionPolicy = default(DataDeletionDetectionPolicy), string eTag = default(string))
        {
            Name = name;
            Description = description;
            Type = type;
            Credentials = credentials;
            Container = container;
            DataChangeDetectionPolicy = dataChangeDetectionPolicy;
            DataDeletionDetectionPolicy = dataDeletionDetectionPolicy;
            ETag = eTag;
        }

        /// <summary>
        /// Gets or sets the name of the datasource.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description of the datasource.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the type of the datasource.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public DataSourceType Type { get; set; }

        /// <summary>
        /// Gets or sets credentials for the datasource.
        /// </summary>
        [JsonProperty(PropertyName = "credentials")]
        public DataSourceCredentials Credentials { get; set; }

        /// <summary>
        /// Gets or sets the data container for the datasource.
        /// </summary>
        [JsonProperty(PropertyName = "container")]
        public DataContainer Container { get; set; }

        /// <summary>
        /// Gets or sets the data change detection policy for the datasource.
        /// </summary>
        [JsonProperty(PropertyName = "dataChangeDetectionPolicy")]
        public DataChangeDetectionPolicy DataChangeDetectionPolicy { get; set; }

        /// <summary>
        /// Gets or sets the data deletion detection policy for the datasource.
        /// </summary>
        [JsonProperty(PropertyName = "dataDeletionDetectionPolicy")]
        public DataDeletionDetectionPolicy DataDeletionDetectionPolicy { get; set; }

        /// <summary>
        /// Gets or sets the ETag of the DataSource.
        /// </summary>
        [JsonProperty(PropertyName = "@odata.etag")]
        public string ETag { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (Type == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Type");
            }
            if (Credentials == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Credentials");
            }
            if (Container == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Container");
            }
            if (Credentials != null)
            {
                Credentials.Validate();
            }
            if (Container != null)
            {
                Container.Validate();
            }
        }
    }
}

