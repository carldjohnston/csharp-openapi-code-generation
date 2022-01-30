# Agl.Cdr.Energy.Models.EnergyPlanGeography
Describes the geographical area that the plan is available for.  If absent then it is assumed the plan is not geographically limited

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ExcludedPostcodes** | **List&lt;string&gt;** | Array of valid Australian post codes that are specifically excluded from the plan.  Each element is a single four digit postcode (e.g. 3000) or a range of postcodes defined by two four digit postcodes and a hyphen (e.g. 3000-3999) | [optional] 
**IncludedPostcodes** | **List&lt;string&gt;** | Array of valid Australian post codes that are included from the plan.  If absent defaults to all non-excluded post codes.  Each element is a single four digit postcode (e.g. 3000) or a range of postcodes defined by two four digit postcodes and a hyphen (e.g. 3000-3999) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

