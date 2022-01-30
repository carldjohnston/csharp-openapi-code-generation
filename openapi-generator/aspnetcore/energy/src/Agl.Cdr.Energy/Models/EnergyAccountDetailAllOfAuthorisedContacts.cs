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
    public partial class EnergyAccountDetailAllOfAuthorisedContacts : IEquatable<EnergyAccountDetailAllOfAuthorisedContacts>
    {
        /// <summary>
        /// For people with single names this field need not be present. The single name should be in the lastName field
        /// </summary>
        /// <value>For people with single names this field need not be present. The single name should be in the lastName field</value>
        [DataMember(Name="firstName", EmitDefaultValue=false)]
        public string FirstName { get; set; }

        /// <summary>
        /// For people with single names the single name should be in this field
        /// </summary>
        /// <value>For people with single names the single name should be in this field</value>
        [Required]
        [DataMember(Name="lastName", EmitDefaultValue=false)]
        public string LastName { get; set; }

        /// <summary>
        /// Field is mandatory but array may be empty
        /// </summary>
        /// <value>Field is mandatory but array may be empty</value>
        [DataMember(Name="middleNames", EmitDefaultValue=false)]
        public List<string> MiddleNames { get; set; }

        /// <summary>
        /// Also known as title or salutation. The prefix to the name (e.g. Mr, Mrs, Ms, Miss, Sir, etc)
        /// </summary>
        /// <value>Also known as title or salutation. The prefix to the name (e.g. Mr, Mrs, Ms, Miss, Sir, etc)</value>
        [DataMember(Name="prefix", EmitDefaultValue=false)]
        public string Prefix { get; set; }

        /// <summary>
        /// Used for a trailing suffix to the name (e.g. Jr)
        /// </summary>
        /// <value>Used for a trailing suffix to the name (e.g. Jr)</value>
        [DataMember(Name="suffix", EmitDefaultValue=false)]
        public string Suffix { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnergyAccountDetailAllOfAuthorisedContacts {\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  MiddleNames: ").Append(MiddleNames).Append("\n");
            sb.Append("  Prefix: ").Append(Prefix).Append("\n");
            sb.Append("  Suffix: ").Append(Suffix).Append("\n");
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
            return obj.GetType() == GetType() && Equals((EnergyAccountDetailAllOfAuthorisedContacts)obj);
        }

        /// <summary>
        /// Returns true if EnergyAccountDetailAllOfAuthorisedContacts instances are equal
        /// </summary>
        /// <param name="other">Instance of EnergyAccountDetailAllOfAuthorisedContacts to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EnergyAccountDetailAllOfAuthorisedContacts other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    FirstName == other.FirstName ||
                    FirstName != null &&
                    FirstName.Equals(other.FirstName)
                ) && 
                (
                    LastName == other.LastName ||
                    LastName != null &&
                    LastName.Equals(other.LastName)
                ) && 
                (
                    MiddleNames == other.MiddleNames ||
                    MiddleNames != null &&
                    other.MiddleNames != null &&
                    MiddleNames.SequenceEqual(other.MiddleNames)
                ) && 
                (
                    Prefix == other.Prefix ||
                    Prefix != null &&
                    Prefix.Equals(other.Prefix)
                ) && 
                (
                    Suffix == other.Suffix ||
                    Suffix != null &&
                    Suffix.Equals(other.Suffix)
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
                    if (FirstName != null)
                    hashCode = hashCode * 59 + FirstName.GetHashCode();
                    if (LastName != null)
                    hashCode = hashCode * 59 + LastName.GetHashCode();
                    if (MiddleNames != null)
                    hashCode = hashCode * 59 + MiddleNames.GetHashCode();
                    if (Prefix != null)
                    hashCode = hashCode * 59 + Prefix.GetHashCode();
                    if (Suffix != null)
                    hashCode = hashCode * 59 + Suffix.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(EnergyAccountDetailAllOfAuthorisedContacts left, EnergyAccountDetailAllOfAuthorisedContacts right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(EnergyAccountDetailAllOfAuthorisedContacts left, EnergyAccountDetailAllOfAuthorisedContacts right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
