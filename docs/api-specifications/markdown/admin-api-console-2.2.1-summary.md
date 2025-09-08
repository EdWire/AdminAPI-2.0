<!-- Generator: Widdershins v4.0.1 -->

<h1 id="admin-api-documentation">Admin API Documentation vadminconsole</h1>

> Scroll down for code samples, example requests and responses. Select a language for code samples from the tabs above or the mobile navigation menu.

The Ed-Fi Admin API is a REST API-based administrative interface for managing vendors, applications, client credentials, and authorization rules for accessing an Ed-Fi API.

# Authentication

- oAuth2 authentication. 

    - Flow: clientCredentials

    - Token URL = [https://localhost:7214/connect/token](https://localhost:7214/connect/token)

|Scope|Scope Description|
|---|---|
|edfi_admin_api/full_access|Full access to the Admin API|
|edfi_admin_api/tenant_access|Access to a specific tenant|
|edfi_admin_api/worker|Worker access to the Admin API|

<h1 id="admin-api-documentation-information">Information</h1>

## Retrieve API informational metadata

`GET /`

> Example responses

> 200 Response

```json
{
  "version": "string",
  "build": "string"
}
```

<h3 id="retrieve-api-informational-metadata-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[informationResult](#schemainformationresult)|
|500|[Internal Server Error](https://tools.ietf.org/html/rfc7231#section-6.6.1)|Internal server error. An unhandled error occurred on the server. See the response body for details.|[informationResult](#schemainformationresult)|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
oauth ( Scopes: api )
</aside>

<h1 id="admin-api-documentation-adminconsole">Adminconsole</h1>

## get__adminconsole_instances

`GET /adminconsole/instances`

<h3 id="get__adminconsole_instances-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|tenantName|query|string|false|none|
|status|query|string|false|none|

<h3 id="get__adminconsole_instances-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized. The request requires authentication|None|
|403|[Forbidden](https://tools.ietf.org/html/rfc7231#section-6.5.3)|Forbidden. The request is authenticated, but not authorized to access this resource|None|
|409|[Conflict](https://tools.ietf.org/html/rfc7231#section-6.5.8)|Conflict. The request is authenticated, but it has a conflict with an existing element|None|
|500|[Internal Server Error](https://tools.ietf.org/html/rfc7231#section-6.6.1)|Internal server error. An unhandled error occurred on the server. See the response body for details.|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
oauth ( Scopes: api )
</aside>

## get__adminconsole_instances_{id}

`GET /adminconsole/instances/{id}`

<h3 id="get__adminconsole_instances_{id}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|integer(int32)|true|none|

> Example responses

> 200 Response

```json
{
  "id": 0,
  "tenantId": 0,
  "name": "string",
  "instanceType": "string",
  "status": "string",
  "baseUrl": "string",
  "odsInstanceContexts": [
    {
      "id": 0,
      "instanceId": 0,
      "contextKey": "string",
      "contextValue": "string"
    }
  ],
  "odsInstanceDerivatives": [
    {
      "id": 0,
      "instanceId": 0,
      "derivativeType": "string"
    }
  ]
}
```

<h3 id="get__adminconsole_instances_{id}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[instanceModel](#schemainstancemodel)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized. The request requires authentication|None|
|403|[Forbidden](https://tools.ietf.org/html/rfc7231#section-6.5.3)|Forbidden. The request is authenticated, but not authorized to access this resource|None|
|404|[Not Found](https://tools.ietf.org/html/rfc7231#section-6.5.4)|Not found. A resource with given identifier could not be found.|None|
|409|[Conflict](https://tools.ietf.org/html/rfc7231#section-6.5.8)|Conflict. The request is authenticated, but it has a conflict with an existing element|None|
|500|[Internal Server Error](https://tools.ietf.org/html/rfc7231#section-6.6.1)|Internal server error. An unhandled error occurred on the server. See the response body for details.|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
oauth ( Scopes: api )
</aside>

## get__adminconsole_tenants

`GET /adminconsole/tenants`

<h3 id="get__adminconsole_tenants-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized. The request requires authentication|None|
|403|[Forbidden](https://tools.ietf.org/html/rfc7231#section-6.5.3)|Forbidden. The request is authenticated, but not authorized to access this resource|None|
|409|[Conflict](https://tools.ietf.org/html/rfc7231#section-6.5.8)|Conflict. The request is authenticated, but it has a conflict with an existing element|None|
|500|[Internal Server Error](https://tools.ietf.org/html/rfc7231#section-6.6.1)|Internal server error. An unhandled error occurred on the server. See the response body for details.|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
oauth ( Scopes: api )
</aside>

## get__adminconsole_tenants_{tenantId}

`GET /adminconsole/tenants/{tenantId}`

<h3 id="get__adminconsole_tenants_{tenantid}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|tenantId|path|integer(int32)|true|none|

<h3 id="get__adminconsole_tenants_{tenantid}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized. The request requires authentication|None|
|403|[Forbidden](https://tools.ietf.org/html/rfc7231#section-6.5.3)|Forbidden. The request is authenticated, but not authorized to access this resource|None|
|404|[Not Found](https://tools.ietf.org/html/rfc7231#section-6.5.4)|Not found. A resource with given identifier could not be found.|None|
|409|[Conflict](https://tools.ietf.org/html/rfc7231#section-6.5.8)|Conflict. The request is authenticated, but it has a conflict with an existing element|None|
|500|[Internal Server Error](https://tools.ietf.org/html/rfc7231#section-6.6.1)|Internal server error. An unhandled error occurred on the server. See the response body for details.|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
oauth ( Scopes: api )
</aside>

## get__adminconsole_odsInstances

`GET /adminconsole/odsInstances`

<h3 id="get__adminconsole_odsinstances-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|status|query|string|false|none|

<h3 id="get__adminconsole_odsinstances-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized. The request requires authentication|None|
|403|[Forbidden](https://tools.ietf.org/html/rfc7231#section-6.5.3)|Forbidden. The request is authenticated, but not authorized to access this resource|None|
|409|[Conflict](https://tools.ietf.org/html/rfc7231#section-6.5.8)|Conflict. The request is authenticated, but it has a conflict with an existing element|None|
|500|[Internal Server Error](https://tools.ietf.org/html/rfc7231#section-6.6.1)|Internal server error. An unhandled error occurred on the server. See the response body for details.|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
oauth ( Scopes: api )
</aside>

## post__adminconsole_odsInstances

`POST /adminconsole/odsInstances`

> Body parameter

```json
{
  "tenantId": 0,
  "tenantName": "string",
  "name": "string",
  "instanceType": "string",
  "odsInstanceContexts": [
    {
      "contextKey": "string",
      "contextValue": "string"
    }
  ],
  "odsInstanceDerivatives": [
    {
      "derivativeType": "string"
    }
  ]
}
```

<h3 id="post__adminconsole_odsinstances-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|body|body|[addInstanceRequest](#schemaaddinstancerequest)|true|none|

<h3 id="post__adminconsole_odsinstances-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|201|[Created](https://tools.ietf.org/html/rfc7231#section-6.3.2)|Created|None|
|400|[Bad Request](https://tools.ietf.org/html/rfc7231#section-6.5.1)|Bad Request. The request was invalid and cannot be completed. See the response body for details.|None|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized. The request requires authentication|None|
|403|[Forbidden](https://tools.ietf.org/html/rfc7231#section-6.5.3)|Forbidden. The request is authenticated, but not authorized to access this resource|None|
|409|[Conflict](https://tools.ietf.org/html/rfc7231#section-6.5.8)|Conflict. The request is authenticated, but it has a conflict with an existing element|None|
|500|[Internal Server Error](https://tools.ietf.org/html/rfc7231#section-6.6.1)|Internal server error. An unhandled error occurred on the server. See the response body for details.|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
oauth ( Scopes: api )
</aside>

## get__adminconsole_odsInstances_{id}

`GET /adminconsole/odsInstances/{id}`

<h3 id="get__adminconsole_odsinstances_{id}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|integer(int32)|true|none|

> Example responses

> 200 Response

```json
{
  "id": 0,
  "tenantId": 0,
  "name": "string",
  "instanceType": "string",
  "status": "string",
  "baseUrl": "string",
  "odsInstanceContexts": [
    {
      "id": 0,
      "instanceId": 0,
      "contextKey": "string",
      "contextValue": "string"
    }
  ],
  "odsInstanceDerivatives": [
    {
      "id": 0,
      "instanceId": 0,
      "derivativeType": "string"
    }
  ]
}
```

<h3 id="get__adminconsole_odsinstances_{id}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[instanceModel](#schemainstancemodel)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized. The request requires authentication|None|
|403|[Forbidden](https://tools.ietf.org/html/rfc7231#section-6.5.3)|Forbidden. The request is authenticated, but not authorized to access this resource|None|
|404|[Not Found](https://tools.ietf.org/html/rfc7231#section-6.5.4)|Not found. A resource with given identifier could not be found.|None|
|409|[Conflict](https://tools.ietf.org/html/rfc7231#section-6.5.8)|Conflict. The request is authenticated, but it has a conflict with an existing element|None|
|500|[Internal Server Error](https://tools.ietf.org/html/rfc7231#section-6.6.1)|Internal server error. An unhandled error occurred on the server. See the response body for details.|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
oauth ( Scopes: api )
</aside>

## put__adminconsole_odsInstances_{id}

`PUT /adminconsole/odsInstances/{id}`

> Body parameter

```json
{
  "tenantId": 0,
  "tenantName": "string",
  "name": "string",
  "instanceType": "string",
  "odsInstanceContexts": [
    {
      "contextKey": "string",
      "contextValue": "string"
    }
  ],
  "odsInstanceDerivatives": [
    {
      "derivativeType": "string"
    }
  ]
}
```

<h3 id="put__adminconsole_odsinstances_{id}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|integer(int32)|true|none|
|body|body|[editInstanceRequest](#schemaeditinstancerequest)|true|none|

<h3 id="put__adminconsole_odsinstances_{id}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|204|[No Content](https://tools.ietf.org/html/rfc7231#section-6.3.5)|No Content|None|
|400|[Bad Request](https://tools.ietf.org/html/rfc7231#section-6.5.1)|Bad Request. The request was invalid and cannot be completed. See the response body for details.|None|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized. The request requires authentication|None|
|403|[Forbidden](https://tools.ietf.org/html/rfc7231#section-6.5.3)|Forbidden. The request is authenticated, but not authorized to access this resource|None|
|404|[Not Found](https://tools.ietf.org/html/rfc7231#section-6.5.4)|Not found. A resource with given identifier could not be found.|None|
|409|[Conflict](https://tools.ietf.org/html/rfc7231#section-6.5.8)|Conflict. The request is authenticated, but it has a conflict with an existing element|None|
|500|[Internal Server Error](https://tools.ietf.org/html/rfc7231#section-6.6.1)|Internal server error. An unhandled error occurred on the server. See the response body for details.|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
oauth ( Scopes: api )
</aside>

## delete__adminconsole_odsInstances_{id}

`DELETE /adminconsole/odsInstances/{id}`

<h3 id="delete__adminconsole_odsinstances_{id}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|integer(int32)|true|none|

<h3 id="delete__adminconsole_odsinstances_{id}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|202|[Accepted](https://tools.ietf.org/html/rfc7231#section-6.3.3)|Accepted|None|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized. The request requires authentication|None|
|403|[Forbidden](https://tools.ietf.org/html/rfc7231#section-6.5.3)|Forbidden. The request is authenticated, but not authorized to access this resource|None|
|404|[Not Found](https://tools.ietf.org/html/rfc7231#section-6.5.4)|Not found. A resource with given identifier could not be found.|None|
|409|[Conflict](https://tools.ietf.org/html/rfc7231#section-6.5.8)|Conflict. The request is authenticated, but it has a conflict with an existing element|None|
|500|[Internal Server Error](https://tools.ietf.org/html/rfc7231#section-6.6.1)|Internal server error. An unhandled error occurred on the server. See the response body for details.|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
oauth ( Scopes: api )
</aside>

## get__adminconsole_healthcheck

`GET /adminconsole/healthcheck`

<h3 id="get__adminconsole_healthcheck-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized. The request requires authentication|None|
|403|[Forbidden](https://tools.ietf.org/html/rfc7231#section-6.5.3)|Forbidden. The request is authenticated, but not authorized to access this resource|None|
|409|[Conflict](https://tools.ietf.org/html/rfc7231#section-6.5.8)|Conflict. The request is authenticated, but it has a conflict with an existing element|None|
|500|[Internal Server Error](https://tools.ietf.org/html/rfc7231#section-6.6.1)|Internal server error. An unhandled error occurred on the server. See the response body for details.|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
oauth ( Scopes: api )
</aside>

## post__adminconsole_healthcheck

`POST /adminconsole/healthcheck`

> Body parameter

```json
{
  "docId": 0,
  "instanceId": 0,
  "edOrgId": 0,
  "tenantId": 0,
  "document": "string"
}
```

<h3 id="post__adminconsole_healthcheck-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|body|body|[addHealthCheckRequest](#schemaaddhealthcheckrequest)|true|none|

<h3 id="post__adminconsole_healthcheck-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|201|[Created](https://tools.ietf.org/html/rfc7231#section-6.3.2)|Created|None|
|400|[Bad Request](https://tools.ietf.org/html/rfc7231#section-6.5.1)|Bad Request. The request was invalid and cannot be completed. See the response body for details.|None|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized. The request requires authentication|None|
|403|[Forbidden](https://tools.ietf.org/html/rfc7231#section-6.5.3)|Forbidden. The request is authenticated, but not authorized to access this resource|None|
|409|[Conflict](https://tools.ietf.org/html/rfc7231#section-6.5.8)|Conflict. The request is authenticated, but it has a conflict with an existing element|None|
|500|[Internal Server Error](https://tools.ietf.org/html/rfc7231#section-6.6.1)|Internal server error. An unhandled error occurred on the server. See the response body for details.|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
oauth ( Scopes: api )
</aside>

## get__adminconsole_healthcheck_{instanceId}

`GET /adminconsole/healthcheck/{instanceId}`

<h3 id="get__adminconsole_healthcheck_{instanceid}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|instanceId|path|integer(int32)|true|none|

<h3 id="get__adminconsole_healthcheck_{instanceid}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized. The request requires authentication|None|
|403|[Forbidden](https://tools.ietf.org/html/rfc7231#section-6.5.3)|Forbidden. The request is authenticated, but not authorized to access this resource|None|
|404|[Not Found](https://tools.ietf.org/html/rfc7231#section-6.5.4)|Not found. A resource with given identifier could not be found.|None|
|409|[Conflict](https://tools.ietf.org/html/rfc7231#section-6.5.8)|Conflict. The request is authenticated, but it has a conflict with an existing element|None|
|500|[Internal Server Error](https://tools.ietf.org/html/rfc7231#section-6.6.1)|Internal server error. An unhandled error occurred on the server. See the response body for details.|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
oauth ( Scopes: api )
</aside>

## post__adminconsole_instances_{id}_deleted

`POST /adminconsole/instances/{id}/deleted`

<h3 id="post__adminconsole_instances_{id}_deleted-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|integer(int32)|true|none|

<h3 id="post__adminconsole_instances_{id}_deleted-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|204|[No Content](https://tools.ietf.org/html/rfc7231#section-6.3.5)|No Content|None|
|400|[Bad Request](https://tools.ietf.org/html/rfc7231#section-6.5.1)|Bad Request. The request was invalid and cannot be completed. See the response body for details.|None|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized. The request requires authentication|None|
|403|[Forbidden](https://tools.ietf.org/html/rfc7231#section-6.5.3)|Forbidden. The request is authenticated, but not authorized to access this resource|None|
|404|[Not Found](https://tools.ietf.org/html/rfc7231#section-6.5.4)|Not found. A resource with given identifier could not be found.|None|
|409|[Conflict](https://tools.ietf.org/html/rfc7231#section-6.5.8)|Conflict. The request is authenticated, but it has a conflict with an existing element|None|
|500|[Internal Server Error](https://tools.ietf.org/html/rfc7231#section-6.6.1)|Internal server error. An unhandled error occurred on the server. See the response body for details.|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
oauth ( Scopes: api )
</aside>

## post__adminconsole_instances_{id}_deletefailed

`POST /adminconsole/instances/{id}/deletefailed`

<h3 id="post__adminconsole_instances_{id}_deletefailed-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|integer(int32)|true|none|

<h3 id="post__adminconsole_instances_{id}_deletefailed-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|204|[No Content](https://tools.ietf.org/html/rfc7231#section-6.3.5)|No Content|None|
|400|[Bad Request](https://tools.ietf.org/html/rfc7231#section-6.5.1)|Bad Request. The request was invalid and cannot be completed. See the response body for details.|None|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized. The request requires authentication|None|
|403|[Forbidden](https://tools.ietf.org/html/rfc7231#section-6.5.3)|Forbidden. The request is authenticated, but not authorized to access this resource|None|
|404|[Not Found](https://tools.ietf.org/html/rfc7231#section-6.5.4)|Not found. A resource with given identifier could not be found.|None|
|409|[Conflict](https://tools.ietf.org/html/rfc7231#section-6.5.8)|Conflict. The request is authenticated, but it has a conflict with an existing element|None|
|500|[Internal Server Error](https://tools.ietf.org/html/rfc7231#section-6.6.1)|Internal server error. An unhandled error occurred on the server. See the response body for details.|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
oauth ( Scopes: api )
</aside>

## post__adminconsole_instances_{instanceid}_renamed

`POST /adminconsole/instances/{instanceid}/renamed`

> Body parameter

```json
{
  "connectionString": "string"
}
```

<h3 id="post__adminconsole_instances_{instanceid}_renamed-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|instanceid|path|integer(int32)|true|none|
|body|body|[completeInstanceRequest](#schemacompleteinstancerequest)|true|none|

<h3 id="post__adminconsole_instances_{instanceid}_renamed-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|204|[No Content](https://tools.ietf.org/html/rfc7231#section-6.3.5)|No Content|None|
|400|[Bad Request](https://tools.ietf.org/html/rfc7231#section-6.5.1)|Bad Request. The request was invalid and cannot be completed. See the response body for details.|None|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized. The request requires authentication|None|
|403|[Forbidden](https://tools.ietf.org/html/rfc7231#section-6.5.3)|Forbidden. The request is authenticated, but not authorized to access this resource|None|
|404|[Not Found](https://tools.ietf.org/html/rfc7231#section-6.5.4)|Not found. A resource with given identifier could not be found.|None|
|409|[Conflict](https://tools.ietf.org/html/rfc7231#section-6.5.8)|Conflict. The request is authenticated, but it has a conflict with an existing element|None|
|500|[Internal Server Error](https://tools.ietf.org/html/rfc7231#section-6.6.1)|Internal server error. An unhandled error occurred on the server. See the response body for details.|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
oauth ( Scopes: api )
</aside>

## post__adminconsole_instances_{id}_renameFailed

`POST /adminconsole/instances/{id}/renameFailed`

<h3 id="post__adminconsole_instances_{id}_renamefailed-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|integer(int32)|true|none|

<h3 id="post__adminconsole_instances_{id}_renamefailed-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|204|[No Content](https://tools.ietf.org/html/rfc7231#section-6.3.5)|No Content|None|
|400|[Bad Request](https://tools.ietf.org/html/rfc7231#section-6.5.1)|Bad Request. The request was invalid and cannot be completed. See the response body for details.|None|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized. The request requires authentication|None|
|403|[Forbidden](https://tools.ietf.org/html/rfc7231#section-6.5.3)|Forbidden. The request is authenticated, but not authorized to access this resource|None|
|404|[Not Found](https://tools.ietf.org/html/rfc7231#section-6.5.4)|Not found. A resource with given identifier could not be found.|None|
|409|[Conflict](https://tools.ietf.org/html/rfc7231#section-6.5.8)|Conflict. The request is authenticated, but it has a conflict with an existing element|None|
|500|[Internal Server Error](https://tools.ietf.org/html/rfc7231#section-6.6.1)|Internal server error. An unhandled error occurred on the server. See the response body for details.|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
oauth ( Scopes: api )
</aside>

## post__adminconsole_instances_{instanceid}_completed

`POST /adminconsole/instances/{instanceid}/completed`

> Body parameter

```json
{
  "connectionString": "string"
}
```

<h3 id="post__adminconsole_instances_{instanceid}_completed-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|instanceid|path|integer(int32)|true|none|
|body|body|[completeInstanceRequest](#schemacompleteinstancerequest)|true|none|

<h3 id="post__adminconsole_instances_{instanceid}_completed-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|204|[No Content](https://tools.ietf.org/html/rfc7231#section-6.3.5)|No Content|None|
|400|[Bad Request](https://tools.ietf.org/html/rfc7231#section-6.5.1)|Bad Request. The request was invalid and cannot be completed. See the response body for details.|None|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized. The request requires authentication|None|
|403|[Forbidden](https://tools.ietf.org/html/rfc7231#section-6.5.3)|Forbidden. The request is authenticated, but not authorized to access this resource|None|
|404|[Not Found](https://tools.ietf.org/html/rfc7231#section-6.5.4)|Not found. A resource with given identifier could not be found.|None|
|409|[Conflict](https://tools.ietf.org/html/rfc7231#section-6.5.8)|Conflict. The request is authenticated, but it has a conflict with an existing element|None|
|500|[Internal Server Error](https://tools.ietf.org/html/rfc7231#section-6.6.1)|Internal server error. An unhandled error occurred on the server. See the response body for details.|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
oauth ( Scopes: api )
</aside>

<h1 id="admin-api-documentation-connect">Connect</h1>

## Registers new client

`POST /connect/register`

Registers new client

> Body parameter

```yaml
ClientId: string
ClientSecret: string
DisplayName: string

```

<h3 id="registers-new-client-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|body|body|object|false|none|
|» ClientId|body|string|false|Client id|
|» ClientSecret|body|string|false|Client secret|
|» DisplayName|body|string|false|Client display name|

<h3 id="registers-new-client-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|Application registered successfully.|None|
|400|[Bad Request](https://tools.ietf.org/html/rfc7231#section-6.5.1)|Bad Request. The request was invalid and cannot be completed. See the response body for details.|None|
|500|[Internal Server Error](https://tools.ietf.org/html/rfc7231#section-6.6.1)|Internal server error. An unhandled error occurred on the server. See the response body for details.|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
oauth ( Scopes: api )
</aside>

## Retrieves bearer token

`POST /connect/token`

To authenticate Swagger requests, execute using "Authorize" above, not "Try It Out" here.

> Body parameter

```yaml
client_id: null
client_secret: null
grant_type: null
scope: string

```

<h3 id="retrieves-bearer-token-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|body|body|object|false|none|
|» client_id|body|string |false|none|
|» client_secret|body|string |false|none|
|» grant_type|body|string |false|none|
|» scope|body|string|false|none|

<h3 id="retrieves-bearer-token-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|Sign-in successful.|None|
|400|[Bad Request](https://tools.ietf.org/html/rfc7231#section-6.5.1)|Bad request, such as invalid scope.|None|
|500|[Internal Server Error](https://tools.ietf.org/html/rfc7231#section-6.6.1)|Internal server error. An unhandled error occurred on the server. See the response body for details.|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
oauth ( Scopes: api )
</aside>

# Schemas

<h2 id="tocS_addHealthCheckRequest">addHealthCheckRequest</h2>
<!-- backwards compatibility -->
<a id="schemaaddhealthcheckrequest"></a>
<a id="schema_addHealthCheckRequest"></a>
<a id="tocSaddhealthcheckrequest"></a>
<a id="tocsaddhealthcheckrequest"></a>

```json
{
  "docId": 0,
  "instanceId": 0,
  "edOrgId": 0,
  "tenantId": 0,
  "document": "string"
}

```

AddHealthCheckRequest

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|docId|integer(int32)|false|none|none|
|instanceId|integer(int32)|false|none|none|
|edOrgId|integer(int32)|false|none|none|
|tenantId|integer(int32)|false|none|none|
|document|string|false|none|none|

<h2 id="tocS_addInstanceRequest">addInstanceRequest</h2>
<!-- backwards compatibility -->
<a id="schemaaddinstancerequest"></a>
<a id="schema_addInstanceRequest"></a>
<a id="tocSaddinstancerequest"></a>
<a id="tocsaddinstancerequest"></a>

```json
{
  "tenantId": 0,
  "tenantName": "string",
  "name": "string",
  "instanceType": "string",
  "odsInstanceContexts": [
    {
      "contextKey": "string",
      "contextValue": "string"
    }
  ],
  "odsInstanceDerivatives": [
    {
      "derivativeType": "string"
    }
  ]
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|tenantId|integer(int32)|false|none|none|
|tenantName|string¦null|false|none|none|
|name|string¦null|false|none|none|
|instanceType|string¦null|false|none|none|
|odsInstanceContexts|[[odsInstanceContextModel](#schemaodsinstancecontextmodel)]¦null|false|none|none|
|odsInstanceDerivatives|[[odsInstanceDerivativeModel](#schemaodsinstancederivativemodel)]¦null|false|none|none|

<h2 id="tocS_adminApiError">adminApiError</h2>
<!-- backwards compatibility -->
<a id="schemaadminapierror"></a>
<a id="schema_adminApiError"></a>
<a id="tocSadminapierror"></a>
<a id="tocsadminapierror"></a>

```json
{}

```

AdminApiError

### Properties

*None*

<h2 id="tocS_completeInstanceRequest">completeInstanceRequest</h2>
<!-- backwards compatibility -->
<a id="schemacompleteinstancerequest"></a>
<a id="schema_completeInstanceRequest"></a>
<a id="tocScompleteinstancerequest"></a>
<a id="tocscompleteinstancerequest"></a>

```json
{
  "connectionString": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|connectionString|string¦null|false|none|none|

<h2 id="tocS_editInstanceRequest">editInstanceRequest</h2>
<!-- backwards compatibility -->
<a id="schemaeditinstancerequest"></a>
<a id="schema_editInstanceRequest"></a>
<a id="tocSeditinstancerequest"></a>
<a id="tocseditinstancerequest"></a>

```json
{
  "tenantId": 0,
  "tenantName": "string",
  "name": "string",
  "instanceType": "string",
  "odsInstanceContexts": [
    {
      "contextKey": "string",
      "contextValue": "string"
    }
  ],
  "odsInstanceDerivatives": [
    {
      "derivativeType": "string"
    }
  ]
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|tenantId|integer(int32)|false|none|none|
|tenantName|string¦null|false|none|none|
|name|string¦null|false|none|none|
|instanceType|string¦null|false|none|none|
|odsInstanceContexts|[[odsInstanceContextModel](#schemaodsinstancecontextmodel)]¦null|false|none|none|
|odsInstanceDerivatives|[[odsInstanceDerivativeModel](#schemaodsinstancederivativemodel)]¦null|false|none|none|

<h2 id="tocS_informationResult">informationResult</h2>
<!-- backwards compatibility -->
<a id="schemainformationresult"></a>
<a id="schema_informationResult"></a>
<a id="tocSinformationresult"></a>
<a id="tocsinformationresult"></a>

```json
{
  "version": "string",
  "build": "string"
}

```

Information

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|version|string|false|none|Application version|
|build|string|false|none|Build / release version|

<h2 id="tocS_instanceModel">instanceModel</h2>
<!-- backwards compatibility -->
<a id="schemainstancemodel"></a>
<a id="schema_instanceModel"></a>
<a id="tocSinstancemodel"></a>
<a id="tocsinstancemodel"></a>

```json
{
  "id": 0,
  "tenantId": 0,
  "name": "string",
  "instanceType": "string",
  "status": "string",
  "baseUrl": "string",
  "odsInstanceContexts": [
    {
      "id": 0,
      "instanceId": 0,
      "contextKey": "string",
      "contextValue": "string"
    }
  ],
  "odsInstanceDerivatives": [
    {
      "id": 0,
      "instanceId": 0,
      "derivativeType": "string"
    }
  ]
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|integer(int32)|false|none|none|
|tenantId|integer(int32)|false|none|none|
|name|string¦null|false|none|none|
|instanceType|string¦null|false|none|none|
|status|string¦null|false|none|none|
|baseUrl|string¦null|false|none|none|
|odsInstanceContexts|[[odsInstanceContextForInstanceModel](#schemaodsinstancecontextforinstancemodel)]¦null|false|none|none|
|odsInstanceDerivatives|[[odsInstanceDerivativeForInstanceModel](#schemaodsinstancederivativeforinstancemodel)]¦null|false|none|none|

<h2 id="tocS_odsInstanceContextForInstanceModel">odsInstanceContextForInstanceModel</h2>
<!-- backwards compatibility -->
<a id="schemaodsinstancecontextforinstancemodel"></a>
<a id="schema_odsInstanceContextForInstanceModel"></a>
<a id="tocSodsinstancecontextforinstancemodel"></a>
<a id="tocsodsinstancecontextforinstancemodel"></a>

```json
{
  "id": 0,
  "instanceId": 0,
  "contextKey": "string",
  "contextValue": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|integer(int32)|false|none|none|
|instanceId|integer(int32)|false|none|none|
|contextKey|string¦null|false|none|none|
|contextValue|string¦null|false|none|none|

<h2 id="tocS_odsInstanceContextModel">odsInstanceContextModel</h2>
<!-- backwards compatibility -->
<a id="schemaodsinstancecontextmodel"></a>
<a id="schema_odsInstanceContextModel"></a>
<a id="tocSodsinstancecontextmodel"></a>
<a id="tocsodsinstancecontextmodel"></a>

```json
{
  "contextKey": "string",
  "contextValue": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|contextKey|string¦null|false|none|none|
|contextValue|string¦null|false|none|none|

<h2 id="tocS_odsInstanceDerivativeForInstanceModel">odsInstanceDerivativeForInstanceModel</h2>
<!-- backwards compatibility -->
<a id="schemaodsinstancederivativeforinstancemodel"></a>
<a id="schema_odsInstanceDerivativeForInstanceModel"></a>
<a id="tocSodsinstancederivativeforinstancemodel"></a>
<a id="tocsodsinstancederivativeforinstancemodel"></a>

```json
{
  "id": 0,
  "instanceId": 0,
  "derivativeType": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|integer(int32)|false|none|none|
|instanceId|integer(int32)|false|none|none|
|derivativeType|string¦null|false|none|none|

<h2 id="tocS_odsInstanceDerivativeModel">odsInstanceDerivativeModel</h2>
<!-- backwards compatibility -->
<a id="schemaodsinstancederivativemodel"></a>
<a id="schema_odsInstanceDerivativeModel"></a>
<a id="tocSodsinstancederivativemodel"></a>
<a id="tocsodsinstancederivativemodel"></a>

```json
{
  "derivativeType": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|derivativeType|string¦null|false|none|none|

<h2 id="tocS_registerClientRequest">registerClientRequest</h2>
<!-- backwards compatibility -->
<a id="schemaregisterclientrequest"></a>
<a id="schema_registerClientRequest"></a>
<a id="tocSregisterclientrequest"></a>
<a id="tocsregisterclientrequest"></a>

```json
{
  "clientId": "string",
  "clientSecret": "string",
  "displayName": "string"
}

```

RegisterClientRequest

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|clientId|string|false|none|Client id|
|clientSecret|string|false|none|Client secret|
|displayName|string|false|none|Client display name|

