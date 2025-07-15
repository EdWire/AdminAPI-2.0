# EdFi.Ods.AdminApi.Client.Api.OdsInstanceContextsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**V2OdsInstanceContextsGet**](OdsInstanceContextsApi.md#v2odsinstancecontextsget) | **GET** /v2/odsInstanceContexts | Retrieves all odsInstanceContexts. |
| [**V2OdsInstanceContextsIdDelete**](OdsInstanceContextsApi.md#v2odsinstancecontextsiddelete) | **DELETE** /v2/odsInstanceContexts/{id} | Deletes an existing odsInstanceContext using the resource identifier. |
| [**V2OdsInstanceContextsIdGet**](OdsInstanceContextsApi.md#v2odsinstancecontextsidget) | **GET** /v2/odsInstanceContexts/{id} | Retrieves a specific odsInstanceContext based on the identifier. |
| [**V2OdsInstanceContextsIdPut**](OdsInstanceContextsApi.md#v2odsinstancecontextsidput) | **PUT** /v2/odsInstanceContexts/{id} | Updates odsInstanceContext based on the resource identifier. |
| [**V2OdsInstanceContextsPost**](OdsInstanceContextsApi.md#v2odsinstancecontextspost) | **POST** /v2/odsInstanceContexts | Creates odsInstanceContext based on the supplied values. |

<a id="v2odsinstancecontextsget"></a>
# **V2OdsInstanceContextsGet**
> List&lt;OdsInstanceContextModel&gt; V2OdsInstanceContextsGet (int offset = null, int limit = null, string orderBy = null, string direction = null)

Retrieves all odsInstanceContexts.

This GET operation provides access to resources using the \"Get\" search pattern. The values of any properties of the resource that are specified will be used to return all matching results (if it exists).


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **offset** | **int** | Indicates how many items should be skipped before returning results. | [optional]  |
| **limit** | **int** | Indicates the maximum number of items that should be returned in the results. | [optional]  |
| **orderBy** | **string** | Indicates the property name by which the results will be sorted. | [optional] [default to &quot;&quot;] |
| **direction** | **string** | Indicates whether the result should be sorted in descending order (DESC) or ascending order (ASC). | [optional] [default to Descending] |

### Return type

[**List&lt;OdsInstanceContextModel&gt;**](OdsInstanceContextModel.md)

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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="v2odsinstancecontextsiddelete"></a>
# **V2OdsInstanceContextsIdDelete**
> void V2OdsInstanceContextsIdDelete (int id)

Deletes an existing odsInstanceContext using the resource identifier.

The DELETE operation is used to delete an existing resource by identifier. If the resource doesn't exist, an error will result (the resource will not be found).


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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="v2odsinstancecontextsidget"></a>
# **V2OdsInstanceContextsIdGet**
> OdsInstanceContextModel V2OdsInstanceContextsIdGet (int id)

Retrieves a specific odsInstanceContext based on the identifier.

This GET operation provides access to resources using the \"Get\" search pattern. The values of any properties of the resource that are specified will be used to return all matching results (if it exists).


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |

### Return type

[**OdsInstanceContextModel**](OdsInstanceContextModel.md)

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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="v2odsinstancecontextsidput"></a>
# **V2OdsInstanceContextsIdPut**
> void V2OdsInstanceContextsIdPut (int id, EditOdsInstanceContextRequest editOdsInstanceContextRequest)

Updates odsInstanceContext based on the resource identifier.

The PUT operation is used to update a resource by identifier. If the resource identifier (\"id\") is provided in the JSON body, it will be ignored. Additionally, this API resource is not configured for cascading natural key updates. Natural key values for this resource cannot be changed using PUT operation, so the recommendation is to use POST as that supports upsert behavior.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |
| **editOdsInstanceContextRequest** | [**EditOdsInstanceContextRequest**](EditOdsInstanceContextRequest.md) |  |  |

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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="v2odsinstancecontextspost"></a>
# **V2OdsInstanceContextsPost**
> void V2OdsInstanceContextsPost (AddOdsInstanceContextRequest addOdsInstanceContextRequest)

Creates odsInstanceContext based on the supplied values.

The POST operation can be used to create or update resources. In database terms, this is often referred to as an \"upsert\" operation (insert + update). Clients should NOT include the resource \"id\" in the JSON body because it will result in an error. The web service will identify whether the resource already exists based on the natural key values provided, and update or create the resource appropriately. It is recommended to use POST for both create and update except while updating natural key of a resource in which case PUT operation must be used.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **addOdsInstanceContextRequest** | [**AddOdsInstanceContextRequest**](AddOdsInstanceContextRequest.md) |  |  |

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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

