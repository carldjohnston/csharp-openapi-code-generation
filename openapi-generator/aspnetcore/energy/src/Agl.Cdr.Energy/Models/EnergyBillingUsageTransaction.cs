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
    /// 
    /// </summary>
    [DataContract]
    public partial class EnergyBillingUsageTransaction : IEquatable<EnergyBillingUsageTransaction>
    {
        /// <summary>
        /// The ID of the service point to which this transaction applies if any
        /// </summary>
        /// <value>The ID of the service point to which this transaction applies if any</value>
        [DataMember(Name="servicePointId", EmitDefaultValue=false)]
        public string ServicePointId { get; set; }

        /// <summary>
        /// The number of the invoice in which this transaction is included if it has been issued
        /// </summary>
        /// <value>The number of the invoice in which this transaction is included if it has been issued</value>
        [DataMember(Name="invoiceNumber", EmitDefaultValue=false)]
        public string InvoiceNumber { get; set; }


        /// <summary>
        /// The time of use type that the transaction applies to
        /// </summary>
        /// <value>The time of use type that the transaction applies to</value>
        [TypeConverter(typeof(CustomEnumConverter<TimeOfUseTypeEnum>))]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum TimeOfUseTypeEnum
        {
            
            /// <summary>
            /// Enum PEAKEnum for PEAK
            /// </summary>
            [EnumMember(Value = "PEAK")]
            PEAKEnum = 1,
            
            /// <summary>
            /// Enum OFFPEAKEnum for OFF_PEAK
            /// </summary>
            [EnumMember(Value = "OFF_PEAK")]
            OFFPEAKEnum = 2,
            
            /// <summary>
            /// Enum OFFPEAKDEMANDCHARGEEnum for OFF_PEAK_DEMAND_CHARGE
            /// </summary>
            [EnumMember(Value = "OFF_PEAK_DEMAND_CHARGE")]
            OFFPEAKDEMANDCHARGEEnum = 3,
            
            /// <summary>
            /// Enum SHOULDEREnum for SHOULDER
            /// </summary>
            [EnumMember(Value = "SHOULDER")]
            SHOULDEREnum = 4,
            
            /// <summary>
            /// Enum SHOULDER1Enum for SHOULDER1
            /// </summary>
            [EnumMember(Value = "SHOULDER1")]
            SHOULDER1Enum = 5,
            
            /// <summary>
            /// Enum SHOULDER2Enum for SHOULDER2
            /// </summary>
            [EnumMember(Value = "SHOULDER2")]
            SHOULDER2Enum = 6,
            
            /// <summary>
            /// Enum CONTROLLEDLOADEnum for CONTROLLED_LOAD
            /// </summary>
            [EnumMember(Value = "CONTROLLED_LOAD")]
            CONTROLLEDLOADEnum = 7,
            
            /// <summary>
            /// Enum SOLAREnum for SOLAR
            /// </summary>
            [EnumMember(Value = "SOLAR")]
            SOLAREnum = 8,
            
            /// <summary>
            /// Enum AGGREGATEEnum for AGGREGATE
            /// </summary>
            [EnumMember(Value = "AGGREGATE")]
            AGGREGATEEnum = 9
        }

        /// <summary>
        /// The time of use type that the transaction applies to
        /// </summary>
        /// <value>The time of use type that the transaction applies to</value>
        [Required]
        [DataMember(Name="timeOfUseType", EmitDefaultValue=false)]
        public TimeOfUseTypeEnum TimeOfUseType { get; set; }

        /// <summary>
        /// Optional description of the transaction that can be used for display purposes
        /// </summary>
        /// <value>Optional description of the transaction that can be used for display purposes</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Flag indicating if the usage is estimated or actual.  True indicates estimate.  False or absent indicates actual
        /// </summary>
        /// <value>Flag indicating if the usage is estimated or actual.  True indicates estimate.  False or absent indicates actual</value>
        [DataMember(Name="isEstimate", EmitDefaultValue=false)]
        public bool IsEstimate { get; set; }

        /// <summary>
        /// Date and time when the usage period starts
        /// </summary>
        /// <value>Date and time when the usage period starts</value>
        [Required]
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public string StartDate { get; set; }

        /// <summary>
        /// Date and time when the usage period ends
        /// </summary>
        /// <value>Date and time when the usage period ends</value>
        [Required]
        [DataMember(Name="endDate", EmitDefaultValue=false)]
        public string EndDate { get; set; }


        /// <summary>
        /// The measurement unit of rate. Assumed to be KWH if absent
        /// </summary>
        /// <value>The measurement unit of rate. Assumed to be KWH if absent</value>
        [TypeConverter(typeof(CustomEnumConverter<MeasureUnitEnum>))]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum MeasureUnitEnum
        {
            
            /// <summary>
            /// Enum KWHEnum for KWH
            /// </summary>
            [EnumMember(Value = "KWH")]
            KWHEnum = 1,
            
            /// <summary>
            /// Enum KVAEnum for KVA
            /// </summary>
            [EnumMember(Value = "KVA")]
            KVAEnum = 2,
            
            /// <summary>
            /// Enum KVAREnum for KVAR
            /// </summary>
            [EnumMember(Value = "KVAR")]
            KVAREnum = 3,
            
            /// <summary>
            /// Enum KVARHEnum for KVARH
            /// </summary>
            [EnumMember(Value = "KVARH")]
            KVARHEnum = 4,
            
            /// <summary>
            /// Enum KWEnum for KW
            /// </summary>
            [EnumMember(Value = "KW")]
            KWEnum = 5,
            
            /// <summary>
            /// Enum DAYSEnum for DAYS
            /// </summary>
            [EnumMember(Value = "DAYS")]
            DAYSEnum = 6,
            
            /// <summary>
            /// Enum METEREnum for METER
            /// </summary>
            [EnumMember(Value = "METER")]
            METEREnum = 7,
            
            /// <summary>
            /// Enum MONTHEnum for MONTH
            /// </summary>
            [EnumMember(Value = "MONTH")]
            MONTHEnum = 8
        }

        /// <summary>
        /// The measurement unit of rate. Assumed to be KWH if absent
        /// </summary>
        /// <value>The measurement unit of rate. Assumed to be KWH if absent</value>
        [DataMember(Name="measureUnit", EmitDefaultValue=false)]
        public MeasureUnitEnum MeasureUnit { get; set; }

        /// <summary>
        /// The usage for the period in measure unit.  A negative value indicates power generated
        /// </summary>
        /// <value>The usage for the period in measure unit.  A negative value indicates power generated</value>
        [Required]
        [DataMember(Name="usage", EmitDefaultValue=false)]
        public decimal Usage { get; set; }

        /// <summary>
        /// The amount charged or credited for this transaction prior to any adjustments being applied.  A negative value indicates a credit
        /// </summary>
        /// <value>The amount charged or credited for this transaction prior to any adjustments being applied.  A negative value indicates a credit</value>
        [Required]
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public string Amount { get; set; }

        /// <summary>
        /// Additional calculation factors that inform the transaction
        /// </summary>
        /// <value>Additional calculation factors that inform the transaction</value>
        [DataMember(Name="calculationFactors", EmitDefaultValue=false)]
        public List<EnergyBillingUsageTransactionCalculationFactors> CalculationFactors { get; set; }

        /// <summary>
        /// Optional array of adjustments arising for this transaction
        /// </summary>
        /// <value>Optional array of adjustments arising for this transaction</value>
        [DataMember(Name="adjustments", EmitDefaultValue=false)]
        public List<EnergyBillingUsageTransactionAdjustments> Adjustments { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnergyBillingUsageTransaction {\n");
            sb.Append("  ServicePointId: ").Append(ServicePointId).Append("\n");
            sb.Append("  InvoiceNumber: ").Append(InvoiceNumber).Append("\n");
            sb.Append("  TimeOfUseType: ").Append(TimeOfUseType).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  IsEstimate: ").Append(IsEstimate).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  MeasureUnit: ").Append(MeasureUnit).Append("\n");
            sb.Append("  Usage: ").Append(Usage).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  CalculationFactors: ").Append(CalculationFactors).Append("\n");
            sb.Append("  Adjustments: ").Append(Adjustments).Append("\n");
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
            return obj.GetType() == GetType() && Equals((EnergyBillingUsageTransaction)obj);
        }

        /// <summary>
        /// Returns true if EnergyBillingUsageTransaction instances are equal
        /// </summary>
        /// <param name="other">Instance of EnergyBillingUsageTransaction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EnergyBillingUsageTransaction other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    ServicePointId == other.ServicePointId ||
                    ServicePointId != null &&
                    ServicePointId.Equals(other.ServicePointId)
                ) && 
                (
                    InvoiceNumber == other.InvoiceNumber ||
                    InvoiceNumber != null &&
                    InvoiceNumber.Equals(other.InvoiceNumber)
                ) && 
                (
                    TimeOfUseType == other.TimeOfUseType ||
                    
                    TimeOfUseType.Equals(other.TimeOfUseType)
                ) && 
                (
                    Description == other.Description ||
                    Description != null &&
                    Description.Equals(other.Description)
                ) && 
                (
                    IsEstimate == other.IsEstimate ||
                    
                    IsEstimate.Equals(other.IsEstimate)
                ) && 
                (
                    StartDate == other.StartDate ||
                    StartDate != null &&
                    StartDate.Equals(other.StartDate)
                ) && 
                (
                    EndDate == other.EndDate ||
                    EndDate != null &&
                    EndDate.Equals(other.EndDate)
                ) && 
                (
                    MeasureUnit == other.MeasureUnit ||
                    
                    MeasureUnit.Equals(other.MeasureUnit)
                ) && 
                (
                    Usage == other.Usage ||
                    
                    Usage.Equals(other.Usage)
                ) && 
                (
                    Amount == other.Amount ||
                    Amount != null &&
                    Amount.Equals(other.Amount)
                ) && 
                (
                    CalculationFactors == other.CalculationFactors ||
                    CalculationFactors != null &&
                    other.CalculationFactors != null &&
                    CalculationFactors.SequenceEqual(other.CalculationFactors)
                ) && 
                (
                    Adjustments == other.Adjustments ||
                    Adjustments != null &&
                    other.Adjustments != null &&
                    Adjustments.SequenceEqual(other.Adjustments)
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
                    if (ServicePointId != null)
                    hashCode = hashCode * 59 + ServicePointId.GetHashCode();
                    if (InvoiceNumber != null)
                    hashCode = hashCode * 59 + InvoiceNumber.GetHashCode();
                    
                    hashCode = hashCode * 59 + TimeOfUseType.GetHashCode();
                    if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                    
                    hashCode = hashCode * 59 + IsEstimate.GetHashCode();
                    if (StartDate != null)
                    hashCode = hashCode * 59 + StartDate.GetHashCode();
                    if (EndDate != null)
                    hashCode = hashCode * 59 + EndDate.GetHashCode();
                    
                    hashCode = hashCode * 59 + MeasureUnit.GetHashCode();
                    
                    hashCode = hashCode * 59 + Usage.GetHashCode();
                    if (Amount != null)
                    hashCode = hashCode * 59 + Amount.GetHashCode();
                    if (CalculationFactors != null)
                    hashCode = hashCode * 59 + CalculationFactors.GetHashCode();
                    if (Adjustments != null)
                    hashCode = hashCode * 59 + Adjustments.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(EnergyBillingUsageTransaction left, EnergyBillingUsageTransaction right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(EnergyBillingUsageTransaction left, EnergyBillingUsageTransaction right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
