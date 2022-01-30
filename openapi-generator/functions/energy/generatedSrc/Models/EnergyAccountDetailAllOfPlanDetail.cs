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
    /// Detail on the plan applicable to this account
    /// </summary>
    [DataContract(Name = "EnergyAccountDetail_allOf_planDetail")]
    public partial class EnergyAccountDetailAllOfPlanDetail : IEquatable<EnergyAccountDetailAllOfPlanDetail>, IValidatableObject
    {
        /// <summary>
        /// The fuel types covered by the plan
        /// </summary>
        /// <value>The fuel types covered by the plan</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FuelTypeEnum
        {
            /// <summary>
            /// Enum ELECTRICITY for value: ELECTRICITY
            /// </summary>
            [EnumMember(Value = "ELECTRICITY")]
            ELECTRICITY = 1,

            /// <summary>
            /// Enum GAS for value: GAS
            /// </summary>
            [EnumMember(Value = "GAS")]
            GAS = 2,

            /// <summary>
            /// Enum DUAL for value: DUAL
            /// </summary>
            [EnumMember(Value = "DUAL")]
            DUAL = 3

        }


        /// <summary>
        /// The fuel types covered by the plan
        /// </summary>
        /// <value>The fuel types covered by the plan</value>
        [DataMember(Name = "fuelType", IsRequired = true, EmitDefaultValue = false)]
        public FuelTypeEnum FuelType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="EnergyAccountDetailAllOfPlanDetail" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EnergyAccountDetailAllOfPlanDetail() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EnergyAccountDetailAllOfPlanDetail" /> class.
        /// </summary>
        /// <param name="fuelType">The fuel types covered by the plan (required).</param>
        /// <param name="isContingentPlan">Flag that indicates that the plan is contingent on the customer taking up an alternate fuel plan from the same retailer (for instance, if the fuelType is ELECTRICITY then a GAS plan from the same retailer must be taken up). Has no meaning if the plan has a fuelType of DUAL. If absent the value is assumed to be false (default to false).</param>
        /// <param name="meteringCharges">Charges for metering included in the plan.</param>
        /// <param name="gasContract">gasContract.</param>
        /// <param name="electricityContract">electricityContract.</param>
        public EnergyAccountDetailAllOfPlanDetail(FuelTypeEnum fuelType = default(FuelTypeEnum), bool isContingentPlan = false, List<EnergyPlanDetailAllOfMeteringCharges> meteringCharges = default(List<EnergyPlanDetailAllOfMeteringCharges>), EnergyPlanContract gasContract = default(EnergyPlanContract), EnergyPlanContract electricityContract = default(EnergyPlanContract))
        {
            this.FuelType = fuelType;
            this.IsContingentPlan = isContingentPlan;
            this.MeteringCharges = meteringCharges;
            this.GasContract = gasContract;
            this.ElectricityContract = electricityContract;
        }

        /// <summary>
        /// Flag that indicates that the plan is contingent on the customer taking up an alternate fuel plan from the same retailer (for instance, if the fuelType is ELECTRICITY then a GAS plan from the same retailer must be taken up). Has no meaning if the plan has a fuelType of DUAL. If absent the value is assumed to be false
        /// </summary>
        /// <value>Flag that indicates that the plan is contingent on the customer taking up an alternate fuel plan from the same retailer (for instance, if the fuelType is ELECTRICITY then a GAS plan from the same retailer must be taken up). Has no meaning if the plan has a fuelType of DUAL. If absent the value is assumed to be false</value>
        [DataMember(Name = "isContingentPlan", EmitDefaultValue = true)]
        public bool IsContingentPlan { get; set; }

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
        public EnergyPlanContract GasContract { get; set; }

        /// <summary>
        /// Gets or Sets ElectricityContract
        /// </summary>
        [DataMember(Name = "electricityContract", EmitDefaultValue = false)]
        public EnergyPlanContract ElectricityContract { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnergyAccountDetailAllOfPlanDetail {\n");
            sb.Append("  FuelType: ").Append(FuelType).Append("\n");
            sb.Append("  IsContingentPlan: ").Append(IsContingentPlan).Append("\n");
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
            return this.Equals(input as EnergyAccountDetailAllOfPlanDetail);
        }

        /// <summary>
        /// Returns true if EnergyAccountDetailAllOfPlanDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of EnergyAccountDetailAllOfPlanDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EnergyAccountDetailAllOfPlanDetail input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FuelType == input.FuelType ||
                    this.FuelType.Equals(input.FuelType)
                ) && 
                (
                    this.IsContingentPlan == input.IsContingentPlan ||
                    this.IsContingentPlan.Equals(input.IsContingentPlan)
                ) && 
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
                hashCode = hashCode * 59 + this.FuelType.GetHashCode();
                hashCode = hashCode * 59 + this.IsContingentPlan.GetHashCode();
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