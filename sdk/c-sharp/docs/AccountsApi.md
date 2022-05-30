# Co.GetAnchor.Sdk.Api.AccountsApi

All URIs are relative to *http://{{baseurl}}*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiV1AccountsAccountIdGet**](AccountsApi.md#apiv1accountsaccountidget) | **GET** /api/v1/accounts/{accountId} | Fetch Account
[**ApiV1AccountsBalanceAccountIdGet**](AccountsApi.md#apiv1accountsbalanceaccountidget) | **GET** /api/v1/accounts/balance/{accountId} | Fetch Account Balance
[**ApiV1AccountsGet**](AccountsApi.md#apiv1accountsget) | **GET** /api/v1/accounts | List Accounts
[**ApiV1AccountsPost**](AccountsApi.md#apiv1accountspost) | **POST** /api/v1/accounts | Create Account

<a name="apiv1accountsaccountidget"></a>
# **ApiV1AccountsAccountIdGet**
> Object ApiV1AccountsAccountIdGet (string accountId)

Fetch Account

### Example
```csharp
using System;
using System.Diagnostics;
using Co.GetAnchor.Sdk.Api;
using Co.GetAnchor.Sdk.Client;
using Co.GetAnchor.Sdk.Model;

namespace Example
{
    public class ApiV1AccountsAccountIdGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: apikeyAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new AccountsApi();
            var accountId = accountId_example;  // string | 

            try
            {
                // Fetch Account
                Object result = apiInstance.ApiV1AccountsAccountIdGet(accountId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.ApiV1AccountsAccountIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**|  | 

### Return type

**Object**

### Authorization

[apikeyAuth](../README.md#apikeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiv1accountsbalanceaccountidget"></a>
# **ApiV1AccountsBalanceAccountIdGet**
> Object ApiV1AccountsBalanceAccountIdGet (string accountId, string xAnchorKey = null)

Fetch Account Balance

### Example
```csharp
using System;
using System.Diagnostics;
using Co.GetAnchor.Sdk.Api;
using Co.GetAnchor.Sdk.Client;
using Co.GetAnchor.Sdk.Model;

namespace Example
{
    public class ApiV1AccountsBalanceAccountIdGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: apikeyAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new AccountsApi();
            var accountId = accountId_example;  // string | 
            var xAnchorKey = xAnchorKey_example;  // string |  (optional) 

            try
            {
                // Fetch Account Balance
                Object result = apiInstance.ApiV1AccountsBalanceAccountIdGet(accountId, xAnchorKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.ApiV1AccountsBalanceAccountIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**|  | 
 **xAnchorKey** | **string**|  | [optional] 

### Return type

**Object**

### Authorization

[apikeyAuth](../README.md#apikeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiv1accountsget"></a>
# **ApiV1AccountsGet**
> Object ApiV1AccountsGet (string xAnchorKey = null, int? size = null, string accountType = null, string page = null, string customerId = null)

List Accounts

### Example
```csharp
using System;
using System.Diagnostics;
using Co.GetAnchor.Sdk.Api;
using Co.GetAnchor.Sdk.Client;
using Co.GetAnchor.Sdk.Model;

namespace Example
{
    public class ApiV1AccountsGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: apikeyAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new AccountsApi();
            var xAnchorKey = xAnchorKey_example;  // string |  (optional) 
            var size = 56;  // int? |  (optional) 
            var accountType = accountType_example;  // string |  (optional) 
            var page = page_example;  // string |  (optional) 
            var customerId = customerId_example;  // string |  (optional) 

            try
            {
                // List Accounts
                Object result = apiInstance.ApiV1AccountsGet(xAnchorKey, size, accountType, page, customerId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.ApiV1AccountsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **xAnchorKey** | **string**|  | [optional] 
 **size** | **int?**|  | [optional] 
 **accountType** | **string**|  | [optional] 
 **page** | **string**|  | [optional] 
 **customerId** | **string**|  | [optional] 

### Return type

**Object**

### Authorization

[apikeyAuth](../README.md#apikeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiv1accountspost"></a>
# **ApiV1AccountsPost**
> Object ApiV1AccountsPost (Object body = null, string contentType = null)

Create Account

### Example
```csharp
using System;
using System.Diagnostics;
using Co.GetAnchor.Sdk.Api;
using Co.GetAnchor.Sdk.Client;
using Co.GetAnchor.Sdk.Model;

namespace Example
{
    public class ApiV1AccountsPostExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: apikeyAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new AccountsApi();
            var body = new Object(); // Object |  (optional) 
            var contentType = contentType_example;  // string |  (optional) 

            try
            {
                // Create Account
                Object result = apiInstance.ApiV1AccountsPost(body, contentType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.ApiV1AccountsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Object**](Object.md)|  | [optional] 
 **contentType** | **string**|  | [optional] 

### Return type

**Object**

### Authorization

[apikeyAuth](../README.md#apikeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
