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
    /// LinksPaginated
    /// </summary>
    [DataContract(Name = "LinksPaginated")]
    public partial class LinksPaginated : IEquatable<LinksPaginated>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LinksPaginated" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LinksPaginated() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LinksPaginated" /> class.
        /// </summary>
        /// <param name="self">Fully qualified link that generated the current response document (required).</param>
        /// <param name="first">URI to the first page of this set. Mandatory if this response is not the first page.</param>
        /// <param name="prev">URI to the previous page of this set. Mandatory if this response is not the first page.</param>
        /// <param name="next">URI to the next page of this set. Mandatory if this response is not the last page.</param>
        /// <param name="last">URI to the last page of this set. Mandatory if this response is not the last page.</param>
        public LinksPaginated(string self = default(string), string first = default(string), string prev = default(string), string next = default(string), string last = default(string))
        {
            // to ensure "self" is required (not null)
            this.Self = self ?? throw new ArgumentNullException("self is a required property for LinksPaginated and cannot be null");
            this.First = first;
            this.Prev = prev;
            this.Next = next;
            this.Last = last;
        }

        /// <summary>
        /// Fully qualified link that generated the current response document
        /// </summary>
        /// <value>Fully qualified link that generated the current response document</value>
        [DataMember(Name = "self", IsRequired = true, EmitDefaultValue = false)]
        public string Self { get; set; }

        /// <summary>
        /// URI to the first page of this set. Mandatory if this response is not the first page
        /// </summary>
        /// <value>URI to the first page of this set. Mandatory if this response is not the first page</value>
        [DataMember(Name = "first", EmitDefaultValue = false)]
        public string First { get; set; }

        /// <summary>
        /// URI to the previous page of this set. Mandatory if this response is not the first page
        /// </summary>
        /// <value>URI to the previous page of this set. Mandatory if this response is not the first page</value>
        [DataMember(Name = "prev", EmitDefaultValue = false)]
        public string Prev { get; set; }

        /// <summary>
        /// URI to the next page of this set. Mandatory if this response is not the last page
        /// </summary>
        /// <value>URI to the next page of this set. Mandatory if this response is not the last page</value>
        [DataMember(Name = "next", EmitDefaultValue = false)]
        public string Next { get; set; }

        /// <summary>
        /// URI to the last page of this set. Mandatory if this response is not the last page
        /// </summary>
        /// <value>URI to the last page of this set. Mandatory if this response is not the last page</value>
        [DataMember(Name = "last", EmitDefaultValue = false)]
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
            return this.Equals(input as LinksPaginated);
        }

        /// <summary>
        /// Returns true if LinksPaginated instances are equal
        /// </summary>
        /// <param name="input">Instance of LinksPaginated to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LinksPaginated input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Self == input.Self ||
                    (this.Self != null &&
                    this.Self.Equals(input.Self))
                ) && 
                (
                    this.First == input.First ||
                    (this.First != null &&
                    this.First.Equals(input.First))
                ) && 
                (
                    this.Prev == input.Prev ||
                    (this.Prev != null &&
                    this.Prev.Equals(input.Prev))
                ) && 
                (
                    this.Next == input.Next ||
                    (this.Next != null &&
                    this.Next.Equals(input.Next))
                ) && 
                (
                    this.Last == input.Last ||
                    (this.Last != null &&
                    this.Last.Equals(input.Last))
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
                if (this.Self != null)
                    hashCode = hashCode * 59 + this.Self.GetHashCode();
                if (this.First != null)
                    hashCode = hashCode * 59 + this.First.GetHashCode();
                if (this.Prev != null)
                    hashCode = hashCode * 59 + this.Prev.GetHashCode();
                if (this.Next != null)
                    hashCode = hashCode * 59 + this.Next.GetHashCode();
                if (this.Last != null)
                    hashCode = hashCode * 59 + this.Last.GetHashCode();
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
