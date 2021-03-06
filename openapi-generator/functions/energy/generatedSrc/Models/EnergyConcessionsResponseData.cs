/*
 * CDR Energy API
 *
 * Consumer Data Right end points and payloads for the Energy sector
 *
 * The version of the OpenAPI document: 1.15.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Agl.Cdr.Energy.Client.OpenAPIDateConverter;

namespace Agl.Cdr.Energy.Models
{
    /// <summary>
    /// EnergyConcessionsResponseData
    /// </summary>
    [DataContract(Name = "EnergyConcessionsResponse_data")]
    public partial class EnergyConcessionsResponseData : IEquatable<EnergyConcessionsResponseData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EnergyConcessionsResponseData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EnergyConcessionsResponseData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EnergyConcessionsResponseData" /> class.
        /// </summary>
        /// <param name="concessions">Array may be empty if no concessions exist (required).</param>
        public EnergyConcessionsResponseData(List<EnergyConcession> concessions = default(List<EnergyConcession>))
        {
            // to ensure "concessions" is required (not null)
            this.Concessions = concessions ?? throw new ArgumentNullException("concessions is a required property for EnergyConcessionsResponseData and cannot be null");
        }

        /// <summary>
        /// Array may be empty if no concessions exist
        /// </summary>
        /// <value>Array may be empty if no concessions exist</value>
        [DataMember(Name = "concessions", IsRequired = true, EmitDefaultValue = false)]
        public List<EnergyConcession> Concessions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnergyConcessionsResponseData {\n");
            sb.Append("  Concessions: ").Append(Concessions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as EnergyConcessionsResponseData);
        }

        /// <summary>
        /// Returns true if EnergyConcessionsResponseData instances are equal
        /// </summary>
        /// <param name="input">Instance of EnergyConcessionsResponseData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EnergyConcessionsResponseData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Concessions == input.Concessions ||
                    this.Concessions != null &&
                    input.Concessions != null &&
                    this.Concessions.SequenceEqual(input.Concessions)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Concessions != null)
                    hashCode = hashCode * 59 + this.Concessions.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
