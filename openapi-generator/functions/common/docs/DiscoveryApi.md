# Agl.Cdr.Common.Apis.DiscoveryApi

All URIs are relative to *https://data.holder.com.au/cds-au/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetOutages**](DiscoveryApi.md#getoutages) | **GET** /discovery/outages | Get Outages
[**GetStatus**](DiscoveryApi.md#getstatus) | **GET** /discovery/status | Get Status


<a name="getoutages"></a>
# **GetOutages**
> ResponseDiscoveryOutagesList GetOutages (string xV, string xMinV = null)

Get Outages

Obtain a list of scheduled outages for the implementation

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agl.Cdr.Common.Apis;
using Agl.Cdr.Common.Client;
using Agl.Cdr.Common.Models;

namespace Example
{
    public class GetOutagesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.holder.com.au/cds-au/v1";
            var apiInstance = new DiscoveryApi(config);
            var xV = xV_example;  // string | Version of the API end point requested by the client. Must be set to a positive integer. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If the value of [x-min-v](#request-headers) is equal to or higher than the value of [x-v](#request-headers) then the [x-min-v](#request-headers) header should be treated as absent. If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. See [HTTP Headers](#request-headers)
            var xMinV = xMinV_example;  // string | Minimum version of the API end point requested by the client. Must be set to a positive integer if provided. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. (optional) 

            try
            {
                // Get Outages
                ResponseDiscoveryOutagesList result = apiInstance.GetOutages(xV, xMinV);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DiscoveryApi.GetOutages: " + e.Message );
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
 **xMinV** | **string**| Minimum version of the API end point requested by the client. Must be set to a positive integer if provided. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. | [optional] 

### Return type

[**ResponseDiscoveryOutagesList**](ResponseDiscoveryOutagesList.md)

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

<a name="getstatus"></a>
# **GetStatus**
> ResponseCommonDiscoveryStatus GetStatus (string xV, string xMinV = null)

Get Status

Obtain a health check status for the implementation

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agl.Cdr.Common.Apis;
using Agl.Cdr.Common.Client;
using Agl.Cdr.Common.Models;

namespace Example
{
    public class GetStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.holder.com.au/cds-au/v1";
            var apiInstance = new DiscoveryApi(config);
            var xV = xV_example;  // string | Version of the API end point requested by the client. Must be set to a positive integer. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If the value of [x-min-v](#request-headers) is equal to or higher than the value of [x-v](#request-headers) then the [x-min-v](#request-headers) header should be treated as absent. If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. See [HTTP Headers](#request-headers)
            var xMinV = xMinV_example;  // string | Minimum version of the API end point requested by the client. Must be set to a positive integer if provided. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. (optional) 

            try
            {
                // Get Status
                ResponseCommonDiscoveryStatus result = apiInstance.GetStatus(xV, xMinV);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DiscoveryApi.GetStatus: " + e.Message );
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
 **xMinV** | **string**| Minimum version of the API end point requested by the client. Must be set to a positive integer if provided. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. | [optional] 

### Return type

[**ResponseCommonDiscoveryStatus**](ResponseCommonDiscoveryStatus.md)

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

