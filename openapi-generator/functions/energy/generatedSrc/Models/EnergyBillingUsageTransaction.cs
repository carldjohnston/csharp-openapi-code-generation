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
    /// EnergyBillingUsageTransaction
    /// </summary>
    [DataContract(Name = "EnergyBillingUsageTransaction")]
    public partial class EnergyBillingUsageTransaction : IEquatable<EnergyBillingUsageTransaction>, IValidatableObject
    {
        /// <summary>
        /// The time of use type that the transaction applies to
        /// </summary>
        /// <value>The time of use type that the transaction applies to</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TimeOfUseTypeEnum
        {
            /// <summary>
            /// Enum PEAK for value: PEAK
            /// </summary>
            [EnumMember(Value = "PEAK")]
            PEAK = 1,

            /// <summary>
            /// Enum OFFPEAK for value: OFF_PEAK
            /// </summary>
            [EnumMember(Value = "OFF_PEAK")]
            OFFPEAK = 2,

            /// <summary>
            /// Enum OFFPEAKDEMANDCHARGE for value: OFF_PEAK_DEMAND_CHARGE
            /// </summary>
            [EnumMember(Value = "OFF_PEAK_DEMAND_CHARGE")]
            OFFPEAKDEMANDCHARGE = 3,

            /// <summary>
            /// Enum SHOULDER for value: SHOULDER
            /// </summary>
            [EnumMember(Value = "SHOULDER")]
            SHOULDER = 4,

            /// <summary>
            /// Enum SHOULDER1 for value: SHOULDER1
            /// </summary>
            [EnumMember(Value = "SHOULDER1")]
            SHOULDER1 = 5,

            /// <summary>
            /// Enum SHOULDER2 for value: SHOULDER2
            /// </summary>
            [EnumMember(Value = "SHOULDER2")]
            SHOULDER2 = 6,

            /// <summary>
            /// Enum CONTROLLEDLOAD for value: CONTROLLED_LOAD
            /// </summary>
            [EnumMember(Value = "CONTROLLED_LOAD")]
            CONTROLLEDLOAD = 7,

            /// <summary>
            /// Enum SOLAR for value: SOLAR
            /// </summary>
            [EnumMember(Value = "SOLAR")]
            SOLAR = 8,

            /// <summary>
            /// Enum AGGREGATE for value: AGGREGATE
            /// </summary>
            [EnumMember(Value = "AGGREGATE")]
            AGGREGATE = 9

        }


        /// <summary>
        /// The time of use type that the transaction applies to
        /// </summary>
        /// <value>The time of use type that the transaction applies to</value>
        [DataMember(Name = "timeOfUseType", IsRequired = true, EmitDefaultValue = false)]
        public TimeOfUseTypeEnum TimeOfUseType { get; set; }
        /// <summary>
        /// The measurement unit of rate. Assumed to be KWH if absent
        /// </summary>
        /// <value>The measurement unit of rate. Assumed to be KWH if absent</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MeasureUnitEnum
        {
            /// <summary>
            /// Enum KWH for value: KWH
            /// </summary>
            [EnumMember(Value = "KWH")]
            KWH = 1,

            /// <summary>
            /// Enum KVA for value: KVA
            /// </summary>
            [EnumMember(Value = "KVA")]
            KVA = 2,

            /// <summary>
            /// Enum KVAR for value: KVAR
            /// </summary>
            [EnumMember(Value = "KVAR")]
            KVAR = 3,

            /// <summary>
            /// Enum KVARH for value: KVARH
            /// </summary>
            [EnumMember(Value = "KVARH")]
            KVARH = 4,

            /// <summary>
            /// Enum KW for value: KW
            /// </summary>
            [EnumMember(Value = "KW")]
            KW = 5,

            /// <summary>
            /// Enum DAYS for value: DAYS
            /// </summary>
            [EnumMember(Value = "DAYS")]
            DAYS = 6,

            /// <summary>
            /// Enum METER for value: METER
            /// </summary>
            [EnumMember(Value = "METER")]
            METER = 7,

            /// <summary>
            /// Enum MONTH for value: MONTH
            /// </summary>
            [EnumMember(Value = "MONTH")]
            MONTH = 8

        }


        /// <summary>
        /// The measurement unit of rate. Assumed to be KWH if absent
        /// </summary>
        /// <value>The measurement unit of rate. Assumed to be KWH if absent</value>
        [DataMember(Name = "measureUnit", EmitDefaultValue = false)]
        public MeasureUnitEnum? MeasureUnit { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="EnergyBillingUsageTransaction" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EnergyBillingUsageTransaction() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EnergyBillingUsageTransaction" /> class.
        /// </summary>
        /// <param name="servicePointId">The ID of the service point to which this transaction applies if any.</param>
        /// <param name="invoiceNumber">The number of the invoice in which this transaction is included if it has been issued.</param>
        /// <param name="timeOfUseType">The time of use type that the transaction applies to (required).</param>
        /// <param name="description">Optional description of the transaction that can be used for display purposes.</param>
        /// <param name="isEstimate">Flag indicating if the usage is estimated or actual.  True indicates estimate.  False or absent indicates actual.</param>
        /// <param name="startDate">Date and time when the usage period starts (required).</param>
        /// <param name="endDate">Date and time when the usage period ends (required).</param>
        /// <param name="measureUnit">The measurement unit of rate. Assumed to be KWH if absent.</param>
        /// <param name="usage">The usage for the period in measure unit.  A negative value indicates power generated (required).</param>
        /// <param name="amount">The amount charged or credited for this transaction prior to any adjustments being applied.  A negative value indicates a credit (required).</param>
        /// <param name="calculationFactors">Additional calculation factors that inform the transaction.</param>
        /// <param name="adjustments">Optional array of adjustments arising for this transaction.</param>
        public EnergyBillingUsageTransaction(string servicePointId = default(string), string invoiceNumber = default(string), TimeOfUseTypeEnum timeOfUseType = default(TimeOfUseTypeEnum), string description = default(string), bool isEstimate = default(bool), string startDate = default(string), string endDate = default(string), MeasureUnitEnum? measureUnit = default(MeasureUnitEnum?), decimal usage = default(decimal), string amount = default(string), List<EnergyBillingUsageTransactionCalculationFactors> calculationFactors = default(List<EnergyBillingUsageTransactionCalculationFactors>), List<EnergyBillingUsageTransactionAdjustments> adjustments = default(List<EnergyBillingUsageTransactionAdjustments>))
        {
            this.TimeOfUseType = timeOfUseType;
            // to ensure "startDate" is required (not null)
            this.StartDate = startDate ?? throw new ArgumentNullException("startDate is a required property for EnergyBillingUsageTransaction and cannot be null");
            // to ensure "endDate" is required (not null)
            this.EndDate = endDate ?? throw new ArgumentNullException("endDate is a required property for EnergyBillingUsageTransaction and cannot be null");
            this.Usage = usage;
            // to ensure "amount" is required (not null)
            this.Amount = amount ?? throw new ArgumentNullException("amount is a required property for EnergyBillingUsageTransaction and cannot be null");
            this.ServicePointId = servicePointId;
            this.InvoiceNumber = invoiceNumber;
            this.Description = description;
            this.IsEstimate = isEstimate;
            this.MeasureUnit = measureUnit;
            this.CalculationFactors = calculationFactors;
            this.Adjustments = adjustments;
        }

        /// <summary>
        /// The ID of the service point to which this transaction applies if any
        /// </summary>
        /// <value>The ID of the service point to which this transaction applies if any</value>
        [DataMember(Name = "servicePointId", EmitDefaultValue = false)]
        public string ServicePointId { get; set; }

        /// <summary>
        /// The number of the invoice in which this transaction is included if it has been issued
        /// </summary>
        /// <value>The number of the invoice in which this transaction is included if it has been issued</value>
        [DataMember(Name = "invoiceNumber", EmitDefaultValue = false)]
        public string InvoiceNumber { get; set; }

        /// <summary>
        /// Optional description of the transaction that can be used for display purposes
        /// </summary>
        /// <value>Optional description of the transaction that can be used for display purposes</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Flag indicating if the usage is estimated or actual.  True indicates estimate.  False or absent indicates actual
        /// </summary>
        /// <value>Flag indicating if the usage is estimated or actual.  True indicates estimate.  False or absent indicates actual</value>
        [DataMember(Name = "isEstimate", EmitDefaultValue = true)]
        public bool IsEstimate { get; set; }

        /// <summary>
        /// Date and time when the usage period starts
        /// </summary>
        /// <value>Date and time when the usage period starts</value>
        [DataMember(Name = "startDate", IsRequired = true, EmitDefaultValue = false)]
        public string StartDate { get; set; }

        /// <summary>
        /// Date and time when the usage period ends
        /// </summary>
        /// <value>Date and time when the usage period ends</value>
        [DataMember(Name = "endDate", IsRequired = true, EmitDefaultValue = false)]
        public string EndDate { get; set; }

        /// <summary>
        /// The usage for the period in measure unit.  A negative value indicates power generated
        /// </summary>
        /// <value>The usage for the period in measure unit.  A negative value indicates power generated</value>
        [DataMember(Name = "usage", IsRequired = true, EmitDefaultValue = false)]
        public decimal Usage { get; set; }

        /// <summary>
        /// The amount charged or credited for this transaction prior to any adjustments being applied.  A negative value indicates a credit
        /// </summary>
        /// <value>The amount charged or credited for this transaction prior to any adjustments being applied.  A negative value indicates a credit</value>
        [DataMember(Name = "amount", IsRequired = true, EmitDefaultValue = false)]
        public string Amount { get; set; }

        /// <summary>
        /// Additional calculation factors that inform the transaction
        /// </summary>
        /// <value>Additional calculation factors that inform the transaction</value>
        [DataMember(Name = "calculationFactors", EmitDefaultValue = false)]
        public List<EnergyBillingUsageTransactionCalculationFactors> CalculationFactors { get; set; }

        /// <summary>
        /// Optional array of adjustments arising for this transaction
        /// </summary>
        /// <value>Optional array of adjustments arising for this transaction</value>
        [DataMember(Name = "adjustments", EmitDefaultValue = false)]
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
            return this.Equals(input as EnergyBillingUsageTransaction);
        }

        /// <summary>
        /// Returns true if EnergyBillingUsageTransaction instances are equal
        /// </summary>
        /// <param name="input">Instance of EnergyBillingUsageTransaction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EnergyBillingUsageTransaction input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ServicePointId == input.ServicePointId ||
                    (this.ServicePointId != null &&
                    this.ServicePointId.Equals(input.ServicePointId))
                ) && 
                (
                    this.InvoiceNumber == input.InvoiceNumber ||
                    (this.InvoiceNumber != null &&
                    this.InvoiceNumber.Equals(input.InvoiceNumber))
                ) && 
                (
                    this.TimeOfUseType == input.TimeOfUseType ||
                    this.TimeOfUseType.Equals(input.TimeOfUseType)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.IsEstimate == input.IsEstimate ||
                    this.IsEstimate.Equals(input.IsEstimate)
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.MeasureUnit == input.MeasureUnit ||
                    this.MeasureUnit.Equals(input.MeasureUnit)
                ) && 
                (
                    this.Usage == input.Usage ||
                    this.Usage.Equals(input.Usage)
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.CalculationFactors == input.CalculationFactors ||
                    this.CalculationFactors != null &&
                    input.CalculationFactors != null &&
                    this.CalculationFactors.SequenceEqual(input.CalculationFactors)
                ) && 
                (
                    this.Adjustments == input.Adjustments ||
                    this.Adjustments != null &&
                    input.Adjustments != null &&
                    this.Adjustments.SequenceEqual(input.Adjustments)
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
                if (this.ServicePointId != null)
                    hashCode = hashCode * 59 + this.ServicePointId.GetHashCode();
                if (this.InvoiceNumber != null)
                    hashCode = hashCode * 59 + this.InvoiceNumber.GetHashCode();
                hashCode = hashCode * 59 + this.TimeOfUseType.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                hashCode = hashCode * 59 + this.IsEstimate.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                hashCode = hashCode * 59 + this.MeasureUnit.GetHashCode();
                hashCode = hashCode * 59 + this.Usage.GetHashCode();
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.CalculationFactors != null)
                    hashCode = hashCode * 59 + this.CalculationFactors.GetHashCode();
                if (this.Adjustments != null)
                    hashCode = hashCode * 59 + this.Adjustments.GetHashCode();
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
