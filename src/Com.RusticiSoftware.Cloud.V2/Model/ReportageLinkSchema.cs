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
    /// ReportageLinkSchema
    /// </summary>
    [DataContract]
    public partial class ReportageLinkSchema :  IEquatable<ReportageLinkSchema>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportageLinkSchema" /> class.
        /// </summary>
        /// <param name="ReportageLink">ReportageLink.</param>
        public ReportageLinkSchema(string ReportageLink = default(string))
        {
            this.ReportageLink = ReportageLink;
        }
        
        /// <summary>
        /// Gets or Sets ReportageLink
        /// </summary>
        [DataMember(Name="reportageLink", EmitDefaultValue=false)]
        public string ReportageLink { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReportageLinkSchema {\n");
            sb.Append("  ReportageLink: ").Append(ReportageLink).Append("\n");
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
            return this.Equals(obj as ReportageLinkSchema);
        }

        /// <summary>
        /// Returns true if ReportageLinkSchema instances are equal
        /// </summary>
        /// <param name="other">Instance of ReportageLinkSchema to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReportageLinkSchema other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ReportageLink == other.ReportageLink ||
                    this.ReportageLink != null &&
                    this.ReportageLink.Equals(other.ReportageLink)
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
                if (this.ReportageLink != null)
                    hash = hash * 59 + this.ReportageLink.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
