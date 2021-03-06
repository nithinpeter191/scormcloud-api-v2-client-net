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
    /// UserInvitationList
    /// </summary>
    [DataContract]
    public partial class UserInvitationList :  IEquatable<UserInvitationList>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserInvitationList" /> class.
        /// </summary>
        /// <param name="UserInvitations">A list of user invitation objects..</param>
        /// <param name="More">More.</param>
        public UserInvitationList(List<UserInvitationSchema> UserInvitations = default(List<UserInvitationSchema>), string More = default(string))
        {
            this.UserInvitations = UserInvitations;
            this.More = More;
        }
        
        /// <summary>
        /// A list of user invitation objects.
        /// </summary>
        /// <value>A list of user invitation objects.</value>
        [DataMember(Name="userInvitations", EmitDefaultValue=false)]
        public List<UserInvitationSchema> UserInvitations { get; set; }
        /// <summary>
        /// Gets or Sets More
        /// </summary>
        [DataMember(Name="more", EmitDefaultValue=false)]
        public string More { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserInvitationList {\n");
            sb.Append("  UserInvitations: ").Append(UserInvitations).Append("\n");
            sb.Append("  More: ").Append(More).Append("\n");
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
            return this.Equals(obj as UserInvitationList);
        }

        /// <summary>
        /// Returns true if UserInvitationList instances are equal
        /// </summary>
        /// <param name="other">Instance of UserInvitationList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserInvitationList other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.UserInvitations == other.UserInvitations ||
                    this.UserInvitations != null &&
                    this.UserInvitations.SequenceEqual(other.UserInvitations)
                ) && 
                (
                    this.More == other.More ||
                    this.More != null &&
                    this.More.Equals(other.More)
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
                if (this.UserInvitations != null)
                    hash = hash * 59 + this.UserInvitations.GetHashCode();
                if (this.More != null)
                    hash = hash * 59 + this.More.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
