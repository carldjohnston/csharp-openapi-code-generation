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
    /// The address of the service point.  Mandatory if addressUType is set to paf. Formatted according to the file format defined by the [PAF file format](https://auspost.com.au/content/dam/auspost_corp/media/documents/australia-post-data-guide.pdf)
    /// </summary>
    [DataContract]
    public partial class EnergyServicePointDetailLocationPaf : IEquatable<EnergyServicePointDetailLocationPaf>
    {
        /// <summary>
        /// Unique identifier for an address as defined by Australia Post.  Also known as Delivery Point Identifier
        /// </summary>
        /// <value>Unique identifier for an address as defined by Australia Post.  Also known as Delivery Point Identifier</value>
        [DataMember(Name="dpid", EmitDefaultValue=false)]
        public string Dpid { get; set; }

        /// <summary>
        /// Thoroughfare number for a property (first number in a property ranged address)
        /// </summary>
        /// <value>Thoroughfare number for a property (first number in a property ranged address)</value>
        [DataMember(Name="thoroughfareNumber1", EmitDefaultValue=false)]
        public int ThoroughfareNumber1 { get; set; }

        /// <summary>
        /// Suffix for the thoroughfare number. Only relevant is thoroughfareNumber1 is populated
        /// </summary>
        /// <value>Suffix for the thoroughfare number. Only relevant is thoroughfareNumber1 is populated</value>
        [DataMember(Name="thoroughfareNumber1Suffix", EmitDefaultValue=false)]
        public string ThoroughfareNumber1Suffix { get; set; }

        /// <summary>
        /// Second thoroughfare number (only used if the property has a ranged address eg 23-25)
        /// </summary>
        /// <value>Second thoroughfare number (only used if the property has a ranged address eg 23-25)</value>
        [DataMember(Name="thoroughfareNumber2", EmitDefaultValue=false)]
        public int ThoroughfareNumber2 { get; set; }

        /// <summary>
        /// Suffix for the second thoroughfare number. Only relevant is thoroughfareNumber2 is populated
        /// </summary>
        /// <value>Suffix for the second thoroughfare number. Only relevant is thoroughfareNumber2 is populated</value>
        [DataMember(Name="thoroughfareNumber2Suffix", EmitDefaultValue=false)]
        public string ThoroughfareNumber2Suffix { get; set; }

        /// <summary>
        /// Type of flat or unit for the address
        /// </summary>
        /// <value>Type of flat or unit for the address</value>
        [DataMember(Name="flatUnitType", EmitDefaultValue=false)]
        public string FlatUnitType { get; set; }

        /// <summary>
        /// Unit number (including suffix, if applicable)
        /// </summary>
        /// <value>Unit number (including suffix, if applicable)</value>
        [DataMember(Name="flatUnitNumber", EmitDefaultValue=false)]
        public string FlatUnitNumber { get; set; }

        /// <summary>
        /// Type of floor or level for the address
        /// </summary>
        /// <value>Type of floor or level for the address</value>
        [DataMember(Name="floorLevelType", EmitDefaultValue=false)]
        public string FloorLevelType { get; set; }

        /// <summary>
        /// Floor or level number (including alpha characters)
        /// </summary>
        /// <value>Floor or level number (including alpha characters)</value>
        [DataMember(Name="floorLevelNumber", EmitDefaultValue=false)]
        public string FloorLevelNumber { get; set; }

        /// <summary>
        /// Allotment number for the address
        /// </summary>
        /// <value>Allotment number for the address</value>
        [DataMember(Name="lotNumber", EmitDefaultValue=false)]
        public string LotNumber { get; set; }

        /// <summary>
        /// Building/Property name 1
        /// </summary>
        /// <value>Building/Property name 1</value>
        [DataMember(Name="buildingName1", EmitDefaultValue=false)]
        public string BuildingName1 { get; set; }

        /// <summary>
        /// Building/Property name 2
        /// </summary>
        /// <value>Building/Property name 2</value>
        [DataMember(Name="buildingName2", EmitDefaultValue=false)]
        public string BuildingName2 { get; set; }

        /// <summary>
        /// The name of the street
        /// </summary>
        /// <value>The name of the street</value>
        [DataMember(Name="streetName", EmitDefaultValue=false)]
        public string StreetName { get; set; }

        /// <summary>
        /// The street type. Valid enumeration defined by Australia Post PAF code file
        /// </summary>
        /// <value>The street type. Valid enumeration defined by Australia Post PAF code file</value>
        [DataMember(Name="streetType", EmitDefaultValue=false)]
        public string StreetType { get; set; }

        /// <summary>
        /// The street type suffix. Valid enumeration defined by Australia Post PAF code file
        /// </summary>
        /// <value>The street type suffix. Valid enumeration defined by Australia Post PAF code file</value>
        [DataMember(Name="streetSuffix", EmitDefaultValue=false)]
        public string StreetSuffix { get; set; }

        /// <summary>
        /// Postal delivery type. (eg. PO BOX). Valid enumeration defined by Australia Post PAF code file
        /// </summary>
        /// <value>Postal delivery type. (eg. PO BOX). Valid enumeration defined by Australia Post PAF code file</value>
        [DataMember(Name="postalDeliveryType", EmitDefaultValue=false)]
        public string PostalDeliveryType { get; set; }

        /// <summary>
        /// Postal delivery number if the address is a postal delivery type
        /// </summary>
        /// <value>Postal delivery number if the address is a postal delivery type</value>
        [DataMember(Name="postalDeliveryNumber", EmitDefaultValue=false)]
        public int PostalDeliveryNumber { get; set; }

        /// <summary>
        /// Postal delivery number prefix related to the postal delivery number
        /// </summary>
        /// <value>Postal delivery number prefix related to the postal delivery number</value>
        [DataMember(Name="postalDeliveryNumberPrefix", EmitDefaultValue=false)]
        public string PostalDeliveryNumberPrefix { get; set; }

        /// <summary>
        /// Postal delivery number suffix related to the postal delivery number
        /// </summary>
        /// <value>Postal delivery number suffix related to the postal delivery number</value>
        [DataMember(Name="postalDeliveryNumberSuffix", EmitDefaultValue=false)]
        public string PostalDeliveryNumberSuffix { get; set; }

        /// <summary>
        /// Full name of locality
        /// </summary>
        /// <value>Full name of locality</value>
        [Required]
        [DataMember(Name="localityName", EmitDefaultValue=false)]
        public string LocalityName { get; set; }

        /// <summary>
        /// Postcode for the locality
        /// </summary>
        /// <value>Postcode for the locality</value>
        [Required]
        [DataMember(Name="postcode", EmitDefaultValue=false)]
        public string Postcode { get; set; }

        /// <summary>
        /// State in which the address belongs. Valid enumeration defined by Australia Post PAF code file [State Type Abbreviation](https://auspost.com.au/content/dam/auspost_corp/media/documents/australia-post-data-guide.pdf). NSW, QLD, VIC, NT, WA, SA, TAS, ACT, AAT
        /// </summary>
        /// <value>State in which the address belongs. Valid enumeration defined by Australia Post PAF code file [State Type Abbreviation](https://auspost.com.au/content/dam/auspost_corp/media/documents/australia-post-data-guide.pdf). NSW, QLD, VIC, NT, WA, SA, TAS, ACT, AAT</value>
        [Required]
        [DataMember(Name="state", EmitDefaultValue=false)]
        public string State { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnergyServicePointDetailLocationPaf {\n");
            sb.Append("  Dpid: ").Append(Dpid).Append("\n");
            sb.Append("  ThoroughfareNumber1: ").Append(ThoroughfareNumber1).Append("\n");
            sb.Append("  ThoroughfareNumber1Suffix: ").Append(ThoroughfareNumber1Suffix).Append("\n");
            sb.Append("  ThoroughfareNumber2: ").Append(ThoroughfareNumber2).Append("\n");
            sb.Append("  ThoroughfareNumber2Suffix: ").Append(ThoroughfareNumber2Suffix).Append("\n");
            sb.Append("  FlatUnitType: ").Append(FlatUnitType).Append("\n");
            sb.Append("  FlatUnitNumber: ").Append(FlatUnitNumber).Append("\n");
            sb.Append("  FloorLevelType: ").Append(FloorLevelType).Append("\n");
            sb.Append("  FloorLevelNumber: ").Append(FloorLevelNumber).Append("\n");
            sb.Append("  LotNumber: ").Append(LotNumber).Append("\n");
            sb.Append("  BuildingName1: ").Append(BuildingName1).Append("\n");
            sb.Append("  BuildingName2: ").Append(BuildingName2).Append("\n");
            sb.Append("  StreetName: ").Append(StreetName).Append("\n");
            sb.Append("  StreetType: ").Append(StreetType).Append("\n");
            sb.Append("  StreetSuffix: ").Append(StreetSuffix).Append("\n");
            sb.Append("  PostalDeliveryType: ").Append(PostalDeliveryType).Append("\n");
            sb.Append("  PostalDeliveryNumber: ").Append(PostalDeliveryNumber).Append("\n");
            sb.Append("  PostalDeliveryNumberPrefix: ").Append(PostalDeliveryNumberPrefix).Append("\n");
            sb.Append("  PostalDeliveryNumberSuffix: ").Append(PostalDeliveryNumberSuffix).Append("\n");
            sb.Append("  LocalityName: ").Append(LocalityName).Append("\n");
            sb.Append("  Postcode: ").Append(Postcode).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
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
            return obj.GetType() == GetType() && Equals((EnergyServicePointDetailLocationPaf)obj);
        }

        /// <summary>
        /// Returns true if EnergyServicePointDetailLocationPaf instances are equal
        /// </summary>
        /// <param name="other">Instance of EnergyServicePointDetailLocationPaf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EnergyServicePointDetailLocationPaf other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Dpid == other.Dpid ||
                    Dpid != null &&
                    Dpid.Equals(other.Dpid)
                ) && 
                (
                    ThoroughfareNumber1 == other.ThoroughfareNumber1 ||
                    
                    ThoroughfareNumber1.Equals(other.ThoroughfareNumber1)
                ) && 
                (
                    ThoroughfareNumber1Suffix == other.ThoroughfareNumber1Suffix ||
                    ThoroughfareNumber1Suffix != null &&
                    ThoroughfareNumber1Suffix.Equals(other.ThoroughfareNumber1Suffix)
                ) && 
                (
                    ThoroughfareNumber2 == other.ThoroughfareNumber2 ||
                    
                    ThoroughfareNumber2.Equals(other.ThoroughfareNumber2)
                ) && 
                (
                    ThoroughfareNumber2Suffix == other.ThoroughfareNumber2Suffix ||
                    ThoroughfareNumber2Suffix != null &&
                    ThoroughfareNumber2Suffix.Equals(other.ThoroughfareNumber2Suffix)
                ) && 
                (
                    FlatUnitType == other.FlatUnitType ||
                    FlatUnitType != null &&
                    FlatUnitType.Equals(other.FlatUnitType)
                ) && 
                (
                    FlatUnitNumber == other.FlatUnitNumber ||
                    FlatUnitNumber != null &&
                    FlatUnitNumber.Equals(other.FlatUnitNumber)
                ) && 
                (
                    FloorLevelType == other.FloorLevelType ||
                    FloorLevelType != null &&
                    FloorLevelType.Equals(other.FloorLevelType)
                ) && 
                (
                    FloorLevelNumber == other.FloorLevelNumber ||
                    FloorLevelNumber != null &&
                    FloorLevelNumber.Equals(other.FloorLevelNumber)
                ) && 
                (
                    LotNumber == other.LotNumber ||
                    LotNumber != null &&
                    LotNumber.Equals(other.LotNumber)
                ) && 
                (
                    BuildingName1 == other.BuildingName1 ||
                    BuildingName1 != null &&
                    BuildingName1.Equals(other.BuildingName1)
                ) && 
                (
                    BuildingName2 == other.BuildingName2 ||
                    BuildingName2 != null &&
                    BuildingName2.Equals(other.BuildingName2)
                ) && 
                (
                    StreetName == other.StreetName ||
                    StreetName != null &&
                    StreetName.Equals(other.StreetName)
                ) && 
                (
                    StreetType == other.StreetType ||
                    StreetType != null &&
                    StreetType.Equals(other.StreetType)
                ) && 
                (
                    StreetSuffix == other.StreetSuffix ||
                    StreetSuffix != null &&
                    StreetSuffix.Equals(other.StreetSuffix)
                ) && 
                (
                    PostalDeliveryType == other.PostalDeliveryType ||
                    PostalDeliveryType != null &&
                    PostalDeliveryType.Equals(other.PostalDeliveryType)
                ) && 
                (
                    PostalDeliveryNumber == other.PostalDeliveryNumber ||
                    
                    PostalDeliveryNumber.Equals(other.PostalDeliveryNumber)
                ) && 
                (
                    PostalDeliveryNumberPrefix == other.PostalDeliveryNumberPrefix ||
                    PostalDeliveryNumberPrefix != null &&
                    PostalDeliveryNumberPrefix.Equals(other.PostalDeliveryNumberPrefix)
                ) && 
                (
                    PostalDeliveryNumberSuffix == other.PostalDeliveryNumberSuffix ||
                    PostalDeliveryNumberSuffix != null &&
                    PostalDeliveryNumberSuffix.Equals(other.PostalDeliveryNumberSuffix)
                ) && 
                (
                    LocalityName == other.LocalityName ||
                    LocalityName != null &&
                    LocalityName.Equals(other.LocalityName)
                ) && 
                (
                    Postcode == other.Postcode ||
                    Postcode != null &&
                    Postcode.Equals(other.Postcode)
                ) && 
                (
                    State == other.State ||
                    State != null &&
                    State.Equals(other.State)
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
                    if (Dpid != null)
                    hashCode = hashCode * 59 + Dpid.GetHashCode();
                    
                    hashCode = hashCode * 59 + ThoroughfareNumber1.GetHashCode();
                    if (ThoroughfareNumber1Suffix != null)
                    hashCode = hashCode * 59 + ThoroughfareNumber1Suffix.GetHashCode();
                    
                    hashCode = hashCode * 59 + ThoroughfareNumber2.GetHashCode();
                    if (ThoroughfareNumber2Suffix != null)
                    hashCode = hashCode * 59 + ThoroughfareNumber2Suffix.GetHashCode();
                    if (FlatUnitType != null)
                    hashCode = hashCode * 59 + FlatUnitType.GetHashCode();
                    if (FlatUnitNumber != null)
                    hashCode = hashCode * 59 + FlatUnitNumber.GetHashCode();
                    if (FloorLevelType != null)
                    hashCode = hashCode * 59 + FloorLevelType.GetHashCode();
                    if (FloorLevelNumber != null)
                    hashCode = hashCode * 59 + FloorLevelNumber.GetHashCode();
                    if (LotNumber != null)
                    hashCode = hashCode * 59 + LotNumber.GetHashCode();
                    if (BuildingName1 != null)
                    hashCode = hashCode * 59 + BuildingName1.GetHashCode();
                    if (BuildingName2 != null)
                    hashCode = hashCode * 59 + BuildingName2.GetHashCode();
                    if (StreetName != null)
                    hashCode = hashCode * 59 + StreetName.GetHashCode();
                    if (StreetType != null)
                    hashCode = hashCode * 59 + StreetType.GetHashCode();
                    if (StreetSuffix != null)
                    hashCode = hashCode * 59 + StreetSuffix.GetHashCode();
                    if (PostalDeliveryType != null)
                    hashCode = hashCode * 59 + PostalDeliveryType.GetHashCode();
                    
                    hashCode = hashCode * 59 + PostalDeliveryNumber.GetHashCode();
                    if (PostalDeliveryNumberPrefix != null)
                    hashCode = hashCode * 59 + PostalDeliveryNumberPrefix.GetHashCode();
                    if (PostalDeliveryNumberSuffix != null)
                    hashCode = hashCode * 59 + PostalDeliveryNumberSuffix.GetHashCode();
                    if (LocalityName != null)
                    hashCode = hashCode * 59 + LocalityName.GetHashCode();
                    if (Postcode != null)
                    hashCode = hashCode * 59 + Postcode.GetHashCode();
                    if (State != null)
                    hashCode = hashCode * 59 + State.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(EnergyServicePointDetailLocationPaf left, EnergyServicePointDetailLocationPaf right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(EnergyServicePointDetailLocationPaf left, EnergyServicePointDetailLocationPaf right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
