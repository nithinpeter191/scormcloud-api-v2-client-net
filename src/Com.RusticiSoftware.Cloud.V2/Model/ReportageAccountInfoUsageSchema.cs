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
    /// ReportageAccountInfoUsageSchema
    /// </summary>
    [DataContract]
    public partial class ReportageAccountInfoUsageSchema :  IEquatable<ReportageAccountInfoUsageSchema>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportageAccountInfoUsageSchema" /> class.
        /// </summary>
        /// <param name="MonthStart">MonthStart.</param>
        /// <param name="RegCount">RegCount.</param>
        /// <param name="TotalRegistrations">TotalRegistrations.</param>
        /// <param name="TotalCourses">TotalCourses.</param>
        public ReportageAccountInfoUsageSchema(DateTime? MonthStart = default(DateTime?), int? RegCount = default(int?), int? TotalRegistrations = default(int?), int? TotalCourses = default(int?))
        {
            this.MonthStart = MonthStart;
            this.RegCount = RegCount;
            this.TotalRegistrations = TotalRegistrations;
            this.TotalCourses = TotalCourses;
        }
        
        /// <summary>
        /// Gets or Sets MonthStart
        /// </summary>
        [DataMember(Name="monthStart", EmitDefaultValue=false)]
        public DateTime? MonthStart { get; set; }
        /// <summary>
        /// Gets or Sets RegCount
        /// </summary>
        [DataMember(Name="regCount", EmitDefaultValue=false)]
        public int? RegCount { get; set; }
        /// <summary>
        /// Gets or Sets TotalRegistrations
        /// </summary>
        [DataMember(Name="totalRegistrations", EmitDefaultValue=false)]
        public int? TotalRegistrations { get; set; }
        /// <summary>
        /// Gets or Sets TotalCourses
        /// </summary>
        [DataMember(Name="totalCourses", EmitDefaultValue=false)]
        public int? TotalCourses { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReportageAccountInfoUsageSchema {\n");
            sb.Append("  MonthStart: ").Append(MonthStart).Append("\n");
            sb.Append("  RegCount: ").Append(RegCount).Append("\n");
            sb.Append("  TotalRegistrations: ").Append(TotalRegistrations).Append("\n");
            sb.Append("  TotalCourses: ").Append(TotalCourses).Append("\n");
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
            return this.Equals(obj as ReportageAccountInfoUsageSchema);
        }

        /// <summary>
        /// Returns true if ReportageAccountInfoUsageSchema instances are equal
        /// </summary>
        /// <param name="other">Instance of ReportageAccountInfoUsageSchema to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReportageAccountInfoUsageSchema other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.MonthStart == other.MonthStart ||
                    this.MonthStart != null &&
                    this.MonthStart.Equals(other.MonthStart)
                ) && 
                (
                    this.RegCount == other.RegCount ||
                    this.RegCount != null &&
                    this.RegCount.Equals(other.RegCount)
                ) && 
                (
                    this.TotalRegistrations == other.TotalRegistrations ||
                    this.TotalRegistrations != null &&
                    this.TotalRegistrations.Equals(other.TotalRegistrations)
                ) && 
                (
                    this.TotalCourses == other.TotalCourses ||
                    this.TotalCourses != null &&
                    this.TotalCourses.Equals(other.TotalCourses)
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
                if (this.MonthStart != null)
                    hash = hash * 59 + this.MonthStart.GetHashCode();
                if (this.RegCount != null)
                    hash = hash * 59 + this.RegCount.GetHashCode();
                if (this.TotalRegistrations != null)
                    hash = hash * 59 + this.TotalRegistrations.GetHashCode();
                if (this.TotalCourses != null)
                    hash = hash * 59 + this.TotalCourses.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
