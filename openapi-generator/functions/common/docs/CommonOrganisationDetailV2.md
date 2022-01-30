# Agl.Cdr.Common.Models.CommonOrganisationDetailV2

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LastUpdateTime** | **string** | The date and time that this record was last updated by the customer. If no update has occurred then this date should reflect the initial creation date for the data | [optional] 
**AgentFirstName** | **string** | The first name of the individual providing access on behalf of the organisation. For people with single names this field need not be present.  The single name should be in the lastName field | [optional] 
**AgentLastName** | **string** | The last name of the individual providing access on behalf of the organisation. For people with single names the single name should be in this field | 
**AgentRole** | **string** | The role of the individual identified as the agent who is providing authorisation.  Expected to be used for display. Default to Unspecified if the role is not known | 
**BusinessName** | **string** | Name of the organisation | 
**LegalName** | **string** | Legal name, if different to the business name | [optional] 
**ShortName** | **string** | Short name used for communication, if different to the business name | [optional] 
**Abn** | **string** | Australian Business Number for the organisation | [optional] 
**Acn** | **string** | Australian Company Number for the organisation. Required only if an ACN is applicable for the organisation type | [optional] 
**IsACNCRegistered** | **bool** | True if registered with the ACNC.  False if not. Absent or null if not confirmed. | [optional] 
**IndustryCode** | **string** | A valid [ANZSIC](http://www.abs.gov.au/ANZSIC) code for the organisation. If the industry code held by the data holder is not one of the supported [ANZSIC](http://www.abs.gov.au/ANZSIC) versions, then it must not be supplied. | [optional] 
**IndustryCodeVersion** | **string** | The applicable [ANZSIC](http://www.abs.gov.au/ANZSIC) release version of the industry code provided. Should only be supplied if &#x60;&#x60;industryCode&#x60;&#x60; is also supplied. If &#x60;&#x60;industryCode&#x60;&#x60; is supplied but &#x60;&#x60;industryCodeVersion&#x60;&#x60; is absent, default is &#x60;&#x60;ANZSIC_1292.0_2006_V2.0&#x60;&#x60; | [optional] [default to IndustryCodeVersionEnum.V20]
**OrganisationType** | **string** | Legal organisation type | 
**RegisteredCountry** | **string** | Enumeration with values from [ISO 3166 Alpha-3](https://www.iso.org/iso-3166-country-codes.html) country codes.  Assumed to be AUS if absent | [optional] 
**EstablishmentDate** | **string** | The date the organisation described was established | [optional] 
**PhysicalAddresses** | [**List&lt;CommonPhysicalAddressWithPurpose2&gt;**](CommonPhysicalAddressWithPurpose2.md) | Array is mandatory but may be empty if no valid addresses are held. One and only one address may have the purpose of REGISTERED. Zero or one, and no more than one, record may have the purpose of MAIL. If zero then the REGISTERED address is to be used for mail | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

