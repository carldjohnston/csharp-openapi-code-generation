/*
 * CDR Energy API
 *
 * Consumer Data Right end points and payloads for the Energy sector
 *
 * The version of the OpenAPI document: 1.15.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Agl.Cdr.Energy.Client.OpenAPIDateConverter;

namespace Agl.Cdr.Energy.Models
{
    /// <summary>
    /// EnergyInvoiceGasUsageCharges
    /// </summary>
    [DataContract(Name = "EnergyInvoiceGasUsageCharges")]
    public partial class EnergyInvoiceGasUsageCharges : IEquatable<EnergyInvoiceGasUsageCharges>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EnergyInvoiceGasUsageCharges" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EnergyInvoiceGasUsageCharges() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EnergyInvoiceGasUsageCharges" /> class.
        /// </summary>
        /// <param name="totalUsageCharges">The aggregate total of usage charges for the period covered by the invoice (exclusive of GST) (required).</param>
        /// <param name="totalGenerationCredits">The aggregate total of generation credits for the period covered by the invoice (exclusive of GST) (required).</param>
        /// <param name="totalOnceOffCharges">The aggregate total of any once off charges arising from electricity usage for the period covered by the invoice (exclusive of GST) (required).</param>
        /// <param name="totalOnceOffDiscounts">The aggregate total of any once off discounts or credits arising from electricity usage for the period covered by the invoice (exclusive of GST) (required).</param>
        /// <param name="otherCharges">Optional array of charges that may be part of the invoice (for e.g. environmental charges for C&amp;I consumers) (exclusive of GST).</param>
        /// <param name="totalGst">The total GST for all electricity usage charges.  If absent then zero is assumed.</param>
        public EnergyInvoiceGasUsageCharges(string totalUsageCharges = default(string), string totalGenerationCredits = default(string), string totalOnceOffCharges = default(string), string totalOnceOffDiscounts = default(string), List<EnergyInvoiceGasUsageChargesOtherCharges> otherCharges = default(List<EnergyInvoiceGasUsageChargesOtherCharges>), string totalGst = default(string))
        {
            // to ensure "totalUsageCharges" is required (not null)
            this.TotalUsageCharges = totalUsageCharges ?? throw new ArgumentNullException("totalUsageCharges is a required property for EnergyInvoiceGasUsageCharges and cannot be null");
            // to ensure "totalGenerationCredits" is required (not null)
            this.TotalGenerationCredits = totalGenerationCredits ?? throw new ArgumentNullException("totalGenerationCredits is a required property for EnergyInvoiceGasUsageCharges and cannot be null");
            // to ensure "totalOnceOffCharges" is required (not null)
            this.TotalOnceOffCharges = totalOnceOffCharges ?? throw new ArgumentNullException("totalOnceOffCharges is a required property for EnergyInvoiceGasUsageCharges and cannot be null");
            // to ensure "totalOnceOffDiscounts" is required (not null)
            this.TotalOnceOffDiscounts = totalOnceOffDiscounts ?? throw new ArgumentNullException("totalOnceOffDiscounts is a required property for EnergyInvoiceGasUsageCharges and cannot be null");
            this.OtherCharges = otherCharges;
            this.TotalGst = totalGst;
        }

        /// <summary>
        /// The aggregate total of usage charges for the period covered by the invoice (exclusive of GST)
        /// </summary>
        /// <value>The aggregate total of usage charges for the period covered by the invoice (exclusive of GST)</value>
        [DataMember(Name = "totalUsageCharges", IsRequired = true, EmitDefaultValue = false)]
        public string TotalUsageCharges { get; set; }

        /// <summary>
        /// The aggregate total of generation credits for the period covered by the invoice (exclusive of GST)
        /// </summary>
        /// <value>The aggregate total of generation credits for the period covered by the invoice (exclusive of GST)</value>
        [DataMember(Name = "totalGenerationCredits", IsRequired = true, EmitDefaultValue = false)]
        public string TotalGenerationCredits { get; set; }

        /// <summary>
        /// The aggregate total of any once off charges arising from electricity usage for the period covered by the invoice (exclusive of GST)
        /// </summary>
        /// <value>The aggregate total of any once off charges arising from electricity usage for the period covered by the invoice (exclusive of GST)</value>
        [DataMember(Name = "totalOnceOffCharges", IsRequired = true, EmitDefaultValue = false)]
        public string TotalOnceOffCharges { get; set; }

        /// <summary>
        /// The aggregate total of any once off discounts or credits arising from electricity usage for the period covered by the invoice (exclusive of GST)
        /// </summary>
        /// <value>The aggregate total of any once off discounts or credits arising from electricity usage for the period covered by the invoice (exclusive of GST)</value>
        [DataMember(Name = "totalOnceOffDiscounts", IsRequired = true, EmitDefaultValue = false)]
        public string TotalOnceOffDiscounts { get; set; }

        /// <summary>
        /// Optional array of charges that may be part of the invoice (for e.g. environmental charges for C&amp;I consumers) (exclusive of GST)
        /// </summary>
        /// <value>Optional array of charges that may be part of the invoice (for e.g. environmental charges for C&amp;I consumers) (exclusive of GST)</value>
        [DataMember(Name = "otherCharges", EmitDefaultValue = false)]
        public List<EnergyInvoiceGasUsageChargesOtherCharges> OtherCharges { get; set; }

        /// <summary>
        /// The total GST for all electricity usage charges.  If absent then zero is assumed
        /// </summary>
        /// <value>The total GST for all electricity usage charges.  If absent then zero is assumed</value>
        [DataMember(Name = "totalGst", EmitDefaultValue = false)]
        public string TotalGst { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnergyInvoiceGasUsageCharges {\n");
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
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as EnergyInvoiceGasUsageCharges);
        }

        /// <summary>
        /// Returns true if EnergyInvoiceGasUsageCharges instances are equal
        /// </summary>
        /// <param name="input">Instance of EnergyInvoiceGasUsageCharges to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EnergyInvoiceGasUsageCharges input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TotalUsageCharges == input.TotalUsageCharges ||
                    (this.TotalUsageCharges != null &&
                    this.TotalUsageCharges.Equals(input.TotalUsageCharges))
                ) && 
                (
                    this.TotalGenerationCredits == input.TotalGenerationCredits ||
                    (this.TotalGenerationCredits != null &&
                    this.TotalGenerationCredits.Equals(input.TotalGenerationCredits))
                ) && 
                (
                    this.TotalOnceOffCharges == input.TotalOnceOffCharges ||
                    (this.TotalOnceOffCharges != null &&
                    this.TotalOnceOffCharges.Equals(input.TotalOnceOffCharges))
                ) && 
                (
                    this.TotalOnceOffDiscounts == input.TotalOnceOffDiscounts ||
                    (this.TotalOnceOffDiscounts != null &&
                    this.TotalOnceOffDiscounts.Equals(input.TotalOnceOffDiscounts))
                ) && 
                (
                    this.OtherCharges == input.OtherCharges ||
                    this.OtherCharges != null &&
                    input.OtherCharges != null &&
                    this.OtherCharges.SequenceEqual(input.OtherCharges)
                ) && 
                (
                    this.TotalGst == input.TotalGst ||
                    (this.TotalGst != null &&
                    this.TotalGst.Equals(input.TotalGst))
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
                int hashCode = 41;
                if (this.TotalUsageCharges != null)
                    hashCode = hashCode * 59 + this.TotalUsageCharges.GetHashCode();
                if (this.TotalGenerationCredits != null)
                    hashCode = hashCode * 59 + this.TotalGenerationCredits.GetHashCode();
                if (this.TotalOnceOffCharges != null)
                    hashCode = hashCode * 59 + this.TotalOnceOffCharges.GetHashCode();
                if (this.TotalOnceOffDiscounts != null)
                    hashCode = hashCode * 59 + this.TotalOnceOffDiscounts.GetHashCode();
                if (this.OtherCharges != null)
                    hashCode = hashCode * 59 + this.OtherCharges.GetHashCode();
                if (this.TotalGst != null)
                    hashCode = hashCode * 59 + this.TotalGst.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}