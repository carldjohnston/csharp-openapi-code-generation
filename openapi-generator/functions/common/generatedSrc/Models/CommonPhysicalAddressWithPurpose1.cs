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
    /// CommonPhysicalAddressWithPurpose1
    /// </summary>
    [DataContract(Name = "CommonPhysicalAddressWithPurpose1")]
    public partial class CommonPhysicalAddressWithPurpose1 : IEquatable<CommonPhysicalAddressWithPurpose1>, IValidatableObject
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
        /// Enumeration of values indicating the purpose of the physical address
        /// </summary>
        /// <value>Enumeration of values indicating the purpose of the physical address</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PurposeEnum
        {
            /// <summary>
            /// Enum MAIL for value: MAIL
            /// </summary>
            [EnumMember(Value = "MAIL")]
            MAIL = 1,

            /// <summary>
            /// Enum OTHER for value: OTHER
            /// </summary>
            [EnumMember(Value = "OTHER")]
            OTHER = 2,

            /// <summary>
            /// Enum PHYSICAL for value: PHYSICAL
            /// </summary>
            [EnumMember(Value = "PHYSICAL")]
            PHYSICAL = 3,

            /// <summary>
            /// Enum REGISTERED for value: REGISTERED
            /// </summary>
            [EnumMember(Value = "REGISTERED")]
            REGISTERED = 4,

            /// <summary>
            /// Enum WORK for value: WORK
            /// </summary>
            [EnumMember(Value = "WORK")]
            WORK = 5

        }


        /// <summary>
        /// Enumeration of values indicating the purpose of the physical address
        /// </summary>
        /// <value>Enumeration of values indicating the purpose of the physical address</value>
        [DataMember(Name = "purpose", IsRequired = true, EmitDefaultValue = false)]
        public PurposeEnum Purpose { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CommonPhysicalAddressWithPurpose1" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CommonPhysicalAddressWithPurpose1() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CommonPhysicalAddressWithPurpose1" /> class.
        /// </summary>
        /// <param name="addressUType">The type of address object present (required).</param>
        /// <param name="simple">simple.</param>
        /// <param name="paf">paf.</param>
        /// <param name="purpose">Enumeration of values indicating the purpose of the physical address (required).</param>
        public CommonPhysicalAddressWithPurpose1(AddressUTypeEnum addressUType = default(AddressUTypeEnum), CommonSimpleAddress simple = default(CommonSimpleAddress), CommonPAFAddress paf = default(CommonPAFAddress), PurposeEnum purpose = default(PurposeEnum))
        {
            this.AddressUType = addressUType;
            this.Purpose = purpose;
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
            sb.Append("class CommonPhysicalAddressWithPurpose1 {\n");
            sb.Append("  AddressUType: ").Append(AddressUType).Append("\n");
            sb.Append("  Simple: ").Append(Simple).Append("\n");
            sb.Append("  Paf: ").Append(Paf).Append("\n");
            sb.Append("  Purpose: ").Append(Purpose).Append("\n");
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
            return this.Equals(input as CommonPhysicalAddressWithPurpose1);
        }

        /// <summary>
        /// Returns true if CommonPhysicalAddressWithPurpose1 instances are equal
        /// </summary>
        /// <param name="input">Instance of CommonPhysicalAddressWithPurpose1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CommonPhysicalAddressWithPurpose1 input)
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
                ) && 
                (
                    this.Purpose == input.Purpose ||
                    this.Purpose.Equals(input.Purpose)
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
                hashCode = hashCode * 59 + this.Purpose.GetHashCode();
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
