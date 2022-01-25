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
    /// API call counts for the unauthenticated tier
    /// </summary>
    [DataContract]
    public partial class InvocationMetricsV2Unauthenticated : IEquatable<InvocationMetricsV2Unauthenticated>
    {
        /// <summary>
        /// API call counts for current day
        /// </summary>
        /// <value>API call counts for current day</value>
        [DataMember(Name="currentDay", EmitDefaultValue=false)]
        public decimal CurrentDay { get; set; }

        /// <summary>
        /// API call counts for previous days. The first element indicates yesterday and so on. A maximum of seven entries is required if available
        /// </summary>
        /// <value>API call counts for previous days. The first element indicates yesterday and so on. A maximum of seven entries is required if available</value>
        [DataMember(Name="previousDays", EmitDefaultValue=false)]
        public List<decimal> PreviousDays { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InvocationMetricsV2Unauthenticated {\n");
            sb.Append("  CurrentDay: ").Append(CurrentDay).Append("\n");
            sb.Append("  PreviousDays: ").Append(PreviousDays).Append("\n");
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
            return obj.GetType() == GetType() && Equals((InvocationMetricsV2Unauthenticated)obj);
        }

        /// <summary>
        /// Returns true if InvocationMetricsV2Unauthenticated instances are equal
        /// </summary>
        /// <param name="other">Instance of InvocationMetricsV2Unauthenticated to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InvocationMetricsV2Unauthenticated other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    CurrentDay == other.CurrentDay ||
                    
                    CurrentDay.Equals(other.CurrentDay)
                ) && 
                (
                    PreviousDays == other.PreviousDays ||
                    PreviousDays != null &&
                    other.PreviousDays != null &&
                    PreviousDays.SequenceEqual(other.PreviousDays)
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
                    
                    hashCode = hashCode * 59 + CurrentDay.GetHashCode();
                    if (PreviousDays != null)
                    hashCode = hashCode * 59 + PreviousDays.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(InvocationMetricsV2Unauthenticated left, InvocationMetricsV2Unauthenticated right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(InvocationMetricsV2Unauthenticated left, InvocationMetricsV2Unauthenticated right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
