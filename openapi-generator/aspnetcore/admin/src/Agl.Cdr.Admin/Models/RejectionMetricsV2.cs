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
    /// Number of calls rejected due to traffic thresholds over time
    /// </summary>
    [DataContract]
    public partial class RejectionMetricsV2 : IEquatable<RejectionMetricsV2>
    {
        /// <summary>
        /// Gets or Sets Authenticated
        /// </summary>
        [Required]
        [DataMember(Name="authenticated", EmitDefaultValue=false)]
        public RejectionMetricsV2Authenticated Authenticated { get; set; }

        /// <summary>
        /// Gets or Sets Unauthenticated
        /// </summary>
        [Required]
        [DataMember(Name="unauthenticated", EmitDefaultValue=false)]
        public RejectionMetricsV2Unauthenticated Unauthenticated { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RejectionMetricsV2 {\n");
            sb.Append("  Authenticated: ").Append(Authenticated).Append("\n");
            sb.Append("  Unauthenticated: ").Append(Unauthenticated).Append("\n");
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
            return obj.GetType() == GetType() && Equals((RejectionMetricsV2)obj);
        }

        /// <summary>
        /// Returns true if RejectionMetricsV2 instances are equal
        /// </summary>
        /// <param name="other">Instance of RejectionMetricsV2 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RejectionMetricsV2 other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Authenticated == other.Authenticated ||
                    Authenticated != null &&
                    Authenticated.Equals(other.Authenticated)
                ) && 
                (
                    Unauthenticated == other.Unauthenticated ||
                    Unauthenticated != null &&
                    Unauthenticated.Equals(other.Unauthenticated)
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
                    if (Authenticated != null)
                    hashCode = hashCode * 59 + Authenticated.GetHashCode();
                    if (Unauthenticated != null)
                    hashCode = hashCode * 59 + Unauthenticated.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(RejectionMetricsV2 left, RejectionMetricsV2 right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(RejectionMetricsV2 left, RejectionMetricsV2 right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}