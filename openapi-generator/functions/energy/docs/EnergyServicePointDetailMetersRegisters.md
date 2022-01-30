# Agl.Cdr.Energy.Models.EnergyServicePointDetailMetersRegisters
Usage data registers available from the meter

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RegisterId** | **string** | Unique identifier of the register within this service point.  Is not globally unique | 
**RegisterSuffix** | **string** | Register suffix of the meter register where the meter reads are obtained | 
**AveragedDailyLoad** | **decimal** | The energy delivered through a connection point or metering point over an extended period normalised to a &#39;per day&#39; basis (kWh). This value is calculated annually. | [optional] 
**RegisterConsumptionType** | **string** | Indicates the consumption type of register | 
**NetworkTariffCode** | **string** | The Network Tariff Code is a free text field containing a code supplied and published by the local network service provider | [optional] 
**UnitOfMeasure** | **string** | The unit of measure for data held in this register | [optional] 
**TimeOfDay** | **string** | Code to identify the time validity of register contents | [optional] 
**Multiplier** | **decimal** | Multiplier required to take a register value and turn it into a value representing billable energy | [optional] 
**ControlledLoad** | **bool** | Indicates whether the energy recorded by this register is created under a Controlled Load regime. ControlledLoad field will have &#39;No&#39; if register does not relate to a Controlled Load.  If the register relates to a Controlled Load, it should contain a description of the Controlled Load regime. ControlledLoad field will have &#39;No&#39; if register does not relate to a Controlled Load, “Yes” if register relates to a Controlled Load If absent the status is unknown.  | [optional] 
**ConsumptionType** | **string** | Actual/Subtractive Indicator. Note the details of enumeration values below: &lt;ul&gt;&lt;li&gt;**ACTUAL** implies volume of energy actually metered between two dates&lt;/li&gt;&lt;li&gt;**CUMULATIVE** indicates a meter reading for a specific date. A second Meter Reading is required to determine the consumption between those two Meter Reading dates&lt;/li&gt;&lt;/ul&gt; | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

