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
    /// ResponseCommonCustomerDetailV2Data
    /// </summary>
    [DataContract(Name = "ResponseCommonCustomerDetailV2_data")]
    public partial class ResponseCommonCustomerDetailV2Data : IEquatable<ResponseCommonCustomerDetailV2Data>, IValidatableObject
    {
        /// <summary>
        /// The type of customer object that is present
        /// </summary>
        /// <value>The type of customer object that is present</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CustomerUTypeEnum
        {
            /// <summary>
            /// Enum Organisation for value: organisation
            /// </summary>
            [EnumMember(Value = "organisation")]
            Organisation = 1,

            /// <summary>
            /// Enum Person for value: person
            /// </summary>
            [EnumMember(Value = "person")]
            Person = 2

        }


        /// <summary>
        /// The type of customer object that is present
        /// </summary>
        /// <value>The type of customer object that is present</value>
        [DataMember(Name = "customerUType", IsRequired = true, EmitDefaultValue = false)]
        public CustomerUTypeEnum CustomerUType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseCommonCustomerDetailV2Data" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ResponseCommonCustomerDetailV2Data() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseCommonCustomerDetailV2Data" /> class.
        /// </summary>
        /// <param name="customerUType">The type of customer object that is present (required).</param>
        /// <param name="person">person.</param>
        /// <param name="organisation">organisation.</param>
        public ResponseCommonCustomerDetailV2Data(CustomerUTypeEnum customerUType = default(CustomerUTypeEnum), CommonPersonDetailV2 person = default(CommonPersonDetailV2), CommonOrganisationDetailV2 organisation = default(CommonOrganisationDetailV2))
        {
            this.CustomerUType = customerUType;
            this.Person = person;
            this.Organisation = organisation;
        }

        /// <summary>
        /// Gets or Sets Person
        /// </summary>
        [DataMember(Name = "person", EmitDefaultValue = false)]
        public CommonPersonDetailV2 Person { get; set; }

        /// <summary>
        /// Gets or Sets Organisation
        /// </summary>
        [DataMember(Name = "organisation", EmitDefaultValue = false)]
        public CommonOrganisationDetailV2 Organisation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResponseCommonCustomerDetailV2Data {\n");
            sb.Append("  CustomerUType: ").Append(CustomerUType).Append("\n");
            sb.Append("  Person: ").Append(Person).Append("\n");
            sb.Append("  Organisation: ").Append(Organisation).Append("\n");
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
            return this.Equals(input as ResponseCommonCustomerDetailV2Data);
        }

        /// <summary>
        /// Returns true if ResponseCommonCustomerDetailV2Data instances are equal
        /// </summary>
        /// <param name="input">Instance of ResponseCommonCustomerDetailV2Data to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResponseCommonCustomerDetailV2Data input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CustomerUType == input.CustomerUType ||
                    this.CustomerUType.Equals(input.CustomerUType)
                ) && 
                (
                    this.Person == input.Person ||
                    (this.Person != null &&
                    this.Person.Equals(input.Person))
                ) && 
                (
                    this.Organisation == input.Organisation ||
                    (this.Organisation != null &&
                    this.Organisation.Equals(input.Organisation))
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
                hashCode = hashCode * 59 + this.CustomerUType.GetHashCode();
                if (this.Person != null)
                    hashCode = hashCode * 59 + this.Person.GetHashCode();
                if (this.Organisation != null)
                    hashCode = hashCode * 59 + this.Organisation.GetHashCode();
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
