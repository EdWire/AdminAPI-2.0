# EdFi.Ods.AdminApi.V2.Client.Api.ClaimSetsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**V2ClaimSetsClaimSetIdResourceClaimActionsPost**](ClaimSetsApi.md#v2claimsetsclaimsetidresourceclaimactionspost) | **POST** /v2/claimSets/{claimSetId}/resourceClaimActions | Adds ResourceClaimAction association to a claim set. |
| [**V2ClaimSetsClaimSetIdResourceClaimActionsResourceClaimIdDelete**](ClaimSetsApi.md#v2claimsetsclaimsetidresourceclaimactionsresourceclaimiddelete) | **DELETE** /v2/claimSets/{claimSetId}/resourceClaimActions/{resourceClaimId} | Deletes a resource claims association from a claimset |
| [**V2ClaimSetsClaimSetIdResourceClaimActionsResourceClaimIdOverrideAuthorizationStrategyPost**](ClaimSetsApi.md#v2claimsetsclaimsetidresourceclaimactionsresourceclaimidoverrideauthorizationstrategypost) | **POST** /v2/claimSets/{claimSetId}/resourceClaimActions/{resourceClaimId}/overrideAuthorizationStrategy | Overrides the default authorization strategies on provided resource claim for a specific action. |
| [**V2ClaimSetsClaimSetIdResourceClaimActionsResourceClaimIdPut**](ClaimSetsApi.md#v2claimsetsclaimsetidresourceclaimactionsresourceclaimidput) | **PUT** /v2/claimSets/{claimSetId}/resourceClaimActions/{resourceClaimId} | Updates the ResourceClaimActions to a specific resource claim on a claimset. |
| [**V2ClaimSetsClaimSetIdResourceClaimActionsResourceClaimIdResetAuthorizationStrategiesPost**](ClaimSetsApi.md#v2claimsetsclaimsetidresourceclaimactionsresourceclaimidresetauthorizationstrategiespost) | **POST** /v2/claimSets/{claimSetId}/resourceClaimActions/{resourceClaimId}/resetAuthorizationStrategies | Resets to default authorization strategies on provided resource claim. |
| [**V2ClaimSetsCopyPost**](ClaimSetsApi.md#v2claimsetscopypost) | **POST** /v2/claimSets/copy | Copies the existing claimset and create a new one. |
| [**V2ClaimSetsGet**](ClaimSetsApi.md#v2claimsetsget) | **GET** /v2/claimSets | Retrieves all claimSets. |
| [**V2ClaimSetsIdDelete**](ClaimSetsApi.md#v2claimsetsiddelete) | **DELETE** /v2/claimSets/{id} | Deletes an existing claimSet using the resource identifier. |
| [**V2ClaimSetsIdExportGet**](ClaimSetsApi.md#v2claimsetsidexportget) | **GET** /v2/claimSets/{id}/export | Exports a specific claimset by id |
| [**V2ClaimSetsIdGet**](ClaimSetsApi.md#v2claimsetsidget) | **GET** /v2/claimSets/{id} | Retrieves a specific claimSet based on the identifier. |
| [**V2ClaimSetsIdPut**](ClaimSetsApi.md#v2claimsetsidput) | **PUT** /v2/claimSets/{id} | Updates claimSet based on the resource identifier. |
| [**V2ClaimSetsImportPost**](ClaimSetsApi.md#v2claimsetsimportpost) | **POST** /v2/claimSets/import | Imports a new claimset |
| [**V2ClaimSetsPost**](ClaimSetsApi.md#v2claimsetspost) | **POST** /v2/claimSets | Creates claimSet based on the supplied values. |

<a id="v2claimsetsclaimsetidresourceclaimactionspost"></a>
# **V2ClaimSetsClaimSetIdResourceClaimActionsPost**
> void V2ClaimSetsClaimSetIdResourceClaimActionsPost (int claimSetId, AddResourceClaimOnClaimSetRequest addResourceClaimOnClaimSetRequest)

Adds ResourceClaimAction association to a claim set.

Add resourceClaimAction association to claim set. At least one action should be enabled. Valid actions are read, create, update, delete, readchanges.  resouceclaimId is required fields.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdFi.Ods.AdminApi.V2.Client.Api;
using EdFi.Ods.AdminApi.V2.Client.Client;
using EdFi.Ods.AdminApi.V2.Client.Model;

namespace Example
{
    public class V2ClaimSetsClaimSetIdResourceClaimActionsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ClaimSetsApi(config);
            var claimSetId = 56;  // int | 
            var addResourceClaimOnClaimSetRequest = new AddResourceClaimOnClaimSetRequest(); // AddResourceClaimOnClaimSetRequest | 

            try
            {
                // Adds ResourceClaimAction association to a claim set.
                apiInstance.V2ClaimSetsClaimSetIdResourceClaimActionsPost(claimSetId, addResourceClaimOnClaimSetRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClaimSetsApi.V2ClaimSetsClaimSetIdResourceClaimActionsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V2ClaimSetsClaimSetIdResourceClaimActionsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Adds ResourceClaimAction association to a claim set.
    apiInstance.V2ClaimSetsClaimSetIdResourceClaimActionsPostWithHttpInfo(claimSetId, addResourceClaimOnClaimSetRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClaimSetsApi.V2ClaimSetsClaimSetIdResourceClaimActionsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **claimSetId** | **int** |  |  |
| **addResourceClaimOnClaimSetRequest** | [**AddResourceClaimOnClaimSetRequest**](AddResourceClaimOnClaimSetRequest.md) |  |  |

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
| **201** | Created |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="v2claimsetsclaimsetidresourceclaimactionsresourceclaimiddelete"></a>
# **V2ClaimSetsClaimSetIdResourceClaimActionsResourceClaimIdDelete**
> void V2ClaimSetsClaimSetIdResourceClaimActionsResourceClaimIdDelete (int claimSetId, int resourceClaimId)

Deletes a resource claims association from a claimset

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdFi.Ods.AdminApi.V2.Client.Api;
using EdFi.Ods.AdminApi.V2.Client.Client;
using EdFi.Ods.AdminApi.V2.Client.Model;

namespace Example
{
    public class V2ClaimSetsClaimSetIdResourceClaimActionsResourceClaimIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ClaimSetsApi(config);
            var claimSetId = 56;  // int | 
            var resourceClaimId = 56;  // int | 

            try
            {
                // Deletes a resource claims association from a claimset
                apiInstance.V2ClaimSetsClaimSetIdResourceClaimActionsResourceClaimIdDelete(claimSetId, resourceClaimId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClaimSetsApi.V2ClaimSetsClaimSetIdResourceClaimActionsResourceClaimIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V2ClaimSetsClaimSetIdResourceClaimActionsResourceClaimIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes a resource claims association from a claimset
    apiInstance.V2ClaimSetsClaimSetIdResourceClaimActionsResourceClaimIdDeleteWithHttpInfo(claimSetId, resourceClaimId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClaimSetsApi.V2ClaimSetsClaimSetIdResourceClaimActionsResourceClaimIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **claimSetId** | **int** |  |  |
| **resourceClaimId** | **int** |  |  |

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
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="v2claimsetsclaimsetidresourceclaimactionsresourceclaimidoverrideauthorizationstrategypost"></a>
# **V2ClaimSetsClaimSetIdResourceClaimActionsResourceClaimIdOverrideAuthorizationStrategyPost**
> void V2ClaimSetsClaimSetIdResourceClaimActionsResourceClaimIdOverrideAuthorizationStrategyPost (int claimSetId, int resourceClaimId, OverrideAuthStategyOnClaimSetRequest overrideAuthStategyOnClaimSetRequest)

Overrides the default authorization strategies on provided resource claim for a specific action.

Override the default authorization strategies on provided resource claim for a specific action.    ex: actionName = read,  authorizationStrategies= [ \"Ownershipbased\" ]

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdFi.Ods.AdminApi.V2.Client.Api;
using EdFi.Ods.AdminApi.V2.Client.Client;
using EdFi.Ods.AdminApi.V2.Client.Model;

namespace Example
{
    public class V2ClaimSetsClaimSetIdResourceClaimActionsResourceClaimIdOverrideAuthorizationStrategyPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ClaimSetsApi(config);
            var claimSetId = 56;  // int | 
            var resourceClaimId = 56;  // int | 
            var overrideAuthStategyOnClaimSetRequest = new OverrideAuthStategyOnClaimSetRequest(); // OverrideAuthStategyOnClaimSetRequest | 

            try
            {
                // Overrides the default authorization strategies on provided resource claim for a specific action.
                apiInstance.V2ClaimSetsClaimSetIdResourceClaimActionsResourceClaimIdOverrideAuthorizationStrategyPost(claimSetId, resourceClaimId, overrideAuthStategyOnClaimSetRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClaimSetsApi.V2ClaimSetsClaimSetIdResourceClaimActionsResourceClaimIdOverrideAuthorizationStrategyPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V2ClaimSetsClaimSetIdResourceClaimActionsResourceClaimIdOverrideAuthorizationStrategyPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Overrides the default authorization strategies on provided resource claim for a specific action.
    apiInstance.V2ClaimSetsClaimSetIdResourceClaimActionsResourceClaimIdOverrideAuthorizationStrategyPostWithHttpInfo(claimSetId, resourceClaimId, overrideAuthStategyOnClaimSetRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClaimSetsApi.V2ClaimSetsClaimSetIdResourceClaimActionsResourceClaimIdOverrideAuthorizationStrategyPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **claimSetId** | **int** |  |  |
| **resourceClaimId** | **int** |  |  |
| **overrideAuthStategyOnClaimSetRequest** | [**OverrideAuthStategyOnClaimSetRequest**](OverrideAuthStategyOnClaimSetRequest.md) |  |  |

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

<a id="v2claimsetsclaimsetidresourceclaimactionsresourceclaimidput"></a>
# **V2ClaimSetsClaimSetIdResourceClaimActionsResourceClaimIdPut**
> void V2ClaimSetsClaimSetIdResourceClaimActionsResourceClaimIdPut (int claimSetId, int resourceClaimId, EditResourceClaimOnClaimSetRequest editResourceClaimOnClaimSetRequest)

Updates the ResourceClaimActions to a specific resource claim on a claimset.

Updates  the resourceClaimActions to a  specific resource claim on a claimset. At least one action should be enabled. Valid actions are read, create, update, delete, readchanges.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdFi.Ods.AdminApi.V2.Client.Api;
using EdFi.Ods.AdminApi.V2.Client.Client;
using EdFi.Ods.AdminApi.V2.Client.Model;

namespace Example
{
    public class V2ClaimSetsClaimSetIdResourceClaimActionsResourceClaimIdPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ClaimSetsApi(config);
            var claimSetId = 56;  // int | 
            var resourceClaimId = 56;  // int | 
            var editResourceClaimOnClaimSetRequest = new EditResourceClaimOnClaimSetRequest(); // EditResourceClaimOnClaimSetRequest | 

            try
            {
                // Updates the ResourceClaimActions to a specific resource claim on a claimset.
                apiInstance.V2ClaimSetsClaimSetIdResourceClaimActionsResourceClaimIdPut(claimSetId, resourceClaimId, editResourceClaimOnClaimSetRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClaimSetsApi.V2ClaimSetsClaimSetIdResourceClaimActionsResourceClaimIdPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V2ClaimSetsClaimSetIdResourceClaimActionsResourceClaimIdPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates the ResourceClaimActions to a specific resource claim on a claimset.
    apiInstance.V2ClaimSetsClaimSetIdResourceClaimActionsResourceClaimIdPutWithHttpInfo(claimSetId, resourceClaimId, editResourceClaimOnClaimSetRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClaimSetsApi.V2ClaimSetsClaimSetIdResourceClaimActionsResourceClaimIdPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **claimSetId** | **int** |  |  |
| **resourceClaimId** | **int** |  |  |
| **editResourceClaimOnClaimSetRequest** | [**EditResourceClaimOnClaimSetRequest**](EditResourceClaimOnClaimSetRequest.md) |  |  |

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

<a id="v2claimsetsclaimsetidresourceclaimactionsresourceclaimidresetauthorizationstrategiespost"></a>
# **V2ClaimSetsClaimSetIdResourceClaimActionsResourceClaimIdResetAuthorizationStrategiesPost**
> void V2ClaimSetsClaimSetIdResourceClaimActionsResourceClaimIdResetAuthorizationStrategiesPost (int claimSetId, int resourceClaimId)

Resets to default authorization strategies on provided resource claim.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdFi.Ods.AdminApi.V2.Client.Api;
using EdFi.Ods.AdminApi.V2.Client.Client;
using EdFi.Ods.AdminApi.V2.Client.Model;

namespace Example
{
    public class V2ClaimSetsClaimSetIdResourceClaimActionsResourceClaimIdResetAuthorizationStrategiesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ClaimSetsApi(config);
            var claimSetId = 56;  // int | 
            var resourceClaimId = 56;  // int | 

            try
            {
                // Resets to default authorization strategies on provided resource claim.
                apiInstance.V2ClaimSetsClaimSetIdResourceClaimActionsResourceClaimIdResetAuthorizationStrategiesPost(claimSetId, resourceClaimId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClaimSetsApi.V2ClaimSetsClaimSetIdResourceClaimActionsResourceClaimIdResetAuthorizationStrategiesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V2ClaimSetsClaimSetIdResourceClaimActionsResourceClaimIdResetAuthorizationStrategiesPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Resets to default authorization strategies on provided resource claim.
    apiInstance.V2ClaimSetsClaimSetIdResourceClaimActionsResourceClaimIdResetAuthorizationStrategiesPostWithHttpInfo(claimSetId, resourceClaimId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClaimSetsApi.V2ClaimSetsClaimSetIdResourceClaimActionsResourceClaimIdResetAuthorizationStrategiesPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **claimSetId** | **int** |  |  |
| **resourceClaimId** | **int** |  |  |

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
| **400** | Bad Request. The request was invalid and cannot be completed. See the response body for details. |  -  |
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="v2claimsetscopypost"></a>
# **V2ClaimSetsCopyPost**
> void V2ClaimSetsCopyPost (CopyClaimSetRequest copyClaimSetRequest)

Copies the existing claimset and create a new one.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdFi.Ods.AdminApi.V2.Client.Api;
using EdFi.Ods.AdminApi.V2.Client.Client;
using EdFi.Ods.AdminApi.V2.Client.Model;

namespace Example
{
    public class V2ClaimSetsCopyPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ClaimSetsApi(config);
            var copyClaimSetRequest = new CopyClaimSetRequest(); // CopyClaimSetRequest | 

            try
            {
                // Copies the existing claimset and create a new one.
                apiInstance.V2ClaimSetsCopyPost(copyClaimSetRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClaimSetsApi.V2ClaimSetsCopyPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V2ClaimSetsCopyPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Copies the existing claimset and create a new one.
    apiInstance.V2ClaimSetsCopyPostWithHttpInfo(copyClaimSetRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClaimSetsApi.V2ClaimSetsCopyPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **copyClaimSetRequest** | [**CopyClaimSetRequest**](CopyClaimSetRequest.md) |  |  |

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

<a id="v2claimsetsget"></a>
# **V2ClaimSetsGet**
> List&lt;ClaimSetModel&gt; V2ClaimSetsGet (int? offset = null, int? limit = null, string? orderBy = null, string? direction = null, int? id = null, string? name = null)

Retrieves all claimSets.

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
    public class V2ClaimSetsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ClaimSetsApi(config);
            var offset = 56;  // int? | Indicates how many items should be skipped before returning results. (optional) 
            var limit = 56;  // int? | Indicates the maximum number of items that should be returned in the results. (optional) 
            var orderBy = "\"\"";  // string? | Indicates the property name by which the results will be sorted. (optional)  (default to "")
            var direction = "Ascending";  // string? | Indicates whether the result should be sorted in descending order (DESC) or ascending order (ASC). (optional)  (default to Descending)
            var id = 56;  // int? | Claim set id (optional) 
            var name = "name_example";  // string? | Claim set name (optional) 

            try
            {
                // Retrieves all claimSets.
                List<ClaimSetModel> result = apiInstance.V2ClaimSetsGet(offset, limit, orderBy, direction, id, name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClaimSetsApi.V2ClaimSetsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V2ClaimSetsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves all claimSets.
    ApiResponse<List<ClaimSetModel>> response = apiInstance.V2ClaimSetsGetWithHttpInfo(offset, limit, orderBy, direction, id, name);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClaimSetsApi.V2ClaimSetsGetWithHttpInfo: " + e.Message);
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
| **id** | **int?** | Claim set id | [optional]  |
| **name** | **string?** | Claim set name | [optional]  |

### Return type

[**List&lt;ClaimSetModel&gt;**](ClaimSetModel.md)

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

<a id="v2claimsetsiddelete"></a>
# **V2ClaimSetsIdDelete**
> void V2ClaimSetsIdDelete (int id)

Deletes an existing claimSet using the resource identifier.

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
    public class V2ClaimSetsIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ClaimSetsApi(config);
            var id = 56;  // int | 

            try
            {
                // Deletes an existing claimSet using the resource identifier.
                apiInstance.V2ClaimSetsIdDelete(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClaimSetsApi.V2ClaimSetsIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V2ClaimSetsIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes an existing claimSet using the resource identifier.
    apiInstance.V2ClaimSetsIdDeleteWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClaimSetsApi.V2ClaimSetsIdDeleteWithHttpInfo: " + e.Message);
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

<a id="v2claimsetsidexportget"></a>
# **V2ClaimSetsIdExportGet**
> ClaimSetDetailsModel V2ClaimSetsIdExportGet (int id)

Exports a specific claimset by id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdFi.Ods.AdminApi.V2.Client.Api;
using EdFi.Ods.AdminApi.V2.Client.Client;
using EdFi.Ods.AdminApi.V2.Client.Model;

namespace Example
{
    public class V2ClaimSetsIdExportGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ClaimSetsApi(config);
            var id = 56;  // int | 

            try
            {
                // Exports a specific claimset by id
                ClaimSetDetailsModel result = apiInstance.V2ClaimSetsIdExportGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClaimSetsApi.V2ClaimSetsIdExportGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V2ClaimSetsIdExportGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Exports a specific claimset by id
    ApiResponse<ClaimSetDetailsModel> response = apiInstance.V2ClaimSetsIdExportGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClaimSetsApi.V2ClaimSetsIdExportGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |

### Return type

[**ClaimSetDetailsModel**](ClaimSetDetailsModel.md)

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

<a id="v2claimsetsidget"></a>
# **V2ClaimSetsIdGet**
> ClaimSetDetailsModel V2ClaimSetsIdGet (int id)

Retrieves a specific claimSet based on the identifier.

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
    public class V2ClaimSetsIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ClaimSetsApi(config);
            var id = 56;  // int | 

            try
            {
                // Retrieves a specific claimSet based on the identifier.
                ClaimSetDetailsModel result = apiInstance.V2ClaimSetsIdGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClaimSetsApi.V2ClaimSetsIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V2ClaimSetsIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a specific claimSet based on the identifier.
    ApiResponse<ClaimSetDetailsModel> response = apiInstance.V2ClaimSetsIdGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClaimSetsApi.V2ClaimSetsIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |

### Return type

[**ClaimSetDetailsModel**](ClaimSetDetailsModel.md)

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

<a id="v2claimsetsidput"></a>
# **V2ClaimSetsIdPut**
> void V2ClaimSetsIdPut (int id, EditClaimSetRequest editClaimSetRequest)

Updates claimSet based on the resource identifier.

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
    public class V2ClaimSetsIdPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ClaimSetsApi(config);
            var id = 56;  // int | 
            var editClaimSetRequest = new EditClaimSetRequest(); // EditClaimSetRequest | 

            try
            {
                // Updates claimSet based on the resource identifier.
                apiInstance.V2ClaimSetsIdPut(id, editClaimSetRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClaimSetsApi.V2ClaimSetsIdPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V2ClaimSetsIdPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates claimSet based on the resource identifier.
    apiInstance.V2ClaimSetsIdPutWithHttpInfo(id, editClaimSetRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClaimSetsApi.V2ClaimSetsIdPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |
| **editClaimSetRequest** | [**EditClaimSetRequest**](EditClaimSetRequest.md) |  |  |

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

<a id="v2claimsetsimportpost"></a>
# **V2ClaimSetsImportPost**
> void V2ClaimSetsImportPost (ImportClaimSetRequest importClaimSetRequest)

Imports a new claimset

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdFi.Ods.AdminApi.V2.Client.Api;
using EdFi.Ods.AdminApi.V2.Client.Client;
using EdFi.Ods.AdminApi.V2.Client.Model;

namespace Example
{
    public class V2ClaimSetsImportPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ClaimSetsApi(config);
            var importClaimSetRequest = new ImportClaimSetRequest(); // ImportClaimSetRequest | 

            try
            {
                // Imports a new claimset
                apiInstance.V2ClaimSetsImportPost(importClaimSetRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClaimSetsApi.V2ClaimSetsImportPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V2ClaimSetsImportPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Imports a new claimset
    apiInstance.V2ClaimSetsImportPostWithHttpInfo(importClaimSetRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClaimSetsApi.V2ClaimSetsImportPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **importClaimSetRequest** | [**ImportClaimSetRequest**](ImportClaimSetRequest.md) |  |  |

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

<a id="v2claimsetspost"></a>
# **V2ClaimSetsPost**
> void V2ClaimSetsPost (AddClaimSetRequest addClaimSetRequest)

Creates claimSet based on the supplied values.

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
    public class V2ClaimSetsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ClaimSetsApi(config);
            var addClaimSetRequest = new AddClaimSetRequest(); // AddClaimSetRequest | 

            try
            {
                // Creates claimSet based on the supplied values.
                apiInstance.V2ClaimSetsPost(addClaimSetRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClaimSetsApi.V2ClaimSetsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V2ClaimSetsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates claimSet based on the supplied values.
    apiInstance.V2ClaimSetsPostWithHttpInfo(addClaimSetRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClaimSetsApi.V2ClaimSetsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **addClaimSetRequest** | [**AddClaimSetRequest**](AddClaimSetRequest.md) |  |  |

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

