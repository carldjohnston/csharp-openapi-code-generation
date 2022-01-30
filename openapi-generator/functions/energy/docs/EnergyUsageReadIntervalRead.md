# Agl.Cdr.Energy.Models.EnergyUsageReadIntervalRead
Mandatory if readUType is set to intervalRead

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ReadIntervalLength** | **string** | Read interval length in minutes | 
**AggregateValue** | **decimal** | The aggregate sum of the interval read values. If positive then it means net consumption, if negative it means net export | 
**IntervalReads** | [**List&lt;EnergyUsageReadIntervalReadIntervalReads&gt;**](EnergyUsageReadIntervalReadIntervalReads.md) | Array of reads with each element indicating the read for the interval specified by readIntervalLength beginning at midnight of readStartDate (for example 00:00 to 00:30 would be the first reading in a 30 minute Interval) | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

