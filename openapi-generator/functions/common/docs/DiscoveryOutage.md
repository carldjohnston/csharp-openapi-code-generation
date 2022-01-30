# Agl.Cdr.Common.Models.DiscoveryOutage

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OutageTime** | **string** | Date and time that the outage is scheduled to begin | 
**Duration** | **string** | Planned duration of the outage. Formatted according to [ISO 8601 Durations](https://en.wikipedia.org/wiki/ISO_8601#Durations) (excludes recurrence syntax) | 
**IsPartial** | **bool** | Flag that indicates, if present and set to true, that the outage is only partial meaning that only a subset of normally available end points will be affected by the outage | [optional] 
**Explanation** | **string** | Provides an explanation of the current outage that can be displayed to an end customer | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

