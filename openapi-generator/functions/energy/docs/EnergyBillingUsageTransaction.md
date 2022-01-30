# Agl.Cdr.Energy.Models.EnergyBillingUsageTransaction

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ServicePointId** | **string** | The ID of the service point to which this transaction applies if any | [optional] 
**InvoiceNumber** | **string** | The number of the invoice in which this transaction is included if it has been issued | [optional] 
**TimeOfUseType** | **string** | The time of use type that the transaction applies to | 
**Description** | **string** | Optional description of the transaction that can be used for display purposes | [optional] 
**IsEstimate** | **bool** | Flag indicating if the usage is estimated or actual.  True indicates estimate.  False or absent indicates actual | [optional] 
**StartDate** | **string** | Date and time when the usage period starts | 
**EndDate** | **string** | Date and time when the usage period ends | 
**MeasureUnit** | **string** | The measurement unit of rate. Assumed to be KWH if absent | [optional] 
**Usage** | **decimal** | The usage for the period in measure unit.  A negative value indicates power generated | 
**Amount** | **string** | The amount charged or credited for this transaction prior to any adjustments being applied.  A negative value indicates a credit | 
**CalculationFactors** | [**List&lt;EnergyBillingUsageTransactionCalculationFactors&gt;**](EnergyBillingUsageTransactionCalculationFactors.md) | Additional calculation factors that inform the transaction | [optional] 
**Adjustments** | [**List&lt;EnergyBillingUsageTransactionAdjustments&gt;**](EnergyBillingUsageTransactionAdjustments.md) | Optional array of adjustments arising for this transaction | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

