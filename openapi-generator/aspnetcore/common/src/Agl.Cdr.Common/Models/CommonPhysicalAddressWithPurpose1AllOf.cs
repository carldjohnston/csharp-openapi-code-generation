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
    public partial class CommonPhysicalAddressWithPurpose1AllOf : IEquatable<CommonPhysicalAddressWithPurpose1AllOf>
    {

        /// <summary>
        /// Enumeration of values indicating the purpose of the physical address
        /// </summary>
        /// <value>Enumeration of values indicating the purpose of the physical address</value>
        [TypeConverter(typeof(CustomEnumConverter<PurposeEnum>))]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum PurposeEnum
        {
            
            /// <summary>
            /// Enum MAILEnum for MAIL
            /// </summary>
            [EnumMember(Value = "MAIL")]
            MAILEnum = 1,
            
            /// <summary>
            /// Enum OTHEREnum for OTHER
            /// </summary>
            [EnumMember(Value = "OTHER")]
            OTHEREnum = 2,
            
            /// <summary>
            /// Enum PHYSICALEnum for PHYSICAL
            /// </summary>
            [EnumMember(Value = "PHYSICAL")]
            PHYSICALEnum = 3,
            
            /// <summary>
            /// Enum REGISTEREDEnum for REGISTERED
            /// </summary>
            [EnumMember(Value = "REGISTERED")]
            REGISTEREDEnum = 4,
            
            /// <summary>
            /// Enum WORKEnum for WORK
            /// </summary>
            [EnumMember(Value = "WORK")]
            WORKEnum = 5
        }

        /// <summary>
        /// Enumeration of values indicating the purpose of the physical address
        /// </summary>
        /// <value>Enumeration of values indicating the purpose of the physical address</value>
        [Required]
        [DataMember(Name="purpose", EmitDefaultValue=false)]
        public PurposeEnum Purpose { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CommonPhysicalAddressWithPurpose1AllOf {\n");
            sb.Append("  Purpose: ").Append(Purpose).Append("\n");
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
            return obj.GetType() == GetType() && Equals((CommonPhysicalAddressWithPurpose1AllOf)obj);
        }

        /// <summary>
        /// Returns true if CommonPhysicalAddressWithPurpose1AllOf instances are equal
        /// </summary>
        /// <param name="other">Instance of CommonPhysicalAddressWithPurpose1AllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CommonPhysicalAddressWithPurpose1AllOf other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Purpose == other.Purpose ||
                    
                    Purpose.Equals(other.Purpose)
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
                    
                    hashCode = hashCode * 59 + Purpose.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(CommonPhysicalAddressWithPurpose1AllOf left, CommonPhysicalAddressWithPurpose1AllOf right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(CommonPhysicalAddressWithPurpose1AllOf left, CommonPhysicalAddressWithPurpose1AllOf right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}