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
    /// Required only when the hasCentralProtectionAndControl flag is set to true.  One or more of the object fields will be provided to describe the protection modes in place
    /// </summary>
    [DataContract]
    public partial class EnergyDerRecordProtectionMode : IEquatable<EnergyDerRecordProtectionMode>
    {
        /// <summary>
        /// Maximum amount of power (kVA) that may be exported from a connection point to the grid, as monitored by a control / relay function. An absent value indicates no limit
        /// </summary>
        /// <value>Maximum amount of power (kVA) that may be exported from a connection point to the grid, as monitored by a control / relay function. An absent value indicates no limit</value>
        [DataMember(Name="exportLimitkva", EmitDefaultValue=false)]
        public decimal ExportLimitkva { get; set; }

        /// <summary>
        /// Protective function limit in Hz.
        /// </summary>
        /// <value>Protective function limit in Hz.</value>
        [DataMember(Name="underFrequencyProtection", EmitDefaultValue=false)]
        public decimal UnderFrequencyProtection { get; set; }

        /// <summary>
        /// Trip delay time in seconds.
        /// </summary>
        /// <value>Trip delay time in seconds.</value>
        [DataMember(Name="underFrequencyProtectionDelay", EmitDefaultValue=false)]
        public decimal UnderFrequencyProtectionDelay { get; set; }

        /// <summary>
        /// Protective function limit in Hz.
        /// </summary>
        /// <value>Protective function limit in Hz.</value>
        [DataMember(Name="overFrequencyProtection", EmitDefaultValue=false)]
        public decimal OverFrequencyProtection { get; set; }

        /// <summary>
        /// Trip delay time in seconds.
        /// </summary>
        /// <value>Trip delay time in seconds.</value>
        [DataMember(Name="overFrequencyProtectionDelay", EmitDefaultValue=false)]
        public decimal OverFrequencyProtectionDelay { get; set; }

        /// <summary>
        /// Protective function limit in V.
        /// </summary>
        /// <value>Protective function limit in V.</value>
        [DataMember(Name="underVoltageProtection", EmitDefaultValue=false)]
        public decimal UnderVoltageProtection { get; set; }

        /// <summary>
        /// Trip delay time in seconds.
        /// </summary>
        /// <value>Trip delay time in seconds.</value>
        [DataMember(Name="underVoltageProtectionDelay", EmitDefaultValue=false)]
        public decimal UnderVoltageProtectionDelay { get; set; }

        /// <summary>
        /// Protective function limit in V.
        /// </summary>
        /// <value>Protective function limit in V.</value>
        [DataMember(Name="overVoltageProtection", EmitDefaultValue=false)]
        public decimal OverVoltageProtection { get; set; }

        /// <summary>
        /// Trip delay time in seconds.
        /// </summary>
        /// <value>Trip delay time in seconds.</value>
        [DataMember(Name="overVoltageProtectionDelay", EmitDefaultValue=false)]
        public decimal OverVoltageProtectionDelay { get; set; }

        /// <summary>
        /// Sustained over voltage.
        /// </summary>
        /// <value>Sustained over voltage.</value>
        [DataMember(Name="sustainedOverVoltage", EmitDefaultValue=false)]
        public decimal SustainedOverVoltage { get; set; }

        /// <summary>
        /// Trip delay time in seconds.
        /// </summary>
        /// <value>Trip delay time in seconds.</value>
        [DataMember(Name="sustainedOverVoltageDelay", EmitDefaultValue=false)]
        public decimal SustainedOverVoltageDelay { get; set; }

        /// <summary>
        /// Rate of change of frequency trip point (Hz/s).
        /// </summary>
        /// <value>Rate of change of frequency trip point (Hz/s).</value>
        [DataMember(Name="frequencyRateOfChange", EmitDefaultValue=false)]
        public decimal FrequencyRateOfChange { get; set; }

        /// <summary>
        /// Trip angle in degrees.
        /// </summary>
        /// <value>Trip angle in degrees.</value>
        [DataMember(Name="voltageVectorShift", EmitDefaultValue=false)]
        public decimal VoltageVectorShift { get; set; }

        /// <summary>
        /// Description of the form of inter-trip (e.g. &#39;from local substation&#39;).
        /// </summary>
        /// <value>Description of the form of inter-trip (e.g. &#39;from local substation&#39;).</value>
        [DataMember(Name="interTripScheme", EmitDefaultValue=false)]
        public string InterTripScheme { get; set; }

        /// <summary>
        /// Trip voltage.
        /// </summary>
        /// <value>Trip voltage.</value>
        [DataMember(Name="neutralVoltageDisplacement", EmitDefaultValue=false)]
        public decimal NeutralVoltageDisplacement { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnergyDerRecordProtectionMode {\n");
            sb.Append("  ExportLimitkva: ").Append(ExportLimitkva).Append("\n");
            sb.Append("  UnderFrequencyProtection: ").Append(UnderFrequencyProtection).Append("\n");
            sb.Append("  UnderFrequencyProtectionDelay: ").Append(UnderFrequencyProtectionDelay).Append("\n");
            sb.Append("  OverFrequencyProtection: ").Append(OverFrequencyProtection).Append("\n");
            sb.Append("  OverFrequencyProtectionDelay: ").Append(OverFrequencyProtectionDelay).Append("\n");
            sb.Append("  UnderVoltageProtection: ").Append(UnderVoltageProtection).Append("\n");
            sb.Append("  UnderVoltageProtectionDelay: ").Append(UnderVoltageProtectionDelay).Append("\n");
            sb.Append("  OverVoltageProtection: ").Append(OverVoltageProtection).Append("\n");
            sb.Append("  OverVoltageProtectionDelay: ").Append(OverVoltageProtectionDelay).Append("\n");
            sb.Append("  SustainedOverVoltage: ").Append(SustainedOverVoltage).Append("\n");
            sb.Append("  SustainedOverVoltageDelay: ").Append(SustainedOverVoltageDelay).Append("\n");
            sb.Append("  FrequencyRateOfChange: ").Append(FrequencyRateOfChange).Append("\n");
            sb.Append("  VoltageVectorShift: ").Append(VoltageVectorShift).Append("\n");
            sb.Append("  InterTripScheme: ").Append(InterTripScheme).Append("\n");
            sb.Append("  NeutralVoltageDisplacement: ").Append(NeutralVoltageDisplacement).Append("\n");
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
            return obj.GetType() == GetType() && Equals((EnergyDerRecordProtectionMode)obj);
        }

        /// <summary>
        /// Returns true if EnergyDerRecordProtectionMode instances are equal
        /// </summary>
        /// <param name="other">Instance of EnergyDerRecordProtectionMode to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EnergyDerRecordProtectionMode other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    ExportLimitkva == other.ExportLimitkva ||
                    
                    ExportLimitkva.Equals(other.ExportLimitkva)
                ) && 
                (
                    UnderFrequencyProtection == other.UnderFrequencyProtection ||
                    
                    UnderFrequencyProtection.Equals(other.UnderFrequencyProtection)
                ) && 
                (
                    UnderFrequencyProtectionDelay == other.UnderFrequencyProtectionDelay ||
                    
                    UnderFrequencyProtectionDelay.Equals(other.UnderFrequencyProtectionDelay)
                ) && 
                (
                    OverFrequencyProtection == other.OverFrequencyProtection ||
                    
                    OverFrequencyProtection.Equals(other.OverFrequencyProtection)
                ) && 
                (
                    OverFrequencyProtectionDelay == other.OverFrequencyProtectionDelay ||
                    
                    OverFrequencyProtectionDelay.Equals(other.OverFrequencyProtectionDelay)
                ) && 
                (
                    UnderVoltageProtection == other.UnderVoltageProtection ||
                    
                    UnderVoltageProtection.Equals(other.UnderVoltageProtection)
                ) && 
                (
                    UnderVoltageProtectionDelay == other.UnderVoltageProtectionDelay ||
                    
                    UnderVoltageProtectionDelay.Equals(other.UnderVoltageProtectionDelay)
                ) && 
                (
                    OverVoltageProtection == other.OverVoltageProtection ||
                    
                    OverVoltageProtection.Equals(other.OverVoltageProtection)
                ) && 
                (
                    OverVoltageProtectionDelay == other.OverVoltageProtectionDelay ||
                    
                    OverVoltageProtectionDelay.Equals(other.OverVoltageProtectionDelay)
                ) && 
                (
                    SustainedOverVoltage == other.SustainedOverVoltage ||
                    
                    SustainedOverVoltage.Equals(other.SustainedOverVoltage)
                ) && 
                (
                    SustainedOverVoltageDelay == other.SustainedOverVoltageDelay ||
                    
                    SustainedOverVoltageDelay.Equals(other.SustainedOverVoltageDelay)
                ) && 
                (
                    FrequencyRateOfChange == other.FrequencyRateOfChange ||
                    
                    FrequencyRateOfChange.Equals(other.FrequencyRateOfChange)
                ) && 
                (
                    VoltageVectorShift == other.VoltageVectorShift ||
                    
                    VoltageVectorShift.Equals(other.VoltageVectorShift)
                ) && 
                (
                    InterTripScheme == other.InterTripScheme ||
                    InterTripScheme != null &&
                    InterTripScheme.Equals(other.InterTripScheme)
                ) && 
                (
                    NeutralVoltageDisplacement == other.NeutralVoltageDisplacement ||
                    
                    NeutralVoltageDisplacement.Equals(other.NeutralVoltageDisplacement)
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
                    
                    hashCode = hashCode * 59 + ExportLimitkva.GetHashCode();
                    
                    hashCode = hashCode * 59 + UnderFrequencyProtection.GetHashCode();
                    
                    hashCode = hashCode * 59 + UnderFrequencyProtectionDelay.GetHashCode();
                    
                    hashCode = hashCode * 59 + OverFrequencyProtection.GetHashCode();
                    
                    hashCode = hashCode * 59 + OverFrequencyProtectionDelay.GetHashCode();
                    
                    hashCode = hashCode * 59 + UnderVoltageProtection.GetHashCode();
                    
                    hashCode = hashCode * 59 + UnderVoltageProtectionDelay.GetHashCode();
                    
                    hashCode = hashCode * 59 + OverVoltageProtection.GetHashCode();
                    
                    hashCode = hashCode * 59 + OverVoltageProtectionDelay.GetHashCode();
                    
                    hashCode = hashCode * 59 + SustainedOverVoltage.GetHashCode();
                    
                    hashCode = hashCode * 59 + SustainedOverVoltageDelay.GetHashCode();
                    
                    hashCode = hashCode * 59 + FrequencyRateOfChange.GetHashCode();
                    
                    hashCode = hashCode * 59 + VoltageVectorShift.GetHashCode();
                    if (InterTripScheme != null)
                    hashCode = hashCode * 59 + InterTripScheme.GetHashCode();
                    
                    hashCode = hashCode * 59 + NeutralVoltageDisplacement.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(EnergyDerRecordProtectionMode left, EnergyDerRecordProtectionMode right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(EnergyDerRecordProtectionMode left, EnergyDerRecordProtectionMode right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
