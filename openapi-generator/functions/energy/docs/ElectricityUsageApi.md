# Agl.Cdr.Energy.Apis.ElectricityUsageApi

All URIs are relative to *http://example.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetUsageForServicePoint**](ElectricityUsageApi.md#getusageforservicepoint) | **GET** /energy/electricity/servicepoints/{servicePointId}/usage | Get Usage For Service Point
[**ListUsageBulk**](ElectricityUsageApi.md#listusagebulk) | **GET** /energy/electricity/servicepoints/usage | Get Bulk Usage
[**ListUsageForServicePoints**](ElectricityUsageApi.md#listusageforservicepoints) | **POST** /energy/electricity/servicepoints/usage | Get Usage For Specific Service Points


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
            config.BasePath = "http://example.com";
            var apiInstance = new ElectricityUsageApi(config);
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
                Debug.Print("Exception when calling ElectricityUsageApi.GetUsageForServicePoint: " + e.Message );
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
            config.BasePath = "http://example.com";
            var apiInstance = new ElectricityUsageApi(config);
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
                Debug.Print("Exception when calling ElectricityUsageApi.ListUsageBulk: " + e.Message );
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
            config.BasePath = "http://example.com";
            var apiInstance = new ElectricityUsageApi(config);
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
                Debug.Print("Exception when calling ElectricityUsageApi.ListUsageForServicePoints: " + e.Message );
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

