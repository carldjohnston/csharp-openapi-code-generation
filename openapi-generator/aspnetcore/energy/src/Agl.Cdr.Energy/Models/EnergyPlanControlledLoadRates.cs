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
    public partial class EnergyPlanControlledLoadRates : IEquatable<EnergyPlanControlledLoadRates>
    {
        /// <summary>
        /// Unit price of usage per kWh (exclusive of GST)
        /// </summary>
        /// <value>Unit price of usage per kWh (exclusive of GST)</value>
        [Required]
        [DataMember(Name="unitPrice", EmitDefaultValue=false)]
        public string UnitPrice { get; set; }

        /// <summary>
        /// Volume in kWh that this rate applies to.  Only applicable for ‘stepped’ rates where different rates apply for different volumes of usage in a period
        /// </summary>
        /// <value>Volume in kWh that this rate applies to.  Only applicable for ‘stepped’ rates where different rates apply for different volumes of usage in a period</value>
        [DataMember(Name="volume", EmitDefaultValue=false)]
        public decimal Volume { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnergyPlanControlledLoadRates {\n");
            sb.Append("  UnitPrice: ").Append(UnitPrice).Append("\n");
            sb.Append("  Volume: ").Append(Volume).Append("\n");
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
            return obj.GetType() == GetType() && Equals((EnergyPlanControlledLoadRates)obj);
        }

        /// <summary>
        /// Returns true if EnergyPlanControlledLoadRates instances are equal
        /// </summary>
        /// <param name="other">Instance of EnergyPlanControlledLoadRates to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EnergyPlanControlledLoadRates other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    UnitPrice == other.UnitPrice ||
                    UnitPrice != null &&
                    UnitPrice.Equals(other.UnitPrice)
                ) && 
                (
                    Volume == other.Volume ||
                    
                    Volume.Equals(other.Volume)
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
                    if (UnitPrice != null)
                    hashCode = hashCode * 59 + UnitPrice.GetHashCode();
                    
                    hashCode = hashCode * 59 + Volume.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(EnergyPlanControlledLoadRates left, EnergyPlanControlledLoadRates right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(EnergyPlanControlledLoadRates left, EnergyPlanControlledLoadRates right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
