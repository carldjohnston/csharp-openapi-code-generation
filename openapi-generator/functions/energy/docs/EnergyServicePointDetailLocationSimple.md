# Agl.Cdr.Energy.Models.EnergyServicePointDetailLocationSimple
The address of the service point.  Mandatory if addressUType is set to simple

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MailingName** | **string** | Name of the individual or business formatted for inclusion in an address used for physical mail | [optional] 
**AddressLine1** | **string** | First line of the standard address object | 
**AddressLine2** | **string** | Second line of the standard address object | [optional] 
**AddressLine3** | **string** | Third line of the standard address object | [optional] 
**Postcode** | **string** | Mandatory for Australian addresses | [optional] 
**City** | **string** | Name of the city or locality | 
**State** | **string** | Free text if the country is not Australia. If country is Australia then must be one of the values defined by the [State Type Abbreviation](https://auspost.com.au/content/dam/auspost_corp/media/documents/australia-post-data-guide.pdf) in the PAF file format. NSW, QLD, VIC, NT, WA, SA, TAS, ACT, AAT | 
**Country** | **string** | A valid [ISO 3166 Alpha-3](https://www.iso.org/iso-3166-country-codes.html) country code. Australia (AUS) is assumed if country is not present. | [optional] [default to "AUS"]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

