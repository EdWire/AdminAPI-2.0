# EdFi.Ods.AdminApi.V2.Client.Api.OdsInstancesApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**V2OdsInstancesGet**](OdsInstancesApi.md#v2odsinstancesget) | **GET** /v2/odsInstances | Retrieves all odsInstances. |
| [**V2OdsInstancesIdApplicationsGet**](OdsInstancesApi.md#v2odsinstancesidapplicationsget) | **GET** /v2/odsInstances/{id}/applications | Retrieves applications assigned to a specific ODS instance based on the resource identifier. |
| [**V2OdsInstancesIdDelete**](OdsInstancesApi.md#v2odsinstancesiddelete) | **DELETE** /v2/odsInstances/{id} | Deletes an existing odsInstance using the resource identifier. |
| [**V2OdsInstancesIdGet**](OdsInstancesApi.md#v2odsinstancesidget) | **GET** /v2/odsInstances/{id} | Retrieves a specific odsInstance based on the identifier. |
| [**V2OdsInstancesIdPut**](OdsInstancesApi.md#v2odsinstancesidput) | **PUT** /v2/odsInstances/{id} | Updates odsInstance based on the resource identifier. |
| [**V2OdsInstancesPost**](OdsInstancesApi.md#v2odsinstancespost) | **POST** /v2/odsInstances | Creates odsInstance based on the supplied values. |

<a id="v2odsinstancesget"></a>
# **V2OdsInstancesGet**
> List&lt;OdsInstanceModel&gt; V2OdsInstancesGet (int? offset = null, int? limit = null, string? orderBy = null, string? direction = null, int? id = null, string? name = null, string? instanceType = null)

Retrieves all odsInstances.

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
    public class V2OdsInstancesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OdsInstancesApi(config);
            var offset = 56;  // int? | Indicates how many items should be skipped before returning results. (optional) 
            var limit = 56;  // int? | Indicates the maximum number of items that should be returned in the results. (optional) 
            var orderBy = "\"\"";  // string? | Indicates the property name by which the results will be sorted. (optional)  (default to "")
            var direction = "Ascending";  // string? | Indicates whether the result should be sorted in descending order (DESC) or ascending order (ASC). (optional)  (default to Descending)
            var id = 56;  // int? | List of ODS instance id (optional) 
            var name = "name_example";  // string? | Ods Instance name (optional) 
            var instanceType = "instanceType_example";  // string? |  (optional) 

            try
            {
                // Retrieves all odsInstances.
                List<OdsInstanceModel> result = apiInstance.V2OdsInstancesGet(offset, limit, orderBy, direction, id, name, instanceType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OdsInstancesApi.V2OdsInstancesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V2OdsInstancesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves all odsInstances.
    ApiResponse<List<OdsInstanceModel>> response = apiInstance.V2OdsInstancesGetWithHttpInfo(offset, limit, orderBy, direction, id, name, instanceType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OdsInstancesApi.V2OdsInstancesGetWithHttpInfo: " + e.Message);
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
| **id** | **int?** | List of ODS instance id | [optional]  |
| **name** | **string?** | Ods Instance name | [optional]  |
| **instanceType** | **string?** |  | [optional]  |

### Return type

[**List&lt;OdsInstanceModel&gt;**](OdsInstanceModel.md)

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

<a id="v2odsinstancesidapplicationsget"></a>
# **V2OdsInstancesIdApplicationsGet**
> List&lt;ApplicationModel&gt; V2OdsInstancesIdApplicationsGet (int id)

Retrieves applications assigned to a specific ODS instance based on the resource identifier.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdFi.Ods.AdminApi.V2.Client.Api;
using EdFi.Ods.AdminApi.V2.Client.Client;
using EdFi.Ods.AdminApi.V2.Client.Model;

namespace Example
{
    public class V2OdsInstancesIdApplicationsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OdsInstancesApi(config);
            var id = 56;  // int | 

            try
            {
                // Retrieves applications assigned to a specific ODS instance based on the resource identifier.
                List<ApplicationModel> result = apiInstance.V2OdsInstancesIdApplicationsGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OdsInstancesApi.V2OdsInstancesIdApplicationsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V2OdsInstancesIdApplicationsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves applications assigned to a specific ODS instance based on the resource identifier.
    ApiResponse<List<ApplicationModel>> response = apiInstance.V2OdsInstancesIdApplicationsGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OdsInstancesApi.V2OdsInstancesIdApplicationsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |

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
| **404** | Not found. A resource with given identifier could not be found. |  -  |
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="v2odsinstancesiddelete"></a>
# **V2OdsInstancesIdDelete**
> void V2OdsInstancesIdDelete (int id)

Deletes an existing odsInstance using the resource identifier.

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
    public class V2OdsInstancesIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OdsInstancesApi(config);
            var id = 56;  // int | 

            try
            {
                // Deletes an existing odsInstance using the resource identifier.
                apiInstance.V2OdsInstancesIdDelete(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OdsInstancesApi.V2OdsInstancesIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V2OdsInstancesIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes an existing odsInstance using the resource identifier.
    apiInstance.V2OdsInstancesIdDeleteWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OdsInstancesApi.V2OdsInstancesIdDeleteWithHttpInfo: " + e.Message);
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

<a id="v2odsinstancesidget"></a>
# **V2OdsInstancesIdGet**
> OdsInstanceDetailModel V2OdsInstancesIdGet (int id)

Retrieves a specific odsInstance based on the identifier.

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
    public class V2OdsInstancesIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OdsInstancesApi(config);
            var id = 56;  // int | 

            try
            {
                // Retrieves a specific odsInstance based on the identifier.
                OdsInstanceDetailModel result = apiInstance.V2OdsInstancesIdGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OdsInstancesApi.V2OdsInstancesIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V2OdsInstancesIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a specific odsInstance based on the identifier.
    ApiResponse<OdsInstanceDetailModel> response = apiInstance.V2OdsInstancesIdGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OdsInstancesApi.V2OdsInstancesIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |

### Return type

[**OdsInstanceDetailModel**](OdsInstanceDetailModel.md)

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

<a id="v2odsinstancesidput"></a>
# **V2OdsInstancesIdPut**
> void V2OdsInstancesIdPut (int id, EditOdsInstanceRequest editOdsInstanceRequest)

Updates odsInstance based on the resource identifier.

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
    public class V2OdsInstancesIdPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OdsInstancesApi(config);
            var id = 56;  // int | 
            var editOdsInstanceRequest = new EditOdsInstanceRequest(); // EditOdsInstanceRequest | 

            try
            {
                // Updates odsInstance based on the resource identifier.
                apiInstance.V2OdsInstancesIdPut(id, editOdsInstanceRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OdsInstancesApi.V2OdsInstancesIdPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V2OdsInstancesIdPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates odsInstance based on the resource identifier.
    apiInstance.V2OdsInstancesIdPutWithHttpInfo(id, editOdsInstanceRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OdsInstancesApi.V2OdsInstancesIdPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |
| **editOdsInstanceRequest** | [**EditOdsInstanceRequest**](EditOdsInstanceRequest.md) |  |  |

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

<a id="v2odsinstancespost"></a>
# **V2OdsInstancesPost**
> void V2OdsInstancesPost (AddOdsInstanceRequest addOdsInstanceRequest)

Creates odsInstance based on the supplied values.

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
    public class V2OdsInstancesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OdsInstancesApi(config);
            var addOdsInstanceRequest = new AddOdsInstanceRequest(); // AddOdsInstanceRequest | 

            try
            {
                // Creates odsInstance based on the supplied values.
                apiInstance.V2OdsInstancesPost(addOdsInstanceRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OdsInstancesApi.V2OdsInstancesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V2OdsInstancesPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates odsInstance based on the supplied values.
    apiInstance.V2OdsInstancesPostWithHttpInfo(addOdsInstanceRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OdsInstancesApi.V2OdsInstancesPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **addOdsInstanceRequest** | [**AddOdsInstanceRequest**](AddOdsInstanceRequest.md) |  |  |

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
| **400** | Bad Request. The request was invalid and cannot be completed. See the response body for details. |  -  |
| **201** | Created |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

