# Agl.Cdr.Energy.Models.EnergyInvoiceElectricityUsageCharges

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TotalUsageCharges** | **string** | The aggregate total of usage charges for the period covered by the invoice (exclusive of GST) | 
**TotalGenerationCredits** | **string** | The aggregate total of generation credits for the period covered by the invoice (exclusive of GST) | 
**TotalOnceOffCharges** | **string** | The aggregate total of any once off charges arising from electricity usage for the period covered by the invoice (exclusive of GST) | 
**TotalOnceOffDiscounts** | **string** | The aggregate total of any once off discounts or credits arising from electricity usage for the period covered by the invoice (exclusive of GST) | 
**OtherCharges** | [**List&lt;EnergyInvoiceGasUsageChargesOtherCharges&gt;**](EnergyInvoiceGasUsageChargesOtherCharges.md) | Optional array of charges that may be part of the invoice (for e.g. environmental charges for C&amp;I consumers) (exclusive of GST) | [optional] 
**TotalGst** | **string** | The total GST for all electricity usage charges.  If absent then zero is assumed | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

