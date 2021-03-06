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
    /// https://github.com/adlnet/xAPI-Spec/blob/1.0.2/xAPI.md#4151-score
    /// </summary>
    [DataContract]
    public partial class XapiScore :  IEquatable<XapiScore>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="XapiScore" /> class.
        /// </summary>
        /// <param name="Scaled">Scaled.</param>
        /// <param name="Raw">Raw.</param>
        /// <param name="Min">Min.</param>
        /// <param name="Max">Max.</param>
        public XapiScore(double? Scaled = default(double?), double? Raw = default(double?), double? Min = default(double?), double? Max = default(double?))
        {
            this.Scaled = Scaled;
            this.Raw = Raw;
            this.Min = Min;
            this.Max = Max;
        }
        
        /// <summary>
        /// Gets or Sets Scaled
        /// </summary>
        [DataMember(Name="scaled", EmitDefaultValue=false)]
        public double? Scaled { get; set; }
        /// <summary>
        /// Gets or Sets Raw
        /// </summary>
        [DataMember(Name="raw", EmitDefaultValue=false)]
        public double? Raw { get; set; }
        /// <summary>
        /// Gets or Sets Min
        /// </summary>
        [DataMember(Name="min", EmitDefaultValue=false)]
        public double? Min { get; set; }
        /// <summary>
        /// Gets or Sets Max
        /// </summary>
        [DataMember(Name="max", EmitDefaultValue=false)]
        public double? Max { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class XapiScore {\n");
            sb.Append("  Scaled: ").Append(Scaled).Append("\n");
            sb.Append("  Raw: ").Append(Raw).Append("\n");
            sb.Append("  Min: ").Append(Min).Append("\n");
            sb.Append("  Max: ").Append(Max).Append("\n");
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
            return this.Equals(obj as XapiScore);
        }

        /// <summary>
        /// Returns true if XapiScore instances are equal
        /// </summary>
        /// <param name="other">Instance of XapiScore to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(XapiScore other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Scaled == other.Scaled ||
                    this.Scaled != null &&
                    this.Scaled.Equals(other.Scaled)
                ) && 
                (
                    this.Raw == other.Raw ||
                    this.Raw != null &&
                    this.Raw.Equals(other.Raw)
                ) && 
                (
                    this.Min == other.Min ||
                    this.Min != null &&
                    this.Min.Equals(other.Min)
                ) && 
                (
                    this.Max == other.Max ||
                    this.Max != null &&
                    this.Max.Equals(other.Max)
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
                if (this.Scaled != null)
                    hash = hash * 59 + this.Scaled.GetHashCode();
                if (this.Raw != null)
                    hash = hash * 59 + this.Raw.GetHashCode();
                if (this.Min != null)
                    hash = hash * 59 + this.Min.GetHashCode();
                if (this.Max != null)
                    hash = hash * 59 + this.Max.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
