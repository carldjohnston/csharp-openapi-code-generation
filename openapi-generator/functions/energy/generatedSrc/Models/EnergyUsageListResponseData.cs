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
    /// EnergyUsageListResponseData
    /// </summary>
    [DataContract(Name = "EnergyUsageListResponse_data")]
    public partial class EnergyUsageListResponseData : IEquatable<EnergyUsageListResponseData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EnergyUsageListResponseData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EnergyUsageListResponseData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EnergyUsageListResponseData" /> class.
        /// </summary>
        /// <param name="reads">Array of meter reads (required).</param>
        public EnergyUsageListResponseData(List<EnergyUsageRead> reads = default(List<EnergyUsageRead>))
        {
            // to ensure "reads" is required (not null)
            this.Reads = reads ?? throw new ArgumentNullException("reads is a required property for EnergyUsageListResponseData and cannot be null");
        }

        /// <summary>
        /// Array of meter reads
        /// </summary>
        /// <value>Array of meter reads</value>
        [DataMember(Name = "reads", IsRequired = true, EmitDefaultValue = false)]
        public List<EnergyUsageRead> Reads { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnergyUsageListResponseData {\n");
            sb.Append("  Reads: ").Append(Reads).Append("\n");
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
            return this.Equals(input as EnergyUsageListResponseData);
        }

        /// <summary>
        /// Returns true if EnergyUsageListResponseData instances are equal
        /// </summary>
        /// <param name="input">Instance of EnergyUsageListResponseData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EnergyUsageListResponseData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Reads == input.Reads ||
                    this.Reads != null &&
                    input.Reads != null &&
                    this.Reads.SequenceEqual(input.Reads)
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
                if (this.Reads != null)
                    hashCode = hashCode * 59 + this.Reads.GetHashCode();
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