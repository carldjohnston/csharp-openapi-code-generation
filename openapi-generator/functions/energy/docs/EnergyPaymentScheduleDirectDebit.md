# Agl.Cdr.Energy.Models.EnergyPaymentScheduleDirectDebit
Represents a regular direct debit from a specified bank account. Mandatory if paymentScheduleUType is set to directDebit

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsTokenised** | **string** | Flag indicating that the account details are tokenised and cannot be shared.  False if absent.  If false then bsb and accountNumber should not be expected to be included | [optional] 
**Bsb** | **string** | The unmasked BSB for the account to be debited. Is expected to be formatted as digits only with leading zeros included and no punctuation or spaces.  Is required if isTokenised is absent or false | [optional] 
**AccountNumber** | **string** | The unmasked account number for the account to be debited. Is expected to be formatted as digits only with leading zeros included and no punctuation or spaces.  Is required if isTokenised is absent or false | [optional] 
**PaymentFrequency** | **string** | The frequency that payments will occur.  Formatted according to [ISO 8601 Durations](https://en.wikipedia.org/wiki/ISO_8601#Durations) (excludes recurrence syntax) | 
**CalculationType** | **string** | The mechanism by which the payment amount is calculated.  Explanation of values are as follows:&lt;br/&gt;&lt;ul&gt;&lt;li&gt;**STATIC** - Indicates a consistent, static amount, per payment&lt;/li&gt;&lt;li&gt;**BALANCE** - Indicates that the outstanding balance for the account is paid per period&lt;/li&gt;&lt;li&gt;**CALCULATED** - Indicates that the payment amount is variable and calculated using a pre-defined algorithm&lt;/li&gt;&lt;/ul&gt; | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

