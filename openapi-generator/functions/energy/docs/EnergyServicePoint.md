# Agl.Cdr.Energy.Models.EnergyServicePoint

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ServicePointId** | **string** | Tokenised ID of the service point to be used for referring to the service point in the CDR API suite. To be created in accordance with CDR ID permanence requirements | 
**NationalMeteringId** | **string** | The independent ID of the service point, known in the industry as the NMI | 
**ServicePointClassification** | **string** | The classification of the service point as defined in MSATS procedures | 
**ServicePointStatus** | **string** | Code used to indicate the status of the service point. Note the details for the enumeration values below:&lt;ul&gt;&lt;li&gt;**ACTIVE** - An active, energised, service point&lt;/li&gt;&lt;li&gt;**DE_ENERGISED** - The service point exists but is deenergised&lt;/li&gt;&lt;li&gt;**EXTINCT** - The service point has been permanently decommissioned&lt;/li&gt;&lt;li&gt;**GREENFIELD** - Applies to a service point that has never been energised&lt;/li&gt;&lt;li&gt;**OFF_MARKET** - Applies when the service point is no longer settled in the NEM&lt;/li&gt;&lt;/ul&gt;  | 
**JurisdictionCode** | **string** | Jurisdiction code to which the service point belongs.This code defines the jurisdictional rules which apply to the service point. Note the details of enumeration values below:&lt;ul&gt;&lt;li&gt;**ALL** - All Jurisdictions&lt;/li&gt;&lt;li&gt;**ACT** - Australian Capital Territory&lt;/li&gt;&lt;li&gt;**NEM** - National Electricity Market&lt;/li&gt;&lt;li&gt;**NSW** - New South Wales&lt;/li&gt;&lt;li&gt;**QLD** - Queensland&lt;/li&gt;&lt;li&gt;**SA** - South Australia&lt;/li&gt;&lt;li&gt;**TAS** - Tasmania&lt;/li&gt;&lt;li&gt;**VIC** - Victoria&lt;/li&gt;&lt;/ul&gt; | 
**IsGenerator** | **bool** | This flag determines whether the energy at this connection point is to be treated as consumer load or as a generating unit(this may include generator auxiliary loads). If absent defaults to false. &lt;br&gt;**Note:** Only applicable for scheduled or semischeduled generators, does not indicate on site generation by consumer | [optional] 
**ValidFromDate** | **string** | The start date from which this service point first became valid | 
**LastUpdateDateTime** | **string** | The date and time that the information for this service point was modified | 
**ConsumerProfile** | [**EnergyServicePointConsumerProfile**](EnergyServicePointConsumerProfile.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

