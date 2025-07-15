# EdFi.Ods.AdminApi.Client.Api.ClaimSetsApi

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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="v2claimsetsclaimsetidresourceclaimactionsresourceclaimiddelete"></a>
# **V2ClaimSetsClaimSetIdResourceClaimActionsResourceClaimIdDelete**
> void V2ClaimSetsClaimSetIdResourceClaimActionsResourceClaimIdDelete (int claimSetId, int resourceClaimId)

Deletes a resource claims association from a claimset


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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="v2claimsetsclaimsetidresourceclaimactionsresourceclaimidoverrideauthorizationstrategypost"></a>
# **V2ClaimSetsClaimSetIdResourceClaimActionsResourceClaimIdOverrideAuthorizationStrategyPost**
> void V2ClaimSetsClaimSetIdResourceClaimActionsResourceClaimIdOverrideAuthorizationStrategyPost (int claimSetId, int resourceClaimId, OverrideAuthStategyOnClaimSetRequest overrideAuthStategyOnClaimSetRequest)

Overrides the default authorization strategies on provided resource claim for a specific action.

Override the default authorization strategies on provided resource claim for a specific action.    ex: actionName = read,  authorizationStrategies= [ \"Ownershipbased\" ]


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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="v2claimsetsclaimsetidresourceclaimactionsresourceclaimidput"></a>
# **V2ClaimSetsClaimSetIdResourceClaimActionsResourceClaimIdPut**
> void V2ClaimSetsClaimSetIdResourceClaimActionsResourceClaimIdPut (int claimSetId, int resourceClaimId, EditResourceClaimOnClaimSetRequest editResourceClaimOnClaimSetRequest)

Updates the ResourceClaimActions to a specific resource claim on a claimset.

Updates  the resourceClaimActions to a  specific resource claim on a claimset. At least one action should be enabled. Valid actions are read, create, update, delete, readchanges.


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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="v2claimsetsclaimsetidresourceclaimactionsresourceclaimidresetauthorizationstrategiespost"></a>
# **V2ClaimSetsClaimSetIdResourceClaimActionsResourceClaimIdResetAuthorizationStrategiesPost**
> void V2ClaimSetsClaimSetIdResourceClaimActionsResourceClaimIdResetAuthorizationStrategiesPost (int claimSetId, int resourceClaimId)

Resets to default authorization strategies on provided resource claim.


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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="v2claimsetscopypost"></a>
# **V2ClaimSetsCopyPost**
> void V2ClaimSetsCopyPost (CopyClaimSetRequest copyClaimSetRequest)

Copies the existing claimset and create a new one.


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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="v2claimsetsget"></a>
# **V2ClaimSetsGet**
> List&lt;ClaimSetModel&gt; V2ClaimSetsGet (int offset = null, int limit = null, string orderBy = null, string direction = null, int id = null, string name = null)

Retrieves all claimSets.

This GET operation provides access to resources using the \"Get\" search pattern. The values of any properties of the resource that are specified will be used to return all matching results (if it exists).


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **offset** | **int** | Indicates how many items should be skipped before returning results. | [optional]  |
| **limit** | **int** | Indicates the maximum number of items that should be returned in the results. | [optional]  |
| **orderBy** | **string** | Indicates the property name by which the results will be sorted. | [optional] [default to &quot;&quot;] |
| **direction** | **string** | Indicates whether the result should be sorted in descending order (DESC) or ascending order (ASC). | [optional] [default to Descending] |
| **id** | **int** | Claim set id | [optional]  |
| **name** | **string** | Claim set name | [optional]  |

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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="v2claimsetsiddelete"></a>
# **V2ClaimSetsIdDelete**
> void V2ClaimSetsIdDelete (int id)

Deletes an existing claimSet using the resource identifier.

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

<a id="v2claimsetsidexportget"></a>
# **V2ClaimSetsIdExportGet**
> ClaimSetDetailsModel V2ClaimSetsIdExportGet (int id)

Exports a specific claimset by id


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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="v2claimsetsidget"></a>
# **V2ClaimSetsIdGet**
> ClaimSetDetailsModel V2ClaimSetsIdGet (int id)

Retrieves a specific claimSet based on the identifier.

This GET operation provides access to resources using the \"Get\" search pattern. The values of any properties of the resource that are specified will be used to return all matching results (if it exists).


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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="v2claimsetsidput"></a>
# **V2ClaimSetsIdPut**
> void V2ClaimSetsIdPut (int id, EditClaimSetRequest editClaimSetRequest)

Updates claimSet based on the resource identifier.

The PUT operation is used to update a resource by identifier. If the resource identifier (\"id\") is provided in the JSON body, it will be ignored. Additionally, this API resource is not configured for cascading natural key updates. Natural key values for this resource cannot be changed using PUT operation, so the recommendation is to use POST as that supports upsert behavior.


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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="v2claimsetsimportpost"></a>
# **V2ClaimSetsImportPost**
> void V2ClaimSetsImportPost (ImportClaimSetRequest importClaimSetRequest)

Imports a new claimset


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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="v2claimsetspost"></a>
# **V2ClaimSetsPost**
> void V2ClaimSetsPost (AddClaimSetRequest addClaimSetRequest)

Creates claimSet based on the supplied values.

The POST operation can be used to create or update resources. In database terms, this is often referred to as an \"upsert\" operation (insert + update). Clients should NOT include the resource \"id\" in the JSON body because it will result in an error. The web service will identify whether the resource already exists based on the natural key values provided, and update or create the resource appropriately. It is recommended to use POST for both create and update except while updating natural key of a resource in which case PUT operation must be used.


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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

