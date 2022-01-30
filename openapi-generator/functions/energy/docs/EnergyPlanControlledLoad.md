# Agl.Cdr.Energy.Models.EnergyPlanControlledLoad
Required if pricing model is SINGLE_RATE_CONT_LOAD or TIME_OF_USE_CONT_LOAD or FLEXIBLE_CONT_LOAD

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisplayName** | **string** | A display name for the controlled load tier | 
**Description** | **string** | A description of the controlled load tier | [optional] 
**DailyCharge** | **string** | The daily supply charge (exclusive of GST) for this controlled load tier | 
**Period** | **string** | The period for which the controlled load rate applies. Formatted according to [ISO 8601 Durations](https://en.wikipedia.org/wiki/ISO_8601#Durations) (excludes recurrence syntax) | 
**Rates** | [**List&lt;EnergyPlanControlledLoadRates&gt;**](EnergyPlanControlledLoadRates.md) | Array of controlled load rates in order of usage volume | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

