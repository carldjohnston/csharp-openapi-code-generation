# Org.OpenAPITools.Agl.Cdr.Admin.AvailabilityMetrics
Percentage availability of the CDR platform over time

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CurrentMonth** | **decimal** | Percentage availability of the CDR platform so far for the current calendar month. 0.0 means 0%. 1.0 means 100%. | [optional] 
**PreviousMonths** | **List&lt;decimal&gt;** | Percentage availability of the CDR platform for previous calendar months. The first element indicates the last month and so on. A maximum of twelve entries is required if available. 0.0 means 0%. 1.0 means 100%. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

