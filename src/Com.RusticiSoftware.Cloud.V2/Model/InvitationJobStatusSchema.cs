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
    /// InvitationJobStatusSchema
    /// </summary>
    [DataContract]
    public partial class InvitationJobStatusSchema :  IEquatable<InvitationJobStatusSchema>, IValidatableObject
    {
        /// <summary>
        /// The status of the job.
        /// </summary>
        /// <value>The status of the job.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum STARTED for "STARTED"
            /// </summary>
            [EnumMember(Value = "STARTED")]
            STARTED,
            
            /// <summary>
            /// Enum CANCELLED for "CANCELLED"
            /// </summary>
            [EnumMember(Value = "CANCELLED")]
            CANCELLED,
            
            /// <summary>
            /// Enum COMPLETE for "COMPLETE"
            /// </summary>
            [EnumMember(Value = "COMPLETE")]
            COMPLETE,
            
            /// <summary>
            /// Enum ERROR for "ERROR"
            /// </summary>
            [EnumMember(Value = "ERROR")]
            ERROR
        }

        /// <summary>
        /// The status of the job.
        /// </summary>
        /// <value>The status of the job.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="InvitationJobStatusSchema" /> class.
        /// </summary>
        /// <param name="Status">The status of the job..</param>
        /// <param name="Errors">An array containing any errors which occurred..</param>
        /// <param name="Total">The total number of private invitations to be sent..</param>
        /// <param name="Processed">The number of private invitations which have been sent..</param>
        public InvitationJobStatusSchema(StatusEnum? Status = default(StatusEnum?), List<string> Errors = default(List<string>), int? Total = default(int?), int? Processed = default(int?))
        {
            this.Status = Status;
            this.Errors = Errors;
            this.Total = Total;
            this.Processed = Processed;
        }
        
        /// <summary>
        /// An array containing any errors which occurred.
        /// </summary>
        /// <value>An array containing any errors which occurred.</value>
        [DataMember(Name="errors", EmitDefaultValue=false)]
        public List<string> Errors { get; set; }
        /// <summary>
        /// The total number of private invitations to be sent.
        /// </summary>
        /// <value>The total number of private invitations to be sent.</value>
        [DataMember(Name="total", EmitDefaultValue=false)]
        public int? Total { get; set; }
        /// <summary>
        /// The number of private invitations which have been sent.
        /// </summary>
        /// <value>The number of private invitations which have been sent.</value>
        [DataMember(Name="processed", EmitDefaultValue=false)]
        public int? Processed { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InvitationJobStatusSchema {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  Processed: ").Append(Processed).Append("\n");
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
            return this.Equals(obj as InvitationJobStatusSchema);
        }

        /// <summary>
        /// Returns true if InvitationJobStatusSchema instances are equal
        /// </summary>
        /// <param name="other">Instance of InvitationJobStatusSchema to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InvitationJobStatusSchema other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.Errors == other.Errors ||
                    this.Errors != null &&
                    this.Errors.SequenceEqual(other.Errors)
                ) && 
                (
                    this.Total == other.Total ||
                    this.Total != null &&
                    this.Total.Equals(other.Total)
                ) && 
                (
                    this.Processed == other.Processed ||
                    this.Processed != null &&
                    this.Processed.Equals(other.Processed)
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
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.Errors != null)
                    hash = hash * 59 + this.Errors.GetHashCode();
                if (this.Total != null)
                    hash = hash * 59 + this.Total.GetHashCode();
                if (this.Processed != null)
                    hash = hash * 59 + this.Processed.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
