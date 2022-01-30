/*
 * CDR Common API
 *
 * Consumer Data Standards APIs created by the Data Standards Body (DSB), with the Data Standards Chair as the decision maker to meet the needs of the Consumer Data Right
 *
 * The version of the OpenAPI document: 1.15.0
 * Contact: contact@consumerdatastandards.gov.au
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
using Agl.Cdr.Common.Converters;

namespace Agl.Cdr.Common.Models
{ 
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class CommonSimpleAddress : IEquatable<CommonSimpleAddress>
    {
        /// <summary>
        /// Name of the individual or business formatted for inclusion in an address used for physical mail
        /// </summary>
        /// <value>Name of the individual or business formatted for inclusion in an address used for physical mail</value>
        [DataMember(Name="mailingName", EmitDefaultValue=false)]
        public string MailingName { get; set; }

        /// <summary>
        /// First line of the standard address object
        /// </summary>
        /// <value>First line of the standard address object</value>
        [Required]
        [DataMember(Name="addressLine1", EmitDefaultValue=false)]
        public string AddressLine1 { get; set; }

        /// <summary>
        /// Second line of the standard address object
        /// </summary>
        /// <value>Second line of the standard address object</value>
        [DataMember(Name="addressLine2", EmitDefaultValue=false)]
        public string AddressLine2 { get; set; }

        /// <summary>
        /// Third line of the standard address object
        /// </summary>
        /// <value>Third line of the standard address object</value>
        [DataMember(Name="addressLine3", EmitDefaultValue=false)]
        public string AddressLine3 { get; set; }

        /// <summary>
        /// Mandatory for Australian addresses
        /// </summary>
        /// <value>Mandatory for Australian addresses</value>
        [DataMember(Name="postcode", EmitDefaultValue=false)]
        public string Postcode { get; set; }

        /// <summary>
        /// Name of the city or locality
        /// </summary>
        /// <value>Name of the city or locality</value>
        [Required]
        [DataMember(Name="city", EmitDefaultValue=false)]
        public string City { get; set; }

        /// <summary>
        /// Free text if the country is not Australia. If country is Australia then must be one of the values defined by the [State Type Abbreviation](https://auspost.com.au/content/dam/auspost_corp/media/documents/australia-post-data-guide.pdf) in the PAF file format. NSW, QLD, VIC, NT, WA, SA, TAS, ACT, AAT
        /// </summary>
        /// <value>Free text if the country is not Australia. If country is Australia then must be one of the values defined by the [State Type Abbreviation](https://auspost.com.au/content/dam/auspost_corp/media/documents/australia-post-data-guide.pdf) in the PAF file format. NSW, QLD, VIC, NT, WA, SA, TAS, ACT, AAT</value>
        [Required]
        [DataMember(Name="state", EmitDefaultValue=false)]
        public string State { get; set; }

        /// <summary>
        /// A valid [ISO 3166 Alpha-3](https://www.iso.org/iso-3166-country-codes.html) country code. Australia (AUS) is assumed if country is not present.
        /// </summary>
        /// <value>A valid [ISO 3166 Alpha-3](https://www.iso.org/iso-3166-country-codes.html) country code. Australia (AUS) is assumed if country is not present.</value>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; } = "AUS";

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CommonSimpleAddress {\n");
            sb.Append("  MailingName: ").Append(MailingName).Append("\n");
            sb.Append("  AddressLine1: ").Append(AddressLine1).Append("\n");
            sb.Append("  AddressLine2: ").Append(AddressLine2).Append("\n");
            sb.Append("  AddressLine3: ").Append(AddressLine3).Append("\n");
            sb.Append("  Postcode: ").Append(Postcode).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
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
            return obj.GetType() == GetType() && Equals((CommonSimpleAddress)obj);
        }

        /// <summary>
        /// Returns true if CommonSimpleAddress instances are equal
        /// </summary>
        /// <param name="other">Instance of CommonSimpleAddress to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CommonSimpleAddress other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    MailingName == other.MailingName ||
                    MailingName != null &&
                    MailingName.Equals(other.MailingName)
                ) && 
                (
                    AddressLine1 == other.AddressLine1 ||
                    AddressLine1 != null &&
                    AddressLine1.Equals(other.AddressLine1)
                ) && 
                (
                    AddressLine2 == other.AddressLine2 ||
                    AddressLine2 != null &&
                    AddressLine2.Equals(other.AddressLine2)
                ) && 
                (
                    AddressLine3 == other.AddressLine3 ||
                    AddressLine3 != null &&
                    AddressLine3.Equals(other.AddressLine3)
                ) && 
                (
                    Postcode == other.Postcode ||
                    Postcode != null &&
                    Postcode.Equals(other.Postcode)
                ) && 
                (
                    City == other.City ||
                    City != null &&
                    City.Equals(other.City)
                ) && 
                (
                    State == other.State ||
                    State != null &&
                    State.Equals(other.State)
                ) && 
                (
                    Country == other.Country ||
                    Country != null &&
                    Country.Equals(other.Country)
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
                    if (MailingName != null)
                    hashCode = hashCode * 59 + MailingName.GetHashCode();
                    if (AddressLine1 != null)
                    hashCode = hashCode * 59 + AddressLine1.GetHashCode();
                    if (AddressLine2 != null)
                    hashCode = hashCode * 59 + AddressLine2.GetHashCode();
                    if (AddressLine3 != null)
                    hashCode = hashCode * 59 + AddressLine3.GetHashCode();
                    if (Postcode != null)
                    hashCode = hashCode * 59 + Postcode.GetHashCode();
                    if (City != null)
                    hashCode = hashCode * 59 + City.GetHashCode();
                    if (State != null)
                    hashCode = hashCode * 59 + State.GetHashCode();
                    if (Country != null)
                    hashCode = hashCode * 59 + Country.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(CommonSimpleAddress left, CommonSimpleAddress right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(CommonSimpleAddress left, CommonSimpleAddress right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
