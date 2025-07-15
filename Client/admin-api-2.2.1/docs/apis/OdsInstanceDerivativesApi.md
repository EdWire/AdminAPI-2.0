# EdFi.Ods.AdminApi.Client.Api.OdsInstanceDerivativesApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**V2OdsInstanceDerivativesGet**](OdsInstanceDerivativesApi.md#v2odsinstancederivativesget) | **GET** /v2/odsInstanceDerivatives | Retrieves all odsInstanceDerivatives. |
| [**V2OdsInstanceDerivativesIdDelete**](OdsInstanceDerivativesApi.md#v2odsinstancederivativesiddelete) | **DELETE** /v2/odsInstanceDerivatives/{id} | Deletes an existing odsInstanceDerivative using the resource identifier. |
| [**V2OdsInstanceDerivativesIdGet**](OdsInstanceDerivativesApi.md#v2odsinstancederivativesidget) | **GET** /v2/odsInstanceDerivatives/{id} | Retrieves a specific odsInstanceDerivative based on the identifier. |
| [**V2OdsInstanceDerivativesIdPut**](OdsInstanceDerivativesApi.md#v2odsinstancederivativesidput) | **PUT** /v2/odsInstanceDerivatives/{id} | Updates odsInstanceDerivative based on the resource identifier. |
| [**V2OdsInstanceDerivativesPost**](OdsInstanceDerivativesApi.md#v2odsinstancederivativespost) | **POST** /v2/odsInstanceDerivatives | Creates odsInstanceDerivative based on the supplied values. |

<a id="v2odsinstancederivativesget"></a>
# **V2OdsInstanceDerivativesGet**
> List&lt;OdsInstanceDerivativeModel&gt; V2OdsInstanceDerivativesGet (int offset = null, int limit = null, string orderBy = null, string direction = null)

Retrieves all odsInstanceDerivatives.

This GET operation provides access to resources using the \"Get\" search pattern. The values of any properties of the resource that are specified will be used to return all matching results (if it exists).


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **offset** | **int** | Indicates how many items should be skipped before returning results. | [optional]  |
| **limit** | **int** | Indicates the maximum number of items that should be returned in the results. | [optional]  |
| **orderBy** | **string** | Indicates the property name by which the results will be sorted. | [optional] [default to &quot;&quot;] |
| **direction** | **string** | Indicates whether the result should be sorted in descending order (DESC) or ascending order (ASC). | [optional] [default to Descending] |

### Return type

[**List&lt;OdsInstanceDerivativeModel&gt;**](OdsInstanceDerivativeModel.md)

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

<a id="v2odsinstancederivativesiddelete"></a>
# **V2OdsInstanceDerivativesIdDelete**
> void V2OdsInstanceDerivativesIdDelete (int id)

Deletes an existing odsInstanceDerivative using the resource identifier.

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

<a id="v2odsinstancederivativesidget"></a>
# **V2OdsInstanceDerivativesIdGet**
> OdsInstanceDerivativeModel V2OdsInstanceDerivativesIdGet (int id)

Retrieves a specific odsInstanceDerivative based on the identifier.

This GET operation provides access to resources using the \"Get\" search pattern. The values of any properties of the resource that are specified will be used to return all matching results (if it exists).


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |

### Return type

[**OdsInstanceDerivativeModel**](OdsInstanceDerivativeModel.md)

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

<a id="v2odsinstancederivativesidput"></a>
# **V2OdsInstanceDerivativesIdPut**
> void V2OdsInstanceDerivativesIdPut (int id, EditOdsInstanceDerivativeRequest editOdsInstanceDerivativeRequest)

Updates odsInstanceDerivative based on the resource identifier.

The PUT operation is used to update a resource by identifier. If the resource identifier (\"id\") is provided in the JSON body, it will be ignored. Additionally, this API resource is not configured for cascading natural key updates. Natural key values for this resource cannot be changed using PUT operation, so the recommendation is to use POST as that supports upsert behavior.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |
| **editOdsInstanceDerivativeRequest** | [**EditOdsInstanceDerivativeRequest**](EditOdsInstanceDerivativeRequest.md) |  |  |

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

<a id="v2odsinstancederivativespost"></a>
# **V2OdsInstanceDerivativesPost**
> void V2OdsInstanceDerivativesPost (AddOdsInstanceDerivativeRequest addOdsInstanceDerivativeRequest)

Creates odsInstanceDerivative based on the supplied values.

The POST operation can be used to create or update resources. In database terms, this is often referred to as an \"upsert\" operation (insert + update). Clients should NOT include the resource \"id\" in the JSON body because it will result in an error. The web service will identify whether the resource already exists based on the natural key values provided, and update or create the resource appropriately. It is recommended to use POST for both create and update except while updating natural key of a resource in which case PUT operation must be used.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **addOdsInstanceDerivativeRequest** | [**AddOdsInstanceDerivativeRequest**](AddOdsInstanceDerivativeRequest.md) |  |  |

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

