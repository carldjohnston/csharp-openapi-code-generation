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
    public partial class EnergyInvoiceElectricityUsageCharges : IEquatable<EnergyInvoiceElectricityUsageCharges>
    {
        /// <summary>
        /// The aggregate total of usage charges for the period covered by the invoice (exclusive of GST)
        /// </summary>
        /// <value>The aggregate total of usage charges for the period covered by the invoice (exclusive of GST)</value>
        [Required]
        [DataMember(Name="totalUsageCharges", EmitDefaultValue=false)]
        public string TotalUsageCharges { get; set; }

        /// <summary>
        /// The aggregate total of generation credits for the period covered by the invoice (exclusive of GST)
        /// </summary>
        /// <value>The aggregate total of generation credits for the period covered by the invoice (exclusive of GST)</value>
        [Required]
        [DataMember(Name="totalGenerationCredits", EmitDefaultValue=false)]
        public string TotalGenerationCredits { get; set; }

        /// <summary>
        /// The aggregate total of any once off charges arising from electricity usage for the period covered by the invoice (exclusive of GST)
        /// </summary>
        /// <value>The aggregate total of any once off charges arising from electricity usage for the period covered by the invoice (exclusive of GST)</value>
        [Required]
        [DataMember(Name="totalOnceOffCharges", EmitDefaultValue=false)]
        public string TotalOnceOffCharges { get; set; }

        /// <summary>
        /// The aggregate total of any once off discounts or credits arising from electricity usage for the period covered by the invoice (exclusive of GST)
        /// </summary>
        /// <value>The aggregate total of any once off discounts or credits arising from electricity usage for the period covered by the invoice (exclusive of GST)</value>
        [Required]
        [DataMember(Name="totalOnceOffDiscounts", EmitDefaultValue=false)]
        public string TotalOnceOffDiscounts { get; set; }

        /// <summary>
        /// Optional array of charges that may be part of the invoice (for e.g. environmental charges for C&amp;I consumers) (exclusive of GST)
        /// </summary>
        /// <value>Optional array of charges that may be part of the invoice (for e.g. environmental charges for C&amp;I consumers) (exclusive of GST)</value>
        [DataMember(Name="otherCharges", EmitDefaultValue=false)]
        public List<EnergyInvoiceGasUsageChargesOtherCharges> OtherCharges { get; set; }

        /// <summary>
        /// The total GST for all electricity usage charges.  If absent then zero is assumed
        /// </summary>
        /// <value>The total GST for all electricity usage charges.  If absent then zero is assumed</value>
        [DataMember(Name="totalGst", EmitDefaultValue=false)]
        public string TotalGst { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnergyInvoiceElectricityUsageCharges {\n");
            sb.Append("  TotalUsageCharges: ").Append(TotalUsageCharges).Append("\n");
            sb.Append("  TotalGenerationCredits: ").Append(TotalGenerationCredits).Append("\n");
            sb.Append("  TotalOnceOffCharges: ").Append(TotalOnceOffCharges).Append("\n");
            sb.Append("  TotalOnceOffDiscounts: ").Append(TotalOnceOffDiscounts).Append("\n");
            sb.Append("  OtherCharges: ").Append(OtherCharges).Append("\n");
            sb.Append("  TotalGst: ").Append(TotalGst).Append("\n");
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
            return obj.GetType() == GetType() && Equals((EnergyInvoiceElectricityUsageCharges)obj);
        }

        /// <summary>
        /// Returns true if EnergyInvoiceElectricityUsageCharges instances are equal
        /// </summary>
        /// <param name="other">Instance of EnergyInvoiceElectricityUsageCharges to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EnergyInvoiceElectricityUsageCharges other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    TotalUsageCharges == other.TotalUsageCharges ||
                    TotalUsageCharges != null &&
                    TotalUsageCharges.Equals(other.TotalUsageCharges)
                ) && 
                (
                    TotalGenerationCredits == other.TotalGenerationCredits ||
                    TotalGenerationCredits != null &&
                    TotalGenerationCredits.Equals(other.TotalGenerationCredits)
                ) && 
                (
                    TotalOnceOffCharges == other.TotalOnceOffCharges ||
                    TotalOnceOffCharges != null &&
                    TotalOnceOffCharges.Equals(other.TotalOnceOffCharges)
                ) && 
                (
                    TotalOnceOffDiscounts == other.TotalOnceOffDiscounts ||
                    TotalOnceOffDiscounts != null &&
                    TotalOnceOffDiscounts.Equals(other.TotalOnceOffDiscounts)
                ) && 
                (
                    OtherCharges == other.OtherCharges ||
                    OtherCharges != null &&
                    other.OtherCharges != null &&
                    OtherCharges.SequenceEqual(other.OtherCharges)
                ) && 
                (
                    TotalGst == other.TotalGst ||
                    TotalGst != null &&
                    TotalGst.Equals(other.TotalGst)
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
                    if (TotalUsageCharges != null)
                    hashCode = hashCode * 59 + TotalUsageCharges.GetHashCode();
                    if (TotalGenerationCredits != null)
                    hashCode = hashCode * 59 + TotalGenerationCredits.GetHashCode();
                    if (TotalOnceOffCharges != null)
                    hashCode = hashCode * 59 + TotalOnceOffCharges.GetHashCode();
                    if (TotalOnceOffDiscounts != null)
                    hashCode = hashCode * 59 + TotalOnceOffDiscounts.GetHashCode();
                    if (OtherCharges != null)
                    hashCode = hashCode * 59 + OtherCharges.GetHashCode();
                    if (TotalGst != null)
                    hashCode = hashCode * 59 + TotalGst.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(EnergyInvoiceElectricityUsageCharges left, EnergyInvoiceElectricityUsageCharges right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(EnergyInvoiceElectricityUsageCharges left, EnergyInvoiceElectricityUsageCharges right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
