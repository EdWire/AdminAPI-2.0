# EdFi.Ods.AdminApi.V2.Client.Api.ApplicationsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**V2ApplicationsGet**](ApplicationsApi.md#v2applicationsget) | **GET** /v2/applications | Retrieves all applications. |
| [**V2ApplicationsIdDelete**](ApplicationsApi.md#v2applicationsiddelete) | **DELETE** /v2/applications/{id} | Deletes an existing application using the resource identifier. |
| [**V2ApplicationsIdGet**](ApplicationsApi.md#v2applicationsidget) | **GET** /v2/applications/{id} | Retrieves a specific application based on the identifier. |
| [**V2ApplicationsIdPut**](ApplicationsApi.md#v2applicationsidput) | **PUT** /v2/applications/{id} | Updates application based on the resource identifier. |
| [**V2ApplicationsIdResetCredentialPut**](ApplicationsApi.md#v2applicationsidresetcredentialput) | **PUT** /v2/applications/{id}/reset-credential | Reset application credentials. Returns new key and secret. |
| [**V2ApplicationsPost**](ApplicationsApi.md#v2applicationspost) | **POST** /v2/applications | Creates application based on the supplied values. |

<a id="v2applicationsget"></a>
# **V2ApplicationsGet**
> List&lt;ApplicationModel&gt; V2ApplicationsGet (int? offset = null, int? limit = null, string? orderBy = null, string? direction = null, int? id = null, string? applicationName = null, string? claimsetName = null, string? ids = null)

Retrieves all applications.

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
    public class V2ApplicationsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ApplicationsApi(config);
            var offset = 56;  // int? | Indicates how many items should be skipped before returning results. (optional) 
            var limit = 56;  // int? | Indicates the maximum number of items that should be returned in the results. (optional) 
            var orderBy = "\"\"";  // string? | Indicates the property name by which the results will be sorted. (optional)  (default to "")
            var direction = "Ascending";  // string? | Indicates whether the result should be sorted in descending order (DESC) or ascending order (ASC). (optional)  (default to Descending)
            var id = 56;  // int? | Application id (optional) 
            var applicationName = "applicationName_example";  // string? | Application name (optional) 
            var claimsetName = "claimsetName_example";  // string? | Claim set name (optional) 
            var ids = "ids_example";  // string? |  (optional) 

            try
            {
                // Retrieves all applications.
                List<ApplicationModel> result = apiInstance.V2ApplicationsGet(offset, limit, orderBy, direction, id, applicationName, claimsetName, ids);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ApplicationsApi.V2ApplicationsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V2ApplicationsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves all applications.
    ApiResponse<List<ApplicationModel>> response = apiInstance.V2ApplicationsGetWithHttpInfo(offset, limit, orderBy, direction, id, applicationName, claimsetName, ids);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ApplicationsApi.V2ApplicationsGetWithHttpInfo: " + e.Message);
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
| **id** | **int?** | Application id | [optional]  |
| **applicationName** | **string?** | Application name | [optional]  |
| **claimsetName** | **string?** | Claim set name | [optional]  |
| **ids** | **string?** |  | [optional]  |

### Return type

[**List&lt;ApplicationModel&gt;**](ApplicationModel.md)

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

<a id="v2applicationsiddelete"></a>
# **V2ApplicationsIdDelete**
> void V2ApplicationsIdDelete (int id)

Deletes an existing application using the resource identifier.

The DELETE operation is used to delete an existing resource by identifier. If the resource doesn't exist, an error will result (the resource will not be found).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdFi.Ods.AdminApi.V2.Client.Api;
using EdFi.Ods.AdminApi.V2.Client.Client;
using EdFi.Ods.AdminApi.V2.Client.Model;

namespace Example
{
    public class V2ApplicationsIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ApplicationsApi(config);
            var id = 56;  // int | 

            try
            {
                // Deletes an existing application using the resource identifier.
                apiInstance.V2ApplicationsIdDelete(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ApplicationsApi.V2ApplicationsIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V2ApplicationsIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes an existing application using the resource identifier.
    apiInstance.V2ApplicationsIdDeleteWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ApplicationsApi.V2ApplicationsIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |

### Return type

void (empty response body)

### Authorization

[oauth](../README.md#oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **401** | Unauthorized. The request requires authentication |  -  |
| **403** | Forbidden. The request is authenticated, but not authorized to access this resource |  -  |
| **409** | Conflict. The request is authenticated, but it has a conflict with an existing element |  -  |
| **500** | Internal server error. An unhandled error occurred on the server. See the response body for details. |  -  |
| **404** | Not found. A resource with given identifier could not be found. |  -  |
| **200** | Resource was successfully deleted. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="v2applicationsidget"></a>
# **V2ApplicationsIdGet**
> ApplicationModel V2ApplicationsIdGet (int id)

Retrieves a specific application based on the identifier.

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
    public class V2ApplicationsIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ApplicationsApi(config);
            var id = 56;  // int | 

            try
            {
                // Retrieves a specific application based on the identifier.
                ApplicationModel result = apiInstance.V2ApplicationsIdGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ApplicationsApi.V2ApplicationsIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V2ApplicationsIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a specific application based on the identifier.
    ApiResponse<ApplicationModel> response = apiInstance.V2ApplicationsIdGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ApplicationsApi.V2ApplicationsIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |

### Return type

[**ApplicationModel**](ApplicationModel.md)

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
| **404** | Not found. A resource with given identifier could not be found. |  -  |
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="v2applicationsidput"></a>
# **V2ApplicationsIdPut**
> void V2ApplicationsIdPut (int id, EditApplicationRequest editApplicationRequest)

Updates application based on the resource identifier.

The PUT operation is used to update a resource by identifier. If the resource identifier (\"id\") is provided in the JSON body, it will be ignored. Additionally, this API resource is not configured for cascading natural key updates. Natural key values for this resource cannot be changed using PUT operation, so the recommendation is to use POST as that supports upsert behavior.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdFi.Ods.AdminApi.V2.Client.Api;
using EdFi.Ods.AdminApi.V2.Client.Client;
using EdFi.Ods.AdminApi.V2.Client.Model;

namespace Example
{
    public class V2ApplicationsIdPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ApplicationsApi(config);
            var id = 56;  // int | 
            var editApplicationRequest = new EditApplicationRequest(); // EditApplicationRequest | 

            try
            {
                // Updates application based on the resource identifier.
                apiInstance.V2ApplicationsIdPut(id, editApplicationRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ApplicationsApi.V2ApplicationsIdPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V2ApplicationsIdPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates application based on the resource identifier.
    apiInstance.V2ApplicationsIdPutWithHttpInfo(id, editApplicationRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ApplicationsApi.V2ApplicationsIdPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |
| **editApplicationRequest** | [**EditApplicationRequest**](EditApplicationRequest.md) |  |  |

### Return type

void (empty response body)

### Authorization

[oauth](../README.md#oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **401** | Unauthorized. The request requires authentication |  -  |
| **403** | Forbidden. The request is authenticated, but not authorized to access this resource |  -  |
| **409** | Conflict. The request is authenticated, but it has a conflict with an existing element |  -  |
| **500** | Internal server error. An unhandled error occurred on the server. See the response body for details. |  -  |
| **404** | Not found. A resource with given identifier could not be found. |  -  |
| **400** | Bad Request. The request was invalid and cannot be completed. See the response body for details. |  -  |
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="v2applicationsidresetcredentialput"></a>
# **V2ApplicationsIdResetCredentialPut**
> ApplicationResult V2ApplicationsIdResetCredentialPut (int id)

Reset application credentials. Returns new key and secret.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdFi.Ods.AdminApi.V2.Client.Api;
using EdFi.Ods.AdminApi.V2.Client.Client;
using EdFi.Ods.AdminApi.V2.Client.Model;

namespace Example
{
    public class V2ApplicationsIdResetCredentialPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ApplicationsApi(config);
            var id = 56;  // int | 

            try
            {
                // Reset application credentials. Returns new key and secret.
                ApplicationResult result = apiInstance.V2ApplicationsIdResetCredentialPut(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ApplicationsApi.V2ApplicationsIdResetCredentialPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V2ApplicationsIdResetCredentialPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reset application credentials. Returns new key and secret.
    ApiResponse<ApplicationResult> response = apiInstance.V2ApplicationsIdResetCredentialPutWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ApplicationsApi.V2ApplicationsIdResetCredentialPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |

### Return type

[**ApplicationResult**](ApplicationResult.md)

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
| **404** | Not found. A resource with given identifier could not be found. |  -  |
| **400** | Bad Request. The request was invalid and cannot be completed. See the response body for details. |  -  |
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="v2applicationspost"></a>
# **V2ApplicationsPost**
> ApplicationResult V2ApplicationsPost (AddApplicationRequest addApplicationRequest)

Creates application based on the supplied values.

The POST operation can be used to create or update resources. In database terms, this is often referred to as an \"upsert\" operation (insert + update). Clients should NOT include the resource \"id\" in the JSON body because it will result in an error. The web service will identify whether the resource already exists based on the natural key values provided, and update or create the resource appropriately. It is recommended to use POST for both create and update except while updating natural key of a resource in which case PUT operation must be used.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdFi.Ods.AdminApi.V2.Client.Api;
using EdFi.Ods.AdminApi.V2.Client.Client;
using EdFi.Ods.AdminApi.V2.Client.Model;

namespace Example
{
    public class V2ApplicationsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ApplicationsApi(config);
            var addApplicationRequest = new AddApplicationRequest(); // AddApplicationRequest | 

            try
            {
                // Creates application based on the supplied values.
                ApplicationResult result = apiInstance.V2ApplicationsPost(addApplicationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ApplicationsApi.V2ApplicationsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V2ApplicationsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates application based on the supplied values.
    ApiResponse<ApplicationResult> response = apiInstance.V2ApplicationsPostWithHttpInfo(addApplicationRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ApplicationsApi.V2ApplicationsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **addApplicationRequest** | [**AddApplicationRequest**](AddApplicationRequest.md) |  |  |

### Return type

[**ApplicationResult**](ApplicationResult.md)

### Authorization

[oauth](../README.md#oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **401** | Unauthorized. The request requires authentication |  -  |
| **403** | Forbidden. The request is authenticated, but not authorized to access this resource |  -  |
| **409** | Conflict. The request is authenticated, but it has a conflict with an existing element |  -  |
| **500** | Internal server error. An unhandled error occurred on the server. See the response body for details. |  -  |
| **400** | Bad Request. The request was invalid and cannot be completed. See the response body for details. |  -  |
| **201** | Created |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

