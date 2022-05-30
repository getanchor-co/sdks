# Co.GetAnchor.Sdk.Api.AuthorizationApi

All URIs are relative to *http://{{baseurl}}*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiV1AuthLoginPost**](AuthorizationApi.md#apiv1authloginpost) | **POST** /api/v1/auth/login | Login
[**ApiV1OrganizationsTokensGet**](AuthorizationApi.md#apiv1organizationstokensget) | **GET** /api/v1/organizations/tokens | Get Api Keys

<a name="apiv1authloginpost"></a>
# **ApiV1AuthLoginPost**
> Object ApiV1AuthLoginPost (Object body = null)

Login

### Example
```csharp
using System;
using System.Diagnostics;
using Co.GetAnchor.Sdk.Api;
using Co.GetAnchor.Sdk.Client;
using Co.GetAnchor.Sdk.Model;

namespace Example
{
    public class ApiV1AuthLoginPostExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: apikeyAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new AuthorizationApi();
            var body = new Object(); // Object |  (optional) 

            try
            {
                // Login
                Object result = apiInstance.ApiV1AuthLoginPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationApi.ApiV1AuthLoginPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Object**](Object.md)|  | [optional] 

### Return type

**Object**

### Authorization

[apikeyAuth](../README.md#apikeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiv1organizationstokensget"></a>
# **ApiV1OrganizationsTokensGet**
> Object ApiV1OrganizationsTokensGet ()

Get Api Keys

### Example
```csharp
using System;
using System.Diagnostics;
using Co.GetAnchor.Sdk.Api;
using Co.GetAnchor.Sdk.Client;
using Co.GetAnchor.Sdk.Model;

namespace Example
{
    public class ApiV1OrganizationsTokensGetExample
    {
        public void main()
        {

            var apiInstance = new AuthorizationApi();

            try
            {
                // Get Api Keys
                Object result = apiInstance.ApiV1OrganizationsTokensGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationApi.ApiV1OrganizationsTokensGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**Object**

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
