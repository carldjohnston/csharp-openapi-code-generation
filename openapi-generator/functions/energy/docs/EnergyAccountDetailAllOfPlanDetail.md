# Agl.Cdr.Energy.Models.EnergyAccountDetailAllOfPlanDetail
Detail on the plan applicable to this account

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FuelType** | **string** | The fuel types covered by the plan | 
**IsContingentPlan** | **bool** | Flag that indicates that the plan is contingent on the customer taking up an alternate fuel plan from the same retailer (for instance, if the fuelType is ELECTRICITY then a GAS plan from the same retailer must be taken up). Has no meaning if the plan has a fuelType of DUAL. If absent the value is assumed to be false | [optional] [default to false]
**MeteringCharges** | [**List&lt;EnergyPlanDetailAllOfMeteringCharges&gt;**](EnergyPlanDetailAllOfMeteringCharges.md) | Charges for metering included in the plan | [optional] 
**GasContract** | [**EnergyPlanContract**](EnergyPlanContract.md) |  | [optional] 
**ElectricityContract** | [**EnergyPlanContract**](EnergyPlanContract.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

