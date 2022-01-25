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
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Agl.Cdr.Admin
{
    /// <summary>
    /// Transactions per second over time
    /// </summary>
    [DataContract(Name = "AverageTPSMetrics")]
    public partial class AverageTPSMetrics : IEquatable<AverageTPSMetrics>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AverageTPSMetrics" /> class.
        /// </summary>
        /// <param name="currentDay">Average TPS for current day.</param>
        /// <param name="previousDays">Average TPS for previous days. The first element indicates yesterday and so on. A maximum of seven entries is required if available.</param>
        public AverageTPSMetrics(decimal currentDay = default(decimal), List<decimal> previousDays = default(List<decimal>))
        {
            this.CurrentDay = currentDay;
            this.PreviousDays = previousDays;
        }

        /// <summary>
        /// Average TPS for current day
        /// </summary>
        /// <value>Average TPS for current day</value>
        [DataMember(Name = "currentDay", EmitDefaultValue = false)]
        public decimal CurrentDay { get; set; }

        /// <summary>
        /// Average TPS for previous days. The first element indicates yesterday and so on. A maximum of seven entries is required if available
        /// </summary>
        /// <value>Average TPS for previous days. The first element indicates yesterday and so on. A maximum of seven entries is required if available</value>
        [DataMember(Name = "previousDays", EmitDefaultValue = false)]
        public List<decimal> PreviousDays { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AverageTPSMetrics {\n");
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
            return this.Equals(input as AverageTPSMetrics);
        }

        /// <summary>
        /// Returns true if AverageTPSMetrics instances are equal
        /// </summary>
        /// <param name="input">Instance of AverageTPSMetrics to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AverageTPSMetrics input)
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
