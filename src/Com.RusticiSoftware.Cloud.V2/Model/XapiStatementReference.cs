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
    /// https://github.com/adlnet/xAPI-Spec/blob/1.0.2/xAPI.md#statement-references
    /// </summary>
    [DataContract]
    public partial class XapiStatementReference :  IEquatable<XapiStatementReference>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="XapiStatementReference" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected XapiStatementReference() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="XapiStatementReference" /> class.
        /// </summary>
        /// <param name="ObjectType">ObjectType (required) (default to &quot;StatementRef&quot;).</param>
        /// <param name="Id">Id (required).</param>
        public XapiStatementReference(string ObjectType = "StatementRef", string Id = default(string))
        {
            // to ensure "ObjectType" is required (not null)
            if (ObjectType == null)
            {
                throw new InvalidDataException("ObjectType is a required property for XapiStatementReference and cannot be null");
            }
            else
            {
                this.ObjectType = ObjectType;
            }
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for XapiStatementReference and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
        }
        
        /// <summary>
        /// Gets or Sets ObjectType
        /// </summary>
        [DataMember(Name="objectType", EmitDefaultValue=false)]
        public string ObjectType { get; set; }
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class XapiStatementReference {\n");
            sb.Append("  ObjectType: ").Append(ObjectType).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
            return this.Equals(obj as XapiStatementReference);
        }

        /// <summary>
        /// Returns true if XapiStatementReference instances are equal
        /// </summary>
        /// <param name="other">Instance of XapiStatementReference to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(XapiStatementReference other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ObjectType == other.ObjectType ||
                    this.ObjectType != null &&
                    this.ObjectType.Equals(other.ObjectType)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
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
                if (this.ObjectType != null)
                    hash = hash * 59 + this.ObjectType.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
