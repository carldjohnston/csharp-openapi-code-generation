# Agl.Cdr.Energy.Models.EnergyPaymentScheduleCardDebit
Represents a regular credit card payment schedule. Mandatory if paymentScheduleUType is set to cardDebit

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CardScheme** | **string** | The type of credit card held on file | 
**PaymentFrequency** | **string** | The frequency that payments will occur.  Formatted according to [ISO 8601 Durations](https://en.wikipedia.org/wiki/ISO_8601#Durations) (excludes recurrence syntax) | 
**CalculationType** | **string** | The mechanism by which the payment amount is calculated.  Explanation of values are as follows:&lt;br/&gt;&lt;ul&gt;&lt;li&gt;**STATIC** - Indicates a consistent, static amount, per payment&lt;/li&gt;&lt;li&gt;**BALANCE** - Indicates that the outstanding balance for the account is paid per period&lt;/li&gt;&lt;li&gt;**CALCULATED** - Indicates that the payment amount is variable and calculated using a pre-defined algorithm&lt;/li&gt;&lt;/ul&gt; | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

