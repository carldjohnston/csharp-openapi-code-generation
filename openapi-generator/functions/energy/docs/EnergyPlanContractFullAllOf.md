# Agl.Cdr.Energy.Models.EnergyPlanContractFullAllOf

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TermType** | **string** | The term for the contract.  If absent assumes no specified term | [optional] 
**BenefitPeriod** | **string** | Description of the benefit period.  Should only be present if termType has the value ONGOING | [optional] 
**Terms** | **string** | Free text description of the terms for the contract | [optional] 
**MeterTypes** | **List&lt;string&gt;** | An array of the meter types that this contract is available for | [optional] 
**CoolingOffDays** | **string** | Number of days in the cooling off period for the contract.  Mandatory for plans with type of MARKET  | [optional] 
**BillFrequency** | **List&lt;string&gt;** | An array of the available billing schedules for this contract. Formatted according to [ISO 8601 Durations](https://en.wikipedia.org/wiki/ISO_8601#Durations) (excludes recurrence syntax) | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

