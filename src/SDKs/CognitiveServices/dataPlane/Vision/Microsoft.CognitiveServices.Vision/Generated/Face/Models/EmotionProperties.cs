// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.CognitiveServices.Vision.Face.Models
{
    using Microsoft.CognitiveServices;
    using Microsoft.CognitiveServices.Vision;
    using Microsoft.CognitiveServices.Vision.Face;
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Properties describing facial emotion.
    /// </summary>
    public partial class EmotionProperties
    {
        /// <summary>
        /// Initializes a new instance of the EmotionProperties class.
        /// </summary>
        public EmotionProperties()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EmotionProperties class.
        /// </summary>
        public EmotionProperties(double? anger = default(double?), double? contempt = default(double?), double? disgust = default(double?), double? fear = default(double?), double? happiness = default(double?), double? neutral = default(double?), double? sadness = default(double?), double? surprise = default(double?))
        {
            Anger = anger;
            Contempt = contempt;
            Disgust = disgust;
            Fear = fear;
            Happiness = happiness;
            Neutral = neutral;
            Sadness = sadness;
            Surprise = surprise;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "anger")]
        public double? Anger { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "contempt")]
        public double? Contempt { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "disgust")]
        public double? Disgust { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "fear")]
        public double? Fear { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "happiness")]
        public double? Happiness { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "neutral")]
        public double? Neutral { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sadness")]
        public double? Sadness { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "surprise")]
        public double? Surprise { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Anger > 1)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "Anger", 1);
            }
            if (Anger < 0)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "Anger", 0);
            }
            if (Contempt > 1)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "Contempt", 1);
            }
            if (Contempt < 0)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "Contempt", 0);
            }
            if (Disgust > 1)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "Disgust", 1);
            }
            if (Disgust < 0)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "Disgust", 0);
            }
            if (Fear > 1)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "Fear", 1);
            }
            if (Fear < 0)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "Fear", 0);
            }
            if (Happiness > 1)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "Happiness", 1);
            }
            if (Happiness < 0)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "Happiness", 0);
            }
            if (Neutral > 1)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "Neutral", 1);
            }
            if (Neutral < 0)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "Neutral", 0);
            }
            if (Sadness > 1)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "Sadness", 1);
            }
            if (Sadness < 0)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "Sadness", 0);
            }
            if (Surprise > 1)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "Surprise", 1);
            }
            if (Surprise < 0)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "Surprise", 0);
            }
        }
    }
}
