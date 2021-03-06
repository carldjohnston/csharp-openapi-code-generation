# Agl.Cdr.Energy.Models.ErrorListResponseErrors

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **string** | The code of the error encountered. Where the error is specific to the respondent, an application-specific error code, expressed as a string value. If the error is application-specific, the URN code that the specific error extends must be provided in the meta object. Otherwise, the value is the error code URN. | 
**Title** | **string** | A short, human-readable summary of the problem that MUST NOT change from occurrence to occurrence of the problem represented by the error code. | 
**Detail** | **string** | A human-readable explanation specific to this occurrence of the problem. | 
**Meta** | [**ErrorListResponseMeta**](ErrorListResponseMeta.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

