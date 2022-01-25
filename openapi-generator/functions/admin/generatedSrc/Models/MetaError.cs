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
    /// Additional data for customised error codes
    /// </summary>
    [DataContract(Name = "MetaError")]
    public partial class MetaError : IEquatable<MetaError>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MetaError" /> class.
        /// </summary>
        /// <param name="urn">The CDR error code URN which the application-specific error code extends. Mandatory if the error &#x60;code&#x60; is an application-specific error rather than a standardised error code..</param>
        public MetaError(string urn = default(string))
        {
            this.Urn = urn;
        }

        /// <summary>
        /// The CDR error code URN which the application-specific error code extends. Mandatory if the error &#x60;code&#x60; is an application-specific error rather than a standardised error code.
        /// </summary>
        /// <value>The CDR error code URN which the application-specific error code extends. Mandatory if the error &#x60;code&#x60; is an application-specific error rather than a standardised error code.</value>
        [DataMember(Name = "urn", EmitDefaultValue = false)]
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
            return this.Equals(input as MetaError);
        }

        /// <summary>
        /// Returns true if MetaError instances are equal
        /// </summary>
        /// <param name="input">Instance of MetaError to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MetaError input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Urn == input.Urn ||
                    (this.Urn != null &&
                    this.Urn.Equals(input.Urn))
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
                if (this.Urn != null)
                    hashCode = hashCode * 59 + this.Urn.GetHashCode();
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