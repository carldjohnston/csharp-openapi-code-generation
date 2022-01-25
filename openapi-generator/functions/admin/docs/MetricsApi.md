# Agl.Cdr.Admin.Apis.MetricsApi

All URIs are relative to *https://data.holder.com.au/cds-au/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetMetrics**](MetricsApi.md#getmetrics) | **GET** /admin/metrics | Get Metrics


<a name="getmetrics"></a>
# **GetMetrics**
> ResponseMetricsListV3 GetMetrics (string xV, string period = null, string xMinV = null)

Get Metrics

This end point allows the ACCC to obtain operational statistics from the Data Holder on the operation of their CDR compliant implementation. The statistics obtainable from this end point are determined by the non-functional requirements for the CDR regime.  NOTE: This version must be implemented by **October 1st 2022**  Obsolete versions: [v1](includes/obsolete/get-metrics-v1.html) [v2](includes/obsolete/get-metrics-v2.html).  If the Data Holder supports private_key_jwt client authentication they MUST validate the scope.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agl.Cdr.Admin.Apis;
using Agl.Cdr.Admin.Client;
using Agl.Cdr.Admin.Models;

namespace Example
{
    public class GetMetricsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.holder.com.au/cds-au/v1";
            var apiInstance = new MetricsApi(config);
            var xV = xV_example;  // string | Version of the API end point requested by the client. Must be set to a positive integer. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If the value of [x-min-v](#request-headers) is equal to or higher than the value of [x-v](#request-headers) then the [x-min-v](#request-headers) header should be treated as absent. If all versions requested are not supported then the data holder should respond with a 406 Not Acceptable. See [HTTP Headers](#request-headers)
            var period = period_example;  // string | The period of metrics to be requested. Values can be CURRENT (meaning metrics for current day), HISTORIC (meaning metrics for previous days or months) or ALL. If absent the default is ALL. (optional)  (default to ALL)
            var xMinV = xMinV_example;  // string | Minimum version of the API end point requested by the client. Must be set to a positive integer if provided. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If all versions requested are not supported then the data holder should respond with a 406 Not Acceptable. (optional) 

            try
            {
                // Get Metrics
                ResponseMetricsListV3 result = apiInstance.GetMetrics(xV, period, xMinV);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetricsApi.GetMetrics: " + e.Message );
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
 **xV** | **string**| Version of the API end point requested by the client. Must be set to a positive integer. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If the value of [x-min-v](#request-headers) is equal to or higher than the value of [x-v](#request-headers) then the [x-min-v](#request-headers) header should be treated as absent. If all versions requested are not supported then the data holder should respond with a 406 Not Acceptable. See [HTTP Headers](#request-headers) | 
 **period** | **string**| The period of metrics to be requested. Values can be CURRENT (meaning metrics for current day), HISTORIC (meaning metrics for previous days or months) or ALL. If absent the default is ALL. | [optional] [default to ALL]
 **xMinV** | **string**| Minimum version of the API end point requested by the client. Must be set to a positive integer if provided. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If all versions requested are not supported then the data holder should respond with a 406 Not Acceptable. | [optional] 

### Return type

[**ResponseMetricsListV3**](ResponseMetricsListV3.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  * x-v - The [version](#response-headers) of the API end point that the data holder has responded with. <br>  |
| **0** | The following error codes MUST be supported:&lt;br/&gt;&lt;ul class&#x3D;\&quot;error-code-list\&quot;&gt;&lt;li&gt;[400 - Invalid Field](#error-400-field-invalid)&lt;/li&gt;&lt;li&gt;[400 - Invalid Version](#error-400-header-invalid-version)&lt;/li&gt;&lt;li&gt;[406 - Unsupported Version](#error-406-header-unsupported-version)&lt;/li&gt;&lt;/ul&gt; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

