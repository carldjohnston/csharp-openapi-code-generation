/*
 * CDR Common API
 *
 * Consumer Data Standards APIs created by the Data Standards Body (DSB), with the Data Standards Chair as the decision maker to meet the needs of the Consumer Data Right
 *
 * The version of the OpenAPI document: 1.15.0
 * Contact: contact@consumerdatastandards.gov.au
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
using OpenAPIDateConverter = Agl.Cdr.Common.Client.OpenAPIDateConverter;

namespace Agl.Cdr.Common.Models
{
    /// <summary>
    /// CommonSimpleAddress
    /// </summary>
    [DataContract(Name = "CommonSimpleAddress")]
    public partial class CommonSimpleAddress : IEquatable<CommonSimpleAddress>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CommonSimpleAddress" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CommonSimpleAddress() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CommonSimpleAddress" /> class.
        /// </summary>
        /// <param name="mailingName">Name of the individual or business formatted for inclusion in an address used for physical mail.</param>
        /// <param name="addressLine1">First line of the standard address object (required).</param>
        /// <param name="addressLine2">Second line of the standard address object.</param>
        /// <param name="addressLine3">Third line of the standard address object.</param>
        /// <param name="postcode">Mandatory for Australian addresses.</param>
        /// <param name="city">Name of the city or locality (required).</param>
        /// <param name="state">Free text if the country is not Australia. If country is Australia then must be one of the values defined by the [State Type Abbreviation](https://auspost.com.au/content/dam/auspost_corp/media/documents/australia-post-data-guide.pdf) in the PAF file format. NSW, QLD, VIC, NT, WA, SA, TAS, ACT, AAT (required).</param>
        /// <param name="country">A valid [ISO 3166 Alpha-3](https://www.iso.org/iso-3166-country-codes.html) country code. Australia (AUS) is assumed if country is not present. (default to &quot;AUS&quot;).</param>
        public CommonSimpleAddress(string mailingName = default(string), string addressLine1 = default(string), string addressLine2 = default(string), string addressLine3 = default(string), string postcode = default(string), string city = default(string), string state = default(string), string country = "AUS")
        {
            // to ensure "addressLine1" is required (not null)
            this.AddressLine1 = addressLine1 ?? throw new ArgumentNullException("addressLine1 is a required property for CommonSimpleAddress and cannot be null");
            // to ensure "city" is required (not null)
            this.City = city ?? throw new ArgumentNullException("city is a required property for CommonSimpleAddress and cannot be null");
            // to ensure "state" is required (not null)
            this.State = state ?? throw new ArgumentNullException("state is a required property for CommonSimpleAddress and cannot be null");
            this.MailingName = mailingName;
            this.AddressLine2 = addressLine2;
            this.AddressLine3 = addressLine3;
            this.Postcode = postcode;
            // use default value if no "country" provided
            this.Country = country ?? "AUS";
        }

        /// <summary>
        /// Name of the individual or business formatted for inclusion in an address used for physical mail
        /// </summary>
        /// <value>Name of the individual or business formatted for inclusion in an address used for physical mail</value>
        [DataMember(Name = "mailingName", EmitDefaultValue = false)]
        public string MailingName { get; set; }

        /// <summary>
        /// First line of the standard address object
        /// </summary>
        /// <value>First line of the standard address object</value>
        [DataMember(Name = "addressLine1", IsRequired = true, EmitDefaultValue = false)]
        public string AddressLine1 { get; set; }

        /// <summary>
        /// Second line of the standard address object
        /// </summary>
        /// <value>Second line of the standard address object</value>
        [DataMember(Name = "addressLine2", EmitDefaultValue = false)]
        public string AddressLine2 { get; set; }

        /// <summary>
        /// Third line of the standard address object
        /// </summary>
        /// <value>Third line of the standard address object</value>
        [DataMember(Name = "addressLine3", EmitDefaultValue = false)]
        public string AddressLine3 { get; set; }

        /// <summary>
        /// Mandatory for Australian addresses
        /// </summary>
        /// <value>Mandatory for Australian addresses</value>
        [DataMember(Name = "postcode", EmitDefaultValue = false)]
        public string Postcode { get; set; }

        /// <summary>
        /// Name of the city or locality
        /// </summary>
        /// <value>Name of the city or locality</value>
        [DataMember(Name = "city", IsRequired = true, EmitDefaultValue = false)]
        public string City { get; set; }

        /// <summary>
        /// Free text if the country is not Australia. If country is Australia then must be one of the values defined by the [State Type Abbreviation](https://auspost.com.au/content/dam/auspost_corp/media/documents/australia-post-data-guide.pdf) in the PAF file format. NSW, QLD, VIC, NT, WA, SA, TAS, ACT, AAT
        /// </summary>
        /// <value>Free text if the country is not Australia. If country is Australia then must be one of the values defined by the [State Type Abbreviation](https://auspost.com.au/content/dam/auspost_corp/media/documents/australia-post-data-guide.pdf) in the PAF file format. NSW, QLD, VIC, NT, WA, SA, TAS, ACT, AAT</value>
        [DataMember(Name = "state", IsRequired = true, EmitDefaultValue = false)]
        public string State { get; set; }

        /// <summary>
        /// A valid [ISO 3166 Alpha-3](https://www.iso.org/iso-3166-country-codes.html) country code. Australia (AUS) is assumed if country is not present.
        /// </summary>
        /// <value>A valid [ISO 3166 Alpha-3](https://www.iso.org/iso-3166-country-codes.html) country code. Australia (AUS) is assumed if country is not present.</value>
        [DataMember(Name = "country", EmitDefaultValue = false)]
        public string Country { get; set; }

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
            return this.Equals(input as CommonSimpleAddress);
        }

        /// <summary>
        /// Returns true if CommonSimpleAddress instances are equal
        /// </summary>
        /// <param name="input">Instance of CommonSimpleAddress to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CommonSimpleAddress input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MailingName == input.MailingName ||
                    (this.MailingName != null &&
                    this.MailingName.Equals(input.MailingName))
                ) && 
                (
                    this.AddressLine1 == input.AddressLine1 ||
                    (this.AddressLine1 != null &&
                    this.AddressLine1.Equals(input.AddressLine1))
                ) && 
                (
                    this.AddressLine2 == input.AddressLine2 ||
                    (this.AddressLine2 != null &&
                    this.AddressLine2.Equals(input.AddressLine2))
                ) && 
                (
                    this.AddressLine3 == input.AddressLine3 ||
                    (this.AddressLine3 != null &&
                    this.AddressLine3.Equals(input.AddressLine3))
                ) && 
                (
                    this.Postcode == input.Postcode ||
                    (this.Postcode != null &&
                    this.Postcode.Equals(input.Postcode))
                ) && 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
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
                if (this.MailingName != null)
                    hashCode = hashCode * 59 + this.MailingName.GetHashCode();
                if (this.AddressLine1 != null)
                    hashCode = hashCode * 59 + this.AddressLine1.GetHashCode();
                if (this.AddressLine2 != null)
                    hashCode = hashCode * 59 + this.AddressLine2.GetHashCode();
                if (this.AddressLine3 != null)
                    hashCode = hashCode * 59 + this.AddressLine3.GetHashCode();
                if (this.Postcode != null)
                    hashCode = hashCode * 59 + this.Postcode.GetHashCode();
                if (this.City != null)
                    hashCode = hashCode * 59 + this.City.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
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
