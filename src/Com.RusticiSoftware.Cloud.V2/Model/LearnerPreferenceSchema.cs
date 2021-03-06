/* 
 * SCORM Cloud Rest API
 *
 * REST API used for SCORM Cloud integrations.
 *
 * OpenAPI spec version: 2.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace Com.RusticiSoftware.Cloud.V2.Model
{
    /// <summary>
    /// LearnerPreferenceSchema
    /// </summary>
    [DataContract]
    public partial class LearnerPreferenceSchema :  IEquatable<LearnerPreferenceSchema>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LearnerPreferenceSchema" /> class.
        /// </summary>
        /// <param name="AudioLevel">AudioLevel.</param>
        /// <param name="Language">Language.</param>
        /// <param name="DeliverySpeed">DeliverySpeed.</param>
        /// <param name="AudioCaptioning">AudioCaptioning.</param>
        public LearnerPreferenceSchema(double? AudioLevel = default(double?), string Language = default(string), double? DeliverySpeed = default(double?), int? AudioCaptioning = default(int?))
        {
            this.AudioLevel = AudioLevel;
            this.Language = Language;
            this.DeliverySpeed = DeliverySpeed;
            this.AudioCaptioning = AudioCaptioning;
        }
        
        /// <summary>
        /// Gets or Sets AudioLevel
        /// </summary>
        [DataMember(Name="audioLevel", EmitDefaultValue=false)]
        public double? AudioLevel { get; set; }
        /// <summary>
        /// Gets or Sets Language
        /// </summary>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public string Language { get; set; }
        /// <summary>
        /// Gets or Sets DeliverySpeed
        /// </summary>
        [DataMember(Name="deliverySpeed", EmitDefaultValue=false)]
        public double? DeliverySpeed { get; set; }
        /// <summary>
        /// Gets or Sets AudioCaptioning
        /// </summary>
        [DataMember(Name="audioCaptioning", EmitDefaultValue=false)]
        public int? AudioCaptioning { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LearnerPreferenceSchema {\n");
            sb.Append("  AudioLevel: ").Append(AudioLevel).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  DeliverySpeed: ").Append(DeliverySpeed).Append("\n");
            sb.Append("  AudioCaptioning: ").Append(AudioCaptioning).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as LearnerPreferenceSchema);
        }

        /// <summary>
        /// Returns true if LearnerPreferenceSchema instances are equal
        /// </summary>
        /// <param name="other">Instance of LearnerPreferenceSchema to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LearnerPreferenceSchema other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AudioLevel == other.AudioLevel ||
                    this.AudioLevel != null &&
                    this.AudioLevel.Equals(other.AudioLevel)
                ) && 
                (
                    this.Language == other.Language ||
                    this.Language != null &&
                    this.Language.Equals(other.Language)
                ) && 
                (
                    this.DeliverySpeed == other.DeliverySpeed ||
                    this.DeliverySpeed != null &&
                    this.DeliverySpeed.Equals(other.DeliverySpeed)
                ) && 
                (
                    this.AudioCaptioning == other.AudioCaptioning ||
                    this.AudioCaptioning != null &&
                    this.AudioCaptioning.Equals(other.AudioCaptioning)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.AudioLevel != null)
                    hash = hash * 59 + this.AudioLevel.GetHashCode();
                if (this.Language != null)
                    hash = hash * 59 + this.Language.GetHashCode();
                if (this.DeliverySpeed != null)
                    hash = hash * 59 + this.DeliverySpeed.GetHashCode();
                if (this.AudioCaptioning != null)
                    hash = hash * 59 + this.AudioCaptioning.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
