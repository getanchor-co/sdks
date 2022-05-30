# Co.GetAnchor.Sdk.Api.TransactionsApi

All URIs are relative to *http://{{baseurl}}*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiV1TransactionsGet**](TransactionsApi.md#apiv1transactionsget) | **GET** /api/v1/transactions | List Transactions.
[**ApiV1TransactionsTransactionIdGet**](TransactionsApi.md#apiv1transactionstransactionidget) | **GET** /api/v1/transactions/{transactionId} | Fetch Transaction

<a name="apiv1transactionsget"></a>
# **ApiV1TransactionsGet**
> void ApiV1TransactionsGet (string page = null, string size = null, string accountId = null, string customerId = null, string type = null, string from = null, string to = null)

List Transactions.

### Example
```csharp
using System;
using System.Diagnostics;
using Co.GetAnchor.Sdk.Api;
using Co.GetAnchor.Sdk.Client;
using Co.GetAnchor.Sdk.Model;

namespace Example
{
    public class ApiV1TransactionsGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: apikeyAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TransactionsApi();
            var page = page_example;  // string |  (optional) 
            var size = size_example;  // string |  (optional) 
            var accountId = accountId_example;  // string |  (optional) 
            var customerId = customerId_example;  // string |  (optional) 
            var type = type_example;  // string |  (optional) 
            var from = from_example;  // string |  (optional) 
            var to = to_example;  // string |  (optional) 

            try
            {
                // List Transactions.
                apiInstance.ApiV1TransactionsGet(page, size, accountId, customerId, type, from, to);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionsApi.ApiV1TransactionsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **string**|  | [optional] 
 **size** | **string**|  | [optional] 
 **accountId** | **string**|  | [optional] 
 **customerId** | **string**|  | [optional] 
 **type** | **string**|  | [optional] 
 **from** | **string**|  | [optional] 
 **to** | **string**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[apikeyAuth](../README.md#apikeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiv1transactionstransactionidget"></a>
# **ApiV1TransactionsTransactionIdGet**
> void ApiV1TransactionsTransactionIdGet (string transactionId)

Fetch Transaction

### Example
```csharp
using System;
using System.Diagnostics;
using Co.GetAnchor.Sdk.Api;
using Co.GetAnchor.Sdk.Client;
using Co.GetAnchor.Sdk.Model;

namespace Example
{
    public class ApiV1TransactionsTransactionIdGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: apikeyAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TransactionsApi();
            var transactionId = transactionId_example;  // string | 

            try
            {
                // Fetch Transaction
                apiInstance.ApiV1TransactionsTransactionIdGet(transactionId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionsApi.ApiV1TransactionsTransactionIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **transactionId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[apikeyAuth](../README.md#apikeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
