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
    /// EnergyServicePointConsumerProfile
    /// </summary>
    [DataContract(Name = "EnergyServicePoint_consumerProfile")]
    public partial class EnergyServicePointConsumerProfile : IEquatable<EnergyServicePointConsumerProfile>, IValidatableObject
    {
        /// <summary>
        /// A code that defines the consumer class as defined in the National Energy Retail Regulations, or in overriding Jurisdictional instruments
        /// </summary>
        /// <value>A code that defines the consumer class as defined in the National Energy Retail Regulations, or in overriding Jurisdictional instruments</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ClassificationEnum
        {
            /// <summary>
            /// Enum BUSINESS for value: BUSINESS
            /// </summary>
            [EnumMember(Value = "BUSINESS")]
            BUSINESS = 1,

            /// <summary>
            /// Enum RESIDENTIAL for value: RESIDENTIAL
            /// </summary>
            [EnumMember(Value = "RESIDENTIAL")]
            RESIDENTIAL = 2

        }


        /// <summary>
        /// A code that defines the consumer class as defined in the National Energy Retail Regulations, or in overriding Jurisdictional instruments
        /// </summary>
        /// <value>A code that defines the consumer class as defined in the National Energy Retail Regulations, or in overriding Jurisdictional instruments</value>
        [DataMember(Name = "classification", EmitDefaultValue = false)]
        public ClassificationEnum? Classification { get; set; }
        /// <summary>
        /// A code that defines the consumption threshold as defined in the National Energy Retail Regulations, or in overriding Jurisdictional instruments. Note the details of enumeration values below: &lt;ul&gt;&lt;li&gt;**LOW** - Consumption is less than the ‘lower consumption threshold’ as defined in the National Energy Retail Regulations&lt;/li&gt;&lt;li&gt;**MEDIUM** - Consumption is equal to or greater than the ‘lower consumption threshold’, but less than the ‘upper consumption threshold’, as defined in the National Energy Retail Regulations&lt;/li&gt;&lt;li&gt;**HIGH** - Consumption is equal to or greater than the ‘upper consumption threshold’ as defined in the National Energy Retail Regulations&lt;/li&gt;&lt;/ul&gt;
        /// </summary>
        /// <value>A code that defines the consumption threshold as defined in the National Energy Retail Regulations, or in overriding Jurisdictional instruments. Note the details of enumeration values below: &lt;ul&gt;&lt;li&gt;**LOW** - Consumption is less than the ‘lower consumption threshold’ as defined in the National Energy Retail Regulations&lt;/li&gt;&lt;li&gt;**MEDIUM** - Consumption is equal to or greater than the ‘lower consumption threshold’, but less than the ‘upper consumption threshold’, as defined in the National Energy Retail Regulations&lt;/li&gt;&lt;li&gt;**HIGH** - Consumption is equal to or greater than the ‘upper consumption threshold’ as defined in the National Energy Retail Regulations&lt;/li&gt;&lt;/ul&gt;</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ThresholdEnum
        {
            /// <summary>
            /// Enum LOW for value: LOW
            /// </summary>
            [EnumMember(Value = "LOW")]
            LOW = 1,

            /// <summary>
            /// Enum MEDIUM for value: MEDIUM
            /// </summary>
            [EnumMember(Value = "MEDIUM")]
            MEDIUM = 2,

            /// <summary>
            /// Enum HIGH for value: HIGH
            /// </summary>
            [EnumMember(Value = "HIGH")]
            HIGH = 3

        }


        /// <summary>
        /// A code that defines the consumption threshold as defined in the National Energy Retail Regulations, or in overriding Jurisdictional instruments. Note the details of enumeration values below: &lt;ul&gt;&lt;li&gt;**LOW** - Consumption is less than the ‘lower consumption threshold’ as defined in the National Energy Retail Regulations&lt;/li&gt;&lt;li&gt;**MEDIUM** - Consumption is equal to or greater than the ‘lower consumption threshold’, but less than the ‘upper consumption threshold’, as defined in the National Energy Retail Regulations&lt;/li&gt;&lt;li&gt;**HIGH** - Consumption is equal to or greater than the ‘upper consumption threshold’ as defined in the National Energy Retail Regulations&lt;/li&gt;&lt;/ul&gt;
        /// </summary>
        /// <value>A code that defines the consumption threshold as defined in the National Energy Retail Regulations, or in overriding Jurisdictional instruments. Note the details of enumeration values below: &lt;ul&gt;&lt;li&gt;**LOW** - Consumption is less than the ‘lower consumption threshold’ as defined in the National Energy Retail Regulations&lt;/li&gt;&lt;li&gt;**MEDIUM** - Consumption is equal to or greater than the ‘lower consumption threshold’, but less than the ‘upper consumption threshold’, as defined in the National Energy Retail Regulations&lt;/li&gt;&lt;li&gt;**HIGH** - Consumption is equal to or greater than the ‘upper consumption threshold’ as defined in the National Energy Retail Regulations&lt;/li&gt;&lt;/ul&gt;</value>
        [DataMember(Name = "threshold", EmitDefaultValue = false)]
        public ThresholdEnum? Threshold { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="EnergyServicePointConsumerProfile" /> class.
        /// </summary>
        /// <param name="classification">A code that defines the consumer class as defined in the National Energy Retail Regulations, or in overriding Jurisdictional instruments.</param>
        /// <param name="threshold">A code that defines the consumption threshold as defined in the National Energy Retail Regulations, or in overriding Jurisdictional instruments. Note the details of enumeration values below: &lt;ul&gt;&lt;li&gt;**LOW** - Consumption is less than the ‘lower consumption threshold’ as defined in the National Energy Retail Regulations&lt;/li&gt;&lt;li&gt;**MEDIUM** - Consumption is equal to or greater than the ‘lower consumption threshold’, but less than the ‘upper consumption threshold’, as defined in the National Energy Retail Regulations&lt;/li&gt;&lt;li&gt;**HIGH** - Consumption is equal to or greater than the ‘upper consumption threshold’ as defined in the National Energy Retail Regulations&lt;/li&gt;&lt;/ul&gt;.</param>
        public EnergyServicePointConsumerProfile(ClassificationEnum? classification = default(ClassificationEnum?), ThresholdEnum? threshold = default(ThresholdEnum?))
        {
            this.Classification = classification;
            this.Threshold = threshold;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnergyServicePointConsumerProfile {\n");
            sb.Append("  Classification: ").Append(Classification).Append("\n");
            sb.Append("  Threshold: ").Append(Threshold).Append("\n");
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
            return this.Equals(input as EnergyServicePointConsumerProfile);
        }

        /// <summary>
        /// Returns true if EnergyServicePointConsumerProfile instances are equal
        /// </summary>
        /// <param name="input">Instance of EnergyServicePointConsumerProfile to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EnergyServicePointConsumerProfile input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Classification == input.Classification ||
                    this.Classification.Equals(input.Classification)
                ) && 
                (
                    this.Threshold == input.Threshold ||
                    this.Threshold.Equals(input.Threshold)
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
                hashCode = hashCode * 59 + this.Classification.GetHashCode();
                hashCode = hashCode * 59 + this.Threshold.GetHashCode();
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
