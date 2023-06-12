# CubeJS.Gateway.Client.Api.DefaultApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**LoadV1**](DefaultApi.md#loadv1) | **POST** /v1/load | Load data via Cube JSON Query |
| [**MetaV1**](DefaultApi.md#metav1) | **GET** /v1/meta | Load Metadata |

<a id="loadv1"></a>
# **LoadV1**
> V1LoadResponse LoadV1 (V1LoadRequest? v1LoadRequest = null)

Load data via Cube JSON Query

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CubeJS.Gateway.Client.Api;
using CubeJS.Gateway.Client.Client;
using CubeJS.Gateway.Client.Model;

namespace Example
{
    public class LoadV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);
            var v1LoadRequest = new V1LoadRequest?(); // V1LoadRequest? |  (optional) 

            try
            {
                // Load data via Cube JSON Query
                V1LoadResponse result = apiInstance.LoadV1(v1LoadRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.LoadV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LoadV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Load data via Cube JSON Query
    ApiResponse<V1LoadResponse> response = apiInstance.LoadV1WithHttpInfo(v1LoadRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.LoadV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **v1LoadRequest** | [**V1LoadRequest?**](V1LoadRequest?.md) |  | [optional]  |

### Return type

[**V1LoadResponse**](V1LoadResponse.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **4XX** | Request could not be completed |  -  |
| **5XX** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="metav1"></a>
# **MetaV1**
> V1MetaResponse MetaV1 ()

Load Metadata

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CubeJS.Gateway.Client.Api;
using CubeJS.Gateway.Client.Client;
using CubeJS.Gateway.Client.Model;

namespace Example
{
    public class MetaV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);

            try
            {
                // Load Metadata
                V1MetaResponse result = apiInstance.MetaV1();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.MetaV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MetaV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Load Metadata
    ApiResponse<V1MetaResponse> response = apiInstance.MetaV1WithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.MetaV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**V1MetaResponse**](V1MetaResponse.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **4XX** | Request could not be completed |  -  |
| **5XX** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

