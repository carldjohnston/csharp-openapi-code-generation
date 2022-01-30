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
    /// EnergyBalanceListResponseDataBalances
    /// </summary>
    [DataContract(Name = "EnergyBalanceListResponse_data_balances")]
    public partial class EnergyBalanceListResponseDataBalances : IEquatable<EnergyBalanceListResponseDataBalances>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EnergyBalanceListResponseDataBalances" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EnergyBalanceListResponseDataBalances() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EnergyBalanceListResponseDataBalances" /> class.
        /// </summary>
        /// <param name="accountId">The ID of the account (required).</param>
        /// <param name="balance">The current balance of the account.  A positive value indicates that amount is owing to be paid.  A negative value indicates that the account is in credit (required).</param>
        public EnergyBalanceListResponseDataBalances(string accountId = default(string), string balance = default(string))
        {
            // to ensure "accountId" is required (not null)
            this.AccountId = accountId ?? throw new ArgumentNullException("accountId is a required property for EnergyBalanceListResponseDataBalances and cannot be null");
            // to ensure "balance" is required (not null)
            this.Balance = balance ?? throw new ArgumentNullException("balance is a required property for EnergyBalanceListResponseDataBalances and cannot be null");
        }

        /// <summary>
        /// The ID of the account
        /// </summary>
        /// <value>The ID of the account</value>
        [DataMember(Name = "accountId", IsRequired = true, EmitDefaultValue = false)]
        public string AccountId { get; set; }

        /// <summary>
        /// The current balance of the account.  A positive value indicates that amount is owing to be paid.  A negative value indicates that the account is in credit
        /// </summary>
        /// <value>The current balance of the account.  A positive value indicates that amount is owing to be paid.  A negative value indicates that the account is in credit</value>
        [DataMember(Name = "balance", IsRequired = true, EmitDefaultValue = false)]
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
            return this.Equals(input as EnergyBalanceListResponseDataBalances);
        }

        /// <summary>
        /// Returns true if EnergyBalanceListResponseDataBalances instances are equal
        /// </summary>
        /// <param name="input">Instance of EnergyBalanceListResponseDataBalances to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EnergyBalanceListResponseDataBalances input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccountId == input.AccountId ||
                    (this.AccountId != null &&
                    this.AccountId.Equals(input.AccountId))
                ) && 
                (
                    this.Balance == input.Balance ||
                    (this.Balance != null &&
                    this.Balance.Equals(input.Balance))
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
                if (this.AccountId != null)
                    hashCode = hashCode * 59 + this.AccountId.GetHashCode();
                if (this.Balance != null)
                    hashCode = hashCode * 59 + this.Balance.GetHashCode();
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