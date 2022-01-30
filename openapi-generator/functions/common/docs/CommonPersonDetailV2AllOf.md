# Agl.Cdr.Common.Models.CommonPersonDetailV2AllOf

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PhoneNumbers** | [**List&lt;CommonPhoneNumber&gt;**](CommonPhoneNumber.md) | Array is mandatory but may be empty if no phone numbers are held | 
**EmailAddresses** | [**List&lt;CommonEmailAddress&gt;**](CommonEmailAddress.md) | May be empty | 
**PhysicalAddresses** | [**List&lt;CommonPhysicalAddressWithPurpose1&gt;**](CommonPhysicalAddressWithPurpose1.md) | Array is mandatory but may be empty if no valid addresses are held. One and only one address may have the purpose of REGISTERED. Zero or one, and no more than one, record may have the purpose of MAIL. If zero then the REGISTERED address is to be used for mail | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

