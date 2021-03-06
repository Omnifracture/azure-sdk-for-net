// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.CognitiveServices.Language.TextAnalytics.Models
{
    using Microsoft.CognitiveServices;
    using Microsoft.CognitiveServices.Language;
    using Microsoft.CognitiveServices.Language.TextAnalytics;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class KeyPhraseBatchResult
    {
        /// <summary>
        /// Initializes a new instance of the KeyPhraseBatchResult class.
        /// </summary>
        public KeyPhraseBatchResult()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the KeyPhraseBatchResult class.
        /// </summary>
        public KeyPhraseBatchResult(IList<KeyPhraseBatchResultItem> documents = default(IList<KeyPhraseBatchResultItem>), IList<ErrorRecord> errors = default(IList<ErrorRecord>))
        {
            Documents = documents;
            Errors = errors;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "documents")]
        public IList<KeyPhraseBatchResultItem> Documents { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "errors")]
        public IList<ErrorRecord> Errors { get; private set; }

    }
}
