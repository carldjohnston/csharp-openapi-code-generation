/*
 * CDR Common API
 *
 * Consumer Data Standards APIs created by the Data Standards Body (DSB), with the Data Standards Chair as the decision maker to meet the needs of the Consumer Data Right
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
using Agl.Cdr.Common.Converters;

namespace Agl.Cdr.Common.Models
{ 
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class ResponseCommonCustomerDetailV2Data : IEquatable<ResponseCommonCustomerDetailV2Data>
    {

        /// <summary>
        /// The type of customer object that is present
        /// </summary>
        /// <value>The type of customer object that is present</value>
        [TypeConverter(typeof(CustomEnumConverter<CustomerUTypeEnum>))]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum CustomerUTypeEnum
        {
            
            /// <summary>
            /// Enum OrganisationEnum for organisation
            /// </summary>
            [EnumMember(Value = "organisation")]
            OrganisationEnum = 1,
            
            /// <summary>
            /// Enum PersonEnum for person
            /// </summary>
            [EnumMember(Value = "person")]
            PersonEnum = 2
        }

        /// <summary>
        /// The type of customer object that is present
        /// </summary>
        /// <value>The type of customer object that is present</value>
        [Required]
        [DataMember(Name="customerUType", EmitDefaultValue=false)]
        public CustomerUTypeEnum CustomerUType { get; set; }

        /// <summary>
        /// Gets or Sets Person
        /// </summary>
        [DataMember(Name="person", EmitDefaultValue=false)]
        public CommonPersonDetailV2 Person { get; set; }

        /// <summary>
        /// Gets or Sets Organisation
        /// </summary>
        [DataMember(Name="organisation", EmitDefaultValue=false)]
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
            return obj.GetType() == GetType() && Equals((ResponseCommonCustomerDetailV2Data)obj);
        }

        /// <summary>
        /// Returns true if ResponseCommonCustomerDetailV2Data instances are equal
        /// </summary>
        /// <param name="other">Instance of ResponseCommonCustomerDetailV2Data to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResponseCommonCustomerDetailV2Data other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    CustomerUType == other.CustomerUType ||
                    
                    CustomerUType.Equals(other.CustomerUType)
                ) && 
                (
                    Person == other.Person ||
                    Person != null &&
                    Person.Equals(other.Person)
                ) && 
                (
                    Organisation == other.Organisation ||
                    Organisation != null &&
                    Organisation.Equals(other.Organisation)
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
                    
                    hashCode = hashCode * 59 + CustomerUType.GetHashCode();
                    if (Person != null)
                    hashCode = hashCode * 59 + Person.GetHashCode();
                    if (Organisation != null)
                    hashCode = hashCode * 59 + Organisation.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ResponseCommonCustomerDetailV2Data left, ResponseCommonCustomerDetailV2Data right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ResponseCommonCustomerDetailV2Data left, ResponseCommonCustomerDetailV2Data right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
