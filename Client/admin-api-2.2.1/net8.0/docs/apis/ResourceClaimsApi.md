# EdFi.Ods.AdminApi.V2.Client.Api.ResourceClaimsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**V2ResourceClaimsGet**](ResourceClaimsApi.md#v2resourceclaimsget) | **GET** /v2/resourceClaims | Retrieves all resourceClaims. |
| [**V2ResourceClaimsIdGet**](ResourceClaimsApi.md#v2resourceclaimsidget) | **GET** /v2/resourceClaims/{id} | Retrieves a specific resourceClaim based on the identifier. |

<a id="v2resourceclaimsget"></a>
# **V2ResourceClaimsGet**
> List&lt;ResourceClaimModel&gt; V2ResourceClaimsGet (int offset = null, int limit = null, string orderBy = null, string direction = null, int id = null, string name = null)

Retrieves all resourceClaims.

This GET operation provides access to resources using the \"Get\" search pattern. The values of any properties of the resource that are specified will be used to return all matching results (if it exists).


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **offset** | **int** | Indicates how many items should be skipped before returning results. | [optional]  |
| **limit** | **int** | Indicates the maximum number of items that should be returned in the results. | [optional]  |
| **orderBy** | **string** | Indicates the property name by which the results will be sorted. | [optional] [default to &quot;&quot;] |
| **direction** | **string** | Indicates whether the result should be sorted in descending order (DESC) or ascending order (ASC). | [optional] [default to Descending] |
| **id** | **int** | Resource Claim Id | [optional]  |
| **name** | **string** | Resource Claim Name | [optional]  |

### Return type

[**List&lt;ResourceClaimModel&gt;**](ResourceClaimModel.md)

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

<a id="v2resourceclaimsidget"></a>
# **V2ResourceClaimsIdGet**
> ResourceClaimModel V2ResourceClaimsIdGet (int id)

Retrieves a specific resourceClaim based on the identifier.

This GET operation provides access to resources using the \"Get\" search pattern. The values of any properties of the resource that are specified will be used to return all matching results (if it exists).


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |

### Return type

[**ResourceClaimModel**](ResourceClaimModel.md)

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

