# Agl.Cdr.Energy.Models.EnergyUsageReadBasicRead
Mandatory if readUType is set to basicRead

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Quality** | **string** | The quality of the read taken.  If absent then assumed to be ACTUAL | [optional] [default to QualityEnum.ACTUAL]
**Value** | **decimal** | Meter read value.  If positive then it means consumption, if negative it means export | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

