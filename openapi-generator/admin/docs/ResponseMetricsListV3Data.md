# Org.OpenAPITools.Agl.Cdr.Admin.ResponseMetricsListV3Data

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RequestTime** | **string** | The date and time that the metrics in this payload were requested. | 
**Availability** | [**AvailabilityMetrics**](AvailabilityMetrics.md) |  | 
**Performance** | [**PerformanceMetrics**](PerformanceMetrics.md) |  | 
**Invocations** | [**InvocationMetricsV2**](InvocationMetricsV2.md) |  | 
**AverageResponse** | [**AverageResponseMetricsV2**](AverageResponseMetricsV2.md) |  | 
**SessionCount** | [**SessionCountMetrics**](SessionCountMetrics.md) |  | 
**AverageTps** | [**AverageTPSMetrics**](AverageTPSMetrics.md) |  | 
**PeakTps** | [**PeakTPSMetrics**](PeakTPSMetrics.md) |  | 
**Errors** | [**ErrorMetrics**](ErrorMetrics.md) |  | 
**Rejections** | [**RejectionMetricsV2**](RejectionMetricsV2.md) |  | 
**CustomerCount** | **int** | Number of customers with active authorisations at the time of the call | 
**RecipientCount** | **int** | Number of Data Recipient Software Products with active authorisations at the time of the call | 
**SecondaryHolder** | [**SecondaryHolderMetrics**](SecondaryHolderMetrics.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

