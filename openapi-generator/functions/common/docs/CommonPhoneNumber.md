# Agl.Cdr.Common.Models.CommonPhoneNumber

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsPreferred** | **bool** | May be true for one and only one entry to indicate the preferred phone number. Assumed to be &#39;false&#39; if not present | [optional] 
**Purpose** | **string** | The purpose of the number as specified by the customer | 
**CountryCode** | **string** | If absent, assumed to be Australia (+61). The + should be included | [optional] 
**AreaCode** | **string** | Required for non Mobile Phones, if field is present and refers to Australian code - the leading 0 should be omitted. | [optional] 
**Number** | **string** | The actual phone number, with leading zeros as appropriate | 
**Extension** | **string** | An extension number (if applicable) | [optional] 
**FullNumber** | **string** | Fully formatted phone number with country code, area code, number and extension incorporated. Formatted according to section 5.1.4. of [RFC 3966](https://www.ietf.org/rfc/rfc3966.txt) | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

