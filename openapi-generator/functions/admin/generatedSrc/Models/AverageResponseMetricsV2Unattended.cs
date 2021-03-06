/*
 * CDR Admin API
 *
 * Data Holder Consumer Data Standards Administration End Points created by the Data Standards Body (DSB), with the Data Standards Chair as the decision maker
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
using OpenAPIDateConverter = Agl.Cdr.Admin.Client.OpenAPIDateConverter;

namespace Agl.Cdr.Admin.Models
{
    /// <summary>
    /// Average response time for the unattended tier
    /// </summary>
    [DataContract(Name = "AverageResponseMetricsV2_unattended")]
    public partial class AverageResponseMetricsV2Unattended : IEquatable<AverageResponseMetricsV2Unattended>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AverageResponseMetricsV2Unattended" /> class.
        /// </summary>
        /// <param name="currentDay">Average response time for current day.</param>
        /// <param name="previousDays">Average response time for previous days. The first element indicates yesterday and so on. A maximum of seven entries is required if available..</param>
        public AverageResponseMetricsV2Unattended(decimal currentDay = default(decimal), List<decimal> previousDays = default(List<decimal>))
        {
            this.CurrentDay = currentDay;
            this.PreviousDays = previousDays;
        }

        /// <summary>
        /// Average response time for current day
        /// </summary>
        /// <value>Average response time for current day</value>
        [DataMember(Name = "currentDay", EmitDefaultValue = false)]
        public decimal CurrentDay { get; set; }

        /// <summary>
        /// Average response time for previous days. The first element indicates yesterday and so on. A maximum of seven entries is required if available.
        /// </summary>
        /// <value>Average response time for previous days. The first element indicates yesterday and so on. A maximum of seven entries is required if available.</value>
        [DataMember(Name = "previousDays", EmitDefaultValue = false)]
        public List<decimal> PreviousDays { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AverageResponseMetricsV2Unattended {\n");
            sb.Append("  CurrentDay: ").Append(CurrentDay).Append("\n");
            sb.Append("  PreviousDays: ").Append(PreviousDays).Append("\n");
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
            return this.Equals(input as AverageResponseMetricsV2Unattended);
        }

        /// <summary>
        /// Returns true if AverageResponseMetricsV2Unattended instances are equal
        /// </summary>
        /// <param name="input">Instance of AverageResponseMetricsV2Unattended to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AverageResponseMetricsV2Unattended input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CurrentDay == input.CurrentDay ||
                    this.CurrentDay.Equals(input.CurrentDay)
                ) && 
                (
                    this.PreviousDays == input.PreviousDays ||
                    this.PreviousDays != null &&
                    input.PreviousDays != null &&
                    this.PreviousDays.SequenceEqual(input.PreviousDays)
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
                hashCode = hashCode * 59 + this.CurrentDay.GetHashCode();
                if (this.PreviousDays != null)
                    hashCode = hashCode * 59 + this.PreviousDays.GetHashCode();
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
