# Agl.Cdr.Energy.Models.EnergyDerRecord

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ServicePointId** | **string** | Tokenised ID of the service point to be used for referring to the service point in the CDR API suite.  To be created in accordance with CDR ID permanence requirements | 
**ApprovedCapacity** | **decimal** | Approved small generating unit capacity as agreed with NSP in the connection agreement, expressed in kVA | 
**AvailablePhasesCount** | **decimal** | The number of phases available for the installation of DER | 
**InstalledPhasesCount** | **decimal** | The number of phases that DER is connected to | 
**IslandableInstallation** | **string** | For identification of small generating units designed with the ability to operate in an islanded mode | 
**HasCentralProtectionControl** | **bool** | For DER installations where NSPs specify the need for additional forms of protection above those inbuilt in an inverter.  If absent then assumed to be false | [optional] [default to false]
**ProtectionMode** | [**EnergyDerRecordProtectionMode**](EnergyDerRecordProtectionMode.md) |  | [optional] 
**AcConnections** | [**List&lt;EnergyDerRecordAcConnections&gt;**](EnergyDerRecordAcConnections.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

