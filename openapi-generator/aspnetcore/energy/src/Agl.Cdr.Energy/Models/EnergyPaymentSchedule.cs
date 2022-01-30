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
    public partial class EnergyPaymentSchedule : IEquatable<EnergyPaymentSchedule>
    {
        /// <summary>
        /// Optional payment amount indicating that a constant payment amount is scheduled to be paid (used in bill smooting scenarios)
        /// </summary>
        /// <value>Optional payment amount indicating that a constant payment amount is scheduled to be paid (used in bill smooting scenarios)</value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public string Amount { get; set; }


        /// <summary>
        /// The type of object present in this response
        /// </summary>
        /// <value>The type of object present in this response</value>
        [TypeConverter(typeof(CustomEnumConverter<PaymentScheduleUTypeEnum>))]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum PaymentScheduleUTypeEnum
        {
            
            /// <summary>
            /// Enum CardDebitEnum for cardDebit
            /// </summary>
            [EnumMember(Value = "cardDebit")]
            CardDebitEnum = 1,
            
            /// <summary>
            /// Enum DirectDebitEnum for directDebit
            /// </summary>
            [EnumMember(Value = "directDebit")]
            DirectDebitEnum = 2,
            
            /// <summary>
            /// Enum ManualPaymentEnum for manualPayment
            /// </summary>
            [EnumMember(Value = "manualPayment")]
            ManualPaymentEnum = 3
        }

        /// <summary>
        /// The type of object present in this response
        /// </summary>
        /// <value>The type of object present in this response</value>
        [Required]
        [DataMember(Name="paymentScheduleUType", EmitDefaultValue=false)]
        public PaymentScheduleUTypeEnum PaymentScheduleUType { get; set; }

        /// <summary>
        /// Gets or Sets CardDebit
        /// </summary>
        [DataMember(Name="cardDebit", EmitDefaultValue=false)]
        public EnergyPaymentScheduleCardDebit CardDebit { get; set; }

        /// <summary>
        /// Gets or Sets DirectDebit
        /// </summary>
        [DataMember(Name="directDebit", EmitDefaultValue=false)]
        public EnergyPaymentScheduleDirectDebit DirectDebit { get; set; }

        /// <summary>
        /// Gets or Sets ManualPayment
        /// </summary>
        [DataMember(Name="manualPayment", EmitDefaultValue=false)]
        public EnergyPaymentScheduleManualPayment ManualPayment { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnergyPaymentSchedule {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  PaymentScheduleUType: ").Append(PaymentScheduleUType).Append("\n");
            sb.Append("  CardDebit: ").Append(CardDebit).Append("\n");
            sb.Append("  DirectDebit: ").Append(DirectDebit).Append("\n");
            sb.Append("  ManualPayment: ").Append(ManualPayment).Append("\n");
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
            return obj.GetType() == GetType() && Equals((EnergyPaymentSchedule)obj);
        }

        /// <summary>
        /// Returns true if EnergyPaymentSchedule instances are equal
        /// </summary>
        /// <param name="other">Instance of EnergyPaymentSchedule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EnergyPaymentSchedule other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Amount == other.Amount ||
                    Amount != null &&
                    Amount.Equals(other.Amount)
                ) && 
                (
                    PaymentScheduleUType == other.PaymentScheduleUType ||
                    
                    PaymentScheduleUType.Equals(other.PaymentScheduleUType)
                ) && 
                (
                    CardDebit == other.CardDebit ||
                    CardDebit != null &&
                    CardDebit.Equals(other.CardDebit)
                ) && 
                (
                    DirectDebit == other.DirectDebit ||
                    DirectDebit != null &&
                    DirectDebit.Equals(other.DirectDebit)
                ) && 
                (
                    ManualPayment == other.ManualPayment ||
                    ManualPayment != null &&
                    ManualPayment.Equals(other.ManualPayment)
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
                    if (Amount != null)
                    hashCode = hashCode * 59 + Amount.GetHashCode();
                    
                    hashCode = hashCode * 59 + PaymentScheduleUType.GetHashCode();
                    if (CardDebit != null)
                    hashCode = hashCode * 59 + CardDebit.GetHashCode();
                    if (DirectDebit != null)
                    hashCode = hashCode * 59 + DirectDebit.GetHashCode();
                    if (ManualPayment != null)
                    hashCode = hashCode * 59 + ManualPayment.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(EnergyPaymentSchedule left, EnergyPaymentSchedule right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(EnergyPaymentSchedule left, EnergyPaymentSchedule right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}