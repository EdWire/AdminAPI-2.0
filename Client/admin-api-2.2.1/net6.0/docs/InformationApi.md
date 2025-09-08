# EdFi.Ods.AdminApi.V2.Client.Api.InformationApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**RootGet**](InformationApi.md#rootget) | **GET** / | Retrieve API informational metadata |

<a id="rootget"></a>
# **RootGet**
> InformationResult RootGet ()

Retrieve API informational metadata

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdFi.Ods.AdminApi.V2.Client.Api;
using EdFi.Ods.AdminApi.V2.Client.Client;
using EdFi.Ods.AdminApi.V2.Client.Model;

namespace Example
{
    public class RootGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InformationApi(config);

            try
            {
                // Retrieve API informational metadata
                InformationResult result = apiInstance.RootGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InformationApi.RootGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RootGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve API informational metadata
    ApiResponse<InformationResult> response = apiInstance.RootGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InformationApi.RootGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**InformationResult**](InformationResult.md)

### Authorization

[oauth](../README.md#oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **500** | Internal server error. An unhandled error occurred on the server. See the response body for details. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

