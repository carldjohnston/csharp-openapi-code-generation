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
    public partial class EnergyInvoiceListResponseData : IEquatable<EnergyInvoiceListResponseData>
    {
        /// <summary>
        /// Array of invoices sorted by date in descending order
        /// </summary>
        /// <value>Array of invoices sorted by date in descending order</value>
        [Required]
        [DataMember(Name="invoices", EmitDefaultValue=false)]
        public List<EnergyInvoice> Invoices { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnergyInvoiceListResponseData {\n");
            sb.Append("  Invoices: ").Append(Invoices).Append("\n");
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
            return obj.GetType() == GetType() && Equals((EnergyInvoiceListResponseData)obj);
        }

        /// <summary>
        /// Returns true if EnergyInvoiceListResponseData instances are equal
        /// </summary>
        /// <param name="other">Instance of EnergyInvoiceListResponseData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EnergyInvoiceListResponseData other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Invoices == other.Invoices ||
                    Invoices != null &&
                    other.Invoices != null &&
                    Invoices.SequenceEqual(other.Invoices)
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
                    if (Invoices != null)
                    hashCode = hashCode * 59 + Invoices.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(EnergyInvoiceListResponseData left, EnergyInvoiceListResponseData right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(EnergyInvoiceListResponseData left, EnergyInvoiceListResponseData right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
