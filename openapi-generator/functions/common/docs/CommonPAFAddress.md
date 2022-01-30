# Agl.Cdr.Common.Models.CommonPAFAddress
Australian address formatted according to the file format defined by the [PAF file format](https://auspost.com.au/content/dam/auspost_corp/media/documents/australia-post-data-guide.pdf)

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Dpid** | **string** | Unique identifier for an address as defined by Australia Post.  Also known as Delivery Point Identifier | [optional] 
**ThoroughfareNumber1** | **int** | Thoroughfare number for a property (first number in a property ranged address) | [optional] 
**ThoroughfareNumber1Suffix** | **string** | Suffix for the thoroughfare number. Only relevant is thoroughfareNumber1 is populated | [optional] 
**ThoroughfareNumber2** | **int** | Second thoroughfare number (only used if the property has a ranged address eg 23-25) | [optional] 
**ThoroughfareNumber2Suffix** | **string** | Suffix for the second thoroughfare number. Only relevant is thoroughfareNumber2 is populated | [optional] 
**FlatUnitType** | **string** | Type of flat or unit for the address | [optional] 
**FlatUnitNumber** | **string** | Unit number (including suffix, if applicable) | [optional] 
**FloorLevelType** | **string** | Type of floor or level for the address | [optional] 
**FloorLevelNumber** | **string** | Floor or level number (including alpha characters) | [optional] 
**LotNumber** | **string** | Allotment number for the address | [optional] 
**BuildingName1** | **string** | Building/Property name 1 | [optional] 
**BuildingName2** | **string** | Building/Property name 2 | [optional] 
**StreetName** | **string** | The name of the street | [optional] 
**StreetType** | **string** | The street type. Valid enumeration defined by Australia Post PAF code file | [optional] 
**StreetSuffix** | **string** | The street type suffix. Valid enumeration defined by Australia Post PAF code file | [optional] 
**PostalDeliveryType** | **string** | Postal delivery type. (eg. PO BOX). Valid enumeration defined by Australia Post PAF code file | [optional] 
**PostalDeliveryNumber** | **int** | Postal delivery number if the address is a postal delivery type | [optional] 
**PostalDeliveryNumberPrefix** | **string** | Postal delivery number prefix related to the postal delivery number | [optional] 
**PostalDeliveryNumberSuffix** | **string** | Postal delivery number suffix related to the postal delivery number | [optional] 
**LocalityName** | **string** | Full name of locality | 
**Postcode** | **string** | Postcode for the locality | 
**State** | **string** | State in which the address belongs. Valid enumeration defined by Australia Post PAF code file [State Type Abbreviation](https://auspost.com.au/content/dam/auspost_corp/media/documents/australia-post-data-guide.pdf). NSW, QLD, VIC, NT, WA, SA, TAS, ACT, AAT | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

