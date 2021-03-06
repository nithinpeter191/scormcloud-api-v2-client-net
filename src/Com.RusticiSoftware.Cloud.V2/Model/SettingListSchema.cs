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
    /// SettingListSchema
    /// </summary>
    [DataContract]
    public partial class SettingListSchema :  IEquatable<SettingListSchema>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SettingListSchema" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SettingListSchema() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SettingListSchema" /> class.
        /// </summary>
        /// <param name="SettingItems">SettingItems (required).</param>
        public SettingListSchema(List<SettingItem> SettingItems = default(List<SettingItem>))
        {
            // to ensure "SettingItems" is required (not null)
            if (SettingItems == null)
            {
                throw new InvalidDataException("SettingItems is a required property for SettingListSchema and cannot be null");
            }
            else
            {
                this.SettingItems = SettingItems;
            }
        }
        
        /// <summary>
        /// Gets or Sets SettingItems
        /// </summary>
        [DataMember(Name="settingItems", EmitDefaultValue=false)]
        public List<SettingItem> SettingItems { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SettingListSchema {\n");
            sb.Append("  SettingItems: ").Append(SettingItems).Append("\n");
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
            return this.Equals(obj as SettingListSchema);
        }

        /// <summary>
        /// Returns true if SettingListSchema instances are equal
        /// </summary>
        /// <param name="other">Instance of SettingListSchema to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SettingListSchema other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.SettingItems == other.SettingItems ||
                    this.SettingItems != null &&
                    this.SettingItems.SequenceEqual(other.SettingItems)
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
                if (this.SettingItems != null)
                    hash = hash * 59 + this.SettingItems.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
