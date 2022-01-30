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
    public partial class EnergyBillingListResponseData : IEquatable<EnergyBillingListResponseData>
    {
        /// <summary>
        /// Array of transactions sorted by date and time in descending order
        /// </summary>
        /// <value>Array of transactions sorted by date and time in descending order</value>
        [Required]
        [DataMember(Name="transactions", EmitDefaultValue=false)]
        public List<EnergyBillingTransaction> Transactions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnergyBillingListResponseData {\n");
            sb.Append("  Transactions: ").Append(Transactions).Append("\n");
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
            return obj.GetType() == GetType() && Equals((EnergyBillingListResponseData)obj);
        }

        /// <summary>
        /// Returns true if EnergyBillingListResponseData instances are equal
        /// </summary>
        /// <param name="other">Instance of EnergyBillingListResponseData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EnergyBillingListResponseData other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Transactions == other.Transactions ||
                    Transactions != null &&
                    other.Transactions != null &&
                    Transactions.SequenceEqual(other.Transactions)
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
                    if (Transactions != null)
                    hashCode = hashCode * 59 + Transactions.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(EnergyBillingListResponseData left, EnergyBillingListResponseData right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(EnergyBillingListResponseData left, EnergyBillingListResponseData right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}