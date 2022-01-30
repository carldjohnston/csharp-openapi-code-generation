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
    /// Describes intrinsic green power for the plan.  If present then the plan includes a percentage of green power in the base plan. Should not be present for gas contracts
    /// </summary>
    [DataContract(Name = "EnergyPlanContract_intrinsicGreenPower")]
    public partial class EnergyPlanContractIntrinsicGreenPower : IEquatable<EnergyPlanContractIntrinsicGreenPower>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EnergyPlanContractIntrinsicGreenPower" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EnergyPlanContractIntrinsicGreenPower() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EnergyPlanContractIntrinsicGreenPower" /> class.
        /// </summary>
        /// <param name="greenPercentage">Percentage of green power intrinsically included in the plan (required).</param>
        public EnergyPlanContractIntrinsicGreenPower(string greenPercentage = default(string))
        {
            // to ensure "greenPercentage" is required (not null)
            this.GreenPercentage = greenPercentage ?? throw new ArgumentNullException("greenPercentage is a required property for EnergyPlanContractIntrinsicGreenPower and cannot be null");
        }

        /// <summary>
        /// Percentage of green power intrinsically included in the plan
        /// </summary>
        /// <value>Percentage of green power intrinsically included in the plan</value>
        [DataMember(Name = "greenPercentage", IsRequired = true, EmitDefaultValue = false)]
        public string GreenPercentage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnergyPlanContractIntrinsicGreenPower {\n");
            sb.Append("  GreenPercentage: ").Append(GreenPercentage).Append("\n");
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
            return this.Equals(input as EnergyPlanContractIntrinsicGreenPower);
        }

        /// <summary>
        /// Returns true if EnergyPlanContractIntrinsicGreenPower instances are equal
        /// </summary>
        /// <param name="input">Instance of EnergyPlanContractIntrinsicGreenPower to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EnergyPlanContractIntrinsicGreenPower input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GreenPercentage == input.GreenPercentage ||
                    (this.GreenPercentage != null &&
                    this.GreenPercentage.Equals(input.GreenPercentage))
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
                if (this.GreenPercentage != null)
                    hashCode = hashCode * 59 + this.GreenPercentage.GetHashCode();
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