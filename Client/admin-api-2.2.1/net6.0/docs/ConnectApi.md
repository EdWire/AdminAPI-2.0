# EdFi.Ods.AdminApi.V2.Client.Api.ConnectApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ConnectRegisterPost**](ConnectApi.md#connectregisterpost) | **POST** /connect/register | Registers new client |
| [**ConnectTokenPost**](ConnectApi.md#connecttokenpost) | **POST** /connect/token | Retrieves bearer token |

<a id="connectregisterpost"></a>
# **ConnectRegisterPost**
> void ConnectRegisterPost (string? clientId = null, string? clientSecret = null, string? displayName = null)

Registers new client

Registers new client

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdFi.Ods.AdminApi.V2.Client.Api;
using EdFi.Ods.AdminApi.V2.Client.Client;
using EdFi.Ods.AdminApi.V2.Client.Model;

namespace Example
{
    public class ConnectRegisterPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConnectApi(config);
            var clientId = "clientId_example";  // string? | Client id (optional) 
            var clientSecret = "clientSecret_example";  // string? | Client secret (optional) 
            var displayName = "displayName_example";  // string? | Client display name (optional) 

            try
            {
                // Registers new client
                apiInstance.ConnectRegisterPost(clientId, clientSecret, displayName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConnectApi.ConnectRegisterPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ConnectRegisterPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Registers new client
    apiInstance.ConnectRegisterPostWithHttpInfo(clientId, clientSecret, displayName);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConnectApi.ConnectRegisterPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clientId** | **string?** | Client id | [optional]  |
| **clientSecret** | **string?** | Client secret | [optional]  |
| **displayName** | **string?** | Client display name | [optional]  |

### Return type

void (empty response body)

### Authorization

[oauth](../README.md#oauth)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Bad Request. The request was invalid and cannot be completed. See the response body for details. |  -  |
| **500** | Internal server error. An unhandled error occurred on the server. See the response body for details. |  -  |
| **200** | Application registered successfully. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="connecttokenpost"></a>
# **ConnectTokenPost**
> void ConnectTokenPost (String? clientId = null, String? clientSecret = null, String? grantType = null, string? scope = null)

Retrieves bearer token

 To authenticate Swagger requests, execute using \"Authorize\" above, not \"Try It Out\" here.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdFi.Ods.AdminApi.V2.Client.Api;
using EdFi.Ods.AdminApi.V2.Client.Client;
using EdFi.Ods.AdminApi.V2.Client.Model;

namespace Example
{
    public class ConnectTokenPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConnectApi(config);
            var clientId = new String?(); // String? |  (optional) 
            var clientSecret = new String?(); // String? |  (optional) 
            var grantType = new String?(); // String? |  (optional) 
            var scope = "scope_example";  // string? |  (optional) 

            try
            {
                // Retrieves bearer token
                apiInstance.ConnectTokenPost(clientId, clientSecret, grantType, scope);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConnectApi.ConnectTokenPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ConnectTokenPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves bearer token
    apiInstance.ConnectTokenPostWithHttpInfo(clientId, clientSecret, grantType, scope);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConnectApi.ConnectTokenPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clientId** | [**String?**](String?.md) |  | [optional]  |
| **clientSecret** | [**String?**](String?.md) |  | [optional]  |
| **grantType** | [**String?**](String?.md) |  | [optional]  |
| **scope** | **string?** |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[oauth](../README.md#oauth)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Bad request, such as invalid scope. |  -  |
| **500** | Internal server error. An unhandled error occurred on the server. See the response body for details. |  -  |
| **200** | Sign-in successful. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

