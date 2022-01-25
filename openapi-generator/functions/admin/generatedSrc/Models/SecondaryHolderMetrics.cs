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
    /// Errors and rejections received by the primary data holder from the secondary data holder.  Mandatory for data holders designated for a Shared Responsibility Data Request data cluster
    /// </summary>
    [DataContract(Name = "SecondaryHolderMetrics")]
    public partial class SecondaryHolderMetrics : IEquatable<SecondaryHolderMetrics>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SecondaryHolderMetrics" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SecondaryHolderMetrics() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SecondaryHolderMetrics" /> class.
        /// </summary>
        /// <param name="errors">errors (required).</param>
        /// <param name="rejections">rejections (required).</param>
        public SecondaryHolderMetrics(SecondaryHolderMetricsErrors errors = default(SecondaryHolderMetricsErrors), SecondaryHolderMetricsRejections rejections = default(SecondaryHolderMetricsRejections))
        {
            // to ensure "errors" is required (not null)
            this.Errors = errors ?? throw new ArgumentNullException("errors is a required property for SecondaryHolderMetrics and cannot be null");
            // to ensure "rejections" is required (not null)
            this.Rejections = rejections ?? throw new ArgumentNullException("rejections is a required property for SecondaryHolderMetrics and cannot be null");
        }

        /// <summary>
        /// Gets or Sets Errors
        /// </summary>
        [DataMember(Name = "errors", IsRequired = true, EmitDefaultValue = false)]
        public SecondaryHolderMetricsErrors Errors { get; set; }

        /// <summary>
        /// Gets or Sets Rejections
        /// </summary>
        [DataMember(Name = "rejections", IsRequired = true, EmitDefaultValue = false)]
        public SecondaryHolderMetricsRejections Rejections { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SecondaryHolderMetrics {\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
            sb.Append("  Rejections: ").Append(Rejections).Append("\n");
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
            return this.Equals(input as SecondaryHolderMetrics);
        }

        /// <summary>
        /// Returns true if SecondaryHolderMetrics instances are equal
        /// </summary>
        /// <param name="input">Instance of SecondaryHolderMetrics to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SecondaryHolderMetrics input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Errors == input.Errors ||
                    (this.Errors != null &&
                    this.Errors.Equals(input.Errors))
                ) && 
                (
                    this.Rejections == input.Rejections ||
                    (this.Rejections != null &&
                    this.Rejections.Equals(input.Rejections))
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
                if (this.Errors != null)
                    hashCode = hashCode * 59 + this.Errors.GetHashCode();
                if (this.Rejections != null)
                    hashCode = hashCode * 59 + this.Rejections.GetHashCode();
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