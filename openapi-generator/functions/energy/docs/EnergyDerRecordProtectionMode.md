# Agl.Cdr.Energy.Models.EnergyDerRecordProtectionMode
Required only when the hasCentralProtectionAndControl flag is set to true.  One or more of the object fields will be provided to describe the protection modes in place

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ExportLimitkva** | **decimal** | Maximum amount of power (kVA) that may be exported from a connection point to the grid, as monitored by a control / relay function. An absent value indicates no limit | [optional] 
**UnderFrequencyProtection** | **decimal** | Protective function limit in Hz. | [optional] 
**UnderFrequencyProtectionDelay** | **decimal** | Trip delay time in seconds. | [optional] 
**OverFrequencyProtection** | **decimal** | Protective function limit in Hz. | [optional] 
**OverFrequencyProtectionDelay** | **decimal** | Trip delay time in seconds. | [optional] 
**UnderVoltageProtection** | **decimal** | Protective function limit in V. | [optional] 
**UnderVoltageProtectionDelay** | **decimal** | Trip delay time in seconds. | [optional] 
**OverVoltageProtection** | **decimal** | Protective function limit in V. | [optional] 
**OverVoltageProtectionDelay** | **decimal** | Trip delay time in seconds. | [optional] 
**SustainedOverVoltage** | **decimal** | Sustained over voltage. | [optional] 
**SustainedOverVoltageDelay** | **decimal** | Trip delay time in seconds. | [optional] 
**FrequencyRateOfChange** | **decimal** | Rate of change of frequency trip point (Hz/s). | [optional] 
**VoltageVectorShift** | **decimal** | Trip angle in degrees. | [optional] 
**InterTripScheme** | **string** | Description of the form of inter-trip (e.g. &#39;from local substation&#39;). | [optional] 
**NeutralVoltageDisplacement** | **decimal** | Trip voltage. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

