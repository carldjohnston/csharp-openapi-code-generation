# Agl.Cdr.Common.Models.CommonPersonDetailV2

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LastUpdateTime** | **string** | The date and time that this record was last updated by the customer.  If no update has occurred then this date should reflect the initial creation date for the data | [optional] 
**FirstName** | **string** | For people with single names this field need not be present. The single name should be in the lastName field. Where a data holder cannot determine first and middle names from a collection of given names, a single string representing all given names MAY be provided. | [optional] 
**LastName** | **string** | For people with single names the single name should be in this field | 
**MiddleNames** | **List&lt;string&gt;** | Field is mandatory but array may be empty | 
**Prefix** | **string** | Also known as title or salutation.  The prefix to the name (e.g. Mr, Mrs, Ms, Miss, Sir, etc) | [optional] 
**Suffix** | **string** | Used for a trailing suffix to the name (e.g. Jr) | [optional] 
**OccupationCode** | **string** | Value is a valid [ANZSCO](http://www.abs.gov.au/ANZSCO) Standard Occupation classification code. If the occupation code held by the data holder is not one of the supported [ANZSCO](http://www.abs.gov.au/ANZSCO) versions, then it must not be supplied. | [optional] 
**OccupationCodeVersion** | **string** | The applicable [ANZSCO](http://www.abs.gov.au/ANZSCO) release version of the occupation code provided. Mandatory if an &#x60;&#x60;occupationCode&#x60;&#x60; is supplied. If &#x60;&#x60;occupationCode&#x60;&#x60; is supplied but &#x60;&#x60;occupationCodeVersion&#x60;&#x60; is absent, default is &#x60;&#x60;ANZSCO_1220.0_2013_V1.2&#x60;&#x60; | [optional] [default to OccupationCodeVersionEnum._2013V12]
**PhoneNumbers** | [**List&lt;CommonPhoneNumber&gt;**](CommonPhoneNumber.md) | Array is mandatory but may be empty if no phone numbers are held | 
**EmailAddresses** | [**List&lt;CommonEmailAddress&gt;**](CommonEmailAddress.md) | May be empty | 
**PhysicalAddresses** | [**List&lt;CommonPhysicalAddressWithPurpose1&gt;**](CommonPhysicalAddressWithPurpose1.md) | Array is mandatory but may be empty if no valid addresses are held. One and only one address may have the purpose of REGISTERED. Zero or one, and no more than one, record may have the purpose of MAIL. If zero then the REGISTERED address is to be used for mail | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

