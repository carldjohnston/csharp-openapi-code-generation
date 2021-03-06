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
    public partial class LinksPaginated : IEquatable<LinksPaginated>
    {
        /// <summary>
        /// Fully qualified link that generated the current response document
        /// </summary>
        /// <value>Fully qualified link that generated the current response document</value>
        [Required]
        [DataMember(Name="self", EmitDefaultValue=false)]
        public string Self { get; set; }

        /// <summary>
        /// URI to the first page of this set. Mandatory if this response is not the first page
        /// </summary>
        /// <value>URI to the first page of this set. Mandatory if this response is not the first page</value>
        [DataMember(Name="first", EmitDefaultValue=false)]
        public string First { get; set; }

        /// <summary>
        /// URI to the previous page of this set. Mandatory if this response is not the first page
        /// </summary>
        /// <value>URI to the previous page of this set. Mandatory if this response is not the first page</value>
        [DataMember(Name="prev", EmitDefaultValue=false)]
        public string Prev { get; set; }

        /// <summary>
        /// URI to the next page of this set. Mandatory if this response is not the last page
        /// </summary>
        /// <value>URI to the next page of this set. Mandatory if this response is not the last page</value>
        [DataMember(Name="next", EmitDefaultValue=false)]
        public string Next { get; set; }

        /// <summary>
        /// URI to the last page of this set. Mandatory if this response is not the last page
        /// </summary>
        /// <value>URI to the last page of this set. Mandatory if this response is not the last page</value>
        [DataMember(Name="last", EmitDefaultValue=false)]
        public string Last { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LinksPaginated {\n");
            sb.Append("  Self: ").Append(Self).Append("\n");
            sb.Append("  First: ").Append(First).Append("\n");
            sb.Append("  Prev: ").Append(Prev).Append("\n");
            sb.Append("  Next: ").Append(Next).Append("\n");
            sb.Append("  Last: ").Append(Last).Append("\n");
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
            return obj.GetType() == GetType() && Equals((LinksPaginated)obj);
        }

        /// <summary>
        /// Returns true if LinksPaginated instances are equal
        /// </summary>
        /// <param name="other">Instance of LinksPaginated to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LinksPaginated other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Self == other.Self ||
                    Self != null &&
                    Self.Equals(other.Self)
                ) && 
                (
                    First == other.First ||
                    First != null &&
                    First.Equals(other.First)
                ) && 
                (
                    Prev == other.Prev ||
                    Prev != null &&
                    Prev.Equals(other.Prev)
                ) && 
                (
                    Next == other.Next ||
                    Next != null &&
                    Next.Equals(other.Next)
                ) && 
                (
                    Last == other.Last ||
                    Last != null &&
                    Last.Equals(other.Last)
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
                    if (Self != null)
                    hashCode = hashCode * 59 + Self.GetHashCode();
                    if (First != null)
                    hashCode = hashCode * 59 + First.GetHashCode();
                    if (Prev != null)
                    hashCode = hashCode * 59 + Prev.GetHashCode();
                    if (Next != null)
                    hashCode = hashCode * 59 + Next.GetHashCode();
                    if (Last != null)
                    hashCode = hashCode * 59 + Last.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(LinksPaginated left, LinksPaginated right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(LinksPaginated left, LinksPaginated right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
