# Co.GetAnchor.Sdk.Api.CustomersApi

All URIs are relative to *http://{{baseurl}}*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiV1CustomersCustomerIdGet**](CustomersApi.md#apiv1customerscustomeridget) | **GET** /api/v1/customers/{customerId} | Fetch Customer
[**ApiV1CustomersGet**](CustomersApi.md#apiv1customersget) | **GET** /api/v1/customers | List Customers
[**ApiV1CustomersPost**](CustomersApi.md#apiv1customerspost) | **POST** /api/v1/customers | Create Customer
[**ApiV1CustomersUpdateCustomerIdPut**](CustomersApi.md#apiv1customersupdatecustomeridput) | **PUT** /api/v1/customers/update/{customerId} | Update Business Customer

<a name="apiv1customerscustomeridget"></a>
# **ApiV1CustomersCustomerIdGet**
> Object ApiV1CustomersCustomerIdGet (string customerId, string xAnchorKey = null)

Fetch Customer

### Example
```csharp
using System;
using System.Diagnostics;
using Co.GetAnchor.Sdk.Api;
using Co.GetAnchor.Sdk.Client;
using Co.GetAnchor.Sdk.Model;

namespace Example
{
    public class ApiV1CustomersCustomerIdGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: apikeyAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new CustomersApi();
            var customerId = customerId_example;  // string | 
            var xAnchorKey = xAnchorKey_example;  // string |  (optional) 

            try
            {
                // Fetch Customer
                Object result = apiInstance.ApiV1CustomersCustomerIdGet(customerId, xAnchorKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomersApi.ApiV1CustomersCustomerIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerId** | **string**|  | 
 **xAnchorKey** | **string**|  | [optional] 

### Return type

**Object**

### Authorization

[apikeyAuth](../README.md#apikeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiv1customersget"></a>
# **ApiV1CustomersGet**
> Object ApiV1CustomersGet (string type = null, string page = null, int? size = null)

List Customers

### Example
```csharp
using System;
using System.Diagnostics;
using Co.GetAnchor.Sdk.Api;
using Co.GetAnchor.Sdk.Client;
using Co.GetAnchor.Sdk.Model;

namespace Example
{
    public class ApiV1CustomersGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: apikeyAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new CustomersApi();
            var type = type_example;  // string |  (optional) 
            var page = page_example;  // string |  (optional) 
            var size = 56;  // int? |  (optional) 

            try
            {
                // List Customers
                Object result = apiInstance.ApiV1CustomersGet(type, page, size);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomersApi.ApiV1CustomersGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **string**|  | [optional] 
 **page** | **string**|  | [optional] 
 **size** | **int?**|  | [optional] 

### Return type

**Object**

### Authorization

[apikeyAuth](../README.md#apikeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiv1customerspost"></a>
# **ApiV1CustomersPost**
> Object ApiV1CustomersPost (Object body = null, string contentType = null, string xAnchorKey = null)

Create Customer

### Example
```csharp
using System;
using System.Diagnostics;
using Co.GetAnchor.Sdk.Api;
using Co.GetAnchor.Sdk.Client;
using Co.GetAnchor.Sdk.Model;

namespace Example
{
    public class ApiV1CustomersPostExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: apikeyAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new CustomersApi();
            var body = new Object(); // Object |  (optional) 
            var contentType = contentType_example;  // string |  (optional) 
            var xAnchorKey = xAnchorKey_example;  // string |  (optional) 

            try
            {
                // Create Customer
                Object result = apiInstance.ApiV1CustomersPost(body, contentType, xAnchorKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomersApi.ApiV1CustomersPost: " + e.Message );
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
 **xAnchorKey** | **string**|  | [optional] 

### Return type

**Object**

### Authorization

[apikeyAuth](../README.md#apikeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiv1customersupdatecustomeridput"></a>
# **ApiV1CustomersUpdateCustomerIdPut**
> void ApiV1CustomersUpdateCustomerIdPut (string customerId, Object body = null, string contentType = null, string xAnchorKey = null)

Update Business Customer

### Example
```csharp
using System;
using System.Diagnostics;
using Co.GetAnchor.Sdk.Api;
using Co.GetAnchor.Sdk.Client;
using Co.GetAnchor.Sdk.Model;

namespace Example
{
    public class ApiV1CustomersUpdateCustomerIdPutExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: apikeyAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new CustomersApi();
            var customerId = customerId_example;  // string | 
            var body = new Object(); // Object |  (optional) 
            var contentType = contentType_example;  // string |  (optional) 
            var xAnchorKey = xAnchorKey_example;  // string |  (optional) 

            try
            {
                // Update Business Customer
                apiInstance.ApiV1CustomersUpdateCustomerIdPut(customerId, body, contentType, xAnchorKey);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomersApi.ApiV1CustomersUpdateCustomerIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerId** | **string**|  | 
 **body** | [**Object**](Object.md)|  | [optional] 
 **contentType** | **string**|  | [optional] 
 **xAnchorKey** | **string**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[apikeyAuth](../README.md#apikeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
