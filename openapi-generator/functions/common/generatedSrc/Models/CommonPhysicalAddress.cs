/*
 * CDR Common API
 *
 * Consumer Data Standards APIs created by the Data Standards Body (DSB), with the Data Standards Chair as the decision maker to meet the needs of the Consumer Data Right
 *
 * The version of the OpenAPI document: 1.15.0
 * Contact: contact@consumerdatastandards.gov.au
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
using OpenAPIDateConverter = Agl.Cdr.Common.Client.OpenAPIDateConverter;

namespace Agl.Cdr.Common.Models
{
    /// <summary>
    /// CommonPhysicalAddress
    /// </summary>
    [DataContract(Name = "CommonPhysicalAddress")]
    public partial class CommonPhysicalAddress : IEquatable<CommonPhysicalAddress>, IValidatableObject
    {
        /// <summary>
        /// The type of address object present
        /// </summary>
        /// <value>The type of address object present</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AddressUTypeEnum
        {
            /// <summary>
            /// Enum Paf for value: paf
            /// </summary>
            [EnumMember(Value = "paf")]
            Paf = 1,

            /// <summary>
            /// Enum Simple for value: simple
            /// </summary>
            [EnumMember(Value = "simple")]
            Simple = 2

        }


        /// <summary>
        /// The type of address object present
        /// </summary>
        /// <value>The type of address object present</value>
        [DataMember(Name = "addressUType", IsRequired = true, EmitDefaultValue = false)]
        public AddressUTypeEnum AddressUType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CommonPhysicalAddress" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CommonPhysicalAddress() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CommonPhysicalAddress" /> class.
        /// </summary>
        /// <param name="addressUType">The type of address object present (required).</param>
        /// <param name="simple">simple.</param>
        /// <param name="paf">paf.</param>
        public CommonPhysicalAddress(AddressUTypeEnum addressUType = default(AddressUTypeEnum), CommonSimpleAddress simple = default(CommonSimpleAddress), CommonPAFAddress paf = default(CommonPAFAddress))
        {
            this.AddressUType = addressUType;
            this.Simple = simple;
            this.Paf = paf;
        }

        /// <summary>
        /// Gets or Sets Simple
        /// </summary>
        [DataMember(Name = "simple", EmitDefaultValue = false)]
        public CommonSimpleAddress Simple { get; set; }

        /// <summary>
        /// Gets or Sets Paf
        /// </summary>
        [DataMember(Name = "paf", EmitDefaultValue = false)]
        public CommonPAFAddress Paf { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CommonPhysicalAddress {\n");
            sb.Append("  AddressUType: ").Append(AddressUType).Append("\n");
            sb.Append("  Simple: ").Append(Simple).Append("\n");
            sb.Append("  Paf: ").Append(Paf).Append("\n");
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
            return this.Equals(input as CommonPhysicalAddress);
        }

        /// <summary>
        /// Returns true if CommonPhysicalAddress instances are equal
        /// </summary>
        /// <param name="input">Instance of CommonPhysicalAddress to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CommonPhysicalAddress input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AddressUType == input.AddressUType ||
                    this.AddressUType.Equals(input.AddressUType)
                ) && 
                (
                    this.Simple == input.Simple ||
                    (this.Simple != null &&
                    this.Simple.Equals(input.Simple))
                ) && 
                (
                    this.Paf == input.Paf ||
                    (this.Paf != null &&
                    this.Paf.Equals(input.Paf))
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
                hashCode = hashCode * 59 + this.AddressUType.GetHashCode();
                if (this.Simple != null)
                    hashCode = hashCode * 59 + this.Simple.GetHashCode();
                if (this.Paf != null)
                    hashCode = hashCode * 59 + this.Paf.GetHashCode();
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
