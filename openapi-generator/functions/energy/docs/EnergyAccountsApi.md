# Agl.Cdr.Energy.Apis.EnergyAccountsApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAccount**](EnergyAccountsApi.md#getaccount) | **GET** /energy/accounts/{accountId} | Get Energy Account Detail
[**GetConcessions**](EnergyAccountsApi.md#getconcessions) | **GET** /energy/accounts/{accountId}/concessions | Get Concessions
[**GetPaymentSchedule**](EnergyAccountsApi.md#getpaymentschedule) | **GET** /energy/accounts/{accountId}/payment-schedule | Get Agreed Payment Schedule
[**ListAccounts**](EnergyAccountsApi.md#listaccounts) | **GET** /energy/accounts | Get Energy Accounts


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
            var apiInstance = new EnergyAccountsApi(config);
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
                Debug.Print("Exception when calling EnergyAccountsApi.GetAccount: " + e.Message );
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
            var apiInstance = new EnergyAccountsApi(config);
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
                Debug.Print("Exception when calling EnergyAccountsApi.GetConcessions: " + e.Message );
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
            var apiInstance = new EnergyAccountsApi(config);
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
                Debug.Print("Exception when calling EnergyAccountsApi.GetPaymentSchedule: " + e.Message );
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
            var apiInstance = new EnergyAccountsApi(config);
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
                Debug.Print("Exception when calling EnergyAccountsApi.ListAccounts: " + e.Message );
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

