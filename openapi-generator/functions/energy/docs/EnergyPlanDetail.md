# Agl.Cdr.Energy.Models.EnergyPlanDetail

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PlanId** | **string** | The ID of the specific plan | 
**EffectiveFrom** | **string** | The date and time from which this plan is effective (ie. is available for origination). Used to enable the articulation of products to the regime before they are available for customers to originate | [optional] 
**EffectiveTo** | **string** | The date and time at which this plan will be retired and will no longer be offered. Used to enable the managed deprecation of plans | [optional] 
**LastUpdated** | **string** | The last date and time that the information for this plan was changed (or the creation date for the plan if it has never been altered) | 
**DisplayName** | **string** | The display name of the plan | [optional] 
**Description** | **string** | A description of the plan | [optional] 
**Type** | **string** | The type of the plan | 
**FuelType** | **string** | The fuel types covered by the plan | 
**Brand** | **string** | The ID of the brand under which this plan is offered | 
**BrandName** | **string** | The display name of the brand under which this plan is offered | 
**ApplicationUri** | **string** | A link to an application web page where this plan can be applied for | [optional] 
**AdditionalInformation** | [**EnergyPlanAdditionalInformation**](EnergyPlanAdditionalInformation.md) |  | [optional] 
**CustomerType** | **string** | The type of customer that the plan is offered to.  If absent then the plan is available to all customers | [optional] 
**Geography** | [**EnergyPlanGeography**](EnergyPlanGeography.md) |  | [optional] 
**MeteringCharges** | [**List&lt;EnergyPlanDetailAllOfMeteringCharges&gt;**](EnergyPlanDetailAllOfMeteringCharges.md) | Charges for metering included in the plan | [optional] 
**GasContract** | [**EnergyPlanContractFull**](EnergyPlanContractFull.md) |  | [optional] 
**ElectricityContract** | [**EnergyPlanContractFull**](EnergyPlanContractFull.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

