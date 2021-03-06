/*
 * CDR Common API
 *
 * Consumer Data Standards APIs created by the Data Standards Body (DSB), with the Data Standards Chair as the decision maker to meet the needs of the Consumer Data Right
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
using OpenAPIDateConverter = Agl.Cdr.Common.Client.OpenAPIDateConverter;

namespace Agl.Cdr.Common.Models
{
    /// <summary>
    /// DiscoveryOutage
    /// </summary>
    [DataContract(Name = "DiscoveryOutage")]
    public partial class DiscoveryOutage : IEquatable<DiscoveryOutage>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DiscoveryOutage" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DiscoveryOutage() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DiscoveryOutage" /> class.
        /// </summary>
        /// <param name="outageTime">Date and time that the outage is scheduled to begin (required).</param>
        /// <param name="duration">Planned duration of the outage. Formatted according to [ISO 8601 Durations](https://en.wikipedia.org/wiki/ISO_8601#Durations) (excludes recurrence syntax) (required).</param>
        /// <param name="isPartial">Flag that indicates, if present and set to true, that the outage is only partial meaning that only a subset of normally available end points will be affected by the outage.</param>
        /// <param name="explanation">Provides an explanation of the current outage that can be displayed to an end customer (required).</param>
        public DiscoveryOutage(string outageTime = default(string), string duration = default(string), bool isPartial = default(bool), string explanation = default(string))
        {
            // to ensure "outageTime" is required (not null)
            this.OutageTime = outageTime ?? throw new ArgumentNullException("outageTime is a required property for DiscoveryOutage and cannot be null");
            // to ensure "duration" is required (not null)
            this.Duration = duration ?? throw new ArgumentNullException("duration is a required property for DiscoveryOutage and cannot be null");
            // to ensure "explanation" is required (not null)
            this.Explanation = explanation ?? throw new ArgumentNullException("explanation is a required property for DiscoveryOutage and cannot be null");
            this.IsPartial = isPartial;
        }

        /// <summary>
        /// Date and time that the outage is scheduled to begin
        /// </summary>
        /// <value>Date and time that the outage is scheduled to begin</value>
        [DataMember(Name = "outageTime", IsRequired = true, EmitDefaultValue = false)]
        public string OutageTime { get; set; }

        /// <summary>
        /// Planned duration of the outage. Formatted according to [ISO 8601 Durations](https://en.wikipedia.org/wiki/ISO_8601#Durations) (excludes recurrence syntax)
        /// </summary>
        /// <value>Planned duration of the outage. Formatted according to [ISO 8601 Durations](https://en.wikipedia.org/wiki/ISO_8601#Durations) (excludes recurrence syntax)</value>
        [DataMember(Name = "duration", IsRequired = true, EmitDefaultValue = false)]
        public string Duration { get; set; }

        /// <summary>
        /// Flag that indicates, if present and set to true, that the outage is only partial meaning that only a subset of normally available end points will be affected by the outage
        /// </summary>
        /// <value>Flag that indicates, if present and set to true, that the outage is only partial meaning that only a subset of normally available end points will be affected by the outage</value>
        [DataMember(Name = "isPartial", EmitDefaultValue = true)]
        public bool IsPartial { get; set; }

        /// <summary>
        /// Provides an explanation of the current outage that can be displayed to an end customer
        /// </summary>
        /// <value>Provides an explanation of the current outage that can be displayed to an end customer</value>
        [DataMember(Name = "explanation", IsRequired = true, EmitDefaultValue = false)]
        public string Explanation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DiscoveryOutage {\n");
            sb.Append("  OutageTime: ").Append(OutageTime).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  IsPartial: ").Append(IsPartial).Append("\n");
            sb.Append("  Explanation: ").Append(Explanation).Append("\n");
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
            return this.Equals(input as DiscoveryOutage);
        }

        /// <summary>
        /// Returns true if DiscoveryOutage instances are equal
        /// </summary>
        /// <param name="input">Instance of DiscoveryOutage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DiscoveryOutage input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OutageTime == input.OutageTime ||
                    (this.OutageTime != null &&
                    this.OutageTime.Equals(input.OutageTime))
                ) && 
                (
                    this.Duration == input.Duration ||
                    (this.Duration != null &&
                    this.Duration.Equals(input.Duration))
                ) && 
                (
                    this.IsPartial == input.IsPartial ||
                    this.IsPartial.Equals(input.IsPartial)
                ) && 
                (
                    this.Explanation == input.Explanation ||
                    (this.Explanation != null &&
                    this.Explanation.Equals(input.Explanation))
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
                if (this.OutageTime != null)
                    hashCode = hashCode * 59 + this.OutageTime.GetHashCode();
                if (this.Duration != null)
                    hashCode = hashCode * 59 + this.Duration.GetHashCode();
                hashCode = hashCode * 59 + this.IsPartial.GetHashCode();
                if (this.Explanation != null)
                    hashCode = hashCode * 59 + this.Explanation.GetHashCode();
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
