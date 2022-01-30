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
    /// EnergyPlanDetailAllOf
    /// </summary>
    [DataContract(Name = "EnergyPlanDetail_allOf")]
    public partial class EnergyPlanDetailAllOf : IEquatable<EnergyPlanDetailAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EnergyPlanDetailAllOf" /> class.
        /// </summary>
        /// <param name="meteringCharges">Charges for metering included in the plan.</param>
        /// <param name="gasContract">gasContract.</param>
        /// <param name="electricityContract">electricityContract.</param>
        public EnergyPlanDetailAllOf(List<EnergyPlanDetailAllOfMeteringCharges> meteringCharges = default(List<EnergyPlanDetailAllOfMeteringCharges>), EnergyPlanContractFull gasContract = default(EnergyPlanContractFull), EnergyPlanContractFull electricityContract = default(EnergyPlanContractFull))
        {
            this.MeteringCharges = meteringCharges;
            this.GasContract = gasContract;
            this.ElectricityContract = electricityContract;
        }

        /// <summary>
        /// Charges for metering included in the plan
        /// </summary>
        /// <value>Charges for metering included in the plan</value>
        [DataMember(Name = "meteringCharges", EmitDefaultValue = false)]
        public List<EnergyPlanDetailAllOfMeteringCharges> MeteringCharges { get; set; }

        /// <summary>
        /// Gets or Sets GasContract
        /// </summary>
        [DataMember(Name = "gasContract", EmitDefaultValue = false)]
        public EnergyPlanContractFull GasContract { get; set; }

        /// <summary>
        /// Gets or Sets ElectricityContract
        /// </summary>
        [DataMember(Name = "electricityContract", EmitDefaultValue = false)]
        public EnergyPlanContractFull ElectricityContract { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnergyPlanDetailAllOf {\n");
            sb.Append("  MeteringCharges: ").Append(MeteringCharges).Append("\n");
            sb.Append("  GasContract: ").Append(GasContract).Append("\n");
            sb.Append("  ElectricityContract: ").Append(ElectricityContract).Append("\n");
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
            return this.Equals(input as EnergyPlanDetailAllOf);
        }

        /// <summary>
        /// Returns true if EnergyPlanDetailAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of EnergyPlanDetailAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EnergyPlanDetailAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MeteringCharges == input.MeteringCharges ||
                    this.MeteringCharges != null &&
                    input.MeteringCharges != null &&
                    this.MeteringCharges.SequenceEqual(input.MeteringCharges)
                ) && 
                (
                    this.GasContract == input.GasContract ||
                    (this.GasContract != null &&
                    this.GasContract.Equals(input.GasContract))
                ) && 
                (
                    this.ElectricityContract == input.ElectricityContract ||
                    (this.ElectricityContract != null &&
                    this.ElectricityContract.Equals(input.ElectricityContract))
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
                if (this.MeteringCharges != null)
                    hashCode = hashCode * 59 + this.MeteringCharges.GetHashCode();
                if (this.GasContract != null)
                    hashCode = hashCode * 59 + this.GasContract.GetHashCode();
                if (this.ElectricityContract != null)
                    hashCode = hashCode * 59 + this.ElectricityContract.GetHashCode();
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