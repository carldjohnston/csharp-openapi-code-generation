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
    /// Required if pricing model is SINGLE_RATE_CONT_LOAD or TIME_OF_USE_CONT_LOAD or FLEXIBLE_CONT_LOAD
    /// </summary>
    [DataContract]
    public partial class EnergyPlanControlledLoad : IEquatable<EnergyPlanControlledLoad>
    {
        /// <summary>
        /// A display name for the controlled load tier
        /// </summary>
        /// <value>A display name for the controlled load tier</value>
        [Required]
        [DataMember(Name="displayName", EmitDefaultValue=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// A description of the controlled load tier
        /// </summary>
        /// <value>A description of the controlled load tier</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// The daily supply charge (exclusive of GST) for this controlled load tier
        /// </summary>
        /// <value>The daily supply charge (exclusive of GST) for this controlled load tier</value>
        [Required]
        [DataMember(Name="dailyCharge", EmitDefaultValue=false)]
        public string DailyCharge { get; set; }

        /// <summary>
        /// The period for which the controlled load rate applies. Formatted according to [ISO 8601 Durations](https://en.wikipedia.org/wiki/ISO_8601#Durations) (excludes recurrence syntax)
        /// </summary>
        /// <value>The period for which the controlled load rate applies. Formatted according to [ISO 8601 Durations](https://en.wikipedia.org/wiki/ISO_8601#Durations) (excludes recurrence syntax)</value>
        [Required]
        [DataMember(Name="period", EmitDefaultValue=false)]
        public string Period { get; set; }

        /// <summary>
        /// Array of controlled load rates in order of usage volume
        /// </summary>
        /// <value>Array of controlled load rates in order of usage volume</value>
        [Required]
        [DataMember(Name="rates", EmitDefaultValue=false)]
        public List<EnergyPlanControlledLoadRates> Rates { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnergyPlanControlledLoad {\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DailyCharge: ").Append(DailyCharge).Append("\n");
            sb.Append("  Period: ").Append(Period).Append("\n");
            sb.Append("  Rates: ").Append(Rates).Append("\n");
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
            return obj.GetType() == GetType() && Equals((EnergyPlanControlledLoad)obj);
        }

        /// <summary>
        /// Returns true if EnergyPlanControlledLoad instances are equal
        /// </summary>
        /// <param name="other">Instance of EnergyPlanControlledLoad to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EnergyPlanControlledLoad other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    DisplayName == other.DisplayName ||
                    DisplayName != null &&
                    DisplayName.Equals(other.DisplayName)
                ) && 
                (
                    Description == other.Description ||
                    Description != null &&
                    Description.Equals(other.Description)
                ) && 
                (
                    DailyCharge == other.DailyCharge ||
                    DailyCharge != null &&
                    DailyCharge.Equals(other.DailyCharge)
                ) && 
                (
                    Period == other.Period ||
                    Period != null &&
                    Period.Equals(other.Period)
                ) && 
                (
                    Rates == other.Rates ||
                    Rates != null &&
                    other.Rates != null &&
                    Rates.SequenceEqual(other.Rates)
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
                    if (DisplayName != null)
                    hashCode = hashCode * 59 + DisplayName.GetHashCode();
                    if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                    if (DailyCharge != null)
                    hashCode = hashCode * 59 + DailyCharge.GetHashCode();
                    if (Period != null)
                    hashCode = hashCode * 59 + Period.GetHashCode();
                    if (Rates != null)
                    hashCode = hashCode * 59 + Rates.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(EnergyPlanControlledLoad left, EnergyPlanControlledLoad right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(EnergyPlanControlledLoad left, EnergyPlanControlledLoad right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}