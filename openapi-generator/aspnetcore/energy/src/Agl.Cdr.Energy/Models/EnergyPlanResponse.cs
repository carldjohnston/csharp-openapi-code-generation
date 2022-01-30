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
    public partial class EnergyPlanResponse : IEquatable<EnergyPlanResponse>
    {
        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [Required]
        [DataMember(Name="data", EmitDefaultValue=false)]
        public EnergyPlanDetail Data { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [Required]
        [DataMember(Name="links", EmitDefaultValue=false)]
        public Links Links { get; set; }

        /// <summary>
        /// Gets or Sets Meta
        /// </summary>
        [Required]
        [DataMember(Name="meta", EmitDefaultValue=false)]
        public Object Meta { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnergyPlanResponse {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  Meta: ").Append(Meta).Append("\n");
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
            return obj.GetType() == GetType() && Equals((EnergyPlanResponse)obj);
        }

        /// <summary>
        /// Returns true if EnergyPlanResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of EnergyPlanResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EnergyPlanResponse other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Data == other.Data ||
                    Data != null &&
                    Data.Equals(other.Data)
                ) && 
                (
                    Links == other.Links ||
                    Links != null &&
                    Links.Equals(other.Links)
                ) && 
                (
                    Meta == other.Meta ||
                    Meta != null &&
                    Meta.Equals(other.Meta)
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
                    if (Data != null)
                    hashCode = hashCode * 59 + Data.GetHashCode();
                    if (Links != null)
                    hashCode = hashCode * 59 + Links.GetHashCode();
                    if (Meta != null)
                    hashCode = hashCode * 59 + Meta.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(EnergyPlanResponse left, EnergyPlanResponse right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(EnergyPlanResponse left, EnergyPlanResponse right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
