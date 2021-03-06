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
    public partial class EnergyServicePointConsumerProfile : IEquatable<EnergyServicePointConsumerProfile>
    {

        /// <summary>
        /// A code that defines the consumer class as defined in the National Energy Retail Regulations, or in overriding Jurisdictional instruments
        /// </summary>
        /// <value>A code that defines the consumer class as defined in the National Energy Retail Regulations, or in overriding Jurisdictional instruments</value>
        [TypeConverter(typeof(CustomEnumConverter<ClassificationEnum>))]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ClassificationEnum
        {
            
            /// <summary>
            /// Enum BUSINESSEnum for BUSINESS
            /// </summary>
            [EnumMember(Value = "BUSINESS")]
            BUSINESSEnum = 1,
            
            /// <summary>
            /// Enum RESIDENTIALEnum for RESIDENTIAL
            /// </summary>
            [EnumMember(Value = "RESIDENTIAL")]
            RESIDENTIALEnum = 2
        }

        /// <summary>
        /// A code that defines the consumer class as defined in the National Energy Retail Regulations, or in overriding Jurisdictional instruments
        /// </summary>
        /// <value>A code that defines the consumer class as defined in the National Energy Retail Regulations, or in overriding Jurisdictional instruments</value>
        [DataMember(Name="classification", EmitDefaultValue=false)]
        public ClassificationEnum Classification { get; set; }


        /// <summary>
        /// A code that defines the consumption threshold as defined in the National Energy Retail Regulations, or in overriding Jurisdictional instruments. Note the details of enumeration values below: <ul><li>**LOW** - Consumption is less than the ???lower consumption threshold??? as defined in the National Energy Retail Regulations</li><li>**MEDIUM** - Consumption is equal to or greater than the ???lower consumption threshold???, but less than the ???upper consumption threshold???, as defined in the National Energy Retail Regulations</li><li>**HIGH** - Consumption is equal to or greater than the ???upper consumption threshold??? as defined in the National Energy Retail Regulations</li></ul>
        /// </summary>
        /// <value>A code that defines the consumption threshold as defined in the National Energy Retail Regulations, or in overriding Jurisdictional instruments. Note the details of enumeration values below: <ul><li>**LOW** - Consumption is less than the ???lower consumption threshold??? as defined in the National Energy Retail Regulations</li><li>**MEDIUM** - Consumption is equal to or greater than the ???lower consumption threshold???, but less than the ???upper consumption threshold???, as defined in the National Energy Retail Regulations</li><li>**HIGH** - Consumption is equal to or greater than the ???upper consumption threshold??? as defined in the National Energy Retail Regulations</li></ul></value>
        [TypeConverter(typeof(CustomEnumConverter<ThresholdEnum>))]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ThresholdEnum
        {
            
            /// <summary>
            /// Enum LOWEnum for LOW
            /// </summary>
            [EnumMember(Value = "LOW")]
            LOWEnum = 1,
            
            /// <summary>
            /// Enum MEDIUMEnum for MEDIUM
            /// </summary>
            [EnumMember(Value = "MEDIUM")]
            MEDIUMEnum = 2,
            
            /// <summary>
            /// Enum HIGHEnum for HIGH
            /// </summary>
            [EnumMember(Value = "HIGH")]
            HIGHEnum = 3
        }

        /// <summary>
        /// A code that defines the consumption threshold as defined in the National Energy Retail Regulations, or in overriding Jurisdictional instruments. Note the details of enumeration values below: &lt;ul&gt;&lt;li&gt;**LOW** - Consumption is less than the ???lower consumption threshold??? as defined in the National Energy Retail Regulations&lt;/li&gt;&lt;li&gt;**MEDIUM** - Consumption is equal to or greater than the ???lower consumption threshold???, but less than the ???upper consumption threshold???, as defined in the National Energy Retail Regulations&lt;/li&gt;&lt;li&gt;**HIGH** - Consumption is equal to or greater than the ???upper consumption threshold??? as defined in the National Energy Retail Regulations&lt;/li&gt;&lt;/ul&gt;
        /// </summary>
        /// <value>A code that defines the consumption threshold as defined in the National Energy Retail Regulations, or in overriding Jurisdictional instruments. Note the details of enumeration values below: &lt;ul&gt;&lt;li&gt;**LOW** - Consumption is less than the ???lower consumption threshold??? as defined in the National Energy Retail Regulations&lt;/li&gt;&lt;li&gt;**MEDIUM** - Consumption is equal to or greater than the ???lower consumption threshold???, but less than the ???upper consumption threshold???, as defined in the National Energy Retail Regulations&lt;/li&gt;&lt;li&gt;**HIGH** - Consumption is equal to or greater than the ???upper consumption threshold??? as defined in the National Energy Retail Regulations&lt;/li&gt;&lt;/ul&gt;</value>
        [DataMember(Name="threshold", EmitDefaultValue=false)]
        public ThresholdEnum Threshold { get; set; }

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
            return obj.GetType() == GetType() && Equals((EnergyServicePointConsumerProfile)obj);
        }

        /// <summary>
        /// Returns true if EnergyServicePointConsumerProfile instances are equal
        /// </summary>
        /// <param name="other">Instance of EnergyServicePointConsumerProfile to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EnergyServicePointConsumerProfile other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Classification == other.Classification ||
                    
                    Classification.Equals(other.Classification)
                ) && 
                (
                    Threshold == other.Threshold ||
                    
                    Threshold.Equals(other.Threshold)
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
                    
                    hashCode = hashCode * 59 + Classification.GetHashCode();
                    
                    hashCode = hashCode * 59 + Threshold.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(EnergyServicePointConsumerProfile left, EnergyServicePointConsumerProfile right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(EnergyServicePointConsumerProfile left, EnergyServicePointConsumerProfile right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
