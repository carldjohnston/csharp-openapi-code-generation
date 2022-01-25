# Agl.Cdr.Admin.Models.InvocationMetricsV2LargeSecondary
API call counts for the large Shared Responsibility Data Requests tier.  Mandatory for data holders designated for a Shared Responsibility Data Request data cluster

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CurrentDay** | **decimal** | API call counts for current day | [optional] 
**PreviousDays** | **List&lt;decimal&gt;** | API call counts for previous days. The first element indicates yesterday and so on. A maximum of seven entries is required if available | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

