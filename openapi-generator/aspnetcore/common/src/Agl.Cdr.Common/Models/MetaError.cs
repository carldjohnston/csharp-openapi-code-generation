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
    /// Additional data for customised error codes
    /// </summary>
    [DataContract]
    public partial class MetaError : IEquatable<MetaError>
    {
        /// <summary>
        /// The CDR error code URN which the application-specific error code extends. Mandatory if the error &#x60;code&#x60; is an application-specific error rather than a standardised error code.
        /// </summary>
        /// <value>The CDR error code URN which the application-specific error code extends. Mandatory if the error &#x60;code&#x60; is an application-specific error rather than a standardised error code.</value>
        [DataMember(Name="urn", EmitDefaultValue=false)]
        public string Urn { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MetaError {\n");
            sb.Append("  Urn: ").Append(Urn).Append("\n");
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
            return obj.GetType() == GetType() && Equals((MetaError)obj);
        }

        /// <summary>
        /// Returns true if MetaError instances are equal
        /// </summary>
        /// <param name="other">Instance of MetaError to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MetaError other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Urn == other.Urn ||
                    Urn != null &&
                    Urn.Equals(other.Urn)
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
                    if (Urn != null)
                    hashCode = hashCode * 59 + Urn.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(MetaError left, MetaError right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(MetaError left, MetaError right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
