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
    /// Represents a manual payment schedule where the customer pays in response to a delivered statement. Mandatory if paymentScheduleUType is set to manualPayment
    /// </summary>
    [DataContract]
    public partial class EnergyPaymentScheduleManualPayment : IEquatable<EnergyPaymentScheduleManualPayment>
    {
        /// <summary>
        /// The frequency with which a bill will be issued.  Formatted according to [ISO 8601 Durations](https://en.wikipedia.org/wiki/ISO_8601#Durations) (excludes recurrence syntax)
        /// </summary>
        /// <value>The frequency with which a bill will be issued.  Formatted according to [ISO 8601 Durations](https://en.wikipedia.org/wiki/ISO_8601#Durations) (excludes recurrence syntax)</value>
        [Required]
        [DataMember(Name="billFrequency", EmitDefaultValue=false)]
        public string BillFrequency { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnergyPaymentScheduleManualPayment {\n");
            sb.Append("  BillFrequency: ").Append(BillFrequency).Append("\n");
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
            return obj.GetType() == GetType() && Equals((EnergyPaymentScheduleManualPayment)obj);
        }

        /// <summary>
        /// Returns true if EnergyPaymentScheduleManualPayment instances are equal
        /// </summary>
        /// <param name="other">Instance of EnergyPaymentScheduleManualPayment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EnergyPaymentScheduleManualPayment other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    BillFrequency == other.BillFrequency ||
                    BillFrequency != null &&
                    BillFrequency.Equals(other.BillFrequency)
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
                    if (BillFrequency != null)
                    hashCode = hashCode * 59 + BillFrequency.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(EnergyPaymentScheduleManualPayment left, EnergyPaymentScheduleManualPayment right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(EnergyPaymentScheduleManualPayment left, EnergyPaymentScheduleManualPayment right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}