# Agl.Cdr.Energy.Models.EnergyInvoice

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccountId** | **string** | The ID of the account for which the invoice was issued | 
**InvoiceNumber** | **string** | The number assigned to this invoice by the energy Retailer | 
**IssueDate** | **string** | The date that the invoice was actually issued (as opposed to generated or calculated) | 
**DueDate** | **string** | The date that the invoice is due to be paid | [optional] 
**Period** | [**EnergyInvoicePeriod**](EnergyInvoicePeriod.md) |  | [optional] 
**InvoiceAmount** | **string** | The net amount due for this invoice regardless of previous balance | [optional] 
**GstAmount** | **string** | The total GST amount for this invoice.  If absent then zero is assumed | [optional] 
**PayOnTimeDiscount** | [**EnergyInvoicePayOnTimeDiscount**](EnergyInvoicePayOnTimeDiscount.md) |  | [optional] 
**BalanceAtIssue** | **string** | The account balance at the time the invoice was issued | 
**ServicePoints** | **List&lt;string&gt;** | Array of service point IDs to which this invoice applies. May be empty if the invoice contains no electricity usage related charges | 
**Gas** | [**EnergyInvoiceGasUsageCharges**](EnergyInvoiceGasUsageCharges.md) |  | [optional] 
**Electricity** | [**EnergyInvoiceElectricityUsageCharges**](EnergyInvoiceElectricityUsageCharges.md) |  | [optional] 
**AccountCharges** | [**EnergyInvoiceAccountCharges**](EnergyInvoiceAccountCharges.md) |  | [optional] 
**PaymentStatus** | **string** | Indicator of the payment status for the invoice | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

