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
    /// Object contain charges and credits related to electricity usage
    /// </summary>
    [DataContract(Name = "EnergyInvoiceAccountCharges")]
    public partial class EnergyInvoiceAccountCharges : IEquatable<EnergyInvoiceAccountCharges>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EnergyInvoiceAccountCharges" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EnergyInvoiceAccountCharges() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EnergyInvoiceAccountCharges" /> class.
        /// </summary>
        /// <param name="totalCharges">The aggregate total of account level charges for the period covered by the invoice (required).</param>
        /// <param name="totalDiscounts">The aggregate total of account level discounts or credits for the period covered by the invoice (required).</param>
        /// <param name="totalGst">The total GST for all account level charges.  If absent then zero is assumed.</param>
        public EnergyInvoiceAccountCharges(string totalCharges = default(string), string totalDiscounts = default(string), string totalGst = default(string))
        {
            // to ensure "totalCharges" is required (not null)
            this.TotalCharges = totalCharges ?? throw new ArgumentNullException("totalCharges is a required property for EnergyInvoiceAccountCharges and cannot be null");
            // to ensure "totalDiscounts" is required (not null)
            this.TotalDiscounts = totalDiscounts ?? throw new ArgumentNullException("totalDiscounts is a required property for EnergyInvoiceAccountCharges and cannot be null");
            this.TotalGst = totalGst;
        }

        /// <summary>
        /// The aggregate total of account level charges for the period covered by the invoice
        /// </summary>
        /// <value>The aggregate total of account level charges for the period covered by the invoice</value>
        [DataMember(Name = "totalCharges", IsRequired = true, EmitDefaultValue = false)]
        public string TotalCharges { get; set; }

        /// <summary>
        /// The aggregate total of account level discounts or credits for the period covered by the invoice
        /// </summary>
        /// <value>The aggregate total of account level discounts or credits for the period covered by the invoice</value>
        [DataMember(Name = "totalDiscounts", IsRequired = true, EmitDefaultValue = false)]
        public string TotalDiscounts { get; set; }

        /// <summary>
        /// The total GST for all account level charges.  If absent then zero is assumed
        /// </summary>
        /// <value>The total GST for all account level charges.  If absent then zero is assumed</value>
        [DataMember(Name = "totalGst", EmitDefaultValue = false)]
        public string TotalGst { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnergyInvoiceAccountCharges {\n");
            sb.Append("  TotalCharges: ").Append(TotalCharges).Append("\n");
            sb.Append("  TotalDiscounts: ").Append(TotalDiscounts).Append("\n");
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
            return this.Equals(input as EnergyInvoiceAccountCharges);
        }

        /// <summary>
        /// Returns true if EnergyInvoiceAccountCharges instances are equal
        /// </summary>
        /// <param name="input">Instance of EnergyInvoiceAccountCharges to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EnergyInvoiceAccountCharges input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TotalCharges == input.TotalCharges ||
                    (this.TotalCharges != null &&
                    this.TotalCharges.Equals(input.TotalCharges))
                ) && 
                (
                    this.TotalDiscounts == input.TotalDiscounts ||
                    (this.TotalDiscounts != null &&
                    this.TotalDiscounts.Equals(input.TotalDiscounts))
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
                if (this.TotalCharges != null)
                    hashCode = hashCode * 59 + this.TotalCharges.GetHashCode();
                if (this.TotalDiscounts != null)
                    hashCode = hashCode * 59 + this.TotalDiscounts.GetHashCode();
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