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
    /// Describes the geographical area that the plan is available for.  If absent then it is assumed the plan is not geographically limited
    /// </summary>
    [DataContract]
    public partial class EnergyPlanGeography : IEquatable<EnergyPlanGeography>
    {
        /// <summary>
        /// Array of valid Australian post codes that are specifically excluded from the plan.  Each element is a single four digit postcode (e.g. 3000) or a range of postcodes defined by two four digit postcodes and a hyphen (e.g. 3000-3999)
        /// </summary>
        /// <value>Array of valid Australian post codes that are specifically excluded from the plan.  Each element is a single four digit postcode (e.g. 3000) or a range of postcodes defined by two four digit postcodes and a hyphen (e.g. 3000-3999)</value>
        [DataMember(Name="excludedPostcodes", EmitDefaultValue=false)]
        public List<string> ExcludedPostcodes { get; set; }

        /// <summary>
        /// Array of valid Australian post codes that are included from the plan.  If absent defaults to all non-excluded post codes.  Each element is a single four digit postcode (e.g. 3000) or a range of postcodes defined by two four digit postcodes and a hyphen (e.g. 3000-3999)
        /// </summary>
        /// <value>Array of valid Australian post codes that are included from the plan.  If absent defaults to all non-excluded post codes.  Each element is a single four digit postcode (e.g. 3000) or a range of postcodes defined by two four digit postcodes and a hyphen (e.g. 3000-3999)</value>
        [DataMember(Name="includedPostcodes", EmitDefaultValue=false)]
        public List<string> IncludedPostcodes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnergyPlanGeography {\n");
            sb.Append("  ExcludedPostcodes: ").Append(ExcludedPostcodes).Append("\n");
            sb.Append("  IncludedPostcodes: ").Append(IncludedPostcodes).Append("\n");
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
            return obj.GetType() == GetType() && Equals((EnergyPlanGeography)obj);
        }

        /// <summary>
        /// Returns true if EnergyPlanGeography instances are equal
        /// </summary>
        /// <param name="other">Instance of EnergyPlanGeography to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EnergyPlanGeography other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    ExcludedPostcodes == other.ExcludedPostcodes ||
                    ExcludedPostcodes != null &&
                    other.ExcludedPostcodes != null &&
                    ExcludedPostcodes.SequenceEqual(other.ExcludedPostcodes)
                ) && 
                (
                    IncludedPostcodes == other.IncludedPostcodes ||
                    IncludedPostcodes != null &&
                    other.IncludedPostcodes != null &&
                    IncludedPostcodes.SequenceEqual(other.IncludedPostcodes)
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
                    if (ExcludedPostcodes != null)
                    hashCode = hashCode * 59 + ExcludedPostcodes.GetHashCode();
                    if (IncludedPostcodes != null)
                    hashCode = hashCode * 59 + IncludedPostcodes.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(EnergyPlanGeography left, EnergyPlanGeography right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(EnergyPlanGeography left, EnergyPlanGeography right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
