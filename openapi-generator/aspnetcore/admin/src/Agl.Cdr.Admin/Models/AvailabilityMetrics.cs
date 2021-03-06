/*
 * CDR Admin API
 *
 * Data Holder Consumer Data Standards Administration End Points created by the Data Standards Body (DSB), with the Data Standards Chair as the decision maker
 *
 * The version of the OpenAPI document: 1.15.0
 * Contact: contact@consumerdatastandards.gov.au
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
using Agl.Cdr.Admin.Converters;

namespace Agl.Cdr.Admin.Models
{ 
    /// <summary>
    /// Percentage availability of the CDR platform over time
    /// </summary>
    [DataContract]
    public partial class AvailabilityMetrics : IEquatable<AvailabilityMetrics>
    {
        /// <summary>
        /// Percentage availability of the CDR platform so far for the current calendar month. 0.0 means 0%. 1.0 means 100%.
        /// </summary>
        /// <value>Percentage availability of the CDR platform so far for the current calendar month. 0.0 means 0%. 1.0 means 100%.</value>
        [DataMember(Name="currentMonth", EmitDefaultValue=false)]
        public decimal CurrentMonth { get; set; }

        /// <summary>
        /// Percentage availability of the CDR platform for previous calendar months. The first element indicates the last month and so on. A maximum of twelve entries is required if available. 0.0 means 0%. 1.0 means 100%.
        /// </summary>
        /// <value>Percentage availability of the CDR platform for previous calendar months. The first element indicates the last month and so on. A maximum of twelve entries is required if available. 0.0 means 0%. 1.0 means 100%.</value>
        [DataMember(Name="previousMonths", EmitDefaultValue=false)]
        public List<decimal> PreviousMonths { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AvailabilityMetrics {\n");
            sb.Append("  CurrentMonth: ").Append(CurrentMonth).Append("\n");
            sb.Append("  PreviousMonths: ").Append(PreviousMonths).Append("\n");
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
            return obj.GetType() == GetType() && Equals((AvailabilityMetrics)obj);
        }

        /// <summary>
        /// Returns true if AvailabilityMetrics instances are equal
        /// </summary>
        /// <param name="other">Instance of AvailabilityMetrics to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AvailabilityMetrics other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    CurrentMonth == other.CurrentMonth ||
                    
                    CurrentMonth.Equals(other.CurrentMonth)
                ) && 
                (
                    PreviousMonths == other.PreviousMonths ||
                    PreviousMonths != null &&
                    other.PreviousMonths != null &&
                    PreviousMonths.SequenceEqual(other.PreviousMonths)
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
                    
                    hashCode = hashCode * 59 + CurrentMonth.GetHashCode();
                    if (PreviousMonths != null)
                    hashCode = hashCode * 59 + PreviousMonths.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(AvailabilityMetrics left, AvailabilityMetrics right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(AvailabilityMetrics left, AvailabilityMetrics right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
