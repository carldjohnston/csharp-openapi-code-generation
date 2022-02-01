// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Agl.Cdr.Energy.Models
{
    /// <summary> The address of the service point.  Mandatory if addressUType is set to paf. Formatted according to the file format defined by the [PAF file format](https://auspost.com.au/content/dam/auspost_corp/media/documents/australia-post-data-guide.pdf). </summary>
    public partial class EnergyServicePointDetailLocationPaf
    {
        /// <summary> Initializes a new instance of EnergyServicePointDetailLocationPaf. </summary>
        /// <param name="localityName"> Full name of locality. </param>
        /// <param name="postcode"> Postcode for the locality. </param>
        /// <param name="state"> State in which the address belongs. Valid enumeration defined by Australia Post PAF code file [State Type Abbreviation](https://auspost.com.au/content/dam/auspost_corp/media/documents/australia-post-data-guide.pdf). NSW, QLD, VIC, NT, WA, SA, TAS, ACT, AAT. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="localityName"/>, <paramref name="postcode"/>, or <paramref name="state"/> is null. </exception>
        internal EnergyServicePointDetailLocationPaf(string localityName, string postcode, string state)
        {
            if (localityName == null)
            {
                throw new ArgumentNullException(nameof(localityName));
            }
            if (postcode == null)
            {
                throw new ArgumentNullException(nameof(postcode));
            }
            if (state == null)
            {
                throw new ArgumentNullException(nameof(state));
            }

            LocalityName = localityName;
            Postcode = postcode;
            State = state;
        }

        /// <summary> Initializes a new instance of EnergyServicePointDetailLocationPaf. </summary>
        /// <param name="dpid"> Unique identifier for an address as defined by Australia Post.  Also known as Delivery Point Identifier. </param>
        /// <param name="thoroughfareNumber1"> Thoroughfare number for a property (first number in a property ranged address). </param>
        /// <param name="thoroughfareNumber1Suffix"> Suffix for the thoroughfare number. Only relevant is thoroughfareNumber1 is populated. </param>
        /// <param name="thoroughfareNumber2"> Second thoroughfare number (only used if the property has a ranged address eg 23-25). </param>
        /// <param name="thoroughfareNumber2Suffix"> Suffix for the second thoroughfare number. Only relevant is thoroughfareNumber2 is populated. </param>
        /// <param name="flatUnitType"> Type of flat or unit for the address. </param>
        /// <param name="flatUnitNumber"> Unit number (including suffix, if applicable). </param>
        /// <param name="floorLevelType"> Type of floor or level for the address. </param>
        /// <param name="floorLevelNumber"> Floor or level number (including alpha characters). </param>
        /// <param name="lotNumber"> Allotment number for the address. </param>
        /// <param name="buildingName1"> Building/Property name 1. </param>
        /// <param name="buildingName2"> Building/Property name 2. </param>
        /// <param name="streetName"> The name of the street. </param>
        /// <param name="streetType"> The street type. Valid enumeration defined by Australia Post PAF code file. </param>
        /// <param name="streetSuffix"> The street type suffix. Valid enumeration defined by Australia Post PAF code file. </param>
        /// <param name="postalDeliveryType"> Postal delivery type. (eg. PO BOX). Valid enumeration defined by Australia Post PAF code file. </param>
        /// <param name="postalDeliveryNumber"> Postal delivery number if the address is a postal delivery type. </param>
        /// <param name="postalDeliveryNumberPrefix"> Postal delivery number prefix related to the postal delivery number. </param>
        /// <param name="postalDeliveryNumberSuffix"> Postal delivery number suffix related to the postal delivery number. </param>
        /// <param name="localityName"> Full name of locality. </param>
        /// <param name="postcode"> Postcode for the locality. </param>
        /// <param name="state"> State in which the address belongs. Valid enumeration defined by Australia Post PAF code file [State Type Abbreviation](https://auspost.com.au/content/dam/auspost_corp/media/documents/australia-post-data-guide.pdf). NSW, QLD, VIC, NT, WA, SA, TAS, ACT, AAT. </param>
        internal EnergyServicePointDetailLocationPaf(string dpid, int? thoroughfareNumber1, string thoroughfareNumber1Suffix, int? thoroughfareNumber2, string thoroughfareNumber2Suffix, string flatUnitType, string flatUnitNumber, string floorLevelType, string floorLevelNumber, string lotNumber, string buildingName1, string buildingName2, string streetName, string streetType, string streetSuffix, string postalDeliveryType, int? postalDeliveryNumber, string postalDeliveryNumberPrefix, string postalDeliveryNumberSuffix, string localityName, string postcode, string state)
        {
            Dpid = dpid;
            ThoroughfareNumber1 = thoroughfareNumber1;
            ThoroughfareNumber1Suffix = thoroughfareNumber1Suffix;
            ThoroughfareNumber2 = thoroughfareNumber2;
            ThoroughfareNumber2Suffix = thoroughfareNumber2Suffix;
            FlatUnitType = flatUnitType;
            FlatUnitNumber = flatUnitNumber;
            FloorLevelType = floorLevelType;
            FloorLevelNumber = floorLevelNumber;
            LotNumber = lotNumber;
            BuildingName1 = buildingName1;
            BuildingName2 = buildingName2;
            StreetName = streetName;
            StreetType = streetType;
            StreetSuffix = streetSuffix;
            PostalDeliveryType = postalDeliveryType;
            PostalDeliveryNumber = postalDeliveryNumber;
            PostalDeliveryNumberPrefix = postalDeliveryNumberPrefix;
            PostalDeliveryNumberSuffix = postalDeliveryNumberSuffix;
            LocalityName = localityName;
            Postcode = postcode;
            State = state;
        }

        /// <summary> Unique identifier for an address as defined by Australia Post.  Also known as Delivery Point Identifier. </summary>
        public string Dpid { get; }
        /// <summary> Thoroughfare number for a property (first number in a property ranged address). </summary>
        public int? ThoroughfareNumber1 { get; }
        /// <summary> Suffix for the thoroughfare number. Only relevant is thoroughfareNumber1 is populated. </summary>
        public string ThoroughfareNumber1Suffix { get; }
        /// <summary> Second thoroughfare number (only used if the property has a ranged address eg 23-25). </summary>
        public int? ThoroughfareNumber2 { get; }
        /// <summary> Suffix for the second thoroughfare number. Only relevant is thoroughfareNumber2 is populated. </summary>
        public string ThoroughfareNumber2Suffix { get; }
        /// <summary> Type of flat or unit for the address. </summary>
        public string FlatUnitType { get; }
        /// <summary> Unit number (including suffix, if applicable). </summary>
        public string FlatUnitNumber { get; }
        /// <summary> Type of floor or level for the address. </summary>
        public string FloorLevelType { get; }
        /// <summary> Floor or level number (including alpha characters). </summary>
        public string FloorLevelNumber { get; }
        /// <summary> Allotment number for the address. </summary>
        public string LotNumber { get; }
        /// <summary> Building/Property name 1. </summary>
        public string BuildingName1 { get; }
        /// <summary> Building/Property name 2. </summary>
        public string BuildingName2 { get; }
        /// <summary> The name of the street. </summary>
        public string StreetName { get; }
        /// <summary> The street type. Valid enumeration defined by Australia Post PAF code file. </summary>
        public string StreetType { get; }
        /// <summary> The street type suffix. Valid enumeration defined by Australia Post PAF code file. </summary>
        public string StreetSuffix { get; }
        /// <summary> Postal delivery type. (eg. PO BOX). Valid enumeration defined by Australia Post PAF code file. </summary>
        public string PostalDeliveryType { get; }
        /// <summary> Postal delivery number if the address is a postal delivery type. </summary>
        public int? PostalDeliveryNumber { get; }
        /// <summary> Postal delivery number prefix related to the postal delivery number. </summary>
        public string PostalDeliveryNumberPrefix { get; }
        /// <summary> Postal delivery number suffix related to the postal delivery number. </summary>
        public string PostalDeliveryNumberSuffix { get; }
        /// <summary> Full name of locality. </summary>
        public string LocalityName { get; }
        /// <summary> Postcode for the locality. </summary>
        public string Postcode { get; }
        /// <summary> State in which the address belongs. Valid enumeration defined by Australia Post PAF code file [State Type Abbreviation](https://auspost.com.au/content/dam/auspost_corp/media/documents/australia-post-data-guide.pdf). NSW, QLD, VIC, NT, WA, SA, TAS, ACT, AAT. </summary>
        public string State { get; }
    }
}