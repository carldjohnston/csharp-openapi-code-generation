# Agl.Cdr.Energy.Models.EnergyPlanContract

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AdditionalFeeInformation** | **string** | Free text field containing additional information of the fees for this contract | [optional] 
**PricingModel** | **string** | The pricing model for the contract.  Contracts for gas must use SINGLE_RATE.  Note that the detail for the enumeration values are:&lt;ul&gt;&lt;li&gt;**SINGLE_RATE** - all energy usage is charged at a single unit rate no matter when it is consumed. Multiple unit rates may exist that correspond to varying volumes of usage i.e. a ‘block’ or ‘step’ tariff (first 50kWh @ X cents, next 50kWh at Y cents etc.&lt;/li&gt;&lt;li&gt;**SINGLE_RATE_CONT_LOAD** - as above, but with an additional, separate unit rate charged for all energy usage from a controlled load i.e. separately metered appliance like hot water service, pool pump etc.&lt;/li&gt;&lt;li&gt;**TIME_OF_USE** - energy usage is charged at unit rates that vary dependent on time of day and day of week that the energy is consumed&lt;/li&gt;&lt;li&gt;**TIME_OF_USE_CONT_LOAD** - as above, but with an additional, separate unit rate charged for all energy usage from a controlled load i.e. separately metered appliance like hot water service, pool pump etc.&lt;/li&gt;&lt;li&gt;**FLEXIBLE** - energy usage is charged at unit rates that vary based on external factors&lt;/li&gt;&lt;li&gt;**FLEXIBLE_CONT_LOAD** - as above, but with an additional, separate unit rate charged for all energy usage from a controlled load i.e. separately metered appliance like hot water service, pool pump etc.&lt;/li&gt;&lt;li&gt;**QUOTA** - all energy usage is charged at a single fixed rate, up to a specified usage quota/allowance. All excess usage beyond the allowance is then charged at a single unit rate (may not be the best way to explain it but it is essentially a ‘subscription’ or telco style product i.e. $50/month for up to 150kWh included usage&lt;/li&gt;&lt;/ul&gt; | 
**TimeZone** | **string** | Required if pricingModel is set to TIME_OF_USE.  Defines the time zone to use for calculation of the time of use thresholds | [optional] 
**IsFixed** | **bool** | Flag indicating whether prices are fixed or variable | 
**Variation** | **string** | Free text description of price variation policy and conditions for the contract.  Mandatory if isFixed is true | [optional] 
**OnExpiryDescription** | **string** | Free text field that describes what will occur on or prior to expiry of the fixed contract term or benefit period | [optional] 
**PaymentOption** | **List&lt;string&gt;** | Payment options for this contract | 
**IntrinsicGreenPower** | [**EnergyPlanContractIntrinsicGreenPower**](EnergyPlanContractIntrinsicGreenPower.md) |  | [optional] 
**ControlledLoad** | [**EnergyPlanControlledLoad**](EnergyPlanControlledLoad.md) |  | [optional] 
**Incentives** | **List&lt;Object&gt;** | Optional list of incentives available for the contract | [optional] 
**Discounts** | **List&lt;Object&gt;** | Optional list of discounts available for the contract | [optional] 
**GreenPowerCharges** | **List&lt;Object&gt;** | Optional list of charges applicable to green power | [optional] 
**Eligibility** | **List&lt;Object&gt;** | Eligibility restrictions or requirements | [optional] 
**Fees** | **List&lt;Object&gt;** | An array of fees applicable to the plan | [optional] 
**SolarFeedInTariff** | **List&lt;Object&gt;** | Array of feed in tariffs for solar power | [optional] 
**TariffPeriod** | **List&lt;Object&gt;** | Array of tariff periods | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

