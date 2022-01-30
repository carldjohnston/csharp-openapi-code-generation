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
    /// EnergyServicePointDetailMeters
    /// </summary>
    [DataContract(Name = "EnergyServicePointDetail_meters")]
    public partial class EnergyServicePointDetailMeters : IEquatable<EnergyServicePointDetailMeters>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EnergyServicePointDetailMeters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EnergyServicePointDetailMeters() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EnergyServicePointDetailMeters" /> class.
        /// </summary>
        /// <param name="meterId">The meter ID uniquely identifies a meter for a given service point.  It is unique in the context of the service point.  It is not globally unique (required).</param>
        /// <param name="specifications">specifications (required).</param>
        /// <param name="registers">registers (required).</param>
        public EnergyServicePointDetailMeters(string meterId = default(string), EnergyServicePointDetailMetersSpecifications specifications = default(EnergyServicePointDetailMetersSpecifications), EnergyServicePointDetailMetersRegisters registers = default(EnergyServicePointDetailMetersRegisters))
        {
            // to ensure "meterId" is required (not null)
            this.MeterId = meterId ?? throw new ArgumentNullException("meterId is a required property for EnergyServicePointDetailMeters and cannot be null");
            // to ensure "specifications" is required (not null)
            this.Specifications = specifications ?? throw new ArgumentNullException("specifications is a required property for EnergyServicePointDetailMeters and cannot be null");
            // to ensure "registers" is required (not null)
            this.Registers = registers ?? throw new ArgumentNullException("registers is a required property for EnergyServicePointDetailMeters and cannot be null");
        }

        /// <summary>
        /// The meter ID uniquely identifies a meter for a given service point.  It is unique in the context of the service point.  It is not globally unique
        /// </summary>
        /// <value>The meter ID uniquely identifies a meter for a given service point.  It is unique in the context of the service point.  It is not globally unique</value>
        [DataMember(Name = "meterId", IsRequired = true, EmitDefaultValue = false)]
        public string MeterId { get; set; }

        /// <summary>
        /// Gets or Sets Specifications
        /// </summary>
        [DataMember(Name = "specifications", IsRequired = true, EmitDefaultValue = false)]
        public EnergyServicePointDetailMetersSpecifications Specifications { get; set; }

        /// <summary>
        /// Gets or Sets Registers
        /// </summary>
        [DataMember(Name = "registers", IsRequired = true, EmitDefaultValue = false)]
        public EnergyServicePointDetailMetersRegisters Registers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnergyServicePointDetailMeters {\n");
            sb.Append("  MeterId: ").Append(MeterId).Append("\n");
            sb.Append("  Specifications: ").Append(Specifications).Append("\n");
            sb.Append("  Registers: ").Append(Registers).Append("\n");
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
            return this.Equals(input as EnergyServicePointDetailMeters);
        }

        /// <summary>
        /// Returns true if EnergyServicePointDetailMeters instances are equal
        /// </summary>
        /// <param name="input">Instance of EnergyServicePointDetailMeters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EnergyServicePointDetailMeters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MeterId == input.MeterId ||
                    (this.MeterId != null &&
                    this.MeterId.Equals(input.MeterId))
                ) && 
                (
                    this.Specifications == input.Specifications ||
                    (this.Specifications != null &&
                    this.Specifications.Equals(input.Specifications))
                ) && 
                (
                    this.Registers == input.Registers ||
                    (this.Registers != null &&
                    this.Registers.Equals(input.Registers))
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
                if (this.MeterId != null)
                    hashCode = hashCode * 59 + this.MeterId.GetHashCode();
                if (this.Specifications != null)
                    hashCode = hashCode * 59 + this.Specifications.GetHashCode();
                if (this.Registers != null)
                    hashCode = hashCode * 59 + this.Registers.GetHashCode();
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