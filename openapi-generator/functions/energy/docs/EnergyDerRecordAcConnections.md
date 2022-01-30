# Agl.Cdr.Energy.Models.EnergyDerRecordAcConnections

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ConnectionIdentifier** | **decimal** | AC Connection ID as defined in the DER register.  Does not align with CDR ID permanence standards | 
**Count** | **string** | Number of AC Connections in the group. For the suite of AC Connections to be considered as a group, all of the AC Connections included must have the same attributes | 
**EquipmentType** | **string** | Indicates whether the DER device is connected via an inverter (and what category of inverter it is) or not (e.g. rotating machine). If absent, assume equipment type to be “OTHER”. | [optional] 
**ManufacturerName** | **string** | The name of the inverter manufacturer. Mandatory if equipmentType is INVERTER | [optional] 
**InverterSeries** | **string** | The inverter series. Mandatory if equipmentType is INVERTER | [optional] 
**InverterModelNumber** | **string** | The inverter model number. Mandatory if equipmentType is INVERTER | [optional] 
**CommissioningDate** | **string** | The date that the DER installation is commissioned | 
**Status** | **string** | Code used to indicate the status of the Inverter. This will be used to identify if an inverter is active or inactive or decommissioned | 
**InverterDeviceCapacity** | **decimal** | The rated AC output power that is listed in the product specified by the manufacturer. Mandatory if equipmentType is INVERTER | [optional] 
**DerDevices** | [**List&lt;EnergyDerRecordDerDevices&gt;**](EnergyDerRecordDerDevices.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

