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
    /// https://github.com/adlnet/xAPI-Spec/blob/1.0.2/xAPI.md#413-verb
    /// </summary>
    [DataContract]
    public partial class XapiVerb :  IEquatable<XapiVerb>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="XapiVerb" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected XapiVerb() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="XapiVerb" /> class.
        /// </summary>
        /// <param name="Id">Id (required).</param>
        /// <param name="Display">Display.</param>
        public XapiVerb(string Id = default(string), Dictionary<string, string> Display = default(Dictionary<string, string>))
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for XapiVerb and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            this.Display = Display;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// Gets or Sets Display
        /// </summary>
        [DataMember(Name="display", EmitDefaultValue=false)]
        public Dictionary<string, string> Display { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class XapiVerb {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Display: ").Append(Display).Append("\n");
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
            return this.Equals(obj as XapiVerb);
        }

        /// <summary>
        /// Returns true if XapiVerb instances are equal
        /// </summary>
        /// <param name="other">Instance of XapiVerb to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(XapiVerb other)
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
                    this.Display == other.Display ||
                    this.Display != null &&
                    this.Display.SequenceEqual(other.Display)
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
                if (this.Display != null)
                    hash = hash * 59 + this.Display.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
