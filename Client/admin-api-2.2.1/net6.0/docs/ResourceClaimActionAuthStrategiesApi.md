# EdFi.Ods.AdminApi.V2.Client.Api.ResourceClaimActionAuthStrategiesApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**V2ResourceClaimActionAuthStrategiesGet**](ResourceClaimActionAuthStrategiesApi.md#v2resourceclaimactionauthstrategiesget) | **GET** /v2/resourceClaimActionAuthStrategies | Retrieves all resourceClaimActionAuthStrategies. |

<a id="v2resourceclaimactionauthstrategiesget"></a>
# **V2ResourceClaimActionAuthStrategiesGet**
> List&lt;ResourceClaimActionAuthStrategyModel&gt; V2ResourceClaimActionAuthStrategiesGet (int? offset = null, int? limit = null, string? orderBy = null, string? direction = null, string? resourceName = null)

Retrieves all resourceClaimActionAuthStrategies.

This GET operation provides access to resources using the \"Get\" search pattern. The values of any properties of the resource that are specified will be used to return all matching results (if it exists).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdFi.Ods.AdminApi.V2.Client.Api;
using EdFi.Ods.AdminApi.V2.Client.Client;
using EdFi.Ods.AdminApi.V2.Client.Model;

namespace Example
{
    public class V2ResourceClaimActionAuthStrategiesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ResourceClaimActionAuthStrategiesApi(config);
            var offset = 56;  // int? | Indicates how many items should be skipped before returning results. (optional) 
            var limit = 56;  // int? | Indicates the maximum number of items that should be returned in the results. (optional) 
            var orderBy = "\"\"";  // string? | Indicates the property name by which the results will be sorted. (optional)  (default to "")
            var direction = "Ascending";  // string? | Indicates whether the result should be sorted in descending order (DESC) or ascending order (ASC). (optional)  (default to Descending)
            var resourceName = "resourceName_example";  // string? |  (optional) 

            try
            {
                // Retrieves all resourceClaimActionAuthStrategies.
                List<ResourceClaimActionAuthStrategyModel> result = apiInstance.V2ResourceClaimActionAuthStrategiesGet(offset, limit, orderBy, direction, resourceName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ResourceClaimActionAuthStrategiesApi.V2ResourceClaimActionAuthStrategiesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V2ResourceClaimActionAuthStrategiesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves all resourceClaimActionAuthStrategies.
    ApiResponse<List<ResourceClaimActionAuthStrategyModel>> response = apiInstance.V2ResourceClaimActionAuthStrategiesGetWithHttpInfo(offset, limit, orderBy, direction, resourceName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ResourceClaimActionAuthStrategiesApi.V2ResourceClaimActionAuthStrategiesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **offset** | **int?** | Indicates how many items should be skipped before returning results. | [optional]  |
| **limit** | **int?** | Indicates the maximum number of items that should be returned in the results. | [optional]  |
| **orderBy** | **string?** | Indicates the property name by which the results will be sorted. | [optional] [default to &quot;&quot;] |
| **direction** | **string?** | Indicates whether the result should be sorted in descending order (DESC) or ascending order (ASC). | [optional] [default to Descending] |
| **resourceName** | **string?** |  | [optional]  |

### Return type

[**List&lt;ResourceClaimActionAuthStrategyModel&gt;**](ResourceClaimActionAuthStrategyModel.md)

### Authorization

[oauth](../README.md#oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **401** | Unauthorized. The request requires authentication |  -  |
| **403** | Forbidden. The request is authenticated, but not authorized to access this resource |  -  |
| **409** | Conflict. The request is authenticated, but it has a conflict with an existing element |  -  |
| **500** | Internal server error. An unhandled error occurred on the server. See the response body for details. |  -  |
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

