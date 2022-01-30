# Agl.Cdr.Energy.Models.EnergyUsageRead

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ServicePointId** | **string** | Tokenised ID of the service point to be used for referring to the service point in the CDR API suite.  To be created in accordance with CDR ID permanence requirements | 
**RegisterId** | **string** | Register ID of the meter register where the meter reads are obtained | [optional] 
**RegisterSuffix** | **string** | Register suffix of the meter register where the meter reads are obtained | 
**MeterID** | **string** | Meter id/serial number as it appears in customer’s bill. ID permanence rules do not apply. | [optional] 
**ControlledLoad** | **bool** | Indicates whether the energy recorded by this register is created under a Controlled Load regime. ControlledLoad field will have &#39;No if register does not relate to a Controlled Load, “Yes” if register relates to a Controlled Load If absent the status is unknown.  | [optional] 
**ReadStartDate** | **string** | Date time when the meter reads start | 
**ReadEndDate** | **string** | Date time when the meter reads end.  If absent then assumed to be equal to readStartDate.  In this case the entry represents data for a single date specified by readStartDate | [optional] 
**UnitOfMeasure** | **string** | Unit of measure of the meter reads. Refer to Appendix B of &lt;a href&#x3D;&#39;https://www.aemo.com.au/-/media/files/stakeholder_consultation/consultations/nem-consultations/2019/5ms-metering-package-2/final-determination/mdff-specification-nem12-nem13-v21-final-determination-clean.pdf?la&#x3D;en&amp;hash&#x3D;03FCBA0D60E091DE00F2361AE76206EA&#39;&gt;MDFF Specification NEM12 NEM13 v2.1&lt;/a&gt; for a list of possible values | [optional] 
**ReadUType** | **string** | Specify the type of the meter read data | 
**BasicRead** | [**EnergyUsageReadBasicRead**](EnergyUsageReadBasicRead.md) |  | [optional] 
**IntervalRead** | [**EnergyUsageReadIntervalRead**](EnergyUsageReadIntervalRead.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

