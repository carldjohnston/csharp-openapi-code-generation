# Agl.Cdr.Energy.Apis.EnergyApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAccount**](EnergyApi.md#getaccount) | **GET** /energy/accounts/{accountId} | Get Energy Account Detail
[**GetBalanceForAccount**](EnergyApi.md#getbalanceforaccount) | **GET** /energy/accounts/{accountId}/balance | Get Balance For Energy Account
[**GetBillingForAccount**](EnergyApi.md#getbillingforaccount) | **GET** /energy/accounts/{accountId}/billing | Get Billing For Account
[**GetConcessions**](EnergyApi.md#getconcessions) | **GET** /energy/accounts/{accountId}/concessions | Get Concessions
[**GetDERForServicePoint**](EnergyApi.md#getderforservicepoint) | **GET** /energy/electricity/servicepoints/{servicePointId}/der | Get DER For Service Point
[**GetInvoicesForAccount**](EnergyApi.md#getinvoicesforaccount) | **GET** /energy/accounts/{accountId}/invoices | Get Invoices For Account
[**GetPaymentSchedule**](EnergyApi.md#getpaymentschedule) | **GET** /energy/accounts/{accountId}/payment-schedule | Get Agreed Payment Schedule
[**GetPlan**](EnergyApi.md#getplan) | **GET** /energy/plans/{planId} | Get Generic Plan Detail
[**GetServicePoint**](EnergyApi.md#getservicepoint) | **GET** /energy/electricity/servicepoints/{servicePointId} | Get Service Point Detail
[**GetUsageForServicePoint**](EnergyApi.md#getusageforservicepoint) | **GET** /energy/electricity/servicepoints/{servicePointId}/usage | Get Usage For Service Point
[**ListAccounts**](EnergyApi.md#listaccounts) | **GET** /energy/accounts | Get Energy Accounts
[**ListBalancesBulk**](EnergyApi.md#listbalancesbulk) | **GET** /energy/accounts/balances | Get Bulk Balances for Energy
[**ListBalancesForAccounts**](EnergyApi.md#listbalancesforaccounts) | **POST** /energy/accounts/balances | Get Balances For Specific Energy Accounts
[**ListBillingBulk**](EnergyApi.md#listbillingbulk) | **GET** /energy/accounts/billing | Get Bulk Billing
[**ListBillingForAccounts**](EnergyApi.md#listbillingforaccounts) | **POST** /energy/accounts/billing | Get Billing For Specific Accounts
[**ListDERBulk**](EnergyApi.md#listderbulk) | **GET** /energy/electricity/servicepoints/der | Get Bulk DER
[**ListDERForServicePoints**](EnergyApi.md#listderforservicepoints) | **POST** /energy/electricity/servicepoints/der | Get DER For Specific Service Points
[**ListInvoicesBulk**](EnergyApi.md#listinvoicesbulk) | **GET** /energy/accounts/invoices | Get Bulk Invoices
[**ListInvoicesForAccounts**](EnergyApi.md#listinvoicesforaccounts) | **POST** /energy/accounts/invoices | Get Invoices For Specific Accounts
[**ListPlans**](EnergyApi.md#listplans) | **GET** /energy/plans | Get Generic Plans
[**ListServicePoints**](EnergyApi.md#listservicepoints) | **GET** /energy/electricity/servicepoints | Get Service Points
[**ListUsageBulk**](EnergyApi.md#listusagebulk) | **GET** /energy/electricity/servicepoints/usage | Get Bulk Usage
[**ListUsageForServicePoints**](EnergyApi.md#listusageforservicepoints) | **POST** /energy/electricity/servicepoints/usage | Get Usage For Specific Service Points


<a name="getaccount"></a>
# **GetAccount**
> EnergyAccountDetailResponse GetAccount (string accountId, string xV, string xMinV = null, string xFapiInteractionId = null, string xFapiAuthDate = null, string xFapiCustomerIpAddress = null, string xCdsClientHeaders = null)

Get Energy Account Detail

Obtain detailed information for a specific energy account

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agl.Cdr.Energy.Apis;
using Agl.Cdr.Energy.Client;
using Agl.Cdr.Energy.Models;

namespace Example
{
    public class GetAccountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new EnergyApi(config);
            var accountId = accountId_example;  // string | ID of a specific account to obtain data for.  This is a tokenised ID previous obtained from the Account List end point.
            var xV = xV_example;  // string | Version of the API end point requested by the client. Must be set to a positive integer. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If the value of [x-min-v](#request-headers) is equal to or higher than the value of [x-v](#request-headers) then the [x-min-v](#request-headers) header should be treated as absent. If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. See [HTTP Headers](#request-headers)
            var xMinV = xMinV_example;  // string | Minimum version of the API end point requested by the client. Must be set to a positive integer if provided. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. (optional) 
            var xFapiInteractionId = xFapiInteractionId_example;  // string | An [RFC4122](https://tools.ietf.org/html/rfc4122) UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a [RFC4122] UUID value is required to be provided in the response header to track the interaction. (optional) 
            var xFapiAuthDate = xFapiAuthDate_example;  // string | The time when the customer last logged in to the data recipient. Required for all resource calls (customer present and unattended). Not to be included for unauthenticated calls. (optional) 
            var xFapiCustomerIpAddress = xFapiCustomerIpAddress_example;  // string | The customer's original IP address if the customer is currently logged in to the data recipient. The presence of this header indicates that the API is being called in a customer present context. Not to be included for unauthenticated calls. (optional) 
            var xCdsClientHeaders = xCdsClientHeaders_example;  // string | The customer's original standard http headers [Base64](#common-field-types) encoded, including the original User Agent header, if the customer is currently logged in to the data recipient. Mandatory for customer present calls.  Not required for unattended or unauthenticated calls. (optional) 

            try
            {
                // Get Energy Account Detail
                EnergyAccountDetailResponse result = apiInstance.GetAccount(accountId, xV, xMinV, xFapiInteractionId, xFapiAuthDate, xFapiCustomerIpAddress, xCdsClientHeaders);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EnergyApi.GetAccount: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| ID of a specific account to obtain data for.  This is a tokenised ID previous obtained from the Account List end point. | 
 **xV** | **string**| Version of the API end point requested by the client. Must be set to a positive integer. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If the value of [x-min-v](#request-headers) is equal to or higher than the value of [x-v](#request-headers) then the [x-min-v](#request-headers) header should be treated as absent. If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. See [HTTP Headers](#request-headers) | 
 **xMinV** | **string**| Minimum version of the API end point requested by the client. Must be set to a positive integer if provided. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. | [optional] 
 **xFapiInteractionId** | **string**| An [RFC4122](https://tools.ietf.org/html/rfc4122) UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a [RFC4122] UUID value is required to be provided in the response header to track the interaction. | [optional] 
 **xFapiAuthDate** | **string**| The time when the customer last logged in to the data recipient. Required for all resource calls (customer present and unattended). Not to be included for unauthenticated calls. | [optional] 
 **xFapiCustomerIpAddress** | **string**| The customer&#39;s original IP address if the customer is currently logged in to the data recipient. The presence of this header indicates that the API is being called in a customer present context. Not to be included for unauthenticated calls. | [optional] 
 **xCdsClientHeaders** | **string**| The customer&#39;s original standard http headers [Base64](#common-field-types) encoded, including the original User Agent header, if the customer is currently logged in to the data recipient. Mandatory for customer present calls.  Not required for unattended or unauthenticated calls. | [optional] 

### Return type

[**EnergyAccountDetailResponse**](EnergyAccountDetailResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  * x-v -  <br>  * x-fapi-interaction-id -  <br>  |
| **0** | The following error codes MUST be supported:&lt;br/&gt;&lt;ul class&#x3D;\&quot;error-code-list\&quot;&gt;&lt;li&gt;[400 - Invalid Field](#error-400-field-invalid)&lt;/li&gt;&lt;li&gt;[400 - Invalid Version](#error-400-header-invalid-version)&lt;/li&gt;&lt;li&gt;[406 - Unsupported Version](#error-406-header-unsupported-version)&lt;/li&gt;&lt;li&gt;[404 - Unavailable Energy Account](#error-404-unavailable-energy-account)&lt;/li&gt;&lt;li&gt;[404 - Invalid Energy Account](#error-404-invalid-energy-account)&lt;/li&gt;&lt;/ul&gt; |  * x-fapi-interaction-id -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbalanceforaccount"></a>
# **GetBalanceForAccount**
> EnergyBalanceResponse GetBalanceForAccount (string accountId, string xV, string xMinV = null, string xFapiInteractionId = null, string xFapiAuthDate = null, string xFapiCustomerIpAddress = null, string xCdsClientHeaders = null)

Get Balance For Energy Account

Obtain the current balance for a specific account

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agl.Cdr.Energy.Apis;
using Agl.Cdr.Energy.Client;
using Agl.Cdr.Energy.Models;

namespace Example
{
    public class GetBalanceForAccountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new EnergyApi(config);
            var accountId = accountId_example;  // string | ID of a specific account to obtain data for.  This is a tokenised ID previous obtained from the Account List end point.
            var xV = xV_example;  // string | Version of the API end point requested by the client. Must be set to a positive integer. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If the value of [x-min-v](#request-headers) is equal to or higher than the value of [x-v](#request-headers) then the [x-min-v](#request-headers) header should be treated as absent. If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. See [HTTP Headers](#request-headers)
            var xMinV = xMinV_example;  // string | Minimum version of the API end point requested by the client. Must be set to a positive integer if provided. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. (optional) 
            var xFapiInteractionId = xFapiInteractionId_example;  // string | An [RFC4122](https://tools.ietf.org/html/rfc4122) UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a [RFC4122] UUID value is required to be provided in the response header to track the interaction. (optional) 
            var xFapiAuthDate = xFapiAuthDate_example;  // string | The time when the customer last logged in to the data recipient. Required for all resource calls (customer present and unattended). Not to be included for unauthenticated calls. (optional) 
            var xFapiCustomerIpAddress = xFapiCustomerIpAddress_example;  // string | The customer's original IP address if the customer is currently logged in to the data recipient. The presence of this header indicates that the API is being called in a customer present context. Not to be included for unauthenticated calls. (optional) 
            var xCdsClientHeaders = xCdsClientHeaders_example;  // string | The customer's original standard http headers [Base64](#common-field-types) encoded, including the original User Agent header, if the customer is currently logged in to the data recipient. Mandatory for customer present calls.  Not required for unattended or unauthenticated calls. (optional) 

            try
            {
                // Get Balance For Energy Account
                EnergyBalanceResponse result = apiInstance.GetBalanceForAccount(accountId, xV, xMinV, xFapiInteractionId, xFapiAuthDate, xFapiCustomerIpAddress, xCdsClientHeaders);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EnergyApi.GetBalanceForAccount: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| ID of a specific account to obtain data for.  This is a tokenised ID previous obtained from the Account List end point. | 
 **xV** | **string**| Version of the API end point requested by the client. Must be set to a positive integer. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If the value of [x-min-v](#request-headers) is equal to or higher than the value of [x-v](#request-headers) then the [x-min-v](#request-headers) header should be treated as absent. If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. See [HTTP Headers](#request-headers) | 
 **xMinV** | **string**| Minimum version of the API end point requested by the client. Must be set to a positive integer if provided. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. | [optional] 
 **xFapiInteractionId** | **string**| An [RFC4122](https://tools.ietf.org/html/rfc4122) UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a [RFC4122] UUID value is required to be provided in the response header to track the interaction. | [optional] 
 **xFapiAuthDate** | **string**| The time when the customer last logged in to the data recipient. Required for all resource calls (customer present and unattended). Not to be included for unauthenticated calls. | [optional] 
 **xFapiCustomerIpAddress** | **string**| The customer&#39;s original IP address if the customer is currently logged in to the data recipient. The presence of this header indicates that the API is being called in a customer present context. Not to be included for unauthenticated calls. | [optional] 
 **xCdsClientHeaders** | **string**| The customer&#39;s original standard http headers [Base64](#common-field-types) encoded, including the original User Agent header, if the customer is currently logged in to the data recipient. Mandatory for customer present calls.  Not required for unattended or unauthenticated calls. | [optional] 

### Return type

[**EnergyBalanceResponse**](EnergyBalanceResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  * x-v -  <br>  * x-fapi-interaction-id -  <br>  |
| **0** | The following error codes MUST be supported:&lt;br/&gt;&lt;ul class&#x3D;\&quot;error-code-list\&quot;&gt;&lt;li&gt;[400 - Invalid Field](#error-400-field-invalid)&lt;/li&gt;&lt;li&gt;[400 - Invalid Version](#error-400-header-invalid-version)&lt;/li&gt;&lt;li&gt;[406 - Unsupported Version](#error-406-header-unsupported-version)&lt;/li&gt;&lt;li&gt;[404 - Unavailable Energy Account](#error-404-unavailable-energy-account)&lt;/li&gt;&lt;li&gt;[404 - Invalid Energy Account](#error-404-invalid-energy-account)&lt;/li&gt;&lt;/ul&gt; |  * x-fapi-interaction-id -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbillingforaccount"></a>
# **GetBillingForAccount**
> EnergyBillingListResponse GetBillingForAccount (string accountId, string xV, string newestTime = null, string oldestTime = null, decimal? page = null, decimal? pageSize = null, string xMinV = null, string xFapiInteractionId = null, string xFapiAuthDate = null, string xFapiCustomerIpAddress = null, string xCdsClientHeaders = null)

Get Billing For Account

Obtain the billing transactions for a specific account

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agl.Cdr.Energy.Apis;
using Agl.Cdr.Energy.Client;
using Agl.Cdr.Energy.Models;

namespace Example
{
    public class GetBillingForAccountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new EnergyApi(config);
            var accountId = accountId_example;  // string | ID of a specific account to obtain data for.  This is a tokenised ID previous obtained from the Account List end point.
            var xV = xV_example;  // string | Version of the API end point requested by the client. Must be set to a positive integer. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If the value of [x-min-v](#request-headers) is equal to or higher than the value of [x-v](#request-headers) then the [x-min-v](#request-headers) header should be treated as absent. If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. See [HTTP Headers](#request-headers)
            var newestTime = newestTime_example;  // string | Constrain the request to records with effective time at or before this date/time.  If absent defaults to current date/time.  Format is aligned to DateTimeString common type (optional) 
            var oldestTime = oldestTime_example;  // string | Constrain the request to records with effective time at or after this date/time. If absent defaults to newest-time minus 12 months.  Format is aligned to DateTimeString common type (optional) 
            var page = 8.14;  // decimal? | Page of results to request (standard pagination) (optional) 
            var pageSize = 8.14;  // decimal? | Page size to request.  Default is 25 (standard pagination) (optional) 
            var xMinV = xMinV_example;  // string | Minimum version of the API end point requested by the client. Must be set to a positive integer if provided. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. (optional) 
            var xFapiInteractionId = xFapiInteractionId_example;  // string | An [RFC4122](https://tools.ietf.org/html/rfc4122) UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a [RFC4122] UUID value is required to be provided in the response header to track the interaction. (optional) 
            var xFapiAuthDate = xFapiAuthDate_example;  // string | The time when the customer last logged in to the data recipient. Required for all resource calls (customer present and unattended). Not to be included for unauthenticated calls. (optional) 
            var xFapiCustomerIpAddress = xFapiCustomerIpAddress_example;  // string | The customer's original IP address if the customer is currently logged in to the data recipient. The presence of this header indicates that the API is being called in a customer present context. Not to be included for unauthenticated calls. (optional) 
            var xCdsClientHeaders = xCdsClientHeaders_example;  // string | The customer's original standard http headers [Base64](#common-field-types) encoded, including the original User Agent header, if the customer is currently logged in to the data recipient. Mandatory for customer present calls.  Not required for unattended or unauthenticated calls. (optional) 

            try
            {
                // Get Billing For Account
                EnergyBillingListResponse result = apiInstance.GetBillingForAccount(accountId, xV, newestTime, oldestTime, page, pageSize, xMinV, xFapiInteractionId, xFapiAuthDate, xFapiCustomerIpAddress, xCdsClientHeaders);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EnergyApi.GetBillingForAccount: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| ID of a specific account to obtain data for.  This is a tokenised ID previous obtained from the Account List end point. | 
 **xV** | **string**| Version of the API end point requested by the client. Must be set to a positive integer. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If the value of [x-min-v](#request-headers) is equal to or higher than the value of [x-v](#request-headers) then the [x-min-v](#request-headers) header should be treated as absent. If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. See [HTTP Headers](#request-headers) | 
 **newestTime** | **string**| Constrain the request to records with effective time at or before this date/time.  If absent defaults to current date/time.  Format is aligned to DateTimeString common type | [optional] 
 **oldestTime** | **string**| Constrain the request to records with effective time at or after this date/time. If absent defaults to newest-time minus 12 months.  Format is aligned to DateTimeString common type | [optional] 
 **page** | **decimal?**| Page of results to request (standard pagination) | [optional] 
 **pageSize** | **decimal?**| Page size to request.  Default is 25 (standard pagination) | [optional] 
 **xMinV** | **string**| Minimum version of the API end point requested by the client. Must be set to a positive integer if provided. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. | [optional] 
 **xFapiInteractionId** | **string**| An [RFC4122](https://tools.ietf.org/html/rfc4122) UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a [RFC4122] UUID value is required to be provided in the response header to track the interaction. | [optional] 
 **xFapiAuthDate** | **string**| The time when the customer last logged in to the data recipient. Required for all resource calls (customer present and unattended). Not to be included for unauthenticated calls. | [optional] 
 **xFapiCustomerIpAddress** | **string**| The customer&#39;s original IP address if the customer is currently logged in to the data recipient. The presence of this header indicates that the API is being called in a customer present context. Not to be included for unauthenticated calls. | [optional] 
 **xCdsClientHeaders** | **string**| The customer&#39;s original standard http headers [Base64](#common-field-types) encoded, including the original User Agent header, if the customer is currently logged in to the data recipient. Mandatory for customer present calls.  Not required for unattended or unauthenticated calls. | [optional] 

### Return type

[**EnergyBillingListResponse**](EnergyBillingListResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  * x-v -  <br>  * x-fapi-interaction-id -  <br>  |
| **0** | The following error codes MUST be supported:&lt;br/&gt;&lt;ul class&#x3D;\&quot;error-code-list\&quot;&gt;&lt;li&gt;[400 - Invalid Field](#error-400-field-invalid)&lt;/li&gt;&lt;li&gt;[400 - Invalid Page Size](#error-400-field-invalid-page-size)&lt;/li&gt;&lt;li&gt;[400 - Invalid Version](#error-400-header-invalid-version)&lt;/li&gt;&lt;li&gt;[406 - Unsupported Version](#error-406-header-unsupported-version)&lt;/li&gt;&lt;li&gt;[422 - Invalid Page](#error-422-field-invalid-page)&lt;/li&gt;&lt;li&gt;[404 - Unavailable Energy Account](#error-404-unavailable-energy-account)&lt;/li&gt;&lt;li&gt;[404 - Invalid Energy Account](#error-404-invalid-energy-account)&lt;/li&gt;&lt;/ul&gt; |  * x-fapi-interaction-id -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getconcessions"></a>
# **GetConcessions**
> EnergyConcessionsResponse GetConcessions (string accountId, string xV, string xMinV = null, string xFapiInteractionId = null, string xFapiAuthDate = null, string xFapiCustomerIpAddress = null, string xCdsClientHeaders = null)

Get Concessions

Obtain the details of any concessions or arrangements applied to a specific energy account

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agl.Cdr.Energy.Apis;
using Agl.Cdr.Energy.Client;
using Agl.Cdr.Energy.Models;

namespace Example
{
    public class GetConcessionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new EnergyApi(config);
            var accountId = accountId_example;  // string | ID of a specific account to obtain data for.  This is a tokenised ID previous obtained from the Account List end point.
            var xV = xV_example;  // string | Version of the API end point requested by the client. Must be set to a positive integer. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If the value of [x-min-v](#request-headers) is equal to or higher than the value of [x-v](#request-headers) then the [x-min-v](#request-headers) header should be treated as absent. If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. See [HTTP Headers](#request-headers)
            var xMinV = xMinV_example;  // string | Minimum version of the API end point requested by the client. Must be set to a positive integer if provided. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. (optional) 
            var xFapiInteractionId = xFapiInteractionId_example;  // string | An [RFC4122](https://tools.ietf.org/html/rfc4122) UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a [RFC4122] UUID value is required to be provided in the response header to track the interaction. (optional) 
            var xFapiAuthDate = xFapiAuthDate_example;  // string | The time when the customer last logged in to the data recipient. Required for all resource calls (customer present and unattended). Not to be included for unauthenticated calls. (optional) 
            var xFapiCustomerIpAddress = xFapiCustomerIpAddress_example;  // string | The customer's original IP address if the customer is currently logged in to the data recipient. The presence of this header indicates that the API is being called in a customer present context. Not to be included for unauthenticated calls. (optional) 
            var xCdsClientHeaders = xCdsClientHeaders_example;  // string | The customer's original standard http headers [Base64](#common-field-types) encoded, including the original User Agent header, if the customer is currently logged in to the data recipient. Mandatory for customer present calls.  Not required for unattended or unauthenticated calls. (optional) 

            try
            {
                // Get Concessions
                EnergyConcessionsResponse result = apiInstance.GetConcessions(accountId, xV, xMinV, xFapiInteractionId, xFapiAuthDate, xFapiCustomerIpAddress, xCdsClientHeaders);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EnergyApi.GetConcessions: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| ID of a specific account to obtain data for.  This is a tokenised ID previous obtained from the Account List end point. | 
 **xV** | **string**| Version of the API end point requested by the client. Must be set to a positive integer. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If the value of [x-min-v](#request-headers) is equal to or higher than the value of [x-v](#request-headers) then the [x-min-v](#request-headers) header should be treated as absent. If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. See [HTTP Headers](#request-headers) | 
 **xMinV** | **string**| Minimum version of the API end point requested by the client. Must be set to a positive integer if provided. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. | [optional] 
 **xFapiInteractionId** | **string**| An [RFC4122](https://tools.ietf.org/html/rfc4122) UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a [RFC4122] UUID value is required to be provided in the response header to track the interaction. | [optional] 
 **xFapiAuthDate** | **string**| The time when the customer last logged in to the data recipient. Required for all resource calls (customer present and unattended). Not to be included for unauthenticated calls. | [optional] 
 **xFapiCustomerIpAddress** | **string**| The customer&#39;s original IP address if the customer is currently logged in to the data recipient. The presence of this header indicates that the API is being called in a customer present context. Not to be included for unauthenticated calls. | [optional] 
 **xCdsClientHeaders** | **string**| The customer&#39;s original standard http headers [Base64](#common-field-types) encoded, including the original User Agent header, if the customer is currently logged in to the data recipient. Mandatory for customer present calls.  Not required for unattended or unauthenticated calls. | [optional] 

### Return type

[**EnergyConcessionsResponse**](EnergyConcessionsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  * x-v -  <br>  * x-fapi-interaction-id -  <br>  |
| **0** | The following error codes MUST be supported:&lt;br/&gt;&lt;ul class&#x3D;\&quot;error-code-list\&quot;&gt;&lt;li&gt;[400 - Invalid Field](#error-400-field-invalid)&lt;/li&gt;&lt;li&gt;[400 - Invalid Version](#error-400-header-invalid-version)&lt;/li&gt;&lt;li&gt;[406 - Unsupported Version](#error-406-header-unsupported-version)&lt;/li&gt;&lt;li&gt;[404 - Unavailable Energy Account](#error-404-unavailable-energy-account)&lt;/li&gt;&lt;li&gt;[404 - Invalid Energy Account](#error-404-invalid-energy-account)&lt;/li&gt;&lt;/ul&gt; |  * x-fapi-interaction-id -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getderforservicepoint"></a>
# **GetDERForServicePoint**
> EnergyDerDetailResponse GetDERForServicePoint (string servicePointId, string xV, string xMinV = null, string xFapiInteractionId = null, string xFapiAuthDate = null, string xFapiCustomerIpAddress = null, string xCdsClientHeaders = null)

Get DER For Service Point

Obtain a list of DER data from a particular service point

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agl.Cdr.Energy.Apis;
using Agl.Cdr.Energy.Client;
using Agl.Cdr.Energy.Models;

namespace Example
{
    public class GetDERForServicePointExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new EnergyApi(config);
            var servicePointId = servicePointId_example;  // string | ID of the specific service point requested.  This is a tokenised ID previous obtained from the Service Point List Data end point.  Note that it is not a nationalMeteringId.
            var xV = xV_example;  // string | Version of the API end point requested by the client. Must be set to a positive integer. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If the value of [x-min-v](#request-headers) is equal to or higher than the value of [x-v](#request-headers) then the [x-min-v](#request-headers) header should be treated as absent. If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. See [HTTP Headers](#request-headers)
            var xMinV = xMinV_example;  // string | Minimum version of the API end point requested by the client. Must be set to a positive integer if provided. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. (optional) 
            var xFapiInteractionId = xFapiInteractionId_example;  // string | An [RFC4122](https://tools.ietf.org/html/rfc4122) UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a [RFC4122] UUID value is required to be provided in the response header to track the interaction. (optional) 
            var xFapiAuthDate = xFapiAuthDate_example;  // string | The time when the customer last logged in to the data recipient. Required for all resource calls (customer present and unattended). Not to be included for unauthenticated calls. (optional) 
            var xFapiCustomerIpAddress = xFapiCustomerIpAddress_example;  // string | The customer's original IP address if the customer is currently logged in to the data recipient. The presence of this header indicates that the API is being called in a customer present context. Not to be included for unauthenticated calls. (optional) 
            var xCdsClientHeaders = xCdsClientHeaders_example;  // string | The customer's original standard http headers [Base64](#common-field-types) encoded, including the original User Agent header, if the customer is currently logged in to the data recipient. Mandatory for customer present calls.  Not required for unattended or unauthenticated calls. (optional) 

            try
            {
                // Get DER For Service Point
                EnergyDerDetailResponse result = apiInstance.GetDERForServicePoint(servicePointId, xV, xMinV, xFapiInteractionId, xFapiAuthDate, xFapiCustomerIpAddress, xCdsClientHeaders);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EnergyApi.GetDERForServicePoint: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **servicePointId** | **string**| ID of the specific service point requested.  This is a tokenised ID previous obtained from the Service Point List Data end point.  Note that it is not a nationalMeteringId. | 
 **xV** | **string**| Version of the API end point requested by the client. Must be set to a positive integer. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If the value of [x-min-v](#request-headers) is equal to or higher than the value of [x-v](#request-headers) then the [x-min-v](#request-headers) header should be treated as absent. If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. See [HTTP Headers](#request-headers) | 
 **xMinV** | **string**| Minimum version of the API end point requested by the client. Must be set to a positive integer if provided. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. | [optional] 
 **xFapiInteractionId** | **string**| An [RFC4122](https://tools.ietf.org/html/rfc4122) UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a [RFC4122] UUID value is required to be provided in the response header to track the interaction. | [optional] 
 **xFapiAuthDate** | **string**| The time when the customer last logged in to the data recipient. Required for all resource calls (customer present and unattended). Not to be included for unauthenticated calls. | [optional] 
 **xFapiCustomerIpAddress** | **string**| The customer&#39;s original IP address if the customer is currently logged in to the data recipient. The presence of this header indicates that the API is being called in a customer present context. Not to be included for unauthenticated calls. | [optional] 
 **xCdsClientHeaders** | **string**| The customer&#39;s original standard http headers [Base64](#common-field-types) encoded, including the original User Agent header, if the customer is currently logged in to the data recipient. Mandatory for customer present calls.  Not required for unattended or unauthenticated calls. | [optional] 

### Return type

[**EnergyDerDetailResponse**](EnergyDerDetailResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  * x-v -  <br>  * x-fapi-interaction-id -  <br>  |
| **0** | The following error codes MUST be supported:&lt;br/&gt;&lt;ul class&#x3D;\&quot;error-code-list\&quot;&gt;&lt;li&gt;[400 - Invalid Field](#error-400-field-invalid)&lt;/li&gt;&lt;li&gt;[400 - Invalid Version](#error-400-header-invalid-version)&lt;/li&gt;&lt;li&gt;[406 - Unsupported Version](#error-406-header-unsupported-version)&lt;/li&gt;&lt;li&gt;[404 - Unavailable Service Point](#error-404-unavailable-service-point)&lt;/li&gt;&lt;li&gt;[404 - Invalid Service Point](#error-404-invalid-service-point)&lt;/li&gt;&lt;/ul&gt; |  * x-fapi-interaction-id -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinvoicesforaccount"></a>
# **GetInvoicesForAccount**
> EnergyInvoiceListResponse GetInvoicesForAccount (string accountId, string xV, string newestDate = null, string oldestDate = null, decimal? page = null, decimal? pageSize = null, string xMinV = null, string xFapiInteractionId = null, string xFapiAuthDate = null, string xFapiCustomerIpAddress = null, string xCdsClientHeaders = null)

Get Invoices For Account

Obtain the invoices for a specific account

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agl.Cdr.Energy.Apis;
using Agl.Cdr.Energy.Client;
using Agl.Cdr.Energy.Models;

namespace Example
{
    public class GetInvoicesForAccountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new EnergyApi(config);
            var accountId = accountId_example;  // string | ID of a specific account to obtain data for.  This is a tokenised ID previous obtained from the Account List end point.
            var xV = xV_example;  // string | Version of the API end point requested by the client. Must be set to a positive integer. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If the value of [x-min-v](#request-headers) is equal to or higher than the value of [x-v](#request-headers) then the [x-min-v](#request-headers) header should be treated as absent. If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. See [HTTP Headers](#request-headers)
            var newestDate = newestDate_example;  // string | Constrain the request to records with effective date at or before this date.  If absent defaults to current date.  Format is aligned to DateString common type (optional) 
            var oldestDate = oldestDate_example;  // string | Constrain the request to records with effective date at or after this date. If absent defaults to newest-date minus 24 months days.  Format is aligned to DateString common type (optional) 
            var page = 8.14;  // decimal? | Page of results to request (standard pagination) (optional) 
            var pageSize = 8.14;  // decimal? | Page size to request.  Default is 25 (standard pagination) (optional) 
            var xMinV = xMinV_example;  // string | Minimum version of the API end point requested by the client. Must be set to a positive integer if provided. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. (optional) 
            var xFapiInteractionId = xFapiInteractionId_example;  // string | An [RFC4122](https://tools.ietf.org/html/rfc4122) UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a [RFC4122] UUID value is required to be provided in the response header to track the interaction. (optional) 
            var xFapiAuthDate = xFapiAuthDate_example;  // string | The time when the customer last logged in to the data recipient. Required for all resource calls (customer present and unattended). Not to be included for unauthenticated calls. (optional) 
            var xFapiCustomerIpAddress = xFapiCustomerIpAddress_example;  // string | The customer's original IP address if the customer is currently logged in to the data recipient. The presence of this header indicates that the API is being called in a customer present context. Not to be included for unauthenticated calls. (optional) 
            var xCdsClientHeaders = xCdsClientHeaders_example;  // string | The customer's original standard http headers [Base64](#common-field-types) encoded, including the original User Agent header, if the customer is currently logged in to the data recipient. Mandatory for customer present calls.  Not required for unattended or unauthenticated calls. (optional) 

            try
            {
                // Get Invoices For Account
                EnergyInvoiceListResponse result = apiInstance.GetInvoicesForAccount(accountId, xV, newestDate, oldestDate, page, pageSize, xMinV, xFapiInteractionId, xFapiAuthDate, xFapiCustomerIpAddress, xCdsClientHeaders);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EnergyApi.GetInvoicesForAccount: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| ID of a specific account to obtain data for.  This is a tokenised ID previous obtained from the Account List end point. | 
 **xV** | **string**| Version of the API end point requested by the client. Must be set to a positive integer. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If the value of [x-min-v](#request-headers) is equal to or higher than the value of [x-v](#request-headers) then the [x-min-v](#request-headers) header should be treated as absent. If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. See [HTTP Headers](#request-headers) | 
 **newestDate** | **string**| Constrain the request to records with effective date at or before this date.  If absent defaults to current date.  Format is aligned to DateString common type | [optional] 
 **oldestDate** | **string**| Constrain the request to records with effective date at or after this date. If absent defaults to newest-date minus 24 months days.  Format is aligned to DateString common type | [optional] 
 **page** | **decimal?**| Page of results to request (standard pagination) | [optional] 
 **pageSize** | **decimal?**| Page size to request.  Default is 25 (standard pagination) | [optional] 
 **xMinV** | **string**| Minimum version of the API end point requested by the client. Must be set to a positive integer if provided. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. | [optional] 
 **xFapiInteractionId** | **string**| An [RFC4122](https://tools.ietf.org/html/rfc4122) UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a [RFC4122] UUID value is required to be provided in the response header to track the interaction. | [optional] 
 **xFapiAuthDate** | **string**| The time when the customer last logged in to the data recipient. Required for all resource calls (customer present and unattended). Not to be included for unauthenticated calls. | [optional] 
 **xFapiCustomerIpAddress** | **string**| The customer&#39;s original IP address if the customer is currently logged in to the data recipient. The presence of this header indicates that the API is being called in a customer present context. Not to be included for unauthenticated calls. | [optional] 
 **xCdsClientHeaders** | **string**| The customer&#39;s original standard http headers [Base64](#common-field-types) encoded, including the original User Agent header, if the customer is currently logged in to the data recipient. Mandatory for customer present calls.  Not required for unattended or unauthenticated calls. | [optional] 

### Return type

[**EnergyInvoiceListResponse**](EnergyInvoiceListResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  * x-v -  <br>  * x-fapi-interaction-id -  <br>  |
| **0** | The following error codes MUST be supported:&lt;br/&gt;&lt;ul class&#x3D;\&quot;error-code-list\&quot;&gt;&lt;li&gt;[400 - Invalid Field](#error-400-field-invalid)&lt;/li&gt;&lt;li&gt;[400 - Invalid Page Size](#error-400-field-invalid-page-size)&lt;/li&gt;&lt;li&gt;[400 - Invalid Version](#error-400-header-invalid-version)&lt;/li&gt;&lt;li&gt;[406 - Unsupported Version](#error-406-header-unsupported-version)&lt;/li&gt;&lt;li&gt;[422 - Invalid Page](#error-422-field-invalid-page)&lt;/li&gt;&lt;li&gt;[404 - Unavailable Energy Account](#error-404-unavailable-energy-account)&lt;/li&gt;&lt;li&gt;[404 - Invalid Energy Account](#error-404-invalid-energy-account)&lt;/li&gt;&lt;/ul&gt; |  * x-fapi-interaction-id -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpaymentschedule"></a>
# **GetPaymentSchedule**
> EnergyPaymentScheduleResponse GetPaymentSchedule (string accountId, string xV, string xMinV = null, string xFapiInteractionId = null, string xFapiAuthDate = null, string xFapiCustomerIpAddress = null, string xCdsClientHeaders = null)

Get Agreed Payment Schedule

Obtain the agreed payment schedule and details, if any, for a specific energy account

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agl.Cdr.Energy.Apis;
using Agl.Cdr.Energy.Client;
using Agl.Cdr.Energy.Models;

namespace Example
{
    public class GetPaymentScheduleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new EnergyApi(config);
            var accountId = accountId_example;  // string | ID of a specific account to obtain data for.  This is a tokenised ID previous obtained from the Account List end point.
            var xV = xV_example;  // string | Version of the API end point requested by the client. Must be set to a positive integer. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If the value of [x-min-v](#request-headers) is equal to or higher than the value of [x-v](#request-headers) then the [x-min-v](#request-headers) header should be treated as absent. If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. See [HTTP Headers](#request-headers)
            var xMinV = xMinV_example;  // string | Minimum version of the API end point requested by the client. Must be set to a positive integer if provided. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. (optional) 
            var xFapiInteractionId = xFapiInteractionId_example;  // string | An [RFC4122](https://tools.ietf.org/html/rfc4122) UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a [RFC4122] UUID value is required to be provided in the response header to track the interaction. (optional) 
            var xFapiAuthDate = xFapiAuthDate_example;  // string | The time when the customer last logged in to the data recipient. Required for all resource calls (customer present and unattended). Not to be included for unauthenticated calls. (optional) 
            var xFapiCustomerIpAddress = xFapiCustomerIpAddress_example;  // string | The customer's original IP address if the customer is currently logged in to the data recipient. The presence of this header indicates that the API is being called in a customer present context. Not to be included for unauthenticated calls. (optional) 
            var xCdsClientHeaders = xCdsClientHeaders_example;  // string | The customer's original standard http headers [Base64](#common-field-types) encoded, including the original User Agent header, if the customer is currently logged in to the data recipient. Mandatory for customer present calls.  Not required for unattended or unauthenticated calls. (optional) 

            try
            {
                // Get Agreed Payment Schedule
                EnergyPaymentScheduleResponse result = apiInstance.GetPaymentSchedule(accountId, xV, xMinV, xFapiInteractionId, xFapiAuthDate, xFapiCustomerIpAddress, xCdsClientHeaders);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EnergyApi.GetPaymentSchedule: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| ID of a specific account to obtain data for.  This is a tokenised ID previous obtained from the Account List end point. | 
 **xV** | **string**| Version of the API end point requested by the client. Must be set to a positive integer. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If the value of [x-min-v](#request-headers) is equal to or higher than the value of [x-v](#request-headers) then the [x-min-v](#request-headers) header should be treated as absent. If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. See [HTTP Headers](#request-headers) | 
 **xMinV** | **string**| Minimum version of the API end point requested by the client. Must be set to a positive integer if provided. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. | [optional] 
 **xFapiInteractionId** | **string**| An [RFC4122](https://tools.ietf.org/html/rfc4122) UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a [RFC4122] UUID value is required to be provided in the response header to track the interaction. | [optional] 
 **xFapiAuthDate** | **string**| The time when the customer last logged in to the data recipient. Required for all resource calls (customer present and unattended). Not to be included for unauthenticated calls. | [optional] 
 **xFapiCustomerIpAddress** | **string**| The customer&#39;s original IP address if the customer is currently logged in to the data recipient. The presence of this header indicates that the API is being called in a customer present context. Not to be included for unauthenticated calls. | [optional] 
 **xCdsClientHeaders** | **string**| The customer&#39;s original standard http headers [Base64](#common-field-types) encoded, including the original User Agent header, if the customer is currently logged in to the data recipient. Mandatory for customer present calls.  Not required for unattended or unauthenticated calls. | [optional] 

### Return type

[**EnergyPaymentScheduleResponse**](EnergyPaymentScheduleResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  * x-v -  <br>  * x-fapi-interaction-id -  <br>  |
| **0** | The following error codes MUST be supported:&lt;br/&gt;&lt;ul class&#x3D;\&quot;error-code-list\&quot;&gt;&lt;li&gt;[400 - Invalid Field](#error-400-field-invalid)&lt;/li&gt;&lt;li&gt;[400 - Invalid Version](#error-400-header-invalid-version)&lt;/li&gt;&lt;li&gt;[406 - Unsupported Version](#error-406-header-unsupported-version)&lt;/li&gt;&lt;li&gt;[404 - Unavailable Energy Account](#error-404-unavailable-energy-account)&lt;/li&gt;&lt;li&gt;[404 - Invalid Energy Account](#error-404-invalid-energy-account)&lt;/li&gt;&lt;/ul&gt; |  * x-fapi-interaction-id -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getplan"></a>
# **GetPlan**
> EnergyPlanResponse GetPlan (string planId, string xV, string xMinV = null, string xFapiInteractionId = null)

Get Generic Plan Detail

Obtain detailed information on a single energy plan offered openly to the market

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agl.Cdr.Energy.Apis;
using Agl.Cdr.Energy.Client;
using Agl.Cdr.Energy.Models;

namespace Example
{
    public class GetPlanExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new EnergyApi(config);
            var planId = planId_example;  // string | ID of the specific plan requested
            var xV = xV_example;  // string | Version of the API end point requested by the client. Must be set to a positive integer. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If the value of [x-min-v](#request-headers) is equal to or higher than the value of [x-v](#request-headers) then the [x-min-v](#request-headers) header should be treated as absent. If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. See [HTTP Headers](#request-headers)
            var xMinV = xMinV_example;  // string | Minimum version of the API end point requested by the client. Must be set to a positive integer if provided. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. (optional) 
            var xFapiInteractionId = xFapiInteractionId_example;  // string | An [RFC4122](https://tools.ietf.org/html/rfc4122) UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a [RFC4122] UUID value is required to be provided in the response header to track the interaction. (optional) 

            try
            {
                // Get Generic Plan Detail
                EnergyPlanResponse result = apiInstance.GetPlan(planId, xV, xMinV, xFapiInteractionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EnergyApi.GetPlan: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **planId** | **string**| ID of the specific plan requested | 
 **xV** | **string**| Version of the API end point requested by the client. Must be set to a positive integer. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If the value of [x-min-v](#request-headers) is equal to or higher than the value of [x-v](#request-headers) then the [x-min-v](#request-headers) header should be treated as absent. If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. See [HTTP Headers](#request-headers) | 
 **xMinV** | **string**| Minimum version of the API end point requested by the client. Must be set to a positive integer if provided. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. | [optional] 
 **xFapiInteractionId** | **string**| An [RFC4122](https://tools.ietf.org/html/rfc4122) UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a [RFC4122] UUID value is required to be provided in the response header to track the interaction. | [optional] 

### Return type

[**EnergyPlanResponse**](EnergyPlanResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  * x-v -  <br>  * x-fapi-interaction-id -  <br>  |
| **0** | The following error codes MUST be supported:&lt;br/&gt;&lt;ul class&#x3D;\&quot;error-code-list\&quot;&gt;&lt;li&gt;[400 - Invalid Field](#error-400-field-invalid)&lt;/li&gt;&lt;li&gt;[400 - Invalid Version](#error-400-header-invalid-version)&lt;/li&gt;&lt;li&gt;[404 - Invalid Resource](#error-404-resource-invalid)&lt;/li&gt;&lt;li&gt;[406 - Unsupported Version](#error-406-header-unsupported-version)&lt;/li&gt;&lt;/ul&gt; |  * x-fapi-interaction-id -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getservicepoint"></a>
# **GetServicePoint**
> EnergyServicePointDetailResponse GetServicePoint (string servicePointId, string xV, string xMinV = null, string xFapiInteractionId = null, string xFapiAuthDate = null, string xFapiCustomerIpAddress = null, string xCdsClientHeaders = null)

Get Service Point Detail

Obtain detailed standing information for a specific service point that is owned by the customer that has authorised the current session

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agl.Cdr.Energy.Apis;
using Agl.Cdr.Energy.Client;
using Agl.Cdr.Energy.Models;

namespace Example
{
    public class GetServicePointExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new EnergyApi(config);
            var servicePointId = servicePointId_example;  // string | ID of the specific service point requested.  This is a tokenised ID previous obtained from the Service Point List Data end point.  Note that it is not a nationalMeteringId.
            var xV = xV_example;  // string | Version of the API end point requested by the client. Must be set to a positive integer. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If the value of [x-min-v](#request-headers) is equal to or higher than the value of [x-v](#request-headers) then the [x-min-v](#request-headers) header should be treated as absent. If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. See [HTTP Headers](#request-headers)
            var xMinV = xMinV_example;  // string | Minimum version of the API end point requested by the client. Must be set to a positive integer if provided. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. (optional) 
            var xFapiInteractionId = xFapiInteractionId_example;  // string | An [RFC4122](https://tools.ietf.org/html/rfc4122) UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a [RFC4122] UUID value is required to be provided in the response header to track the interaction. (optional) 
            var xFapiAuthDate = xFapiAuthDate_example;  // string | The time when the customer last logged in to the data recipient. Required for all resource calls (customer present and unattended). Not to be included for unauthenticated calls. (optional) 
            var xFapiCustomerIpAddress = xFapiCustomerIpAddress_example;  // string | The customer's original IP address if the customer is currently logged in to the data recipient. The presence of this header indicates that the API is being called in a customer present context. Not to be included for unauthenticated calls. (optional) 
            var xCdsClientHeaders = xCdsClientHeaders_example;  // string | The customer's original standard http headers [Base64](#common-field-types) encoded, including the original User Agent header, if the customer is currently logged in to the data recipient. Mandatory for customer present calls.  Not required for unattended or unauthenticated calls. (optional) 

            try
            {
                // Get Service Point Detail
                EnergyServicePointDetailResponse result = apiInstance.GetServicePoint(servicePointId, xV, xMinV, xFapiInteractionId, xFapiAuthDate, xFapiCustomerIpAddress, xCdsClientHeaders);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EnergyApi.GetServicePoint: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **servicePointId** | **string**| ID of the specific service point requested.  This is a tokenised ID previous obtained from the Service Point List Data end point.  Note that it is not a nationalMeteringId. | 
 **xV** | **string**| Version of the API end point requested by the client. Must be set to a positive integer. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If the value of [x-min-v](#request-headers) is equal to or higher than the value of [x-v](#request-headers) then the [x-min-v](#request-headers) header should be treated as absent. If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. See [HTTP Headers](#request-headers) | 
 **xMinV** | **string**| Minimum version of the API end point requested by the client. Must be set to a positive integer if provided. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. | [optional] 
 **xFapiInteractionId** | **string**| An [RFC4122](https://tools.ietf.org/html/rfc4122) UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a [RFC4122] UUID value is required to be provided in the response header to track the interaction. | [optional] 
 **xFapiAuthDate** | **string**| The time when the customer last logged in to the data recipient. Required for all resource calls (customer present and unattended). Not to be included for unauthenticated calls. | [optional] 
 **xFapiCustomerIpAddress** | **string**| The customer&#39;s original IP address if the customer is currently logged in to the data recipient. The presence of this header indicates that the API is being called in a customer present context. Not to be included for unauthenticated calls. | [optional] 
 **xCdsClientHeaders** | **string**| The customer&#39;s original standard http headers [Base64](#common-field-types) encoded, including the original User Agent header, if the customer is currently logged in to the data recipient. Mandatory for customer present calls.  Not required for unattended or unauthenticated calls. | [optional] 

### Return type

[**EnergyServicePointDetailResponse**](EnergyServicePointDetailResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  * x-v -  <br>  * x-fapi-interaction-id -  <br>  |
| **0** | The following error codes MUST be supported:&lt;br/&gt;&lt;ul class&#x3D;\&quot;error-code-list\&quot;&gt;&lt;li&gt;[400 - Invalid Field](#error-400-field-invalid)&lt;/li&gt;&lt;li&gt;[400 - Invalid Version](#error-400-header-invalid-version)&lt;/li&gt;&lt;li&gt;[406 - Unsupported Version](#error-406-header-unsupported-version)&lt;/li&gt;&lt;li&gt;[404 - Unavailable Service Point](#error-404-unavailable-service-point)&lt;/li&gt;&lt;li&gt;[404 - Invalid Service Point](#error-404-invalid-service-point)&lt;/li&gt;&lt;/ul&gt; |  * x-fapi-interaction-id -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusageforservicepoint"></a>
# **GetUsageForServicePoint**
> EnergyUsageListResponse GetUsageForServicePoint (string servicePointId, string xV, string oldestDate = null, string newestDate = null, decimal? page = null, decimal? pageSize = null, string xMinV = null, string xFapiInteractionId = null, string xFapiAuthDate = null, string xFapiCustomerIpAddress = null, string xCdsClientHeaders = null)

Get Usage For Service Point

Obtain a list of electricity usage data from a particular service point

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agl.Cdr.Energy.Apis;
using Agl.Cdr.Energy.Client;
using Agl.Cdr.Energy.Models;

namespace Example
{
    public class GetUsageForServicePointExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new EnergyApi(config);
            var servicePointId = servicePointId_example;  // string | ID of the specific service point requested.  This is a tokenised ID previous obtained from the Service Point List Data end point.  Note that it is not a nationalMeteringId.
            var xV = xV_example;  // string | Version of the API end point requested by the client. Must be set to a positive integer. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If the value of [x-min-v](#request-headers) is equal to or higher than the value of [x-v](#request-headers) then the [x-min-v](#request-headers) header should be treated as absent. If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. See [HTTP Headers](#request-headers)
            var oldestDate = oldestDate_example;  // string | Constrain the request to records with effective date at or after this date. If absent defaults to newest-date minus 24 months days.  Format is aligned to DateString common type (optional) 
            var newestDate = newestDate_example;  // string | Constrain the request to records with effective date at or before this date.  If absent defaults to current date.  Format is aligned to DateString common type (optional) 
            var page = 8.14;  // decimal? | Page of results to request (standard pagination) (optional) 
            var pageSize = 8.14;  // decimal? | Page size to request.  Default is 25 (standard pagination) (optional) 
            var xMinV = xMinV_example;  // string | Minimum version of the API end point requested by the client. Must be set to a positive integer if provided. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. (optional) 
            var xFapiInteractionId = xFapiInteractionId_example;  // string | An [RFC4122](https://tools.ietf.org/html/rfc4122) UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a [RFC4122] UUID value is required to be provided in the response header to track the interaction. (optional) 
            var xFapiAuthDate = xFapiAuthDate_example;  // string | The time when the customer last logged in to the data recipient. Required for all resource calls (customer present and unattended). Not to be included for unauthenticated calls. (optional) 
            var xFapiCustomerIpAddress = xFapiCustomerIpAddress_example;  // string | The customer's original IP address if the customer is currently logged in to the data recipient. The presence of this header indicates that the API is being called in a customer present context. Not to be included for unauthenticated calls. (optional) 
            var xCdsClientHeaders = xCdsClientHeaders_example;  // string | The customer's original standard http headers [Base64](#common-field-types) encoded, including the original User Agent header, if the customer is currently logged in to the data recipient. Mandatory for customer present calls.  Not required for unattended or unauthenticated calls. (optional) 

            try
            {
                // Get Usage For Service Point
                EnergyUsageListResponse result = apiInstance.GetUsageForServicePoint(servicePointId, xV, oldestDate, newestDate, page, pageSize, xMinV, xFapiInteractionId, xFapiAuthDate, xFapiCustomerIpAddress, xCdsClientHeaders);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EnergyApi.GetUsageForServicePoint: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **servicePointId** | **string**| ID of the specific service point requested.  This is a tokenised ID previous obtained from the Service Point List Data end point.  Note that it is not a nationalMeteringId. | 
 **xV** | **string**| Version of the API end point requested by the client. Must be set to a positive integer. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If the value of [x-min-v](#request-headers) is equal to or higher than the value of [x-v](#request-headers) then the [x-min-v](#request-headers) header should be treated as absent. If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. See [HTTP Headers](#request-headers) | 
 **oldestDate** | **string**| Constrain the request to records with effective date at or after this date. If absent defaults to newest-date minus 24 months days.  Format is aligned to DateString common type | [optional] 
 **newestDate** | **string**| Constrain the request to records with effective date at or before this date.  If absent defaults to current date.  Format is aligned to DateString common type | [optional] 
 **page** | **decimal?**| Page of results to request (standard pagination) | [optional] 
 **pageSize** | **decimal?**| Page size to request.  Default is 25 (standard pagination) | [optional] 
 **xMinV** | **string**| Minimum version of the API end point requested by the client. Must be set to a positive integer if provided. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. | [optional] 
 **xFapiInteractionId** | **string**| An [RFC4122](https://tools.ietf.org/html/rfc4122) UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a [RFC4122] UUID value is required to be provided in the response header to track the interaction. | [optional] 
 **xFapiAuthDate** | **string**| The time when the customer last logged in to the data recipient. Required for all resource calls (customer present and unattended). Not to be included for unauthenticated calls. | [optional] 
 **xFapiCustomerIpAddress** | **string**| The customer&#39;s original IP address if the customer is currently logged in to the data recipient. The presence of this header indicates that the API is being called in a customer present context. Not to be included for unauthenticated calls. | [optional] 
 **xCdsClientHeaders** | **string**| The customer&#39;s original standard http headers [Base64](#common-field-types) encoded, including the original User Agent header, if the customer is currently logged in to the data recipient. Mandatory for customer present calls.  Not required for unattended or unauthenticated calls. | [optional] 

### Return type

[**EnergyUsageListResponse**](EnergyUsageListResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  * x-v -  <br>  * x-fapi-interaction-id -  <br>  |
| **0** | The following error codes MUST be supported:&lt;br/&gt;&lt;ul class&#x3D;\&quot;error-code-list\&quot;&gt;&lt;li&gt;[400 - Invalid Field](#error-400-field-invalid)&lt;/li&gt;&lt;li&gt;[400 - Invalid Page Size](#error-400-field-invalid-page-size)&lt;/li&gt;&lt;li&gt;[400 - Invalid Version](#error-400-header-invalid-version)&lt;/li&gt;&lt;li&gt;[406 - Unsupported Version](#error-406-header-unsupported-version)&lt;/li&gt;&lt;li&gt;[422 - Invalid Page](#error-422-field-invalid-page)&lt;/li&gt;&lt;li&gt;[404 - Unavailable Service Point](#error-404-unavailable-service-point)&lt;/li&gt;&lt;li&gt;[404 - Invalid Service Point](#error-404-invalid-service-point)&lt;/li&gt;&lt;/ul&gt; |  * x-fapi-interaction-id -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listaccounts"></a>
# **ListAccounts**
> EnergyAccountListResponse ListAccounts (string xV, decimal? page = null, decimal? pageSize = null, string xMinV = null, string xFapiInteractionId = null, string xFapiAuthDate = null, string xFapiCustomerIpAddress = null, string xCdsClientHeaders = null)

Get Energy Accounts

Obtain the list of energy accounts available under the authorised consent

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agl.Cdr.Energy.Apis;
using Agl.Cdr.Energy.Client;
using Agl.Cdr.Energy.Models;

namespace Example
{
    public class ListAccountsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new EnergyApi(config);
            var xV = xV_example;  // string | Version of the API end point requested by the client. Must be set to a positive integer. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If the value of [x-min-v](#request-headers) is equal to or higher than the value of [x-v](#request-headers) then the [x-min-v](#request-headers) header should be treated as absent. If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. See [HTTP Headers](#request-headers)
            var page = 8.14;  // decimal? | Page of results to request (standard pagination) (optional) 
            var pageSize = 8.14;  // decimal? | Page size to request.  Default is 25 (standard pagination) (optional) 
            var xMinV = xMinV_example;  // string | Minimum version of the API end point requested by the client. Must be set to a positive integer if provided. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. (optional) 
            var xFapiInteractionId = xFapiInteractionId_example;  // string | An [RFC4122](https://tools.ietf.org/html/rfc4122) UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a [RFC4122] UUID value is required to be provided in the response header to track the interaction. (optional) 
            var xFapiAuthDate = xFapiAuthDate_example;  // string | The time when the customer last logged in to the data recipient. Required for all resource calls (customer present and unattended). Not to be included for unauthenticated calls. (optional) 
            var xFapiCustomerIpAddress = xFapiCustomerIpAddress_example;  // string | The customer's original IP address if the customer is currently logged in to the data recipient. The presence of this header indicates that the API is being called in a customer present context. Not to be included for unauthenticated calls. (optional) 
            var xCdsClientHeaders = xCdsClientHeaders_example;  // string | The customer's original standard http headers [Base64](#common-field-types) encoded, including the original User Agent header, if the customer is currently logged in to the data recipient. Mandatory for customer present calls.  Not required for unattended or unauthenticated calls. (optional) 

            try
            {
                // Get Energy Accounts
                EnergyAccountListResponse result = apiInstance.ListAccounts(xV, page, pageSize, xMinV, xFapiInteractionId, xFapiAuthDate, xFapiCustomerIpAddress, xCdsClientHeaders);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EnergyApi.ListAccounts: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **xV** | **string**| Version of the API end point requested by the client. Must be set to a positive integer. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If the value of [x-min-v](#request-headers) is equal to or higher than the value of [x-v](#request-headers) then the [x-min-v](#request-headers) header should be treated as absent. If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. See [HTTP Headers](#request-headers) | 
 **page** | **decimal?**| Page of results to request (standard pagination) | [optional] 
 **pageSize** | **decimal?**| Page size to request.  Default is 25 (standard pagination) | [optional] 
 **xMinV** | **string**| Minimum version of the API end point requested by the client. Must be set to a positive integer if provided. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. | [optional] 
 **xFapiInteractionId** | **string**| An [RFC4122](https://tools.ietf.org/html/rfc4122) UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a [RFC4122] UUID value is required to be provided in the response header to track the interaction. | [optional] 
 **xFapiAuthDate** | **string**| The time when the customer last logged in to the data recipient. Required for all resource calls (customer present and unattended). Not to be included for unauthenticated calls. | [optional] 
 **xFapiCustomerIpAddress** | **string**| The customer&#39;s original IP address if the customer is currently logged in to the data recipient. The presence of this header indicates that the API is being called in a customer present context. Not to be included for unauthenticated calls. | [optional] 
 **xCdsClientHeaders** | **string**| The customer&#39;s original standard http headers [Base64](#common-field-types) encoded, including the original User Agent header, if the customer is currently logged in to the data recipient. Mandatory for customer present calls.  Not required for unattended or unauthenticated calls. | [optional] 

### Return type

[**EnergyAccountListResponse**](EnergyAccountListResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  * x-v -  <br>  * x-fapi-interaction-id -  <br>  |
| **0** | The following error codes MUST be supported:&lt;br/&gt;&lt;ul class&#x3D;\&quot;error-code-list\&quot;&gt;&lt;li&gt;[400 - Invalid Field](#error-400-field-invalid)&lt;/li&gt;&lt;li&gt;[400 - Invalid Page Size](#error-400-field-invalid-page-size)&lt;/li&gt;&lt;li&gt;[400 - Invalid Version](#error-400-header-invalid-version)&lt;/li&gt;&lt;li&gt;[406 - Unsupported Version](#error-406-header-unsupported-version)&lt;/li&gt;&lt;li&gt;[422 - Invalid Page](#error-422-field-invalid-page)&lt;/li&gt;&lt;/ul&gt; |  * x-fapi-interaction-id -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listbalancesbulk"></a>
# **ListBalancesBulk**
> EnergyBalanceListResponse ListBalancesBulk (string xV, decimal? page = null, decimal? pageSize = null, string xMinV = null, string xFapiInteractionId = null, string xFapiAuthDate = null, string xFapiCustomerIpAddress = null, string xCdsClientHeaders = null)

Get Bulk Balances for Energy

Obtain the current balance for all accounts

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agl.Cdr.Energy.Apis;
using Agl.Cdr.Energy.Client;
using Agl.Cdr.Energy.Models;

namespace Example
{
    public class ListBalancesBulkExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new EnergyApi(config);
            var xV = xV_example;  // string | Version of the API end point requested by the client. Must be set to a positive integer. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If the value of [x-min-v](#request-headers) is equal to or higher than the value of [x-v](#request-headers) then the [x-min-v](#request-headers) header should be treated as absent. If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. See [HTTP Headers](#request-headers)
            var page = 8.14;  // decimal? | Page of results to request (standard pagination) (optional) 
            var pageSize = 8.14;  // decimal? | Page size to request.  Default is 25 (standard pagination) (optional) 
            var xMinV = xMinV_example;  // string | Minimum version of the API end point requested by the client. Must be set to a positive integer if provided. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. (optional) 
            var xFapiInteractionId = xFapiInteractionId_example;  // string | An [RFC4122](https://tools.ietf.org/html/rfc4122) UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a [RFC4122] UUID value is required to be provided in the response header to track the interaction. (optional) 
            var xFapiAuthDate = xFapiAuthDate_example;  // string | The time when the customer last logged in to the data recipient. Required for all resource calls (customer present and unattended). Not to be included for unauthenticated calls. (optional) 
            var xFapiCustomerIpAddress = xFapiCustomerIpAddress_example;  // string | The customer's original IP address if the customer is currently logged in to the data recipient. The presence of this header indicates that the API is being called in a customer present context. Not to be included for unauthenticated calls. (optional) 
            var xCdsClientHeaders = xCdsClientHeaders_example;  // string | The customer's original standard http headers [Base64](#common-field-types) encoded, including the original User Agent header, if the customer is currently logged in to the data recipient. Mandatory for customer present calls.  Not required for unattended or unauthenticated calls. (optional) 

            try
            {
                // Get Bulk Balances for Energy
                EnergyBalanceListResponse result = apiInstance.ListBalancesBulk(xV, page, pageSize, xMinV, xFapiInteractionId, xFapiAuthDate, xFapiCustomerIpAddress, xCdsClientHeaders);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EnergyApi.ListBalancesBulk: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **xV** | **string**| Version of the API end point requested by the client. Must be set to a positive integer. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If the value of [x-min-v](#request-headers) is equal to or higher than the value of [x-v](#request-headers) then the [x-min-v](#request-headers) header should be treated as absent. If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. See [HTTP Headers](#request-headers) | 
 **page** | **decimal?**| Page of results to request (standard pagination) | [optional] 
 **pageSize** | **decimal?**| Page size to request.  Default is 25 (standard pagination) | [optional] 
 **xMinV** | **string**| Minimum version of the API end point requested by the client. Must be set to a positive integer if provided. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. | [optional] 
 **xFapiInteractionId** | **string**| An [RFC4122](https://tools.ietf.org/html/rfc4122) UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a [RFC4122] UUID value is required to be provided in the response header to track the interaction. | [optional] 
 **xFapiAuthDate** | **string**| The time when the customer last logged in to the data recipient. Required for all resource calls (customer present and unattended). Not to be included for unauthenticated calls. | [optional] 
 **xFapiCustomerIpAddress** | **string**| The customer&#39;s original IP address if the customer is currently logged in to the data recipient. The presence of this header indicates that the API is being called in a customer present context. Not to be included for unauthenticated calls. | [optional] 
 **xCdsClientHeaders** | **string**| The customer&#39;s original standard http headers [Base64](#common-field-types) encoded, including the original User Agent header, if the customer is currently logged in to the data recipient. Mandatory for customer present calls.  Not required for unattended or unauthenticated calls. | [optional] 

### Return type

[**EnergyBalanceListResponse**](EnergyBalanceListResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  * x-v -  <br>  * x-fapi-interaction-id -  <br>  |
| **0** | The following error codes MUST be supported:&lt;br/&gt;&lt;ul class&#x3D;\&quot;error-code-list\&quot;&gt;&lt;li&gt;[400 - Invalid Field](#error-400-field-invalid)&lt;/li&gt;&lt;li&gt;[400 - Invalid Page Size](#error-400-field-invalid-page-size)&lt;/li&gt;&lt;li&gt;[400 - Invalid Version](#error-400-header-invalid-version)&lt;/li&gt;&lt;li&gt;[406 - Unsupported Version](#error-406-header-unsupported-version)&lt;/li&gt;&lt;li&gt;[422 - Invalid Page](#error-422-field-invalid-page)&lt;/li&gt;&lt;/ul&gt; |  * x-fapi-interaction-id -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listbalancesforaccounts"></a>
# **ListBalancesForAccounts**
> EnergyBalanceListResponse ListBalancesForAccounts (string xV, UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE, decimal? page = null, decimal? pageSize = null, string xMinV = null, string xFapiInteractionId = null, string xFapiAuthDate = null, string xFapiCustomerIpAddress = null, string xCdsClientHeaders = null)

Get Balances For Specific Energy Accounts

Obtain the current balance for a specified set of accounts

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agl.Cdr.Energy.Apis;
using Agl.Cdr.Energy.Client;
using Agl.Cdr.Energy.Models;

namespace Example
{
    public class ListBalancesForAccountsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new EnergyApi(config);
            var xV = xV_example;  // string | Version of the API end point requested by the client. Must be set to a positive integer. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If the value of [x-min-v](#request-headers) is equal to or higher than the value of [x-v](#request-headers) then the [x-min-v](#request-headers) header should be treated as absent. If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. See [HTTP Headers](#request-headers)
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | Request payload containing list of specific Accounts to obtain data for
            var page = 8.14;  // decimal? | Page of results to request (standard pagination) (optional) 
            var pageSize = 8.14;  // decimal? | Page size to request.  Default is 25 (standard pagination) (optional) 
            var xMinV = xMinV_example;  // string | Minimum version of the API end point requested by the client. Must be set to a positive integer if provided. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. (optional) 
            var xFapiInteractionId = xFapiInteractionId_example;  // string | An [RFC4122](https://tools.ietf.org/html/rfc4122) UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a [RFC4122] UUID value is required to be provided in the response header to track the interaction. (optional) 
            var xFapiAuthDate = xFapiAuthDate_example;  // string | The time when the customer last logged in to the data recipient. Required for all resource calls (customer present and unattended). Not to be included for unauthenticated calls. (optional) 
            var xFapiCustomerIpAddress = xFapiCustomerIpAddress_example;  // string | The customer's original IP address if the customer is currently logged in to the data recipient. The presence of this header indicates that the API is being called in a customer present context. Not to be included for unauthenticated calls. (optional) 
            var xCdsClientHeaders = xCdsClientHeaders_example;  // string | The customer's original standard http headers [Base64](#common-field-types) encoded, including the original User Agent header, if the customer is currently logged in to the data recipient. Mandatory for customer present calls.  Not required for unattended or unauthenticated calls. (optional) 

            try
            {
                // Get Balances For Specific Energy Accounts
                EnergyBalanceListResponse result = apiInstance.ListBalancesForAccounts(xV, UNKNOWN_BASE_TYPE, page, pageSize, xMinV, xFapiInteractionId, xFapiAuthDate, xFapiCustomerIpAddress, xCdsClientHeaders);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EnergyApi.ListBalancesForAccounts: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **xV** | **string**| Version of the API end point requested by the client. Must be set to a positive integer. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If the value of [x-min-v](#request-headers) is equal to or higher than the value of [x-v](#request-headers) then the [x-min-v](#request-headers) header should be treated as absent. If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. See [HTTP Headers](#request-headers) | 
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)| Request payload containing list of specific Accounts to obtain data for | 
 **page** | **decimal?**| Page of results to request (standard pagination) | [optional] 
 **pageSize** | **decimal?**| Page size to request.  Default is 25 (standard pagination) | [optional] 
 **xMinV** | **string**| Minimum version of the API end point requested by the client. Must be set to a positive integer if provided. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. | [optional] 
 **xFapiInteractionId** | **string**| An [RFC4122](https://tools.ietf.org/html/rfc4122) UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a [RFC4122] UUID value is required to be provided in the response header to track the interaction. | [optional] 
 **xFapiAuthDate** | **string**| The time when the customer last logged in to the data recipient. Required for all resource calls (customer present and unattended). Not to be included for unauthenticated calls. | [optional] 
 **xFapiCustomerIpAddress** | **string**| The customer&#39;s original IP address if the customer is currently logged in to the data recipient. The presence of this header indicates that the API is being called in a customer present context. Not to be included for unauthenticated calls. | [optional] 
 **xCdsClientHeaders** | **string**| The customer&#39;s original standard http headers [Base64](#common-field-types) encoded, including the original User Agent header, if the customer is currently logged in to the data recipient. Mandatory for customer present calls.  Not required for unattended or unauthenticated calls. | [optional] 

### Return type

[**EnergyBalanceListResponse**](EnergyBalanceListResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  * x-v -  <br>  * x-fapi-interaction-id -  <br>  |
| **0** | The following error codes MUST be supported:&lt;br/&gt;&lt;ul class&#x3D;\&quot;error-code-list\&quot;&gt;&lt;li&gt;[400 - Invalid Field](#error-400-field-invalid)&lt;/li&gt;&lt;li&gt;[400 - Invalid Page Size](#error-400-field-invalid-page-size)&lt;/li&gt;&lt;li&gt;[400 - Invalid Version](#error-400-header-invalid-version)&lt;/li&gt;&lt;li&gt;[406 - Unsupported Version](#error-406-header-unsupported-version)&lt;/li&gt;&lt;li&gt;[422 - Invalid Page](#error-422-field-invalid-page)&lt;/li&gt;&lt;li&gt;[422 - Unavailable Energy Account](#error-422-unavailable-energy-account)&lt;/li&gt;&lt;li&gt;[422 - Invalid Energy Account](#error-422-invalid-energy-account)&lt;/li&gt;&lt;/ul&gt; |  * x-fapi-interaction-id -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listbillingbulk"></a>
# **ListBillingBulk**
> EnergyBillingListResponse ListBillingBulk (string xV, string newestTime = null, string oldestTime = null, decimal? page = null, decimal? pageSize = null, string xMinV = null, string xFapiInteractionId = null, string xFapiAuthDate = null, string xFapiCustomerIpAddress = null, string xCdsClientHeaders = null)

Get Bulk Billing

Obtain billing transactions for all accounts

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agl.Cdr.Energy.Apis;
using Agl.Cdr.Energy.Client;
using Agl.Cdr.Energy.Models;

namespace Example
{
    public class ListBillingBulkExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new EnergyApi(config);
            var xV = xV_example;  // string | Version of the API end point requested by the client. Must be set to a positive integer. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If the value of [x-min-v](#request-headers) is equal to or higher than the value of [x-v](#request-headers) then the [x-min-v](#request-headers) header should be treated as absent. If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. See [HTTP Headers](#request-headers)
            var newestTime = newestTime_example;  // string | Constrain the request to records with effective time at or before this date/time.  If absent defaults to current date/time.  Format is aligned to DateTimeString common type (optional) 
            var oldestTime = oldestTime_example;  // string | Constrain the request to records with effective time at or after this date/time. If absent defaults to newest-time minus 12 months.  Format is aligned to DateTimeString common type (optional) 
            var page = 8.14;  // decimal? | Page of results to request (standard pagination) (optional) 
            var pageSize = 8.14;  // decimal? | Page size to request.  Default is 25 (standard pagination) (optional) 
            var xMinV = xMinV_example;  // string | Minimum version of the API end point requested by the client. Must be set to a positive integer if provided. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. (optional) 
            var xFapiInteractionId = xFapiInteractionId_example;  // string | An [RFC4122](https://tools.ietf.org/html/rfc4122) UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a [RFC4122] UUID value is required to be provided in the response header to track the interaction. (optional) 
            var xFapiAuthDate = xFapiAuthDate_example;  // string | The time when the customer last logged in to the data recipient. Required for all resource calls (customer present and unattended). Not to be included for unauthenticated calls. (optional) 
            var xFapiCustomerIpAddress = xFapiCustomerIpAddress_example;  // string | The customer's original IP address if the customer is currently logged in to the data recipient. The presence of this header indicates that the API is being called in a customer present context. Not to be included for unauthenticated calls. (optional) 
            var xCdsClientHeaders = xCdsClientHeaders_example;  // string | The customer's original standard http headers [Base64](#common-field-types) encoded, including the original User Agent header, if the customer is currently logged in to the data recipient. Mandatory for customer present calls.  Not required for unattended or unauthenticated calls. (optional) 

            try
            {
                // Get Bulk Billing
                EnergyBillingListResponse result = apiInstance.ListBillingBulk(xV, newestTime, oldestTime, page, pageSize, xMinV, xFapiInteractionId, xFapiAuthDate, xFapiCustomerIpAddress, xCdsClientHeaders);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EnergyApi.ListBillingBulk: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **xV** | **string**| Version of the API end point requested by the client. Must be set to a positive integer. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If the value of [x-min-v](#request-headers) is equal to or higher than the value of [x-v](#request-headers) then the [x-min-v](#request-headers) header should be treated as absent. If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. See [HTTP Headers](#request-headers) | 
 **newestTime** | **string**| Constrain the request to records with effective time at or before this date/time.  If absent defaults to current date/time.  Format is aligned to DateTimeString common type | [optional] 
 **oldestTime** | **string**| Constrain the request to records with effective time at or after this date/time. If absent defaults to newest-time minus 12 months.  Format is aligned to DateTimeString common type | [optional] 
 **page** | **decimal?**| Page of results to request (standard pagination) | [optional] 
 **pageSize** | **decimal?**| Page size to request.  Default is 25 (standard pagination) | [optional] 
 **xMinV** | **string**| Minimum version of the API end point requested by the client. Must be set to a positive integer if provided. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. | [optional] 
 **xFapiInteractionId** | **string**| An [RFC4122](https://tools.ietf.org/html/rfc4122) UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a [RFC4122] UUID value is required to be provided in the response header to track the interaction. | [optional] 
 **xFapiAuthDate** | **string**| The time when the customer last logged in to the data recipient. Required for all resource calls (customer present and unattended). Not to be included for unauthenticated calls. | [optional] 
 **xFapiCustomerIpAddress** | **string**| The customer&#39;s original IP address if the customer is currently logged in to the data recipient. The presence of this header indicates that the API is being called in a customer present context. Not to be included for unauthenticated calls. | [optional] 
 **xCdsClientHeaders** | **string**| The customer&#39;s original standard http headers [Base64](#common-field-types) encoded, including the original User Agent header, if the customer is currently logged in to the data recipient. Mandatory for customer present calls.  Not required for unattended or unauthenticated calls. | [optional] 

### Return type

[**EnergyBillingListResponse**](EnergyBillingListResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  * x-v -  <br>  * x-fapi-interaction-id -  <br>  |
| **0** | The following error codes MUST be supported:&lt;br/&gt;&lt;ul class&#x3D;\&quot;error-code-list\&quot;&gt;&lt;li&gt;[400 - Invalid Field](#error-400-field-invalid)&lt;/li&gt;&lt;li&gt;[400 - Invalid Page Size](#error-400-field-invalid-page-size)&lt;/li&gt;&lt;li&gt;[400 - Invalid Version](#error-400-header-invalid-version)&lt;/li&gt;&lt;li&gt;[406 - Unsupported Version](#error-406-header-unsupported-version)&lt;/li&gt;&lt;li&gt;[422 - Invalid Page](#error-422-field-invalid-page)&lt;/li&gt;&lt;/ul&gt; |  * x-fapi-interaction-id -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listbillingforaccounts"></a>
# **ListBillingForAccounts**
> EnergyBillingListResponse ListBillingForAccounts (string xV, UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE, string newestTime = null, string oldestTime = null, decimal? page = null, decimal? pageSize = null, string xMinV = null, string xFapiInteractionId = null, string xFapiAuthDate = null, string xFapiCustomerIpAddress = null, string xCdsClientHeaders = null)

Get Billing For Specific Accounts

Obtain billing for a specified set of accounts

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agl.Cdr.Energy.Apis;
using Agl.Cdr.Energy.Client;
using Agl.Cdr.Energy.Models;

namespace Example
{
    public class ListBillingForAccountsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new EnergyApi(config);
            var xV = xV_example;  // string | Version of the API end point requested by the client. Must be set to a positive integer. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If the value of [x-min-v](#request-headers) is equal to or higher than the value of [x-v](#request-headers) then the [x-min-v](#request-headers) header should be treated as absent. If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. See [HTTP Headers](#request-headers)
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | Request payload containing list of specific Accounts to obtain data for
            var newestTime = newestTime_example;  // string | Constrain the request to records with effective time at or before this date/time.  If absent defaults to current date/time.  Format is aligned to DateTimeString common type (optional) 
            var oldestTime = oldestTime_example;  // string | Constrain the request to records with effective time at or after this date/time. If absent defaults to newest-time minus 12 months.  Format is aligned to DateTimeString common type (optional) 
            var page = 8.14;  // decimal? | Page of results to request (standard pagination) (optional) 
            var pageSize = 8.14;  // decimal? | Page size to request.  Default is 25 (standard pagination) (optional) 
            var xMinV = xMinV_example;  // string | Minimum version of the API end point requested by the client. Must be set to a positive integer if provided. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. (optional) 
            var xFapiInteractionId = xFapiInteractionId_example;  // string | An [RFC4122](https://tools.ietf.org/html/rfc4122) UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a [RFC4122] UUID value is required to be provided in the response header to track the interaction. (optional) 
            var xFapiAuthDate = xFapiAuthDate_example;  // string | The time when the customer last logged in to the data recipient. Required for all resource calls (customer present and unattended). Not to be included for unauthenticated calls. (optional) 
            var xFapiCustomerIpAddress = xFapiCustomerIpAddress_example;  // string | The customer's original IP address if the customer is currently logged in to the data recipient. The presence of this header indicates that the API is being called in a customer present context. Not to be included for unauthenticated calls. (optional) 
            var xCdsClientHeaders = xCdsClientHeaders_example;  // string | The customer's original standard http headers [Base64](#common-field-types) encoded, including the original User Agent header, if the customer is currently logged in to the data recipient. Mandatory for customer present calls.  Not required for unattended or unauthenticated calls. (optional) 

            try
            {
                // Get Billing For Specific Accounts
                EnergyBillingListResponse result = apiInstance.ListBillingForAccounts(xV, UNKNOWN_BASE_TYPE, newestTime, oldestTime, page, pageSize, xMinV, xFapiInteractionId, xFapiAuthDate, xFapiCustomerIpAddress, xCdsClientHeaders);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EnergyApi.ListBillingForAccounts: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **xV** | **string**| Version of the API end point requested by the client. Must be set to a positive integer. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If the value of [x-min-v](#request-headers) is equal to or higher than the value of [x-v](#request-headers) then the [x-min-v](#request-headers) header should be treated as absent. If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. See [HTTP Headers](#request-headers) | 
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)| Request payload containing list of specific Accounts to obtain data for | 
 **newestTime** | **string**| Constrain the request to records with effective time at or before this date/time.  If absent defaults to current date/time.  Format is aligned to DateTimeString common type | [optional] 
 **oldestTime** | **string**| Constrain the request to records with effective time at or after this date/time. If absent defaults to newest-time minus 12 months.  Format is aligned to DateTimeString common type | [optional] 
 **page** | **decimal?**| Page of results to request (standard pagination) | [optional] 
 **pageSize** | **decimal?**| Page size to request.  Default is 25 (standard pagination) | [optional] 
 **xMinV** | **string**| Minimum version of the API end point requested by the client. Must be set to a positive integer if provided. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. | [optional] 
 **xFapiInteractionId** | **string**| An [RFC4122](https://tools.ietf.org/html/rfc4122) UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a [RFC4122] UUID value is required to be provided in the response header to track the interaction. | [optional] 
 **xFapiAuthDate** | **string**| The time when the customer last logged in to the data recipient. Required for all resource calls (customer present and unattended). Not to be included for unauthenticated calls. | [optional] 
 **xFapiCustomerIpAddress** | **string**| The customer&#39;s original IP address if the customer is currently logged in to the data recipient. The presence of this header indicates that the API is being called in a customer present context. Not to be included for unauthenticated calls. | [optional] 
 **xCdsClientHeaders** | **string**| The customer&#39;s original standard http headers [Base64](#common-field-types) encoded, including the original User Agent header, if the customer is currently logged in to the data recipient. Mandatory for customer present calls.  Not required for unattended or unauthenticated calls. | [optional] 

### Return type

[**EnergyBillingListResponse**](EnergyBillingListResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  * x-v -  <br>  * x-fapi-interaction-id -  <br>  |
| **0** | The following error codes MUST be supported:&lt;br/&gt;&lt;ul class&#x3D;\&quot;error-code-list\&quot;&gt;&lt;li&gt;[400 - Invalid Field](#error-400-field-invalid)&lt;/li&gt;&lt;li&gt;[400 - Invalid Page Size](#error-400-field-invalid-page-size)&lt;/li&gt;&lt;li&gt;[400 - Invalid Version](#error-400-header-invalid-version)&lt;/li&gt;&lt;li&gt;[406 - Unsupported Version](#error-406-header-unsupported-version)&lt;/li&gt;&lt;li&gt;[422 - Invalid Page](#error-422-field-invalid-page)&lt;/li&gt;&lt;li&gt;[422 - Unavailable Energy Account](#error-422-unavailable-energy-account)&lt;/li&gt;&lt;li&gt;[422 - Invalid Energy Account](#error-422-invalid-energy-account)&lt;/li&gt;&lt;/ul&gt; |  * x-fapi-interaction-id -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listderbulk"></a>
# **ListDERBulk**
> EnergyDerListResponse ListDERBulk (string xV, decimal? page = null, decimal? pageSize = null, string xMinV = null, string xFapiInteractionId = null, string xFapiAuthDate = null, string xFapiCustomerIpAddress = null, string xCdsClientHeaders = null)

Get Bulk DER

Obtain DER data for all service points associated with the customer

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agl.Cdr.Energy.Apis;
using Agl.Cdr.Energy.Client;
using Agl.Cdr.Energy.Models;

namespace Example
{
    public class ListDERBulkExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new EnergyApi(config);
            var xV = xV_example;  // string | Version of the API end point requested by the client. Must be set to a positive integer. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If the value of [x-min-v](#request-headers) is equal to or higher than the value of [x-v](#request-headers) then the [x-min-v](#request-headers) header should be treated as absent. If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. See [HTTP Headers](#request-headers)
            var page = 8.14;  // decimal? | Page of results to request (standard pagination) (optional) 
            var pageSize = 8.14;  // decimal? | Page size to request.  Default is 25 (standard pagination) (optional) 
            var xMinV = xMinV_example;  // string | Minimum version of the API end point requested by the client. Must be set to a positive integer if provided. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. (optional) 
            var xFapiInteractionId = xFapiInteractionId_example;  // string | An [RFC4122](https://tools.ietf.org/html/rfc4122) UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a [RFC4122] UUID value is required to be provided in the response header to track the interaction. (optional) 
            var xFapiAuthDate = xFapiAuthDate_example;  // string | The time when the customer last logged in to the data recipient. Required for all resource calls (customer present and unattended). Not to be included for unauthenticated calls. (optional) 
            var xFapiCustomerIpAddress = xFapiCustomerIpAddress_example;  // string | The customer's original IP address if the customer is currently logged in to the data recipient. The presence of this header indicates that the API is being called in a customer present context. Not to be included for unauthenticated calls. (optional) 
            var xCdsClientHeaders = xCdsClientHeaders_example;  // string | The customer's original standard http headers [Base64](#common-field-types) encoded, including the original User Agent header, if the customer is currently logged in to the data recipient. Mandatory for customer present calls.  Not required for unattended or unauthenticated calls. (optional) 

            try
            {
                // Get Bulk DER
                EnergyDerListResponse result = apiInstance.ListDERBulk(xV, page, pageSize, xMinV, xFapiInteractionId, xFapiAuthDate, xFapiCustomerIpAddress, xCdsClientHeaders);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EnergyApi.ListDERBulk: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **xV** | **string**| Version of the API end point requested by the client. Must be set to a positive integer. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If the value of [x-min-v](#request-headers) is equal to or higher than the value of [x-v](#request-headers) then the [x-min-v](#request-headers) header should be treated as absent. If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. See [HTTP Headers](#request-headers) | 
 **page** | **decimal?**| Page of results to request (standard pagination) | [optional] 
 **pageSize** | **decimal?**| Page size to request.  Default is 25 (standard pagination) | [optional] 
 **xMinV** | **string**| Minimum version of the API end point requested by the client. Must be set to a positive integer if provided. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. | [optional] 
 **xFapiInteractionId** | **string**| An [RFC4122](https://tools.ietf.org/html/rfc4122) UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a [RFC4122] UUID value is required to be provided in the response header to track the interaction. | [optional] 
 **xFapiAuthDate** | **string**| The time when the customer last logged in to the data recipient. Required for all resource calls (customer present and unattended). Not to be included for unauthenticated calls. | [optional] 
 **xFapiCustomerIpAddress** | **string**| The customer&#39;s original IP address if the customer is currently logged in to the data recipient. The presence of this header indicates that the API is being called in a customer present context. Not to be included for unauthenticated calls. | [optional] 
 **xCdsClientHeaders** | **string**| The customer&#39;s original standard http headers [Base64](#common-field-types) encoded, including the original User Agent header, if the customer is currently logged in to the data recipient. Mandatory for customer present calls.  Not required for unattended or unauthenticated calls. | [optional] 

### Return type

[**EnergyDerListResponse**](EnergyDerListResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  * x-v -  <br>  * x-fapi-interaction-id -  <br>  |
| **0** | The following error codes MUST be supported:&lt;br/&gt;&lt;ul class&#x3D;\&quot;error-code-list\&quot;&gt;&lt;li&gt;[400 - Invalid Field](#error-400-field-invalid)&lt;/li&gt;&lt;li&gt;[400 - Invalid Page Size](#error-400-field-invalid-page-size)&lt;/li&gt;&lt;li&gt;[400 - Invalid Version](#error-400-header-invalid-version)&lt;/li&gt;&lt;li&gt;[406 - Unsupported Version](#error-406-header-unsupported-version)&lt;/li&gt;&lt;li&gt;[422 - Invalid Page](#error-422-field-invalid-page)&lt;/li&gt;&lt;/ul&gt; |  * x-fapi-interaction-id -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listderforservicepoints"></a>
# **ListDERForServicePoints**
> EnergyDerListResponse ListDERForServicePoints (string xV, UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE, decimal? page = null, decimal? pageSize = null, string xMinV = null, string xFapiInteractionId = null, string xFapiAuthDate = null, string xFapiCustomerIpAddress = null, string xCdsClientHeaders = null)

Get DER For Specific Service Points

Obtain DER data for a specific set of service points

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agl.Cdr.Energy.Apis;
using Agl.Cdr.Energy.Client;
using Agl.Cdr.Energy.Models;

namespace Example
{
    public class ListDERForServicePointsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new EnergyApi(config);
            var xV = xV_example;  // string | Version of the API end point requested by the client. Must be set to a positive integer. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If the value of [x-min-v](#request-headers) is equal to or higher than the value of [x-v](#request-headers) then the [x-min-v](#request-headers) header should be treated as absent. If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. See [HTTP Headers](#request-headers)
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | Request payload containing list of specific Service Points to obtain data for
            var page = 8.14;  // decimal? | Page of results to request (standard pagination) (optional) 
            var pageSize = 8.14;  // decimal? | Page size to request.  Default is 25 (standard pagination) (optional) 
            var xMinV = xMinV_example;  // string | Minimum version of the API end point requested by the client. Must be set to a positive integer if provided. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. (optional) 
            var xFapiInteractionId = xFapiInteractionId_example;  // string | An [RFC4122](https://tools.ietf.org/html/rfc4122) UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a [RFC4122] UUID value is required to be provided in the response header to track the interaction. (optional) 
            var xFapiAuthDate = xFapiAuthDate_example;  // string | The time when the customer last logged in to the data recipient. Required for all resource calls (customer present and unattended). Not to be included for unauthenticated calls. (optional) 
            var xFapiCustomerIpAddress = xFapiCustomerIpAddress_example;  // string | The customer's original IP address if the customer is currently logged in to the data recipient. The presence of this header indicates that the API is being called in a customer present context. Not to be included for unauthenticated calls. (optional) 
            var xCdsClientHeaders = xCdsClientHeaders_example;  // string | The customer's original standard http headers [Base64](#common-field-types) encoded, including the original User Agent header, if the customer is currently logged in to the data recipient. Mandatory for customer present calls.  Not required for unattended or unauthenticated calls. (optional) 

            try
            {
                // Get DER For Specific Service Points
                EnergyDerListResponse result = apiInstance.ListDERForServicePoints(xV, UNKNOWN_BASE_TYPE, page, pageSize, xMinV, xFapiInteractionId, xFapiAuthDate, xFapiCustomerIpAddress, xCdsClientHeaders);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EnergyApi.ListDERForServicePoints: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **xV** | **string**| Version of the API end point requested by the client. Must be set to a positive integer. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If the value of [x-min-v](#request-headers) is equal to or higher than the value of [x-v](#request-headers) then the [x-min-v](#request-headers) header should be treated as absent. If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. See [HTTP Headers](#request-headers) | 
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)| Request payload containing list of specific Service Points to obtain data for | 
 **page** | **decimal?**| Page of results to request (standard pagination) | [optional] 
 **pageSize** | **decimal?**| Page size to request.  Default is 25 (standard pagination) | [optional] 
 **xMinV** | **string**| Minimum version of the API end point requested by the client. Must be set to a positive integer if provided. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. | [optional] 
 **xFapiInteractionId** | **string**| An [RFC4122](https://tools.ietf.org/html/rfc4122) UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a [RFC4122] UUID value is required to be provided in the response header to track the interaction. | [optional] 
 **xFapiAuthDate** | **string**| The time when the customer last logged in to the data recipient. Required for all resource calls (customer present and unattended). Not to be included for unauthenticated calls. | [optional] 
 **xFapiCustomerIpAddress** | **string**| The customer&#39;s original IP address if the customer is currently logged in to the data recipient. The presence of this header indicates that the API is being called in a customer present context. Not to be included for unauthenticated calls. | [optional] 
 **xCdsClientHeaders** | **string**| The customer&#39;s original standard http headers [Base64](#common-field-types) encoded, including the original User Agent header, if the customer is currently logged in to the data recipient. Mandatory for customer present calls.  Not required for unattended or unauthenticated calls. | [optional] 

### Return type

[**EnergyDerListResponse**](EnergyDerListResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  * x-v -  <br>  * x-fapi-interaction-id -  <br>  |
| **0** | The following error codes MUST be supported:&lt;br/&gt;&lt;ul class&#x3D;\&quot;error-code-list\&quot;&gt;&lt;li&gt;[400 - Invalid Field](#error-400-field-invalid)&lt;/li&gt;&lt;li&gt;[400 - Invalid Page Size](#error-400-field-invalid-page-size)&lt;/li&gt;&lt;li&gt;[400 - Invalid Version](#error-400-header-invalid-version)&lt;/li&gt;&lt;li&gt;[406 - Unsupported Version](#error-406-header-unsupported-version)&lt;/li&gt;&lt;li&gt;[422 - Invalid Page](#error-422-field-invalid-page)&lt;/li&gt;&lt;li&gt;[422 - Unavailable Service Point](#error-422-unavailable-service-point)&lt;/li&gt;&lt;li&gt;[422 - Invalid Service Point](#error-422-invalid-service-point)&lt;/li&gt;&lt;/ul&gt; |  * x-fapi-interaction-id -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listinvoicesbulk"></a>
# **ListInvoicesBulk**
> EnergyInvoiceListResponse ListInvoicesBulk (string xV, string newestDate = null, string oldestDate = null, decimal? page = null, decimal? pageSize = null, string xMinV = null, string xFapiInteractionId = null, string xFapiAuthDate = null, string xFapiCustomerIpAddress = null, string xCdsClientHeaders = null)

Get Bulk Invoices

Obtain the invoices for all accounts

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agl.Cdr.Energy.Apis;
using Agl.Cdr.Energy.Client;
using Agl.Cdr.Energy.Models;

namespace Example
{
    public class ListInvoicesBulkExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new EnergyApi(config);
            var xV = xV_example;  // string | Version of the API end point requested by the client. Must be set to a positive integer. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If the value of [x-min-v](#request-headers) is equal to or higher than the value of [x-v](#request-headers) then the [x-min-v](#request-headers) header should be treated as absent. If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. See [HTTP Headers](#request-headers)
            var newestDate = newestDate_example;  // string | Constrain the request to records with effective date at or before this date.  If absent defaults to current date.  Format is aligned to DateString common type (optional) 
            var oldestDate = oldestDate_example;  // string | Constrain the request to records with effective date at or after this date. If absent defaults to newest-date minus 24 months days.  Format is aligned to DateString common type (optional) 
            var page = 8.14;  // decimal? | Page of results to request (standard pagination) (optional) 
            var pageSize = 8.14;  // decimal? | Page size to request.  Default is 25 (standard pagination) (optional) 
            var xMinV = xMinV_example;  // string | Minimum version of the API end point requested by the client. Must be set to a positive integer if provided. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. (optional) 
            var xFapiInteractionId = xFapiInteractionId_example;  // string | An [RFC4122](https://tools.ietf.org/html/rfc4122) UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a [RFC4122] UUID value is required to be provided in the response header to track the interaction. (optional) 
            var xFapiAuthDate = xFapiAuthDate_example;  // string | The time when the customer last logged in to the data recipient. Required for all resource calls (customer present and unattended). Not to be included for unauthenticated calls. (optional) 
            var xFapiCustomerIpAddress = xFapiCustomerIpAddress_example;  // string | The customer's original IP address if the customer is currently logged in to the data recipient. The presence of this header indicates that the API is being called in a customer present context. Not to be included for unauthenticated calls. (optional) 
            var xCdsClientHeaders = xCdsClientHeaders_example;  // string | The customer's original standard http headers [Base64](#common-field-types) encoded, including the original User Agent header, if the customer is currently logged in to the data recipient. Mandatory for customer present calls.  Not required for unattended or unauthenticated calls. (optional) 

            try
            {
                // Get Bulk Invoices
                EnergyInvoiceListResponse result = apiInstance.ListInvoicesBulk(xV, newestDate, oldestDate, page, pageSize, xMinV, xFapiInteractionId, xFapiAuthDate, xFapiCustomerIpAddress, xCdsClientHeaders);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EnergyApi.ListInvoicesBulk: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **xV** | **string**| Version of the API end point requested by the client. Must be set to a positive integer. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If the value of [x-min-v](#request-headers) is equal to or higher than the value of [x-v](#request-headers) then the [x-min-v](#request-headers) header should be treated as absent. If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. See [HTTP Headers](#request-headers) | 
 **newestDate** | **string**| Constrain the request to records with effective date at or before this date.  If absent defaults to current date.  Format is aligned to DateString common type | [optional] 
 **oldestDate** | **string**| Constrain the request to records with effective date at or after this date. If absent defaults to newest-date minus 24 months days.  Format is aligned to DateString common type | [optional] 
 **page** | **decimal?**| Page of results to request (standard pagination) | [optional] 
 **pageSize** | **decimal?**| Page size to request.  Default is 25 (standard pagination) | [optional] 
 **xMinV** | **string**| Minimum version of the API end point requested by the client. Must be set to a positive integer if provided. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. | [optional] 
 **xFapiInteractionId** | **string**| An [RFC4122](https://tools.ietf.org/html/rfc4122) UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a [RFC4122] UUID value is required to be provided in the response header to track the interaction. | [optional] 
 **xFapiAuthDate** | **string**| The time when the customer last logged in to the data recipient. Required for all resource calls (customer present and unattended). Not to be included for unauthenticated calls. | [optional] 
 **xFapiCustomerIpAddress** | **string**| The customer&#39;s original IP address if the customer is currently logged in to the data recipient. The presence of this header indicates that the API is being called in a customer present context. Not to be included for unauthenticated calls. | [optional] 
 **xCdsClientHeaders** | **string**| The customer&#39;s original standard http headers [Base64](#common-field-types) encoded, including the original User Agent header, if the customer is currently logged in to the data recipient. Mandatory for customer present calls.  Not required for unattended or unauthenticated calls. | [optional] 

### Return type

[**EnergyInvoiceListResponse**](EnergyInvoiceListResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  * x-v -  <br>  * x-fapi-interaction-id -  <br>  |
| **0** | The following error codes MUST be supported:&lt;br/&gt;&lt;ul class&#x3D;\&quot;error-code-list\&quot;&gt;&lt;li&gt;[400 - Invalid Field](#error-400-field-invalid)&lt;/li&gt;&lt;li&gt;[400 - Invalid Page Size](#error-400-field-invalid-page-size)&lt;/li&gt;&lt;li&gt;[400 - Invalid Version](#error-400-header-invalid-version)&lt;/li&gt;&lt;li&gt;[406 - Unsupported Version](#error-406-header-unsupported-version)&lt;/li&gt;&lt;li&gt;[422 - Invalid Page](#error-422-field-invalid-page)&lt;/li&gt;&lt;/ul&gt; |  * x-fapi-interaction-id -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listinvoicesforaccounts"></a>
# **ListInvoicesForAccounts**
> EnergyInvoiceListResponse ListInvoicesForAccounts (string xV, UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE, string newestDate = null, string oldestDate = null, decimal? page = null, decimal? pageSize = null, string xMinV = null, string xFapiInteractionId = null, string xFapiAuthDate = null, string xFapiCustomerIpAddress = null, string xCdsClientHeaders = null)

Get Invoices For Specific Accounts

Obtain invoices for a specified set of accounts

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agl.Cdr.Energy.Apis;
using Agl.Cdr.Energy.Client;
using Agl.Cdr.Energy.Models;

namespace Example
{
    public class ListInvoicesForAccountsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new EnergyApi(config);
            var xV = xV_example;  // string | Version of the API end point requested by the client. Must be set to a positive integer. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If the value of [x-min-v](#request-headers) is equal to or higher than the value of [x-v](#request-headers) then the [x-min-v](#request-headers) header should be treated as absent. If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. See [HTTP Headers](#request-headers)
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | Request payload containing list of specific Accounts to obtain data for
            var newestDate = newestDate_example;  // string | Constrain the request to records with effective date at or before this date.  If absent defaults to current date.  Format is aligned to DateString common type (optional) 
            var oldestDate = oldestDate_example;  // string | Constrain the request to records with effective date at or after this date. If absent defaults to newest-date minus 24 months days.  Format is aligned to DateString common type (optional) 
            var page = 8.14;  // decimal? | Page of results to request (standard pagination) (optional) 
            var pageSize = 8.14;  // decimal? | Page size to request.  Default is 25 (standard pagination) (optional) 
            var xMinV = xMinV_example;  // string | Minimum version of the API end point requested by the client. Must be set to a positive integer if provided. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. (optional) 
            var xFapiInteractionId = xFapiInteractionId_example;  // string | An [RFC4122](https://tools.ietf.org/html/rfc4122) UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a [RFC4122] UUID value is required to be provided in the response header to track the interaction. (optional) 
            var xFapiAuthDate = xFapiAuthDate_example;  // string | The time when the customer last logged in to the data recipient. Required for all resource calls (customer present and unattended). Not to be included for unauthenticated calls. (optional) 
            var xFapiCustomerIpAddress = xFapiCustomerIpAddress_example;  // string | The customer's original IP address if the customer is currently logged in to the data recipient. The presence of this header indicates that the API is being called in a customer present context. Not to be included for unauthenticated calls. (optional) 
            var xCdsClientHeaders = xCdsClientHeaders_example;  // string | The customer's original standard http headers [Base64](#common-field-types) encoded, including the original User Agent header, if the customer is currently logged in to the data recipient. Mandatory for customer present calls.  Not required for unattended or unauthenticated calls. (optional) 

            try
            {
                // Get Invoices For Specific Accounts
                EnergyInvoiceListResponse result = apiInstance.ListInvoicesForAccounts(xV, UNKNOWN_BASE_TYPE, newestDate, oldestDate, page, pageSize, xMinV, xFapiInteractionId, xFapiAuthDate, xFapiCustomerIpAddress, xCdsClientHeaders);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EnergyApi.ListInvoicesForAccounts: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **xV** | **string**| Version of the API end point requested by the client. Must be set to a positive integer. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If the value of [x-min-v](#request-headers) is equal to or higher than the value of [x-v](#request-headers) then the [x-min-v](#request-headers) header should be treated as absent. If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. See [HTTP Headers](#request-headers) | 
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)| Request payload containing list of specific Accounts to obtain data for | 
 **newestDate** | **string**| Constrain the request to records with effective date at or before this date.  If absent defaults to current date.  Format is aligned to DateString common type | [optional] 
 **oldestDate** | **string**| Constrain the request to records with effective date at or after this date. If absent defaults to newest-date minus 24 months days.  Format is aligned to DateString common type | [optional] 
 **page** | **decimal?**| Page of results to request (standard pagination) | [optional] 
 **pageSize** | **decimal?**| Page size to request.  Default is 25 (standard pagination) | [optional] 
 **xMinV** | **string**| Minimum version of the API end point requested by the client. Must be set to a positive integer if provided. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. | [optional] 
 **xFapiInteractionId** | **string**| An [RFC4122](https://tools.ietf.org/html/rfc4122) UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a [RFC4122] UUID value is required to be provided in the response header to track the interaction. | [optional] 
 **xFapiAuthDate** | **string**| The time when the customer last logged in to the data recipient. Required for all resource calls (customer present and unattended). Not to be included for unauthenticated calls. | [optional] 
 **xFapiCustomerIpAddress** | **string**| The customer&#39;s original IP address if the customer is currently logged in to the data recipient. The presence of this header indicates that the API is being called in a customer present context. Not to be included for unauthenticated calls. | [optional] 
 **xCdsClientHeaders** | **string**| The customer&#39;s original standard http headers [Base64](#common-field-types) encoded, including the original User Agent header, if the customer is currently logged in to the data recipient. Mandatory for customer present calls.  Not required for unattended or unauthenticated calls. | [optional] 

### Return type

[**EnergyInvoiceListResponse**](EnergyInvoiceListResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  * x-v -  <br>  * x-fapi-interaction-id -  <br>  |
| **0** | The following error codes MUST be supported:&lt;br/&gt;&lt;ul class&#x3D;\&quot;error-code-list\&quot;&gt;&lt;li&gt;[400 - Invalid Field](#error-400-field-invalid)&lt;/li&gt;&lt;li&gt;[400 - Invalid Page Size](#error-400-field-invalid-page-size)&lt;/li&gt;&lt;li&gt;[400 - Invalid Version](#error-400-header-invalid-version)&lt;/li&gt;&lt;li&gt;[406 - Unsupported Version](#error-406-header-unsupported-version)&lt;/li&gt;&lt;li&gt;[422 - Invalid Page](#error-422-field-invalid-page)&lt;/li&gt;&lt;li&gt;[422 - Unavailable Energy Account](#error-422-unavailable-energy-account)&lt;/li&gt;&lt;li&gt;[422 - Invalid Energy Account](#error-422-invalid-energy-account)&lt;/li&gt;&lt;/ul&gt; |  * x-fapi-interaction-id -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listplans"></a>
# **ListPlans**
> EnergyPlanListResponse ListPlans (string xV, string type = null, string fuelType = null, string effective = null, string updatedSince = null, string brand = null, decimal? page = null, decimal? pageSize = null, string xMinV = null, string xFapiInteractionId = null)

Get Generic Plans

Obtain a list of energy plans that are currently offered to the market.  Note that the results returned by this end point are expected to be ordered in descending order according to `lastUpdated`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agl.Cdr.Energy.Apis;
using Agl.Cdr.Energy.Client;
using Agl.Cdr.Energy.Models;

namespace Example
{
    public class ListPlansExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new EnergyApi(config);
            var xV = xV_example;  // string | Version of the API end point requested by the client. Must be set to a positive integer. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If the value of [x-min-v](#request-headers) is equal to or higher than the value of [x-v](#request-headers) then the [x-min-v](#request-headers) header should be treated as absent. If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. See [HTTP Headers](#request-headers)
            var type = type_example;  // string | Used to filter results on the type field.  Any one of the valid values for this field can be supplied plus 'ALL'.  If absent defaults to 'ALL' (optional)  (default to ALL)
            var fuelType = fuelType_example;  // string | Used to filter results on the fuelType field.  Any one of the valid values for this field can be supplied plus 'ALL'.  If absent defaults to 'ALL' (optional)  (default to ALL)
            var effective = effective_example;  // string | Allows for the filtering of plans based on whether the current time is within the period of time defined as effective by the effectiveFrom and effectiveTo fields. Valid values are ‘CURRENT’, ‘FUTURE’ and ‘ALL’. If absent defaults to 'CURRENT' (optional)  (default to CURRENT)
            var updatedSince = updatedSince_example;  // string | Only include plans that have been updated after the specified date and time.  If absent defaults to include all plans (optional) 
            var brand = brand_example;  // string | Used to filter results on the brand field.  If absent defaults to include all plans (optional) 
            var page = 8.14;  // decimal? | Page of results to request (standard pagination) (optional) 
            var pageSize = 8.14;  // decimal? | Page size to request.  Default is 25 (standard pagination) (optional) 
            var xMinV = xMinV_example;  // string | Minimum version of the API end point requested by the client. Must be set to a positive integer if provided. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. (optional) 
            var xFapiInteractionId = xFapiInteractionId_example;  // string | An [RFC4122](https://tools.ietf.org/html/rfc4122) UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a [RFC4122] UUID value is required to be provided in the response header to track the interaction. (optional) 

            try
            {
                // Get Generic Plans
                EnergyPlanListResponse result = apiInstance.ListPlans(xV, type, fuelType, effective, updatedSince, brand, page, pageSize, xMinV, xFapiInteractionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EnergyApi.ListPlans: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **xV** | **string**| Version of the API end point requested by the client. Must be set to a positive integer. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If the value of [x-min-v](#request-headers) is equal to or higher than the value of [x-v](#request-headers) then the [x-min-v](#request-headers) header should be treated as absent. If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. See [HTTP Headers](#request-headers) | 
 **type** | **string**| Used to filter results on the type field.  Any one of the valid values for this field can be supplied plus &#39;ALL&#39;.  If absent defaults to &#39;ALL&#39; | [optional] [default to ALL]
 **fuelType** | **string**| Used to filter results on the fuelType field.  Any one of the valid values for this field can be supplied plus &#39;ALL&#39;.  If absent defaults to &#39;ALL&#39; | [optional] [default to ALL]
 **effective** | **string**| Allows for the filtering of plans based on whether the current time is within the period of time defined as effective by the effectiveFrom and effectiveTo fields. Valid values are ‘CURRENT’, ‘FUTURE’ and ‘ALL’. If absent defaults to &#39;CURRENT&#39; | [optional] [default to CURRENT]
 **updatedSince** | **string**| Only include plans that have been updated after the specified date and time.  If absent defaults to include all plans | [optional] 
 **brand** | **string**| Used to filter results on the brand field.  If absent defaults to include all plans | [optional] 
 **page** | **decimal?**| Page of results to request (standard pagination) | [optional] 
 **pageSize** | **decimal?**| Page size to request.  Default is 25 (standard pagination) | [optional] 
 **xMinV** | **string**| Minimum version of the API end point requested by the client. Must be set to a positive integer if provided. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. | [optional] 
 **xFapiInteractionId** | **string**| An [RFC4122](https://tools.ietf.org/html/rfc4122) UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a [RFC4122] UUID value is required to be provided in the response header to track the interaction. | [optional] 

### Return type

[**EnergyPlanListResponse**](EnergyPlanListResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  * x-v -  <br>  * x-fapi-interaction-id -  <br>  |
| **0** | The following error codes MUST be supported:&lt;br/&gt;&lt;ul class&#x3D;\&quot;error-code-list\&quot;&gt;&lt;li&gt;[400 - Invalid Field](#error-400-field-invalid)&lt;/li&gt;&lt;li&gt;[400 - Invalid Page Size](#error-400-field-invalid-page-size)&lt;/li&gt;&lt;li&gt;[400 - Invalid Version](#error-400-header-invalid-version)&lt;/li&gt;&lt;li&gt;[406 - Unsupported Version](#error-406-header-unsupported-version)&lt;/li&gt;&lt;li&gt;[422 - Invalid Page](#error-422-field-invalid-page)&lt;/li&gt;&lt;/ul&gt; |  * x-fapi-interaction-id -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listservicepoints"></a>
# **ListServicePoints**
> EnergyServicePointListResponse ListServicePoints (string xV, decimal? page = null, decimal? pageSize = null, string xMinV = null, string xFapiInteractionId = null, string xFapiAuthDate = null, string xFapiCustomerIpAddress = null, string xCdsClientHeaders = null)

Get Service Points

Obtain a list of service points owned by the customer that has authorised the current session

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agl.Cdr.Energy.Apis;
using Agl.Cdr.Energy.Client;
using Agl.Cdr.Energy.Models;

namespace Example
{
    public class ListServicePointsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new EnergyApi(config);
            var xV = xV_example;  // string | Version of the API end point requested by the client. Must be set to a positive integer. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If the value of [x-min-v](#request-headers) is equal to or higher than the value of [x-v](#request-headers) then the [x-min-v](#request-headers) header should be treated as absent. If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. See [HTTP Headers](#request-headers)
            var page = 8.14;  // decimal? | Page of results to request (standard pagination) (optional) 
            var pageSize = 8.14;  // decimal? | Page size to request.  Default is 25 (standard pagination) (optional) 
            var xMinV = xMinV_example;  // string | Minimum version of the API end point requested by the client. Must be set to a positive integer if provided. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. (optional) 
            var xFapiInteractionId = xFapiInteractionId_example;  // string | An [RFC4122](https://tools.ietf.org/html/rfc4122) UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a [RFC4122] UUID value is required to be provided in the response header to track the interaction. (optional) 
            var xFapiAuthDate = xFapiAuthDate_example;  // string | The time when the customer last logged in to the data recipient. Required for all resource calls (customer present and unattended). Not to be included for unauthenticated calls. (optional) 
            var xFapiCustomerIpAddress = xFapiCustomerIpAddress_example;  // string | The customer's original IP address if the customer is currently logged in to the data recipient. The presence of this header indicates that the API is being called in a customer present context. Not to be included for unauthenticated calls. (optional) 
            var xCdsClientHeaders = xCdsClientHeaders_example;  // string | The customer's original standard http headers [Base64](#common-field-types) encoded, including the original User Agent header, if the customer is currently logged in to the data recipient. Mandatory for customer present calls.  Not required for unattended or unauthenticated calls. (optional) 

            try
            {
                // Get Service Points
                EnergyServicePointListResponse result = apiInstance.ListServicePoints(xV, page, pageSize, xMinV, xFapiInteractionId, xFapiAuthDate, xFapiCustomerIpAddress, xCdsClientHeaders);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EnergyApi.ListServicePoints: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **xV** | **string**| Version of the API end point requested by the client. Must be set to a positive integer. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If the value of [x-min-v](#request-headers) is equal to or higher than the value of [x-v](#request-headers) then the [x-min-v](#request-headers) header should be treated as absent. If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. See [HTTP Headers](#request-headers) | 
 **page** | **decimal?**| Page of results to request (standard pagination) | [optional] 
 **pageSize** | **decimal?**| Page size to request.  Default is 25 (standard pagination) | [optional] 
 **xMinV** | **string**| Minimum version of the API end point requested by the client. Must be set to a positive integer if provided. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. | [optional] 
 **xFapiInteractionId** | **string**| An [RFC4122](https://tools.ietf.org/html/rfc4122) UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a [RFC4122] UUID value is required to be provided in the response header to track the interaction. | [optional] 
 **xFapiAuthDate** | **string**| The time when the customer last logged in to the data recipient. Required for all resource calls (customer present and unattended). Not to be included for unauthenticated calls. | [optional] 
 **xFapiCustomerIpAddress** | **string**| The customer&#39;s original IP address if the customer is currently logged in to the data recipient. The presence of this header indicates that the API is being called in a customer present context. Not to be included for unauthenticated calls. | [optional] 
 **xCdsClientHeaders** | **string**| The customer&#39;s original standard http headers [Base64](#common-field-types) encoded, including the original User Agent header, if the customer is currently logged in to the data recipient. Mandatory for customer present calls.  Not required for unattended or unauthenticated calls. | [optional] 

### Return type

[**EnergyServicePointListResponse**](EnergyServicePointListResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  * x-v -  <br>  * x-fapi-interaction-id -  <br>  |
| **0** | The following error codes MUST be supported:&lt;br/&gt;&lt;ul class&#x3D;\&quot;error-code-list\&quot;&gt;&lt;li&gt;[400 - Invalid Field](#error-400-field-invalid)&lt;/li&gt;&lt;li&gt;[400 - Invalid Page Size](#error-400-field-invalid-page-size)&lt;/li&gt;&lt;li&gt;[400 - Invalid Version](#error-400-header-invalid-version)&lt;/li&gt;&lt;li&gt;[406 - Unsupported Version](#error-406-header-unsupported-version)&lt;/li&gt;&lt;li&gt;[422 - Invalid Page](#error-422-field-invalid-page)&lt;/li&gt;&lt;/ul&gt; |  * x-fapi-interaction-id -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listusagebulk"></a>
# **ListUsageBulk**
> EnergyUsageListResponse ListUsageBulk (string xV, string oldestDate = null, string newestDate = null, decimal? page = null, decimal? pageSize = null, string xMinV = null, string xFapiInteractionId = null, string xFapiAuthDate = null, string xFapiCustomerIpAddress = null, string xCdsClientHeaders = null)

Get Bulk Usage

Obtain usage data for all service points associated with the customer

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agl.Cdr.Energy.Apis;
using Agl.Cdr.Energy.Client;
using Agl.Cdr.Energy.Models;

namespace Example
{
    public class ListUsageBulkExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new EnergyApi(config);
            var xV = xV_example;  // string | Version of the API end point requested by the client. Must be set to a positive integer. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If the value of [x-min-v](#request-headers) is equal to or higher than the value of [x-v](#request-headers) then the [x-min-v](#request-headers) header should be treated as absent. If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. See [HTTP Headers](#request-headers)
            var oldestDate = oldestDate_example;  // string | Constrain the request to records with effective date at or after this date. If absent defaults to newest-date minus 24 months days.  Format is aligned to DateString common type (optional) 
            var newestDate = newestDate_example;  // string | Constrain the request to records with effective date at or before this date.  If absent defaults to current date.  Format is aligned to DateString common type (optional) 
            var page = 8.14;  // decimal? | Page of results to request (standard pagination) (optional) 
            var pageSize = 8.14;  // decimal? | Page size to request.  Default is 25 (standard pagination) (optional) 
            var xMinV = xMinV_example;  // string | Minimum version of the API end point requested by the client. Must be set to a positive integer if provided. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. (optional) 
            var xFapiInteractionId = xFapiInteractionId_example;  // string | An [RFC4122](https://tools.ietf.org/html/rfc4122) UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a [RFC4122] UUID value is required to be provided in the response header to track the interaction. (optional) 
            var xFapiAuthDate = xFapiAuthDate_example;  // string | The time when the customer last logged in to the data recipient. Required for all resource calls (customer present and unattended). Not to be included for unauthenticated calls. (optional) 
            var xFapiCustomerIpAddress = xFapiCustomerIpAddress_example;  // string | The customer's original IP address if the customer is currently logged in to the data recipient. The presence of this header indicates that the API is being called in a customer present context. Not to be included for unauthenticated calls. (optional) 
            var xCdsClientHeaders = xCdsClientHeaders_example;  // string | The customer's original standard http headers [Base64](#common-field-types) encoded, including the original User Agent header, if the customer is currently logged in to the data recipient. Mandatory for customer present calls.  Not required for unattended or unauthenticated calls. (optional) 

            try
            {
                // Get Bulk Usage
                EnergyUsageListResponse result = apiInstance.ListUsageBulk(xV, oldestDate, newestDate, page, pageSize, xMinV, xFapiInteractionId, xFapiAuthDate, xFapiCustomerIpAddress, xCdsClientHeaders);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EnergyApi.ListUsageBulk: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **xV** | **string**| Version of the API end point requested by the client. Must be set to a positive integer. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If the value of [x-min-v](#request-headers) is equal to or higher than the value of [x-v](#request-headers) then the [x-min-v](#request-headers) header should be treated as absent. If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. See [HTTP Headers](#request-headers) | 
 **oldestDate** | **string**| Constrain the request to records with effective date at or after this date. If absent defaults to newest-date minus 24 months days.  Format is aligned to DateString common type | [optional] 
 **newestDate** | **string**| Constrain the request to records with effective date at or before this date.  If absent defaults to current date.  Format is aligned to DateString common type | [optional] 
 **page** | **decimal?**| Page of results to request (standard pagination) | [optional] 
 **pageSize** | **decimal?**| Page size to request.  Default is 25 (standard pagination) | [optional] 
 **xMinV** | **string**| Minimum version of the API end point requested by the client. Must be set to a positive integer if provided. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. | [optional] 
 **xFapiInteractionId** | **string**| An [RFC4122](https://tools.ietf.org/html/rfc4122) UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a [RFC4122] UUID value is required to be provided in the response header to track the interaction. | [optional] 
 **xFapiAuthDate** | **string**| The time when the customer last logged in to the data recipient. Required for all resource calls (customer present and unattended). Not to be included for unauthenticated calls. | [optional] 
 **xFapiCustomerIpAddress** | **string**| The customer&#39;s original IP address if the customer is currently logged in to the data recipient. The presence of this header indicates that the API is being called in a customer present context. Not to be included for unauthenticated calls. | [optional] 
 **xCdsClientHeaders** | **string**| The customer&#39;s original standard http headers [Base64](#common-field-types) encoded, including the original User Agent header, if the customer is currently logged in to the data recipient. Mandatory for customer present calls.  Not required for unattended or unauthenticated calls. | [optional] 

### Return type

[**EnergyUsageListResponse**](EnergyUsageListResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  * x-v -  <br>  * x-fapi-interaction-id -  <br>  |
| **0** | The following error codes MUST be supported:&lt;br/&gt;&lt;ul class&#x3D;\&quot;error-code-list\&quot;&gt;&lt;li&gt;[400 - Invalid Field](#error-400-field-invalid)&lt;/li&gt;&lt;li&gt;[400 - Invalid Page Size](#error-400-field-invalid-page-size)&lt;/li&gt;&lt;li&gt;[400 - Invalid Version](#error-400-header-invalid-version)&lt;/li&gt;&lt;li&gt;[406 - Unsupported Version](#error-406-header-unsupported-version)&lt;/li&gt;&lt;li&gt;[422 - Invalid Page](#error-422-field-invalid-page)&lt;/li&gt;&lt;/ul&gt; |  * x-fapi-interaction-id -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listusageforservicepoints"></a>
# **ListUsageForServicePoints**
> EnergyUsageListResponse ListUsageForServicePoints (string xV, UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE, string oldestDate = null, string newestDate = null, decimal? page = null, decimal? pageSize = null, string xMinV = null, string xFapiInteractionId = null, string xFapiAuthDate = null, string xFapiCustomerIpAddress = null, string xCdsClientHeaders = null)

Get Usage For Specific Service Points

Obtain the electricity usage data for a specific set of service points

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agl.Cdr.Energy.Apis;
using Agl.Cdr.Energy.Client;
using Agl.Cdr.Energy.Models;

namespace Example
{
    public class ListUsageForServicePointsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new EnergyApi(config);
            var xV = xV_example;  // string | Version of the API end point requested by the client. Must be set to a positive integer. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If the value of [x-min-v](#request-headers) is equal to or higher than the value of [x-v](#request-headers) then the [x-min-v](#request-headers) header should be treated as absent. If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. See [HTTP Headers](#request-headers)
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | Request payload containing list of specific Service Points to obtain data for
            var oldestDate = oldestDate_example;  // string | Constrain the request to records with effective date at or after this date. If absent defaults to newest-date minus 24 months days.  Format is aligned to DateString common type (optional) 
            var newestDate = newestDate_example;  // string | Constrain the request to records with effective date at or before this date.  If absent defaults to current date.  Format is aligned to DateString common type (optional) 
            var page = 8.14;  // decimal? | Page of results to request (standard pagination) (optional) 
            var pageSize = 8.14;  // decimal? | Page size to request.  Default is 25 (standard pagination) (optional) 
            var xMinV = xMinV_example;  // string | Minimum version of the API end point requested by the client. Must be set to a positive integer if provided. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. (optional) 
            var xFapiInteractionId = xFapiInteractionId_example;  // string | An [RFC4122](https://tools.ietf.org/html/rfc4122) UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a [RFC4122] UUID value is required to be provided in the response header to track the interaction. (optional) 
            var xFapiAuthDate = xFapiAuthDate_example;  // string | The time when the customer last logged in to the data recipient. Required for all resource calls (customer present and unattended). Not to be included for unauthenticated calls. (optional) 
            var xFapiCustomerIpAddress = xFapiCustomerIpAddress_example;  // string | The customer's original IP address if the customer is currently logged in to the data recipient. The presence of this header indicates that the API is being called in a customer present context. Not to be included for unauthenticated calls. (optional) 
            var xCdsClientHeaders = xCdsClientHeaders_example;  // string | The customer's original standard http headers [Base64](#common-field-types) encoded, including the original User Agent header, if the customer is currently logged in to the data recipient. Mandatory for customer present calls.  Not required for unattended or unauthenticated calls. (optional) 

            try
            {
                // Get Usage For Specific Service Points
                EnergyUsageListResponse result = apiInstance.ListUsageForServicePoints(xV, UNKNOWN_BASE_TYPE, oldestDate, newestDate, page, pageSize, xMinV, xFapiInteractionId, xFapiAuthDate, xFapiCustomerIpAddress, xCdsClientHeaders);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EnergyApi.ListUsageForServicePoints: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **xV** | **string**| Version of the API end point requested by the client. Must be set to a positive integer. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If the value of [x-min-v](#request-headers) is equal to or higher than the value of [x-v](#request-headers) then the [x-min-v](#request-headers) header should be treated as absent. If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. See [HTTP Headers](#request-headers) | 
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)| Request payload containing list of specific Service Points to obtain data for | 
 **oldestDate** | **string**| Constrain the request to records with effective date at or after this date. If absent defaults to newest-date minus 24 months days.  Format is aligned to DateString common type | [optional] 
 **newestDate** | **string**| Constrain the request to records with effective date at or before this date.  If absent defaults to current date.  Format is aligned to DateString common type | [optional] 
 **page** | **decimal?**| Page of results to request (standard pagination) | [optional] 
 **pageSize** | **decimal?**| Page size to request.  Default is 25 (standard pagination) | [optional] 
 **xMinV** | **string**| Minimum version of the API end point requested by the client. Must be set to a positive integer if provided. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. | [optional] 
 **xFapiInteractionId** | **string**| An [RFC4122](https://tools.ietf.org/html/rfc4122) UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a [RFC4122] UUID value is required to be provided in the response header to track the interaction. | [optional] 
 **xFapiAuthDate** | **string**| The time when the customer last logged in to the data recipient. Required for all resource calls (customer present and unattended). Not to be included for unauthenticated calls. | [optional] 
 **xFapiCustomerIpAddress** | **string**| The customer&#39;s original IP address if the customer is currently logged in to the data recipient. The presence of this header indicates that the API is being called in a customer present context. Not to be included for unauthenticated calls. | [optional] 
 **xCdsClientHeaders** | **string**| The customer&#39;s original standard http headers [Base64](#common-field-types) encoded, including the original User Agent header, if the customer is currently logged in to the data recipient. Mandatory for customer present calls.  Not required for unattended or unauthenticated calls. | [optional] 

### Return type

[**EnergyUsageListResponse**](EnergyUsageListResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  * x-v -  <br>  * x-fapi-interaction-id -  <br>  |
| **0** | The following error codes MUST be supported:&lt;br/&gt;&lt;ul class&#x3D;\&quot;error-code-list\&quot;&gt;&lt;li&gt;[400 - Invalid Field](#error-400-field-invalid)&lt;/li&gt;&lt;li&gt;[400 - Invalid Page Size](#error-400-field-invalid-page-size)&lt;/li&gt;&lt;li&gt;[400 - Invalid Version](#error-400-header-invalid-version)&lt;/li&gt;&lt;li&gt;[406 - Unsupported Version](#error-406-header-unsupported-version)&lt;/li&gt;&lt;li&gt;[422 - Invalid Page](#error-422-field-invalid-page)&lt;/li&gt;&lt;li&gt;[422 - Unavailable Service Point](#error-422-unavailable-service-point)&lt;/li&gt;&lt;li&gt;[422 - Invalid Service Point](#error-422-invalid-service-point)&lt;/li&gt;&lt;/ul&gt; |  * x-fapi-interaction-id -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

