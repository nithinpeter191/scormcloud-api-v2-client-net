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
    /// ActivityResultSchema
    /// </summary>
    [DataContract]
    public partial class ActivityResultSchema :  IEquatable<ActivityResultSchema>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets ActivityCompletion
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ActivityCompletionEnum
        {
            
            /// <summary>
            /// Enum UNKNOWN for "UNKNOWN"
            /// </summary>
            [EnumMember(Value = "UNKNOWN")]
            UNKNOWN,
            
            /// <summary>
            /// Enum COMPLETED for "COMPLETED"
            /// </summary>
            [EnumMember(Value = "COMPLETED")]
            COMPLETED,
            
            /// <summary>
            /// Enum INCOMPLETE for "INCOMPLETE"
            /// </summary>
            [EnumMember(Value = "INCOMPLETE")]
            INCOMPLETE
        }

        /// <summary>
        /// Gets or Sets ActivitySuccess
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ActivitySuccessEnum
        {
            
            /// <summary>
            /// Enum UNKNOWN for "UNKNOWN"
            /// </summary>
            [EnumMember(Value = "UNKNOWN")]
            UNKNOWN,
            
            /// <summary>
            /// Enum PASSED for "PASSED"
            /// </summary>
            [EnumMember(Value = "PASSED")]
            PASSED,
            
            /// <summary>
            /// Enum FAILED for "FAILED"
            /// </summary>
            [EnumMember(Value = "FAILED")]
            FAILED
        }

        /// <summary>
        /// Gets or Sets ActivityCompletion
        /// </summary>
        [DataMember(Name="activityCompletion", EmitDefaultValue=false)]
        public ActivityCompletionEnum? ActivityCompletion { get; set; }
        /// <summary>
        /// Gets or Sets ActivitySuccess
        /// </summary>
        [DataMember(Name="activitySuccess", EmitDefaultValue=false)]
        public ActivitySuccessEnum? ActivitySuccess { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityResultSchema" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Title">Title.</param>
        /// <param name="Attempts">Attempts.</param>
        /// <param name="ActivityCompletion">ActivityCompletion.</param>
        /// <param name="ActivitySuccess">ActivitySuccess.</param>
        /// <param name="Score">Score.</param>
        /// <param name="TimeTracked">TimeTracked.</param>
        /// <param name="CompletionAmount">CompletionAmount.</param>
        /// <param name="Suspended">Suspended.</param>
        /// <param name="Children">Children.</param>
        /// <param name="Objectives">Objectives.</param>
        /// <param name="StaticProperties">StaticProperties.</param>
        /// <param name="Runtime">Runtime.</param>
        public ActivityResultSchema(string Id = default(string), string Title = default(string), int? Attempts = default(int?), ActivityCompletionEnum? ActivityCompletion = default(ActivityCompletionEnum?), ActivitySuccessEnum? ActivitySuccess = default(ActivitySuccessEnum?), ScoreSchema Score = default(ScoreSchema), string TimeTracked = default(string), CompletionAmountSchema CompletionAmount = default(CompletionAmountSchema), bool? Suspended = default(bool?), List<ActivityResultSchema> Children = default(List<ActivityResultSchema>), List<ObjectiveSchema> Objectives = default(List<ObjectiveSchema>), StaticPropertiesSchema StaticProperties = default(StaticPropertiesSchema), RuntimeSchema Runtime = default(RuntimeSchema))
        {
            this.Id = Id;
            this.Title = Title;
            this.Attempts = Attempts;
            this.ActivityCompletion = ActivityCompletion;
            this.ActivitySuccess = ActivitySuccess;
            this.Score = Score;
            this.TimeTracked = TimeTracked;
            this.CompletionAmount = CompletionAmount;
            this.Suspended = Suspended;
            this.Children = Children;
            this.Objectives = Objectives;
            this.StaticProperties = StaticProperties;
            this.Runtime = Runtime;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }
        /// <summary>
        /// Gets or Sets Attempts
        /// </summary>
        [DataMember(Name="attempts", EmitDefaultValue=false)]
        public int? Attempts { get; set; }
        /// <summary>
        /// Gets or Sets Score
        /// </summary>
        [DataMember(Name="score", EmitDefaultValue=false)]
        public ScoreSchema Score { get; set; }
        /// <summary>
        /// Gets or Sets TimeTracked
        /// </summary>
        [DataMember(Name="timeTracked", EmitDefaultValue=false)]
        public string TimeTracked { get; set; }
        /// <summary>
        /// Gets or Sets CompletionAmount
        /// </summary>
        [DataMember(Name="completionAmount", EmitDefaultValue=false)]
        public CompletionAmountSchema CompletionAmount { get; set; }
        /// <summary>
        /// Gets or Sets Suspended
        /// </summary>
        [DataMember(Name="suspended", EmitDefaultValue=false)]
        public bool? Suspended { get; set; }
        /// <summary>
        /// Gets or Sets Children
        /// </summary>
        [DataMember(Name="children", EmitDefaultValue=false)]
        public List<ActivityResultSchema> Children { get; set; }
        /// <summary>
        /// Gets or Sets Objectives
        /// </summary>
        [DataMember(Name="objectives", EmitDefaultValue=false)]
        public List<ObjectiveSchema> Objectives { get; set; }
        /// <summary>
        /// Gets or Sets StaticProperties
        /// </summary>
        [DataMember(Name="staticProperties", EmitDefaultValue=false)]
        public StaticPropertiesSchema StaticProperties { get; set; }
        /// <summary>
        /// Gets or Sets Runtime
        /// </summary>
        [DataMember(Name="runtime", EmitDefaultValue=false)]
        public RuntimeSchema Runtime { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ActivityResultSchema {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Attempts: ").Append(Attempts).Append("\n");
            sb.Append("  ActivityCompletion: ").Append(ActivityCompletion).Append("\n");
            sb.Append("  ActivitySuccess: ").Append(ActivitySuccess).Append("\n");
            sb.Append("  Score: ").Append(Score).Append("\n");
            sb.Append("  TimeTracked: ").Append(TimeTracked).Append("\n");
            sb.Append("  CompletionAmount: ").Append(CompletionAmount).Append("\n");
            sb.Append("  Suspended: ").Append(Suspended).Append("\n");
            sb.Append("  Children: ").Append(Children).Append("\n");
            sb.Append("  Objectives: ").Append(Objectives).Append("\n");
            sb.Append("  StaticProperties: ").Append(StaticProperties).Append("\n");
            sb.Append("  Runtime: ").Append(Runtime).Append("\n");
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
            return this.Equals(obj as ActivityResultSchema);
        }

        /// <summary>
        /// Returns true if ActivityResultSchema instances are equal
        /// </summary>
        /// <param name="other">Instance of ActivityResultSchema to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ActivityResultSchema other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Title == other.Title ||
                    this.Title != null &&
                    this.Title.Equals(other.Title)
                ) && 
                (
                    this.Attempts == other.Attempts ||
                    this.Attempts != null &&
                    this.Attempts.Equals(other.Attempts)
                ) && 
                (
                    this.ActivityCompletion == other.ActivityCompletion ||
                    this.ActivityCompletion != null &&
                    this.ActivityCompletion.Equals(other.ActivityCompletion)
                ) && 
                (
                    this.ActivitySuccess == other.ActivitySuccess ||
                    this.ActivitySuccess != null &&
                    this.ActivitySuccess.Equals(other.ActivitySuccess)
                ) && 
                (
                    this.Score == other.Score ||
                    this.Score != null &&
                    this.Score.Equals(other.Score)
                ) && 
                (
                    this.TimeTracked == other.TimeTracked ||
                    this.TimeTracked != null &&
                    this.TimeTracked.Equals(other.TimeTracked)
                ) && 
                (
                    this.CompletionAmount == other.CompletionAmount ||
                    this.CompletionAmount != null &&
                    this.CompletionAmount.Equals(other.CompletionAmount)
                ) && 
                (
                    this.Suspended == other.Suspended ||
                    this.Suspended != null &&
                    this.Suspended.Equals(other.Suspended)
                ) && 
                (
                    this.Children == other.Children ||
                    this.Children != null &&
                    this.Children.SequenceEqual(other.Children)
                ) && 
                (
                    this.Objectives == other.Objectives ||
                    this.Objectives != null &&
                    this.Objectives.SequenceEqual(other.Objectives)
                ) && 
                (
                    this.StaticProperties == other.StaticProperties ||
                    this.StaticProperties != null &&
                    this.StaticProperties.Equals(other.StaticProperties)
                ) && 
                (
                    this.Runtime == other.Runtime ||
                    this.Runtime != null &&
                    this.Runtime.Equals(other.Runtime)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Title != null)
                    hash = hash * 59 + this.Title.GetHashCode();
                if (this.Attempts != null)
                    hash = hash * 59 + this.Attempts.GetHashCode();
                if (this.ActivityCompletion != null)
                    hash = hash * 59 + this.ActivityCompletion.GetHashCode();
                if (this.ActivitySuccess != null)
                    hash = hash * 59 + this.ActivitySuccess.GetHashCode();
                if (this.Score != null)
                    hash = hash * 59 + this.Score.GetHashCode();
                if (this.TimeTracked != null)
                    hash = hash * 59 + this.TimeTracked.GetHashCode();
                if (this.CompletionAmount != null)
                    hash = hash * 59 + this.CompletionAmount.GetHashCode();
                if (this.Suspended != null)
                    hash = hash * 59 + this.Suspended.GetHashCode();
                if (this.Children != null)
                    hash = hash * 59 + this.Children.GetHashCode();
                if (this.Objectives != null)
                    hash = hash * 59 + this.Objectives.GetHashCode();
                if (this.StaticProperties != null)
                    hash = hash * 59 + this.StaticProperties.GetHashCode();
                if (this.Runtime != null)
                    hash = hash * 59 + this.Runtime.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
