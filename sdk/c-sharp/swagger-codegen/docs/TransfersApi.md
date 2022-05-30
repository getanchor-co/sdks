# Co.GetAnchor.Sdk.Api.TransfersApi

All URIs are relative to *http://{{baseurl}}*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiV1TransfersGet**](TransfersApi.md#apiv1transfersget) | **GET** /api/v1/transfers | List Transfers
[**ApiV1TransfersIdGet**](TransfersApi.md#apiv1transfersidget) | **GET** /api/v1/transfers/{id} | Fetch Transfer
[**ApiV1TransfersPost**](TransfersApi.md#apiv1transferspost) | **POST** /api/v1/transfers | Initiate Transfer

<a name="apiv1transfersget"></a>
# **ApiV1TransfersGet**
> Object ApiV1TransfersGet (string type = null, string customerId = null, string accountId = null, string destinationAccountId = null, string from = null, string to = null, int? page = null, int? size = null)

List Transfers

### Example
```csharp
using System;
using System.Diagnostics;
using Co.GetAnchor.Sdk.Api;
using Co.GetAnchor.Sdk.Client;
using Co.GetAnchor.Sdk.Model;

namespace Example
{
    public class ApiV1TransfersGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: apikeyAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TransfersApi();
            var type = type_example;  // string | filter by type of transfer can be BOOK_TRANSFER, NIP_TRANSFER OR INCOMING_TRANSFER (optional) 
            var customerId = customerId_example;  // string | filter by customerId (optional) 
            var accountId = accountId_example;  // string | filter by accountId (optional) 
            var destinationAccountId = destinationAccountId_example;  // string | filter by counterpartyId (optional) 
            var from = from_example;  // string | filter by start date (optional) 
            var to = to_example;  // string | filter by end date (optional) 
            var page = 56;  // int? | page no  (optional) 
            var size = 56;  // int? | page size (optional) 

            try
            {
                // List Transfers
                Object result = apiInstance.ApiV1TransfersGet(type, customerId, accountId, destinationAccountId, from, to, page, size);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransfersApi.ApiV1TransfersGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **string**| filter by type of transfer can be BOOK_TRANSFER, NIP_TRANSFER OR INCOMING_TRANSFER | [optional] 
 **customerId** | **string**| filter by customerId | [optional] 
 **accountId** | **string**| filter by accountId | [optional] 
 **destinationAccountId** | **string**| filter by counterpartyId | [optional] 
 **from** | **string**| filter by start date | [optional] 
 **to** | **string**| filter by end date | [optional] 
 **page** | **int?**| page no  | [optional] 
 **size** | **int?**| page size | [optional] 

### Return type

**Object**

### Authorization

[apikeyAuth](../README.md#apikeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiv1transfersidget"></a>
# **ApiV1TransfersIdGet**
> Object ApiV1TransfersIdGet (string id)

Fetch Transfer

### Example
```csharp
using System;
using System.Diagnostics;
using Co.GetAnchor.Sdk.Api;
using Co.GetAnchor.Sdk.Client;
using Co.GetAnchor.Sdk.Model;

namespace Example
{
    public class ApiV1TransfersIdGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: apikeyAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TransfersApi();
            var id = id_example;  // string | 

            try
            {
                // Fetch Transfer
                Object result = apiInstance.ApiV1TransfersIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransfersApi.ApiV1TransfersIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 

### Return type

**Object**

### Authorization

[apikeyAuth](../README.md#apikeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiv1transferspost"></a>
# **ApiV1TransfersPost**
> Object ApiV1TransfersPost (Object body = null, string contentType = null)

Initiate Transfer

### Example
```csharp
using System;
using System.Diagnostics;
using Co.GetAnchor.Sdk.Api;
using Co.GetAnchor.Sdk.Client;
using Co.GetAnchor.Sdk.Model;

namespace Example
{
    public class ApiV1TransfersPostExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: apikeyAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TransfersApi();
            var body = new Object(); // Object |  (optional) 
            var contentType = contentType_example;  // string |  (optional) 

            try
            {
                // Initiate Transfer
                Object result = apiInstance.ApiV1TransfersPost(body, contentType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransfersApi.ApiV1TransfersPost: " + e.Message );
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
