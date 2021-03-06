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
    public partial class EnergyBalanceListResponseDataBalances : IEquatable<EnergyBalanceListResponseDataBalances>
    {
        /// <summary>
        /// The ID of the account
        /// </summary>
        /// <value>The ID of the account</value>
        [Required]
        [DataMember(Name="accountId", EmitDefaultValue=false)]
        public string AccountId { get; set; }

        /// <summary>
        /// The current balance of the account.  A positive value indicates that amount is owing to be paid.  A negative value indicates that the account is in credit
        /// </summary>
        /// <value>The current balance of the account.  A positive value indicates that amount is owing to be paid.  A negative value indicates that the account is in credit</value>
        [Required]
        [DataMember(Name="balance", EmitDefaultValue=false)]
        public string Balance { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnergyBalanceListResponseDataBalances {\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  Balance: ").Append(Balance).Append("\n");
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
            return obj.GetType() == GetType() && Equals((EnergyBalanceListResponseDataBalances)obj);
        }

        /// <summary>
        /// Returns true if EnergyBalanceListResponseDataBalances instances are equal
        /// </summary>
        /// <param name="other">Instance of EnergyBalanceListResponseDataBalances to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EnergyBalanceListResponseDataBalances other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    AccountId == other.AccountId ||
                    AccountId != null &&
                    AccountId.Equals(other.AccountId)
                ) && 
                (
                    Balance == other.Balance ||
                    Balance != null &&
                    Balance.Equals(other.Balance)
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
                    if (AccountId != null)
                    hashCode = hashCode * 59 + AccountId.GetHashCode();
                    if (Balance != null)
                    hashCode = hashCode * 59 + Balance.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(EnergyBalanceListResponseDataBalances left, EnergyBalanceListResponseDataBalances right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(EnergyBalanceListResponseDataBalances left, EnergyBalanceListResponseDataBalances right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
