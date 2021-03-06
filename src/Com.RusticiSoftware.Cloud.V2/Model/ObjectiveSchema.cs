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
    /// ObjectiveSchema
    /// </summary>
    [DataContract]
    public partial class ObjectiveSchema :  IEquatable<ObjectiveSchema>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets ObjectiveCompletion
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ObjectiveCompletionEnum
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
        /// Gets or Sets ObjectiveSuccess
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ObjectiveSuccessEnum
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
        /// Gets or Sets PreviousObjectiveSuccess
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PreviousObjectiveSuccessEnum
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
        /// Gets or Sets ObjectiveCompletion
        /// </summary>
        [DataMember(Name="objectiveCompletion", EmitDefaultValue=false)]
        public ObjectiveCompletionEnum? ObjectiveCompletion { get; set; }
        /// <summary>
        /// Gets or Sets ObjectiveSuccess
        /// </summary>
        [DataMember(Name="objectiveSuccess", EmitDefaultValue=false)]
        public ObjectiveSuccessEnum? ObjectiveSuccess { get; set; }
        /// <summary>
        /// Gets or Sets PreviousObjectiveSuccess
        /// </summary>
        [DataMember(Name="previousObjectiveSuccess", EmitDefaultValue=false)]
        public PreviousObjectiveSuccessEnum? PreviousObjectiveSuccess { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectiveSchema" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Primary">Primary.</param>
        /// <param name="Score">Score.</param>
        /// <param name="ScoreMax">ScoreMax.</param>
        /// <param name="ScoreMin">ScoreMin.</param>
        /// <param name="ScoreRaw">ScoreRaw.</param>
        /// <param name="PreviousScoreScaled">PreviousScoreScaled.</param>
        /// <param name="FirstScoreScaled">FirstScoreScaled.</param>
        /// <param name="ProgressMeasure">ProgressMeasure.</param>
        /// <param name="FirstSuccessTimeStamp">FirstSuccessTimeStamp.</param>
        /// <param name="ObjectiveCompletion">ObjectiveCompletion (default to ObjectiveCompletionEnum.UNKNOWN).</param>
        /// <param name="ObjectiveSuccess">ObjectiveSuccess (default to ObjectiveSuccessEnum.UNKNOWN).</param>
        /// <param name="PreviousObjectiveSuccess">PreviousObjectiveSuccess (default to PreviousObjectiveSuccessEnum.UNKNOWN).</param>
        public ObjectiveSchema(string Id = default(string), bool? Primary = default(bool?), ScoreSchema Score = default(ScoreSchema), double? ScoreMax = default(double?), double? ScoreMin = default(double?), double? ScoreRaw = default(double?), double? PreviousScoreScaled = default(double?), double? FirstScoreScaled = default(double?), double? ProgressMeasure = default(double?), string FirstSuccessTimeStamp = default(string), ObjectiveCompletionEnum? ObjectiveCompletion = ObjectiveCompletionEnum.UNKNOWN, ObjectiveSuccessEnum? ObjectiveSuccess = ObjectiveSuccessEnum.UNKNOWN, PreviousObjectiveSuccessEnum? PreviousObjectiveSuccess = PreviousObjectiveSuccessEnum.UNKNOWN)
        {
            this.Id = Id;
            this.Primary = Primary;
            this.Score = Score;
            this.ScoreMax = ScoreMax;
            this.ScoreMin = ScoreMin;
            this.ScoreRaw = ScoreRaw;
            this.PreviousScoreScaled = PreviousScoreScaled;
            this.FirstScoreScaled = FirstScoreScaled;
            this.ProgressMeasure = ProgressMeasure;
            this.FirstSuccessTimeStamp = FirstSuccessTimeStamp;
            // use default value if no "ObjectiveCompletion" provided
            if (ObjectiveCompletion == null)
            {
                this.ObjectiveCompletion = ObjectiveCompletionEnum.UNKNOWN;
            }
            else
            {
                this.ObjectiveCompletion = ObjectiveCompletion;
            }
            // use default value if no "ObjectiveSuccess" provided
            if (ObjectiveSuccess == null)
            {
                this.ObjectiveSuccess = ObjectiveSuccessEnum.UNKNOWN;
            }
            else
            {
                this.ObjectiveSuccess = ObjectiveSuccess;
            }
            // use default value if no "PreviousObjectiveSuccess" provided
            if (PreviousObjectiveSuccess == null)
            {
                this.PreviousObjectiveSuccess = PreviousObjectiveSuccessEnum.UNKNOWN;
            }
            else
            {
                this.PreviousObjectiveSuccess = PreviousObjectiveSuccess;
            }
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// Gets or Sets Primary
        /// </summary>
        [DataMember(Name="primary", EmitDefaultValue=false)]
        public bool? Primary { get; set; }
        /// <summary>
        /// Gets or Sets Score
        /// </summary>
        [DataMember(Name="score", EmitDefaultValue=false)]
        public ScoreSchema Score { get; set; }
        /// <summary>
        /// Gets or Sets ScoreMax
        /// </summary>
        [DataMember(Name="scoreMax", EmitDefaultValue=false)]
        public double? ScoreMax { get; set; }
        /// <summary>
        /// Gets or Sets ScoreMin
        /// </summary>
        [DataMember(Name="scoreMin", EmitDefaultValue=false)]
        public double? ScoreMin { get; set; }
        /// <summary>
        /// Gets or Sets ScoreRaw
        /// </summary>
        [DataMember(Name="scoreRaw", EmitDefaultValue=false)]
        public double? ScoreRaw { get; set; }
        /// <summary>
        /// Gets or Sets PreviousScoreScaled
        /// </summary>
        [DataMember(Name="previousScoreScaled", EmitDefaultValue=false)]
        public double? PreviousScoreScaled { get; set; }
        /// <summary>
        /// Gets or Sets FirstScoreScaled
        /// </summary>
        [DataMember(Name="firstScoreScaled", EmitDefaultValue=false)]
        public double? FirstScoreScaled { get; set; }
        /// <summary>
        /// Gets or Sets ProgressMeasure
        /// </summary>
        [DataMember(Name="progressMeasure", EmitDefaultValue=false)]
        public double? ProgressMeasure { get; set; }
        /// <summary>
        /// Gets or Sets FirstSuccessTimeStamp
        /// </summary>
        [DataMember(Name="firstSuccessTimeStamp", EmitDefaultValue=false)]
        public string FirstSuccessTimeStamp { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ObjectiveSchema {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Primary: ").Append(Primary).Append("\n");
            sb.Append("  Score: ").Append(Score).Append("\n");
            sb.Append("  ScoreMax: ").Append(ScoreMax).Append("\n");
            sb.Append("  ScoreMin: ").Append(ScoreMin).Append("\n");
            sb.Append("  ScoreRaw: ").Append(ScoreRaw).Append("\n");
            sb.Append("  PreviousScoreScaled: ").Append(PreviousScoreScaled).Append("\n");
            sb.Append("  FirstScoreScaled: ").Append(FirstScoreScaled).Append("\n");
            sb.Append("  ProgressMeasure: ").Append(ProgressMeasure).Append("\n");
            sb.Append("  FirstSuccessTimeStamp: ").Append(FirstSuccessTimeStamp).Append("\n");
            sb.Append("  ObjectiveCompletion: ").Append(ObjectiveCompletion).Append("\n");
            sb.Append("  ObjectiveSuccess: ").Append(ObjectiveSuccess).Append("\n");
            sb.Append("  PreviousObjectiveSuccess: ").Append(PreviousObjectiveSuccess).Append("\n");
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
            return this.Equals(obj as ObjectiveSchema);
        }

        /// <summary>
        /// Returns true if ObjectiveSchema instances are equal
        /// </summary>
        /// <param name="other">Instance of ObjectiveSchema to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ObjectiveSchema other)
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
                    this.Primary == other.Primary ||
                    this.Primary != null &&
                    this.Primary.Equals(other.Primary)
                ) && 
                (
                    this.Score == other.Score ||
                    this.Score != null &&
                    this.Score.Equals(other.Score)
                ) && 
                (
                    this.ScoreMax == other.ScoreMax ||
                    this.ScoreMax != null &&
                    this.ScoreMax.Equals(other.ScoreMax)
                ) && 
                (
                    this.ScoreMin == other.ScoreMin ||
                    this.ScoreMin != null &&
                    this.ScoreMin.Equals(other.ScoreMin)
                ) && 
                (
                    this.ScoreRaw == other.ScoreRaw ||
                    this.ScoreRaw != null &&
                    this.ScoreRaw.Equals(other.ScoreRaw)
                ) && 
                (
                    this.PreviousScoreScaled == other.PreviousScoreScaled ||
                    this.PreviousScoreScaled != null &&
                    this.PreviousScoreScaled.Equals(other.PreviousScoreScaled)
                ) && 
                (
                    this.FirstScoreScaled == other.FirstScoreScaled ||
                    this.FirstScoreScaled != null &&
                    this.FirstScoreScaled.Equals(other.FirstScoreScaled)
                ) && 
                (
                    this.ProgressMeasure == other.ProgressMeasure ||
                    this.ProgressMeasure != null &&
                    this.ProgressMeasure.Equals(other.ProgressMeasure)
                ) && 
                (
                    this.FirstSuccessTimeStamp == other.FirstSuccessTimeStamp ||
                    this.FirstSuccessTimeStamp != null &&
                    this.FirstSuccessTimeStamp.Equals(other.FirstSuccessTimeStamp)
                ) && 
                (
                    this.ObjectiveCompletion == other.ObjectiveCompletion ||
                    this.ObjectiveCompletion != null &&
                    this.ObjectiveCompletion.Equals(other.ObjectiveCompletion)
                ) && 
                (
                    this.ObjectiveSuccess == other.ObjectiveSuccess ||
                    this.ObjectiveSuccess != null &&
                    this.ObjectiveSuccess.Equals(other.ObjectiveSuccess)
                ) && 
                (
                    this.PreviousObjectiveSuccess == other.PreviousObjectiveSuccess ||
                    this.PreviousObjectiveSuccess != null &&
                    this.PreviousObjectiveSuccess.Equals(other.PreviousObjectiveSuccess)
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
                if (this.Primary != null)
                    hash = hash * 59 + this.Primary.GetHashCode();
                if (this.Score != null)
                    hash = hash * 59 + this.Score.GetHashCode();
                if (this.ScoreMax != null)
                    hash = hash * 59 + this.ScoreMax.GetHashCode();
                if (this.ScoreMin != null)
                    hash = hash * 59 + this.ScoreMin.GetHashCode();
                if (this.ScoreRaw != null)
                    hash = hash * 59 + this.ScoreRaw.GetHashCode();
                if (this.PreviousScoreScaled != null)
                    hash = hash * 59 + this.PreviousScoreScaled.GetHashCode();
                if (this.FirstScoreScaled != null)
                    hash = hash * 59 + this.FirstScoreScaled.GetHashCode();
                if (this.ProgressMeasure != null)
                    hash = hash * 59 + this.ProgressMeasure.GetHashCode();
                if (this.FirstSuccessTimeStamp != null)
                    hash = hash * 59 + this.FirstSuccessTimeStamp.GetHashCode();
                if (this.ObjectiveCompletion != null)
                    hash = hash * 59 + this.ObjectiveCompletion.GetHashCode();
                if (this.ObjectiveSuccess != null)
                    hash = hash * 59 + this.ObjectiveSuccess.GetHashCode();
                if (this.PreviousObjectiveSuccess != null)
                    hash = hash * 59 + this.PreviousObjectiveSuccess.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
