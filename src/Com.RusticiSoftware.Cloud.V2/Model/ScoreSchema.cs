/* 
 * SCORM Cloud Rest API
 *
 * REST API used for SCORM Cloud integrations.
 *
 * OpenAPI spec version: 2.0 beta
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Com.RusticiSoftware.Cloud.V2.Model
{
    /// <summary>
    /// ScoreSchema
    /// </summary>
    [DataContract]
    public partial class ScoreSchema :  IEquatable<ScoreSchema>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScoreSchema" /> class.
        /// </summary>
        /// <param name="Scaled">Scaled score between 0 and 100.</param>
        public ScoreSchema(double? Scaled = null)
        {
            this.Scaled = Scaled;
        }
        
        /// <summary>
        /// Scaled score between 0 and 100
        /// </summary>
        /// <value>Scaled score between 0 and 100</value>
        [DataMember(Name="scaled", EmitDefaultValue=false)]
        public double? Scaled { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScoreSchema {\n");
            sb.Append("  Scaled: ").Append(Scaled).Append("\n");
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
            return this.Equals(obj as ScoreSchema);
        }

        /// <summary>
        /// Returns true if ScoreSchema instances are equal
        /// </summary>
        /// <param name="other">Instance of ScoreSchema to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScoreSchema other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Scaled == other.Scaled ||
                    this.Scaled != null &&
                    this.Scaled.Equals(other.Scaled)
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
                return hash;
            }
        }
    }

}