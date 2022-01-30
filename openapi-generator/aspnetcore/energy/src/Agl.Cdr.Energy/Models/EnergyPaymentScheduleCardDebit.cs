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
    /// Represents a regular credit card payment schedule. Mandatory if paymentScheduleUType is set to cardDebit
    /// </summary>
    [DataContract]
    public partial class EnergyPaymentScheduleCardDebit : IEquatable<EnergyPaymentScheduleCardDebit>
    {

        /// <summary>
        /// The type of credit card held on file
        /// </summary>
        /// <value>The type of credit card held on file</value>
        [TypeConverter(typeof(CustomEnumConverter<CardSchemeEnum>))]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum CardSchemeEnum
        {
            
            /// <summary>
            /// Enum VISAEnum for VISA
            /// </summary>
            [EnumMember(Value = "VISA")]
            VISAEnum = 1,
            
            /// <summary>
            /// Enum MASTERCARDEnum for MASTERCARD
            /// </summary>
            [EnumMember(Value = "MASTERCARD")]
            MASTERCARDEnum = 2,
            
            /// <summary>
            /// Enum AMEXEnum for AMEX
            /// </summary>
            [EnumMember(Value = "AMEX")]
            AMEXEnum = 3,
            
            /// <summary>
            /// Enum DINERSEnum for DINERS
            /// </summary>
            [EnumMember(Value = "DINERS")]
            DINERSEnum = 4,
            
            /// <summary>
            /// Enum OTHEREnum for OTHER
            /// </summary>
            [EnumMember(Value = "OTHER")]
            OTHEREnum = 5,
            
            /// <summary>
            /// Enum UNKNOWNEnum for UNKNOWN
            /// </summary>
            [EnumMember(Value = "UNKNOWN")]
            UNKNOWNEnum = 6
        }

        /// <summary>
        /// The type of credit card held on file
        /// </summary>
        /// <value>The type of credit card held on file</value>
        [Required]
        [DataMember(Name="cardScheme", EmitDefaultValue=false)]
        public CardSchemeEnum CardScheme { get; set; }

        /// <summary>
        /// The frequency that payments will occur.  Formatted according to [ISO 8601 Durations](https://en.wikipedia.org/wiki/ISO_8601#Durations) (excludes recurrence syntax)
        /// </summary>
        /// <value>The frequency that payments will occur.  Formatted according to [ISO 8601 Durations](https://en.wikipedia.org/wiki/ISO_8601#Durations) (excludes recurrence syntax)</value>
        [Required]
        [DataMember(Name="paymentFrequency", EmitDefaultValue=false)]
        public string PaymentFrequency { get; set; }


        /// <summary>
        /// The mechanism by which the payment amount is calculated.  Explanation of values are as follows:<br/><ul><li>**STATIC** - Indicates a consistent, static amount, per payment</li><li>**BALANCE** - Indicates that the outstanding balance for the account is paid per period</li><li>**CALCULATED** - Indicates that the payment amount is variable and calculated using a pre-defined algorithm</li></ul>
        /// </summary>
        /// <value>The mechanism by which the payment amount is calculated.  Explanation of values are as follows:<br/><ul><li>**STATIC** - Indicates a consistent, static amount, per payment</li><li>**BALANCE** - Indicates that the outstanding balance for the account is paid per period</li><li>**CALCULATED** - Indicates that the payment amount is variable and calculated using a pre-defined algorithm</li></ul></value>
        [TypeConverter(typeof(CustomEnumConverter<CalculationTypeEnum>))]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum CalculationTypeEnum
        {
            
            /// <summary>
            /// Enum STATICEnum for STATIC
            /// </summary>
            [EnumMember(Value = "STATIC")]
            STATICEnum = 1,
            
            /// <summary>
            /// Enum BALANCEEnum for BALANCE
            /// </summary>
            [EnumMember(Value = "BALANCE")]
            BALANCEEnum = 2,
            
            /// <summary>
            /// Enum CALCULATEDEnum for CALCULATED
            /// </summary>
            [EnumMember(Value = "CALCULATED")]
            CALCULATEDEnum = 3
        }

        /// <summary>
        /// The mechanism by which the payment amount is calculated.  Explanation of values are as follows:&lt;br/&gt;&lt;ul&gt;&lt;li&gt;**STATIC** - Indicates a consistent, static amount, per payment&lt;/li&gt;&lt;li&gt;**BALANCE** - Indicates that the outstanding balance for the account is paid per period&lt;/li&gt;&lt;li&gt;**CALCULATED** - Indicates that the payment amount is variable and calculated using a pre-defined algorithm&lt;/li&gt;&lt;/ul&gt;
        /// </summary>
        /// <value>The mechanism by which the payment amount is calculated.  Explanation of values are as follows:&lt;br/&gt;&lt;ul&gt;&lt;li&gt;**STATIC** - Indicates a consistent, static amount, per payment&lt;/li&gt;&lt;li&gt;**BALANCE** - Indicates that the outstanding balance for the account is paid per period&lt;/li&gt;&lt;li&gt;**CALCULATED** - Indicates that the payment amount is variable and calculated using a pre-defined algorithm&lt;/li&gt;&lt;/ul&gt;</value>
        [Required]
        [DataMember(Name="calculationType", EmitDefaultValue=false)]
        public CalculationTypeEnum CalculationType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnergyPaymentScheduleCardDebit {\n");
            sb.Append("  CardScheme: ").Append(CardScheme).Append("\n");
            sb.Append("  PaymentFrequency: ").Append(PaymentFrequency).Append("\n");
            sb.Append("  CalculationType: ").Append(CalculationType).Append("\n");
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
            return obj.GetType() == GetType() && Equals((EnergyPaymentScheduleCardDebit)obj);
        }

        /// <summary>
        /// Returns true if EnergyPaymentScheduleCardDebit instances are equal
        /// </summary>
        /// <param name="other">Instance of EnergyPaymentScheduleCardDebit to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EnergyPaymentScheduleCardDebit other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    CardScheme == other.CardScheme ||
                    
                    CardScheme.Equals(other.CardScheme)
                ) && 
                (
                    PaymentFrequency == other.PaymentFrequency ||
                    PaymentFrequency != null &&
                    PaymentFrequency.Equals(other.PaymentFrequency)
                ) && 
                (
                    CalculationType == other.CalculationType ||
                    
                    CalculationType.Equals(other.CalculationType)
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
                    
                    hashCode = hashCode * 59 + CardScheme.GetHashCode();
                    if (PaymentFrequency != null)
                    hashCode = hashCode * 59 + PaymentFrequency.GetHashCode();
                    
                    hashCode = hashCode * 59 + CalculationType.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(EnergyPaymentScheduleCardDebit left, EnergyPaymentScheduleCardDebit right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(EnergyPaymentScheduleCardDebit left, EnergyPaymentScheduleCardDebit right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}