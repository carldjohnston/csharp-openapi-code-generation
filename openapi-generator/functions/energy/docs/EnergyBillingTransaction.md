# Agl.Cdr.Energy.Models.EnergyBillingTransaction

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccountId** | **string** | The ID of the account for which transaction applies | 
**ExecutionDateTime** | **string** | The date and time that the transaction occurred | 
**Gst** | **string** | The GST incurred in the transaction.  Should not be included for credits or payments.  If absent zero is assumed | [optional] 
**TransactionUType** | **string** | Indicator of the type of transaction object present in this record | 
**Usage** | [**EnergyBillingUsageTransaction**](EnergyBillingUsageTransaction.md) |  | [optional] 
**Demand** | [**EnergyBillingDemandTransaction**](EnergyBillingDemandTransaction.md) |  | [optional] 
**OnceOff** | [**EnergyBillingOnceOffTransaction**](EnergyBillingOnceOffTransaction.md) |  | [optional] 
**OtherCharges** | [**EnergyBillingOtherTransaction**](EnergyBillingOtherTransaction.md) |  | [optional] 
**Payment** | [**EnergyBillingPaymentTransaction**](EnergyBillingPaymentTransaction.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

