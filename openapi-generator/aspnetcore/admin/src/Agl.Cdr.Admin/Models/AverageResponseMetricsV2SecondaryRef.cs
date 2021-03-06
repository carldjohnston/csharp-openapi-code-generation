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
    /// Average response time for the secondary tier.  Mandatory for data holders designated for a Shared Responsibility Data Request data cluster
    /// </summary>
    [DataContract]
    public partial class AverageResponseMetricsV2SecondaryRef : IEquatable<AverageResponseMetricsV2SecondaryRef>
    {
        /// <summary>
        /// Gets or Sets Primary
        /// </summary>
        [Required]
        [DataMember(Name="primary", EmitDefaultValue=false)]
        public AverageResponseMetricsV2SecondaryPrimary Primary { get; set; }

        /// <summary>
        /// Gets or Sets Secondary
        /// </summary>
        [Required]
        [DataMember(Name="secondary", EmitDefaultValue=false)]
        public AverageResponseMetricsV2SecondarySecondary Secondary { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AverageResponseMetricsV2SecondaryRef {\n");
            sb.Append("  Primary: ").Append(Primary).Append("\n");
            sb.Append("  Secondary: ").Append(Secondary).Append("\n");
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
            return obj.GetType() == GetType() && Equals((AverageResponseMetricsV2SecondaryRef)obj);
        }

        /// <summary>
        /// Returns true if AverageResponseMetricsV2SecondaryRef instances are equal
        /// </summary>
        /// <param name="other">Instance of AverageResponseMetricsV2SecondaryRef to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AverageResponseMetricsV2SecondaryRef other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Primary == other.Primary ||
                    Primary != null &&
                    Primary.Equals(other.Primary)
                ) && 
                (
                    Secondary == other.Secondary ||
                    Secondary != null &&
                    Secondary.Equals(other.Secondary)
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
                    if (Primary != null)
                    hashCode = hashCode * 59 + Primary.GetHashCode();
                    if (Secondary != null)
                    hashCode = hashCode * 59 + Secondary.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(AverageResponseMetricsV2SecondaryRef left, AverageResponseMetricsV2SecondaryRef right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(AverageResponseMetricsV2SecondaryRef left, AverageResponseMetricsV2SecondaryRef right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
