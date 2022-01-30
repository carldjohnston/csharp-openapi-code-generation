/*
 * CDR Energy API
 *
 * Consumer Data Right end points and payloads for the Energy sector
 *
 * The version of the OpenAPI document: 1.15.0
 * 
 * Generated by: https://openapi-generator.tech
 */

using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Agl.Cdr.Energy.Converters;

namespace Agl.Cdr.Energy.Models
{ 
    /// <summary>
    /// Detail on the plan applicable to this account
    /// </summary>
    [DataContract]
    public partial class EnergyAccountDetailAllOfPlanDetail : IEquatable<EnergyAccountDetailAllOfPlanDetail>
    {

        /// <summary>
        /// The fuel types covered by the plan
        /// </summary>
        /// <value>The fuel types covered by the plan</value>
        [TypeConverter(typeof(CustomEnumConverter<FuelTypeEnum>))]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum FuelTypeEnum
        {
            
            /// <summary>
            /// Enum ELECTRICITYEnum for ELECTRICITY
            /// </summary>
            [EnumMember(Value = "ELECTRICITY")]
            ELECTRICITYEnum = 1,
            
            /// <summary>
            /// Enum GASEnum for GAS
            /// </summary>
            [EnumMember(Value = "GAS")]
            GASEnum = 2,
            
            /// <summary>
            /// Enum DUALEnum for DUAL
            /// </summary>
            [EnumMember(Value = "DUAL")]
            DUALEnum = 3
        }

        /// <summary>
        /// The fuel types covered by the plan
        /// </summary>
        /// <value>The fuel types covered by the plan</value>
        [Required]
        [DataMember(Name="fuelType", EmitDefaultValue=false)]
        public FuelTypeEnum FuelType { get; set; }

        /// <summary>
        /// Flag that indicates that the plan is contingent on the customer taking up an alternate fuel plan from the same retailer (for instance, if the fuelType is ELECTRICITY then a GAS plan from the same retailer must be taken up). Has no meaning if the plan has a fuelType of DUAL. If absent the value is assumed to be false
        /// </summary>
        /// <value>Flag that indicates that the plan is contingent on the customer taking up an alternate fuel plan from the same retailer (for instance, if the fuelType is ELECTRICITY then a GAS plan from the same retailer must be taken up). Has no meaning if the plan has a fuelType of DUAL. If absent the value is assumed to be false</value>
        [DataMember(Name="isContingentPlan", EmitDefaultValue=false)]
        public bool IsContingentPlan { get; set; } = false;

        /// <summary>
        /// Charges for metering included in the plan
        /// </summary>
        /// <value>Charges for metering included in the plan</value>
        [DataMember(Name="meteringCharges", EmitDefaultValue=false)]
        public List<EnergyPlanDetailAllOfMeteringCharges> MeteringCharges { get; set; }

        /// <summary>
        /// Gets or Sets GasContract
        /// </summary>
        [DataMember(Name="gasContract", EmitDefaultValue=false)]
        public EnergyPlanContract GasContract { get; set; }

        /// <summary>
        /// Gets or Sets ElectricityContract
        /// </summary>
        [DataMember(Name="electricityContract", EmitDefaultValue=false)]
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
        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((EnergyAccountDetailAllOfPlanDetail)obj);
        }

        /// <summary>
        /// Returns true if EnergyAccountDetailAllOfPlanDetail instances are equal
        /// </summary>
        /// <param name="other">Instance of EnergyAccountDetailAllOfPlanDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EnergyAccountDetailAllOfPlanDetail other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    FuelType == other.FuelType ||
                    
                    FuelType.Equals(other.FuelType)
                ) && 
                (
                    IsContingentPlan == other.IsContingentPlan ||
                    
                    IsContingentPlan.Equals(other.IsContingentPlan)
                ) && 
                (
                    MeteringCharges == other.MeteringCharges ||
                    MeteringCharges != null &&
                    other.MeteringCharges != null &&
                    MeteringCharges.SequenceEqual(other.MeteringCharges)
                ) && 
                (
                    GasContract == other.GasContract ||
                    GasContract != null &&
                    GasContract.Equals(other.GasContract)
                ) && 
                (
                    ElectricityContract == other.ElectricityContract ||
                    ElectricityContract != null &&
                    ElectricityContract.Equals(other.ElectricityContract)
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
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    
                    hashCode = hashCode * 59 + FuelType.GetHashCode();
                    
                    hashCode = hashCode * 59 + IsContingentPlan.GetHashCode();
                    if (MeteringCharges != null)
                    hashCode = hashCode * 59 + MeteringCharges.GetHashCode();
                    if (GasContract != null)
                    hashCode = hashCode * 59 + GasContract.GetHashCode();
                    if (ElectricityContract != null)
                    hashCode = hashCode * 59 + ElectricityContract.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(EnergyAccountDetailAllOfPlanDetail left, EnergyAccountDetailAllOfPlanDetail right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(EnergyAccountDetailAllOfPlanDetail left, EnergyAccountDetailAllOfPlanDetail right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}