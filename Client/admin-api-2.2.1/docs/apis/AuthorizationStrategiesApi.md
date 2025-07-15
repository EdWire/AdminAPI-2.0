# EdFi.Ods.AdminApi.Client.Api.AuthorizationStrategiesApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**V2AuthorizationStrategiesGet**](AuthorizationStrategiesApi.md#v2authorizationstrategiesget) | **GET** /v2/authorizationStrategies | Retrieves all authorizationStrategies. |

<a id="v2authorizationstrategiesget"></a>
# **V2AuthorizationStrategiesGet**
> List&lt;AuthorizationStrategyModel&gt; V2AuthorizationStrategiesGet (int offset = null, int limit = null, string orderBy = null, string direction = null)

Retrieves all authorizationStrategies.

This GET operation provides access to resources using the \"Get\" search pattern. The values of any properties of the resource that are specified will be used to return all matching results (if it exists).


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **offset** | **int** | Indicates how many items should be skipped before returning results. | [optional]  |
| **limit** | **int** | Indicates the maximum number of items that should be returned in the results. | [optional]  |
| **orderBy** | **string** | Indicates the property name by which the results will be sorted. | [optional] [default to &quot;&quot;] |
| **direction** | **string** | Indicates whether the result should be sorted in descending order (DESC) or ascending order (ASC). | [optional] [default to Descending] |

### Return type

[**List&lt;AuthorizationStrategyModel&gt;**](AuthorizationStrategyModel.md)

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

