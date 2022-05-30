# Co.GetAnchor.Sdk.Api.CustomersDocumentsApi

All URIs are relative to *http://{{baseurl}}*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiV1DocumentsCustomerIdDocumentIdGet**](CustomersDocumentsApi.md#apiv1documentscustomeriddocumentidget) | **GET** /api/v1/documents/{customerId}/{documentId} | Fetch Customer Document By DocumentId
[**ApiV1DocumentsCustomerIdGet**](CustomersDocumentsApi.md#apiv1documentscustomeridget) | **GET** /api/v1/documents/{customerId} | List Customer Documents
[**ApiV1DocumentsDownloadDocumentCustomerIdDocumentIdGet**](CustomersDocumentsApi.md#apiv1documentsdownloaddocumentcustomeriddocumentidget) | **GET** /api/v1/documents/download-document/{customerId}/{documentId} | Download Document
[**ApiV1DocumentsUploadDocumentCustomerIdDocumentIdPost**](CustomersDocumentsApi.md#apiv1documentsuploaddocumentcustomeriddocumentidpost) | **POST** /api/v1/documents/upload-document/{customerId}/{documentId} | Upload Document

<a name="apiv1documentscustomeriddocumentidget"></a>
# **ApiV1DocumentsCustomerIdDocumentIdGet**
> Object ApiV1DocumentsCustomerIdDocumentIdGet (string customerId, string documentId)

Fetch Customer Document By DocumentId

### Example
```csharp
using System;
using System.Diagnostics;
using Co.GetAnchor.Sdk.Api;
using Co.GetAnchor.Sdk.Client;
using Co.GetAnchor.Sdk.Model;

namespace Example
{
    public class ApiV1DocumentsCustomerIdDocumentIdGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: apikeyAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new CustomersDocumentsApi();
            var customerId = customerId_example;  // string | 
            var documentId = documentId_example;  // string | 

            try
            {
                // Fetch Customer Document By DocumentId
                Object result = apiInstance.ApiV1DocumentsCustomerIdDocumentIdGet(customerId, documentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomersDocumentsApi.ApiV1DocumentsCustomerIdDocumentIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerId** | **string**|  | 
 **documentId** | **string**|  | 

### Return type

**Object**

### Authorization

[apikeyAuth](../README.md#apikeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiv1documentscustomeridget"></a>
# **ApiV1DocumentsCustomerIdGet**
> Object ApiV1DocumentsCustomerIdGet (string customerId)

List Customer Documents

### Example
```csharp
using System;
using System.Diagnostics;
using Co.GetAnchor.Sdk.Api;
using Co.GetAnchor.Sdk.Client;
using Co.GetAnchor.Sdk.Model;

namespace Example
{
    public class ApiV1DocumentsCustomerIdGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: apikeyAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new CustomersDocumentsApi();
            var customerId = customerId_example;  // string | 

            try
            {
                // List Customer Documents
                Object result = apiInstance.ApiV1DocumentsCustomerIdGet(customerId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomersDocumentsApi.ApiV1DocumentsCustomerIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerId** | **string**|  | 

### Return type

**Object**

### Authorization

[apikeyAuth](../README.md#apikeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiv1documentsdownloaddocumentcustomeriddocumentidget"></a>
# **ApiV1DocumentsDownloadDocumentCustomerIdDocumentIdGet**
> Object ApiV1DocumentsDownloadDocumentCustomerIdDocumentIdGet (string customerId, string documentId)

Download Document

### Example
```csharp
using System;
using System.Diagnostics;
using Co.GetAnchor.Sdk.Api;
using Co.GetAnchor.Sdk.Client;
using Co.GetAnchor.Sdk.Model;

namespace Example
{
    public class ApiV1DocumentsDownloadDocumentCustomerIdDocumentIdGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: apikeyAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new CustomersDocumentsApi();
            var customerId = customerId_example;  // string | 
            var documentId = documentId_example;  // string | 

            try
            {
                // Download Document
                Object result = apiInstance.ApiV1DocumentsDownloadDocumentCustomerIdDocumentIdGet(customerId, documentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomersDocumentsApi.ApiV1DocumentsDownloadDocumentCustomerIdDocumentIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerId** | **string**|  | 
 **documentId** | **string**|  | 

### Return type

**Object**

### Authorization

[apikeyAuth](../README.md#apikeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiv1documentsuploaddocumentcustomeriddocumentidpost"></a>
# **ApiV1DocumentsUploadDocumentCustomerIdDocumentIdPost**
> void ApiV1DocumentsUploadDocumentCustomerIdDocumentIdPost (string customerId, string documentId, byte[] fileData = null, string textData = null)

Upload Document

### Example
```csharp
using System;
using System.Diagnostics;
using Co.GetAnchor.Sdk.Api;
using Co.GetAnchor.Sdk.Client;
using Co.GetAnchor.Sdk.Model;

namespace Example
{
    public class ApiV1DocumentsUploadDocumentCustomerIdDocumentIdPostExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: apikeyAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new CustomersDocumentsApi();
            var customerId = customerId_example;  // string | 
            var documentId = documentId_example;  // string | 
            var fileData = fileData_example;  // byte[] |  (optional) 
            var textData = textData_example;  // string |  (optional) 

            try
            {
                // Upload Document
                apiInstance.ApiV1DocumentsUploadDocumentCustomerIdDocumentIdPost(customerId, documentId, fileData, textData);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomersDocumentsApi.ApiV1DocumentsUploadDocumentCustomerIdDocumentIdPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerId** | **string**|  | 
 **documentId** | **string**|  | 
 **fileData** | **byte[]****byte[]**|  | [optional] 
 **textData** | **string**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[apikeyAuth](../README.md#apikeyAuth)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
