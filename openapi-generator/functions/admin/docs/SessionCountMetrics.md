# Agl.Cdr.Admin.Models.SessionCountMetrics
Session counts over time. Note that a session is defined as the provisioning of an Access Token.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CurrentDay** | **decimal** | Session count for current day | [optional] 
**PreviousDays** | **List&lt;decimal&gt;** | Session count for previous days. The first element indicates yesterday and so on. A maximum of seven entries is required if available | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

