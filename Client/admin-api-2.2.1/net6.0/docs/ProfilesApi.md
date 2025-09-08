# EdFi.Ods.AdminApi.V2.Client.Api.ProfilesApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**V2ProfilesGet**](ProfilesApi.md#v2profilesget) | **GET** /v2/profiles | Retrieves all profiles. |
| [**V2ProfilesIdDelete**](ProfilesApi.md#v2profilesiddelete) | **DELETE** /v2/profiles/{id} | Deletes an existing profile using the resource identifier. |
| [**V2ProfilesIdGet**](ProfilesApi.md#v2profilesidget) | **GET** /v2/profiles/{id} | Retrieves a specific profile based on the identifier. |
| [**V2ProfilesIdPut**](ProfilesApi.md#v2profilesidput) | **PUT** /v2/profiles/{id} | Updates profile based on the resource identifier. |
| [**V2ProfilesPost**](ProfilesApi.md#v2profilespost) | **POST** /v2/profiles | Creates profile based on the supplied values. |

<a id="v2profilesget"></a>
# **V2ProfilesGet**
> List&lt;ProfileModel&gt; V2ProfilesGet (int? offset = null, int? limit = null, string? orderBy = null, string? direction = null, int? id = null, string? name = null)

Retrieves all profiles.

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
    public class V2ProfilesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProfilesApi(config);
            var offset = 56;  // int? | Indicates how many items should be skipped before returning results. (optional) 
            var limit = 56;  // int? | Indicates the maximum number of items that should be returned in the results. (optional) 
            var orderBy = "\"\"";  // string? | Indicates the property name by which the results will be sorted. (optional)  (default to "")
            var direction = "Ascending";  // string? | Indicates whether the result should be sorted in descending order (DESC) or ascending order (ASC). (optional)  (default to Descending)
            var id = 56;  // int? | Profile id (optional) 
            var name = "name_example";  // string? | Profile name (optional) 

            try
            {
                // Retrieves all profiles.
                List<ProfileModel> result = apiInstance.V2ProfilesGet(offset, limit, orderBy, direction, id, name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProfilesApi.V2ProfilesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V2ProfilesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves all profiles.
    ApiResponse<List<ProfileModel>> response = apiInstance.V2ProfilesGetWithHttpInfo(offset, limit, orderBy, direction, id, name);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProfilesApi.V2ProfilesGetWithHttpInfo: " + e.Message);
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
| **id** | **int?** | Profile id | [optional]  |
| **name** | **string?** | Profile name | [optional]  |

### Return type

[**List&lt;ProfileModel&gt;**](ProfileModel.md)

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

<a id="v2profilesiddelete"></a>
# **V2ProfilesIdDelete**
> void V2ProfilesIdDelete (int id)

Deletes an existing profile using the resource identifier.

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
    public class V2ProfilesIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProfilesApi(config);
            var id = 56;  // int | 

            try
            {
                // Deletes an existing profile using the resource identifier.
                apiInstance.V2ProfilesIdDelete(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProfilesApi.V2ProfilesIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V2ProfilesIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes an existing profile using the resource identifier.
    apiInstance.V2ProfilesIdDeleteWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProfilesApi.V2ProfilesIdDeleteWithHttpInfo: " + e.Message);
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

<a id="v2profilesidget"></a>
# **V2ProfilesIdGet**
> ProfileDetailsModel V2ProfilesIdGet (int id)

Retrieves a specific profile based on the identifier.

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
    public class V2ProfilesIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProfilesApi(config);
            var id = 56;  // int | 

            try
            {
                // Retrieves a specific profile based on the identifier.
                ProfileDetailsModel result = apiInstance.V2ProfilesIdGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProfilesApi.V2ProfilesIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V2ProfilesIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a specific profile based on the identifier.
    ApiResponse<ProfileDetailsModel> response = apiInstance.V2ProfilesIdGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProfilesApi.V2ProfilesIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |

### Return type

[**ProfileDetailsModel**](ProfileDetailsModel.md)

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

<a id="v2profilesidput"></a>
# **V2ProfilesIdPut**
> void V2ProfilesIdPut (int id, EditProfileRequest editProfileRequest)

Updates profile based on the resource identifier.

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
    public class V2ProfilesIdPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProfilesApi(config);
            var id = 56;  // int | 
            var editProfileRequest = new EditProfileRequest(); // EditProfileRequest | 

            try
            {
                // Updates profile based on the resource identifier.
                apiInstance.V2ProfilesIdPut(id, editProfileRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProfilesApi.V2ProfilesIdPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V2ProfilesIdPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates profile based on the resource identifier.
    apiInstance.V2ProfilesIdPutWithHttpInfo(id, editProfileRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProfilesApi.V2ProfilesIdPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |
| **editProfileRequest** | [**EditProfileRequest**](EditProfileRequest.md) |  |  |

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

<a id="v2profilespost"></a>
# **V2ProfilesPost**
> void V2ProfilesPost (AddProfileRequest addProfileRequest)

Creates profile based on the supplied values.

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
    public class V2ProfilesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProfilesApi(config);
            var addProfileRequest = new AddProfileRequest(); // AddProfileRequest | 

            try
            {
                // Creates profile based on the supplied values.
                apiInstance.V2ProfilesPost(addProfileRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProfilesApi.V2ProfilesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V2ProfilesPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates profile based on the supplied values.
    apiInstance.V2ProfilesPostWithHttpInfo(addProfileRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProfilesApi.V2ProfilesPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **addProfileRequest** | [**AddProfileRequest**](AddProfileRequest.md) |  |  |

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

