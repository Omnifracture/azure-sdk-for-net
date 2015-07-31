namespace Microsoft.Azure.Management.Compute.Models
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Compute-specific operation properties, including output
    /// </summary>
    public partial class ComputeLongRunningOperationProperties
    {
        /// <summary>
        /// Operation output data (raw JSON)
        /// </summary>
        [JsonProperty(PropertyName = "output")]
        public object Output { get; set; }

    }
}