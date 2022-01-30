# Agl.Cdr.Energy.Models.EnergyDerRecordDerDevices

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DeviceIdentifier** | **decimal** | Unique identifier for a single DER device or a group of DER devices with the same attributes. Does not align with CDR ID permanence standards | 
**Count** | **decimal** | Number of devices in the group of DER devices | 
**Manufacturer** | **string** | The name of the device manufacturer. If absent then assumed to be “unknown” | [optional] 
**ModelNumber** | **string** | The model number of the device. If absent then assumed to be “unknown” | [optional] 
**Status** | **string** | Code used to indicate the status of the device. This will be used to identify if an inverter is active or inactive or decommissioned | [optional] 
**Type** | **string** | Used to indicate the primary technology used in the DER device | 
**Subtype** | **string** | Used to indicate the primary technology used in the DER device. This field is also used to record for example the battery chemistry, or the type of PV panel. It is also used to record if a battery is contained in an electric vehicle connected in a vehicle-to-grid arrangement. If absent then assumed to be “other” | [optional] 
**NominalRatedCapacity** | **decimal** | Maximum output in kVA that is listed in the product specification by the manufacturer. This refers to the capacity of each unit within the device group | 
**NominalStorageCapacity** | **decimal** | Maximum storage capacity in kVAh. This refers to the capacity of each storage module within the device group. Mandatory if type is equal to “STORAGE” | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

