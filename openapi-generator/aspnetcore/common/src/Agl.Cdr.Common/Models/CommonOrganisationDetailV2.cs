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
    public partial class CommonOrganisationDetailV2 : IEquatable<CommonOrganisationDetailV2>
    {
        /// <summary>
        /// The date and time that this record was last updated by the customer. If no update has occurred then this date should reflect the initial creation date for the data
        /// </summary>
        /// <value>The date and time that this record was last updated by the customer. If no update has occurred then this date should reflect the initial creation date for the data</value>
        [DataMember(Name="lastUpdateTime", EmitDefaultValue=false)]
        public string LastUpdateTime { get; set; }

        /// <summary>
        /// The first name of the individual providing access on behalf of the organisation. For people with single names this field need not be present.  The single name should be in the lastName field
        /// </summary>
        /// <value>The first name of the individual providing access on behalf of the organisation. For people with single names this field need not be present.  The single name should be in the lastName field</value>
        [DataMember(Name="agentFirstName", EmitDefaultValue=false)]
        public string AgentFirstName { get; set; }

        /// <summary>
        /// The last name of the individual providing access on behalf of the organisation. For people with single names the single name should be in this field
        /// </summary>
        /// <value>The last name of the individual providing access on behalf of the organisation. For people with single names the single name should be in this field</value>
        [Required]
        [DataMember(Name="agentLastName", EmitDefaultValue=false)]
        public string AgentLastName { get; set; }

        /// <summary>
        /// The role of the individual identified as the agent who is providing authorisation.  Expected to be used for display. Default to Unspecified if the role is not known
        /// </summary>
        /// <value>The role of the individual identified as the agent who is providing authorisation.  Expected to be used for display. Default to Unspecified if the role is not known</value>
        [Required]
        [DataMember(Name="agentRole", EmitDefaultValue=false)]
        public string AgentRole { get; set; }

        /// <summary>
        /// Name of the organisation
        /// </summary>
        /// <value>Name of the organisation</value>
        [Required]
        [DataMember(Name="businessName", EmitDefaultValue=false)]
        public string BusinessName { get; set; }

        /// <summary>
        /// Legal name, if different to the business name
        /// </summary>
        /// <value>Legal name, if different to the business name</value>
        [DataMember(Name="legalName", EmitDefaultValue=false)]
        public string LegalName { get; set; }

        /// <summary>
        /// Short name used for communication, if different to the business name
        /// </summary>
        /// <value>Short name used for communication, if different to the business name</value>
        [DataMember(Name="shortName", EmitDefaultValue=false)]
        public string ShortName { get; set; }

        /// <summary>
        /// Australian Business Number for the organisation
        /// </summary>
        /// <value>Australian Business Number for the organisation</value>
        [DataMember(Name="abn", EmitDefaultValue=false)]
        public string Abn { get; set; }

        /// <summary>
        /// Australian Company Number for the organisation. Required only if an ACN is applicable for the organisation type
        /// </summary>
        /// <value>Australian Company Number for the organisation. Required only if an ACN is applicable for the organisation type</value>
        [DataMember(Name="acn", EmitDefaultValue=false)]
        public string Acn { get; set; }

        /// <summary>
        /// True if registered with the ACNC.  False if not. Absent or null if not confirmed.
        /// </summary>
        /// <value>True if registered with the ACNC.  False if not. Absent or null if not confirmed.</value>
        [DataMember(Name="isACNCRegistered", EmitDefaultValue=false)]
        public bool IsACNCRegistered { get; set; }

        /// <summary>
        /// A valid [ANZSIC](http://www.abs.gov.au/ANZSIC) code for the organisation. If the industry code held by the data holder is not one of the supported [ANZSIC](http://www.abs.gov.au/ANZSIC) versions, then it must not be supplied.
        /// </summary>
        /// <value>A valid [ANZSIC](http://www.abs.gov.au/ANZSIC) code for the organisation. If the industry code held by the data holder is not one of the supported [ANZSIC](http://www.abs.gov.au/ANZSIC) versions, then it must not be supplied.</value>
        [DataMember(Name="industryCode", EmitDefaultValue=false)]
        public string IndustryCode { get; set; }


        /// <summary>
        /// The applicable [ANZSIC](http://www.abs.gov.au/ANZSIC) release version of the industry code provided. Should only be supplied if ``industryCode`` is also supplied. If ``industryCode`` is supplied but ``industryCodeVersion`` is absent, default is ``ANZSIC_1292.0_2006_V2.0``
        /// </summary>
        /// <value>The applicable [ANZSIC](http://www.abs.gov.au/ANZSIC) release version of the industry code provided. Should only be supplied if ``industryCode`` is also supplied. If ``industryCode`` is supplied but ``industryCodeVersion`` is absent, default is ``ANZSIC_1292.0_2006_V2.0``</value>
        [TypeConverter(typeof(CustomEnumConverter<IndustryCodeVersionEnum>))]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum IndustryCodeVersionEnum
        {
            
            /// <summary>
            /// Enum V10Enum for ANZSIC_1292.0_2006_V1.0
            /// </summary>
            [EnumMember(Value = "ANZSIC_1292.0_2006_V1.0")]
            V10Enum = 1,
            
            /// <summary>
            /// Enum V20Enum for ANZSIC_1292.0_2006_V2.0
            /// </summary>
            [EnumMember(Value = "ANZSIC_1292.0_2006_V2.0")]
            V20Enum = 2
        }

        /// <summary>
        /// The applicable [ANZSIC](http://www.abs.gov.au/ANZSIC) release version of the industry code provided. Should only be supplied if &#x60;&#x60;industryCode&#x60;&#x60; is also supplied. If &#x60;&#x60;industryCode&#x60;&#x60; is supplied but &#x60;&#x60;industryCodeVersion&#x60;&#x60; is absent, default is &#x60;&#x60;ANZSIC_1292.0_2006_V2.0&#x60;&#x60;
        /// </summary>
        /// <value>The applicable [ANZSIC](http://www.abs.gov.au/ANZSIC) release version of the industry code provided. Should only be supplied if &#x60;&#x60;industryCode&#x60;&#x60; is also supplied. If &#x60;&#x60;industryCode&#x60;&#x60; is supplied but &#x60;&#x60;industryCodeVersion&#x60;&#x60; is absent, default is &#x60;&#x60;ANZSIC_1292.0_2006_V2.0&#x60;&#x60;</value>
        [DataMember(Name="industryCodeVersion", EmitDefaultValue=false)]
        public IndustryCodeVersionEnum IndustryCodeVersion { get; set; } = IndustryCodeVersionEnum.V20Enum;


        /// <summary>
        /// Legal organisation type
        /// </summary>
        /// <value>Legal organisation type</value>
        [TypeConverter(typeof(CustomEnumConverter<OrganisationTypeEnum>))]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum OrganisationTypeEnum
        {
            
            /// <summary>
            /// Enum COMPANYEnum for COMPANY
            /// </summary>
            [EnumMember(Value = "COMPANY")]
            COMPANYEnum = 1,
            
            /// <summary>
            /// Enum GOVERNMENTENTITYEnum for GOVERNMENT_ENTITY
            /// </summary>
            [EnumMember(Value = "GOVERNMENT_ENTITY")]
            GOVERNMENTENTITYEnum = 2,
            
            /// <summary>
            /// Enum OTHEREnum for OTHER
            /// </summary>
            [EnumMember(Value = "OTHER")]
            OTHEREnum = 3,
            
            /// <summary>
            /// Enum PARTNERSHIPEnum for PARTNERSHIP
            /// </summary>
            [EnumMember(Value = "PARTNERSHIP")]
            PARTNERSHIPEnum = 4,
            
            /// <summary>
            /// Enum SOLETRADEREnum for SOLE_TRADER
            /// </summary>
            [EnumMember(Value = "SOLE_TRADER")]
            SOLETRADEREnum = 5,
            
            /// <summary>
            /// Enum TRUSTEnum for TRUST
            /// </summary>
            [EnumMember(Value = "TRUST")]
            TRUSTEnum = 6
        }

        /// <summary>
        /// Legal organisation type
        /// </summary>
        /// <value>Legal organisation type</value>
        [Required]
        [DataMember(Name="organisationType", EmitDefaultValue=false)]
        public OrganisationTypeEnum OrganisationType { get; set; }

        /// <summary>
        /// Enumeration with values from [ISO 3166 Alpha-3](https://www.iso.org/iso-3166-country-codes.html) country codes.  Assumed to be AUS if absent
        /// </summary>
        /// <value>Enumeration with values from [ISO 3166 Alpha-3](https://www.iso.org/iso-3166-country-codes.html) country codes.  Assumed to be AUS if absent</value>
        [DataMember(Name="registeredCountry", EmitDefaultValue=false)]
        public string RegisteredCountry { get; set; }

        /// <summary>
        /// The date the organisation described was established
        /// </summary>
        /// <value>The date the organisation described was established</value>
        [DataMember(Name="establishmentDate", EmitDefaultValue=false)]
        public string EstablishmentDate { get; set; }

        /// <summary>
        /// Array is mandatory but may be empty if no valid addresses are held. One and only one address may have the purpose of REGISTERED. Zero or one, and no more than one, record may have the purpose of MAIL. If zero then the REGISTERED address is to be used for mail
        /// </summary>
        /// <value>Array is mandatory but may be empty if no valid addresses are held. One and only one address may have the purpose of REGISTERED. Zero or one, and no more than one, record may have the purpose of MAIL. If zero then the REGISTERED address is to be used for mail</value>
        [Required]
        [DataMember(Name="physicalAddresses", EmitDefaultValue=false)]
        public List<CommonPhysicalAddressWithPurpose2> PhysicalAddresses { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CommonOrganisationDetailV2 {\n");
            sb.Append("  LastUpdateTime: ").Append(LastUpdateTime).Append("\n");
            sb.Append("  AgentFirstName: ").Append(AgentFirstName).Append("\n");
            sb.Append("  AgentLastName: ").Append(AgentLastName).Append("\n");
            sb.Append("  AgentRole: ").Append(AgentRole).Append("\n");
            sb.Append("  BusinessName: ").Append(BusinessName).Append("\n");
            sb.Append("  LegalName: ").Append(LegalName).Append("\n");
            sb.Append("  ShortName: ").Append(ShortName).Append("\n");
            sb.Append("  Abn: ").Append(Abn).Append("\n");
            sb.Append("  Acn: ").Append(Acn).Append("\n");
            sb.Append("  IsACNCRegistered: ").Append(IsACNCRegistered).Append("\n");
            sb.Append("  IndustryCode: ").Append(IndustryCode).Append("\n");
            sb.Append("  IndustryCodeVersion: ").Append(IndustryCodeVersion).Append("\n");
            sb.Append("  OrganisationType: ").Append(OrganisationType).Append("\n");
            sb.Append("  RegisteredCountry: ").Append(RegisteredCountry).Append("\n");
            sb.Append("  EstablishmentDate: ").Append(EstablishmentDate).Append("\n");
            sb.Append("  PhysicalAddresses: ").Append(PhysicalAddresses).Append("\n");
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
            return obj.GetType() == GetType() && Equals((CommonOrganisationDetailV2)obj);
        }

        /// <summary>
        /// Returns true if CommonOrganisationDetailV2 instances are equal
        /// </summary>
        /// <param name="other">Instance of CommonOrganisationDetailV2 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CommonOrganisationDetailV2 other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    LastUpdateTime == other.LastUpdateTime ||
                    LastUpdateTime != null &&
                    LastUpdateTime.Equals(other.LastUpdateTime)
                ) && 
                (
                    AgentFirstName == other.AgentFirstName ||
                    AgentFirstName != null &&
                    AgentFirstName.Equals(other.AgentFirstName)
                ) && 
                (
                    AgentLastName == other.AgentLastName ||
                    AgentLastName != null &&
                    AgentLastName.Equals(other.AgentLastName)
                ) && 
                (
                    AgentRole == other.AgentRole ||
                    AgentRole != null &&
                    AgentRole.Equals(other.AgentRole)
                ) && 
                (
                    BusinessName == other.BusinessName ||
                    BusinessName != null &&
                    BusinessName.Equals(other.BusinessName)
                ) && 
                (
                    LegalName == other.LegalName ||
                    LegalName != null &&
                    LegalName.Equals(other.LegalName)
                ) && 
                (
                    ShortName == other.ShortName ||
                    ShortName != null &&
                    ShortName.Equals(other.ShortName)
                ) && 
                (
                    Abn == other.Abn ||
                    Abn != null &&
                    Abn.Equals(other.Abn)
                ) && 
                (
                    Acn == other.Acn ||
                    Acn != null &&
                    Acn.Equals(other.Acn)
                ) && 
                (
                    IsACNCRegistered == other.IsACNCRegistered ||
                    
                    IsACNCRegistered.Equals(other.IsACNCRegistered)
                ) && 
                (
                    IndustryCode == other.IndustryCode ||
                    IndustryCode != null &&
                    IndustryCode.Equals(other.IndustryCode)
                ) && 
                (
                    IndustryCodeVersion == other.IndustryCodeVersion ||
                    
                    IndustryCodeVersion.Equals(other.IndustryCodeVersion)
                ) && 
                (
                    OrganisationType == other.OrganisationType ||
                    
                    OrganisationType.Equals(other.OrganisationType)
                ) && 
                (
                    RegisteredCountry == other.RegisteredCountry ||
                    RegisteredCountry != null &&
                    RegisteredCountry.Equals(other.RegisteredCountry)
                ) && 
                (
                    EstablishmentDate == other.EstablishmentDate ||
                    EstablishmentDate != null &&
                    EstablishmentDate.Equals(other.EstablishmentDate)
                ) && 
                (
                    PhysicalAddresses == other.PhysicalAddresses ||
                    PhysicalAddresses != null &&
                    other.PhysicalAddresses != null &&
                    PhysicalAddresses.SequenceEqual(other.PhysicalAddresses)
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
                    if (LastUpdateTime != null)
                    hashCode = hashCode * 59 + LastUpdateTime.GetHashCode();
                    if (AgentFirstName != null)
                    hashCode = hashCode * 59 + AgentFirstName.GetHashCode();
                    if (AgentLastName != null)
                    hashCode = hashCode * 59 + AgentLastName.GetHashCode();
                    if (AgentRole != null)
                    hashCode = hashCode * 59 + AgentRole.GetHashCode();
                    if (BusinessName != null)
                    hashCode = hashCode * 59 + BusinessName.GetHashCode();
                    if (LegalName != null)
                    hashCode = hashCode * 59 + LegalName.GetHashCode();
                    if (ShortName != null)
                    hashCode = hashCode * 59 + ShortName.GetHashCode();
                    if (Abn != null)
                    hashCode = hashCode * 59 + Abn.GetHashCode();
                    if (Acn != null)
                    hashCode = hashCode * 59 + Acn.GetHashCode();
                    
                    hashCode = hashCode * 59 + IsACNCRegistered.GetHashCode();
                    if (IndustryCode != null)
                    hashCode = hashCode * 59 + IndustryCode.GetHashCode();
                    
                    hashCode = hashCode * 59 + IndustryCodeVersion.GetHashCode();
                    
                    hashCode = hashCode * 59 + OrganisationType.GetHashCode();
                    if (RegisteredCountry != null)
                    hashCode = hashCode * 59 + RegisteredCountry.GetHashCode();
                    if (EstablishmentDate != null)
                    hashCode = hashCode * 59 + EstablishmentDate.GetHashCode();
                    if (PhysicalAddresses != null)
                    hashCode = hashCode * 59 + PhysicalAddresses.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(CommonOrganisationDetailV2 left, CommonOrganisationDetailV2 right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(CommonOrganisationDetailV2 left, CommonOrganisationDetailV2 right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
