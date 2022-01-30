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
    /// CommonPersonDetailV2
    /// </summary>
    [DataContract(Name = "CommonPersonDetailV2")]
    public partial class CommonPersonDetailV2 : IEquatable<CommonPersonDetailV2>, IValidatableObject
    {
        /// <summary>
        /// The applicable [ANZSCO](http://www.abs.gov.au/ANZSCO) release version of the occupation code provided. Mandatory if an &#x60;&#x60;occupationCode&#x60;&#x60; is supplied. If &#x60;&#x60;occupationCode&#x60;&#x60; is supplied but &#x60;&#x60;occupationCodeVersion&#x60;&#x60; is absent, default is &#x60;&#x60;ANZSCO_1220.0_2013_V1.2&#x60;&#x60;
        /// </summary>
        /// <value>The applicable [ANZSCO](http://www.abs.gov.au/ANZSCO) release version of the occupation code provided. Mandatory if an &#x60;&#x60;occupationCode&#x60;&#x60; is supplied. If &#x60;&#x60;occupationCode&#x60;&#x60; is supplied but &#x60;&#x60;occupationCodeVersion&#x60;&#x60; is absent, default is &#x60;&#x60;ANZSCO_1220.0_2013_V1.2&#x60;&#x60;</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OccupationCodeVersionEnum
        {
            /// <summary>
            /// Enum _2006V10 for value: ANZSCO_1220.0_2006_V1.0
            /// </summary>
            [EnumMember(Value = "ANZSCO_1220.0_2006_V1.0")]
            _2006V10 = 1,

            /// <summary>
            /// Enum _2006V11 for value: ANZSCO_1220.0_2006_V1.1
            /// </summary>
            [EnumMember(Value = "ANZSCO_1220.0_2006_V1.1")]
            _2006V11 = 2,

            /// <summary>
            /// Enum _2013V12 for value: ANZSCO_1220.0_2013_V1.2
            /// </summary>
            [EnumMember(Value = "ANZSCO_1220.0_2013_V1.2")]
            _2013V12 = 3,

            /// <summary>
            /// Enum _2013V13 for value: ANZSCO_1220.0_2013_V1.3
            /// </summary>
            [EnumMember(Value = "ANZSCO_1220.0_2013_V1.3")]
            _2013V13 = 4

        }


        /// <summary>
        /// The applicable [ANZSCO](http://www.abs.gov.au/ANZSCO) release version of the occupation code provided. Mandatory if an &#x60;&#x60;occupationCode&#x60;&#x60; is supplied. If &#x60;&#x60;occupationCode&#x60;&#x60; is supplied but &#x60;&#x60;occupationCodeVersion&#x60;&#x60; is absent, default is &#x60;&#x60;ANZSCO_1220.0_2013_V1.2&#x60;&#x60;
        /// </summary>
        /// <value>The applicable [ANZSCO](http://www.abs.gov.au/ANZSCO) release version of the occupation code provided. Mandatory if an &#x60;&#x60;occupationCode&#x60;&#x60; is supplied. If &#x60;&#x60;occupationCode&#x60;&#x60; is supplied but &#x60;&#x60;occupationCodeVersion&#x60;&#x60; is absent, default is &#x60;&#x60;ANZSCO_1220.0_2013_V1.2&#x60;&#x60;</value>
        [DataMember(Name = "occupationCodeVersion", EmitDefaultValue = false)]
        public OccupationCodeVersionEnum? OccupationCodeVersion { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CommonPersonDetailV2" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CommonPersonDetailV2() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CommonPersonDetailV2" /> class.
        /// </summary>
        /// <param name="lastUpdateTime">The date and time that this record was last updated by the customer.  If no update has occurred then this date should reflect the initial creation date for the data.</param>
        /// <param name="firstName">For people with single names this field need not be present. The single name should be in the lastName field. Where a data holder cannot determine first and middle names from a collection of given names, a single string representing all given names MAY be provided..</param>
        /// <param name="lastName">For people with single names the single name should be in this field (required).</param>
        /// <param name="middleNames">Field is mandatory but array may be empty (required).</param>
        /// <param name="prefix">Also known as title or salutation.  The prefix to the name (e.g. Mr, Mrs, Ms, Miss, Sir, etc).</param>
        /// <param name="suffix">Used for a trailing suffix to the name (e.g. Jr).</param>
        /// <param name="occupationCode">Value is a valid [ANZSCO](http://www.abs.gov.au/ANZSCO) Standard Occupation classification code. If the occupation code held by the data holder is not one of the supported [ANZSCO](http://www.abs.gov.au/ANZSCO) versions, then it must not be supplied..</param>
        /// <param name="occupationCodeVersion">The applicable [ANZSCO](http://www.abs.gov.au/ANZSCO) release version of the occupation code provided. Mandatory if an &#x60;&#x60;occupationCode&#x60;&#x60; is supplied. If &#x60;&#x60;occupationCode&#x60;&#x60; is supplied but &#x60;&#x60;occupationCodeVersion&#x60;&#x60; is absent, default is &#x60;&#x60;ANZSCO_1220.0_2013_V1.2&#x60;&#x60; (default to OccupationCodeVersionEnum._2013V12).</param>
        /// <param name="phoneNumbers">Array is mandatory but may be empty if no phone numbers are held (required).</param>
        /// <param name="emailAddresses">May be empty (required).</param>
        /// <param name="physicalAddresses">Array is mandatory but may be empty if no valid addresses are held. One and only one address may have the purpose of REGISTERED. Zero or one, and no more than one, record may have the purpose of MAIL. If zero then the REGISTERED address is to be used for mail (required).</param>
        public CommonPersonDetailV2(string lastUpdateTime = default(string), string firstName = default(string), string lastName = default(string), List<string> middleNames = default(List<string>), string prefix = default(string), string suffix = default(string), string occupationCode = default(string), OccupationCodeVersionEnum? occupationCodeVersion = OccupationCodeVersionEnum._2013V12, List<CommonPhoneNumber> phoneNumbers = default(List<CommonPhoneNumber>), List<CommonEmailAddress> emailAddresses = default(List<CommonEmailAddress>), List<CommonPhysicalAddressWithPurpose1> physicalAddresses = default(List<CommonPhysicalAddressWithPurpose1>))
        {
            // to ensure "lastName" is required (not null)
            this.LastName = lastName ?? throw new ArgumentNullException("lastName is a required property for CommonPersonDetailV2 and cannot be null");
            // to ensure "middleNames" is required (not null)
            this.MiddleNames = middleNames ?? throw new ArgumentNullException("middleNames is a required property for CommonPersonDetailV2 and cannot be null");
            // to ensure "phoneNumbers" is required (not null)
            this.PhoneNumbers = phoneNumbers ?? throw new ArgumentNullException("phoneNumbers is a required property for CommonPersonDetailV2 and cannot be null");
            // to ensure "emailAddresses" is required (not null)
            this.EmailAddresses = emailAddresses ?? throw new ArgumentNullException("emailAddresses is a required property for CommonPersonDetailV2 and cannot be null");
            // to ensure "physicalAddresses" is required (not null)
            this.PhysicalAddresses = physicalAddresses ?? throw new ArgumentNullException("physicalAddresses is a required property for CommonPersonDetailV2 and cannot be null");
            this.LastUpdateTime = lastUpdateTime;
            this.FirstName = firstName;
            this.Prefix = prefix;
            this.Suffix = suffix;
            this.OccupationCode = occupationCode;
            this.OccupationCodeVersion = occupationCodeVersion;
        }

        /// <summary>
        /// The date and time that this record was last updated by the customer.  If no update has occurred then this date should reflect the initial creation date for the data
        /// </summary>
        /// <value>The date and time that this record was last updated by the customer.  If no update has occurred then this date should reflect the initial creation date for the data</value>
        [DataMember(Name = "lastUpdateTime", EmitDefaultValue = false)]
        public string LastUpdateTime { get; set; }

        /// <summary>
        /// For people with single names this field need not be present. The single name should be in the lastName field. Where a data holder cannot determine first and middle names from a collection of given names, a single string representing all given names MAY be provided.
        /// </summary>
        /// <value>For people with single names this field need not be present. The single name should be in the lastName field. Where a data holder cannot determine first and middle names from a collection of given names, a single string representing all given names MAY be provided.</value>
        [DataMember(Name = "firstName", EmitDefaultValue = false)]
        public string FirstName { get; set; }

        /// <summary>
        /// For people with single names the single name should be in this field
        /// </summary>
        /// <value>For people with single names the single name should be in this field</value>
        [DataMember(Name = "lastName", IsRequired = true, EmitDefaultValue = false)]
        public string LastName { get; set; }

        /// <summary>
        /// Field is mandatory but array may be empty
        /// </summary>
        /// <value>Field is mandatory but array may be empty</value>
        [DataMember(Name = "middleNames", IsRequired = true, EmitDefaultValue = false)]
        public List<string> MiddleNames { get; set; }

        /// <summary>
        /// Also known as title or salutation.  The prefix to the name (e.g. Mr, Mrs, Ms, Miss, Sir, etc)
        /// </summary>
        /// <value>Also known as title or salutation.  The prefix to the name (e.g. Mr, Mrs, Ms, Miss, Sir, etc)</value>
        [DataMember(Name = "prefix", EmitDefaultValue = false)]
        public string Prefix { get; set; }

        /// <summary>
        /// Used for a trailing suffix to the name (e.g. Jr)
        /// </summary>
        /// <value>Used for a trailing suffix to the name (e.g. Jr)</value>
        [DataMember(Name = "suffix", EmitDefaultValue = false)]
        public string Suffix { get; set; }

        /// <summary>
        /// Value is a valid [ANZSCO](http://www.abs.gov.au/ANZSCO) Standard Occupation classification code. If the occupation code held by the data holder is not one of the supported [ANZSCO](http://www.abs.gov.au/ANZSCO) versions, then it must not be supplied.
        /// </summary>
        /// <value>Value is a valid [ANZSCO](http://www.abs.gov.au/ANZSCO) Standard Occupation classification code. If the occupation code held by the data holder is not one of the supported [ANZSCO](http://www.abs.gov.au/ANZSCO) versions, then it must not be supplied.</value>
        [DataMember(Name = "occupationCode", EmitDefaultValue = false)]
        public string OccupationCode { get; set; }

        /// <summary>
        /// Array is mandatory but may be empty if no phone numbers are held
        /// </summary>
        /// <value>Array is mandatory but may be empty if no phone numbers are held</value>
        [DataMember(Name = "phoneNumbers", IsRequired = true, EmitDefaultValue = false)]
        public List<CommonPhoneNumber> PhoneNumbers { get; set; }

        /// <summary>
        /// May be empty
        /// </summary>
        /// <value>May be empty</value>
        [DataMember(Name = "emailAddresses", IsRequired = true, EmitDefaultValue = false)]
        public List<CommonEmailAddress> EmailAddresses { get; set; }

        /// <summary>
        /// Array is mandatory but may be empty if no valid addresses are held. One and only one address may have the purpose of REGISTERED. Zero or one, and no more than one, record may have the purpose of MAIL. If zero then the REGISTERED address is to be used for mail
        /// </summary>
        /// <value>Array is mandatory but may be empty if no valid addresses are held. One and only one address may have the purpose of REGISTERED. Zero or one, and no more than one, record may have the purpose of MAIL. If zero then the REGISTERED address is to be used for mail</value>
        [DataMember(Name = "physicalAddresses", IsRequired = true, EmitDefaultValue = false)]
        public List<CommonPhysicalAddressWithPurpose1> PhysicalAddresses { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CommonPersonDetailV2 {\n");
            sb.Append("  LastUpdateTime: ").Append(LastUpdateTime).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  MiddleNames: ").Append(MiddleNames).Append("\n");
            sb.Append("  Prefix: ").Append(Prefix).Append("\n");
            sb.Append("  Suffix: ").Append(Suffix).Append("\n");
            sb.Append("  OccupationCode: ").Append(OccupationCode).Append("\n");
            sb.Append("  OccupationCodeVersion: ").Append(OccupationCodeVersion).Append("\n");
            sb.Append("  PhoneNumbers: ").Append(PhoneNumbers).Append("\n");
            sb.Append("  EmailAddresses: ").Append(EmailAddresses).Append("\n");
            sb.Append("  PhysicalAddresses: ").Append(PhysicalAddresses).Append("\n");
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
            return this.Equals(input as CommonPersonDetailV2);
        }

        /// <summary>
        /// Returns true if CommonPersonDetailV2 instances are equal
        /// </summary>
        /// <param name="input">Instance of CommonPersonDetailV2 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CommonPersonDetailV2 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LastUpdateTime == input.LastUpdateTime ||
                    (this.LastUpdateTime != null &&
                    this.LastUpdateTime.Equals(input.LastUpdateTime))
                ) && 
                (
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) && 
                (
                    this.LastName == input.LastName ||
                    (this.LastName != null &&
                    this.LastName.Equals(input.LastName))
                ) && 
                (
                    this.MiddleNames == input.MiddleNames ||
                    this.MiddleNames != null &&
                    input.MiddleNames != null &&
                    this.MiddleNames.SequenceEqual(input.MiddleNames)
                ) && 
                (
                    this.Prefix == input.Prefix ||
                    (this.Prefix != null &&
                    this.Prefix.Equals(input.Prefix))
                ) && 
                (
                    this.Suffix == input.Suffix ||
                    (this.Suffix != null &&
                    this.Suffix.Equals(input.Suffix))
                ) && 
                (
                    this.OccupationCode == input.OccupationCode ||
                    (this.OccupationCode != null &&
                    this.OccupationCode.Equals(input.OccupationCode))
                ) && 
                (
                    this.OccupationCodeVersion == input.OccupationCodeVersion ||
                    this.OccupationCodeVersion.Equals(input.OccupationCodeVersion)
                ) && 
                (
                    this.PhoneNumbers == input.PhoneNumbers ||
                    this.PhoneNumbers != null &&
                    input.PhoneNumbers != null &&
                    this.PhoneNumbers.SequenceEqual(input.PhoneNumbers)
                ) && 
                (
                    this.EmailAddresses == input.EmailAddresses ||
                    this.EmailAddresses != null &&
                    input.EmailAddresses != null &&
                    this.EmailAddresses.SequenceEqual(input.EmailAddresses)
                ) && 
                (
                    this.PhysicalAddresses == input.PhysicalAddresses ||
                    this.PhysicalAddresses != null &&
                    input.PhysicalAddresses != null &&
                    this.PhysicalAddresses.SequenceEqual(input.PhysicalAddresses)
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
                if (this.LastUpdateTime != null)
                    hashCode = hashCode * 59 + this.LastUpdateTime.GetHashCode();
                if (this.FirstName != null)
                    hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                if (this.LastName != null)
                    hashCode = hashCode * 59 + this.LastName.GetHashCode();
                if (this.MiddleNames != null)
                    hashCode = hashCode * 59 + this.MiddleNames.GetHashCode();
                if (this.Prefix != null)
                    hashCode = hashCode * 59 + this.Prefix.GetHashCode();
                if (this.Suffix != null)
                    hashCode = hashCode * 59 + this.Suffix.GetHashCode();
                if (this.OccupationCode != null)
                    hashCode = hashCode * 59 + this.OccupationCode.GetHashCode();
                hashCode = hashCode * 59 + this.OccupationCodeVersion.GetHashCode();
                if (this.PhoneNumbers != null)
                    hashCode = hashCode * 59 + this.PhoneNumbers.GetHashCode();
                if (this.EmailAddresses != null)
                    hashCode = hashCode * 59 + this.EmailAddresses.GetHashCode();
                if (this.PhysicalAddresses != null)
                    hashCode = hashCode * 59 + this.PhysicalAddresses.GetHashCode();
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
