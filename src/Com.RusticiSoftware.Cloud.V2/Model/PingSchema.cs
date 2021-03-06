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
    /// PingSchema
    /// </summary>
    [DataContract]
    public partial class PingSchema :  IEquatable<PingSchema>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PingSchema" /> class.
        /// </summary>
        /// <param name="ApiMessage">ApiMessage.</param>
        /// <param name="CurrentTime">CurrentTime.</param>
        public PingSchema(string ApiMessage = default(string), string CurrentTime = default(string))
        {
            this.ApiMessage = ApiMessage;
            this.CurrentTime = CurrentTime;
        }
        
        /// <summary>
        /// Gets or Sets ApiMessage
        /// </summary>
        [DataMember(Name="apiMessage", EmitDefaultValue=false)]
        public string ApiMessage { get; set; }
        /// <summary>
        /// Gets or Sets CurrentTime
        /// </summary>
        [DataMember(Name="currentTime", EmitDefaultValue=false)]
        public string CurrentTime { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PingSchema {\n");
            sb.Append("  ApiMessage: ").Append(ApiMessage).Append("\n");
            sb.Append("  CurrentTime: ").Append(CurrentTime).Append("\n");
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
            return this.Equals(obj as PingSchema);
        }

        /// <summary>
        /// Returns true if PingSchema instances are equal
        /// </summary>
        /// <param name="other">Instance of PingSchema to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PingSchema other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ApiMessage == other.ApiMessage ||
                    this.ApiMessage != null &&
                    this.ApiMessage.Equals(other.ApiMessage)
                ) && 
                (
                    this.CurrentTime == other.CurrentTime ||
                    this.CurrentTime != null &&
                    this.CurrentTime.Equals(other.CurrentTime)
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
                if (this.ApiMessage != null)
                    hash = hash * 59 + this.ApiMessage.GetHashCode();
                if (this.CurrentTime != null)
                    hash = hash * 59 + this.CurrentTime.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
