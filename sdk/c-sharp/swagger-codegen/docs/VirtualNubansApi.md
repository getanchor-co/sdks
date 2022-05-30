# Co.GetAnchor.Sdk.Api.VirtualNubansApi

All URIs are relative to *http://{{baseurl}}*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiV1VirtualNubansBySettlementAccountSettlementAccountIdGet**](VirtualNubansApi.md#apiv1virtualnubansbysettlementaccountsettlementaccountidget) | **GET** /api/v1/virtual-nubans/by-settlement-account/{settlementAccountId} | List Virtual Nuban By Settlement Account
[**ApiV1VirtualNubansCloseAccountAccountIdDelete**](VirtualNubansApi.md#apiv1virtualnubanscloseaccountaccountiddelete) | **DELETE** /api/v1/virtual-nubans/close-account/{accountId} | Close Virtual Nuban
[**ApiV1VirtualNubansPost**](VirtualNubansApi.md#apiv1virtualnubanspost) | **POST** /api/v1/virtual-nubans | Create Virtual Nuban
[**ApiV1VirtualNubansVirtualAccountIdGet**](VirtualNubansApi.md#apiv1virtualnubansvirtualaccountidget) | **GET** /api/v1/virtual-nubans/{virtualAccountId} | Fetch Virtual Nuban

<a name="apiv1virtualnubansbysettlementaccountsettlementaccountidget"></a>
# **ApiV1VirtualNubansBySettlementAccountSettlementAccountIdGet**
> Object ApiV1VirtualNubansBySettlementAccountSettlementAccountIdGet (string settlementAccountId)

List Virtual Nuban By Settlement Account

### Example
```csharp
using System;
using System.Diagnostics;
using Co.GetAnchor.Sdk.Api;
using Co.GetAnchor.Sdk.Client;
using Co.GetAnchor.Sdk.Model;

namespace Example
{
    public class ApiV1VirtualNubansBySettlementAccountSettlementAccountIdGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: apikeyAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new VirtualNubansApi();
            var settlementAccountId = settlementAccountId_example;  // string | 

            try
            {
                // List Virtual Nuban By Settlement Account
                Object result = apiInstance.ApiV1VirtualNubansBySettlementAccountSettlementAccountIdGet(settlementAccountId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VirtualNubansApi.ApiV1VirtualNubansBySettlementAccountSettlementAccountIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **settlementAccountId** | **string**|  | 

### Return type

**Object**

### Authorization

[apikeyAuth](../README.md#apikeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiv1virtualnubanscloseaccountaccountiddelete"></a>
# **ApiV1VirtualNubansCloseAccountAccountIdDelete**
> Object ApiV1VirtualNubansCloseAccountAccountIdDelete (string accountId)

Close Virtual Nuban

### Example
```csharp
using System;
using System.Diagnostics;
using Co.GetAnchor.Sdk.Api;
using Co.GetAnchor.Sdk.Client;
using Co.GetAnchor.Sdk.Model;

namespace Example
{
    public class ApiV1VirtualNubansCloseAccountAccountIdDeleteExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: apikeyAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new VirtualNubansApi();
            var accountId = accountId_example;  // string | 

            try
            {
                // Close Virtual Nuban
                Object result = apiInstance.ApiV1VirtualNubansCloseAccountAccountIdDelete(accountId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VirtualNubansApi.ApiV1VirtualNubansCloseAccountAccountIdDelete: " + e.Message );
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
<a name="apiv1virtualnubanspost"></a>
# **ApiV1VirtualNubansPost**
> Object ApiV1VirtualNubansPost (Object body = null)

Create Virtual Nuban

### Example
```csharp
using System;
using System.Diagnostics;
using Co.GetAnchor.Sdk.Api;
using Co.GetAnchor.Sdk.Client;
using Co.GetAnchor.Sdk.Model;

namespace Example
{
    public class ApiV1VirtualNubansPostExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: apikeyAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new VirtualNubansApi();
            var body = new Object(); // Object |  (optional) 

            try
            {
                // Create Virtual Nuban
                Object result = apiInstance.ApiV1VirtualNubansPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VirtualNubansApi.ApiV1VirtualNubansPost: " + e.Message );
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
<a name="apiv1virtualnubansvirtualaccountidget"></a>
# **ApiV1VirtualNubansVirtualAccountIdGet**
> Object ApiV1VirtualNubansVirtualAccountIdGet (string virtualAccountId)

Fetch Virtual Nuban

### Example
```csharp
using System;
using System.Diagnostics;
using Co.GetAnchor.Sdk.Api;
using Co.GetAnchor.Sdk.Client;
using Co.GetAnchor.Sdk.Model;

namespace Example
{
    public class ApiV1VirtualNubansVirtualAccountIdGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: apikeyAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new VirtualNubansApi();
            var virtualAccountId = virtualAccountId_example;  // string | 

            try
            {
                // Fetch Virtual Nuban
                Object result = apiInstance.ApiV1VirtualNubansVirtualAccountIdGet(virtualAccountId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VirtualNubansApi.ApiV1VirtualNubansVirtualAccountIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **virtualAccountId** | **string**|  | 

### Return type

**Object**

### Authorization

[apikeyAuth](../README.md#apikeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
