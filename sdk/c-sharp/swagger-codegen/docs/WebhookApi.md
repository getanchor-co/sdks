# Co.GetAnchor.Sdk.Api.WebhookApi

All URIs are relative to *http://{{baseurl}}*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiV1WebhooksGet**](WebhookApi.md#apiv1webhooksget) | **GET** /api/v1/webhooks | List Webhooks
[**ApiV1WebhooksPost**](WebhookApi.md#apiv1webhookspost) | **POST** /api/v1/webhooks | Create Webhook
[**ApiV1WebhooksWebhookIdGet**](WebhookApi.md#apiv1webhookswebhookidget) | **GET** /api/v1/webhooks/{webhookId} | Fetch Webhook

<a name="apiv1webhooksget"></a>
# **ApiV1WebhooksGet**
> Object ApiV1WebhooksGet (string page = null, string size = null)

List Webhooks

### Example
```csharp
using System;
using System.Diagnostics;
using Co.GetAnchor.Sdk.Api;
using Co.GetAnchor.Sdk.Client;
using Co.GetAnchor.Sdk.Model;

namespace Example
{
    public class ApiV1WebhooksGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: apikeyAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new WebhookApi();
            var page = page_example;  // string |  (optional) 
            var size = size_example;  // string |  (optional) 

            try
            {
                // List Webhooks
                Object result = apiInstance.ApiV1WebhooksGet(page, size);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhookApi.ApiV1WebhooksGet: " + e.Message );
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

### Return type

**Object**

### Authorization

[apikeyAuth](../README.md#apikeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiv1webhookspost"></a>
# **ApiV1WebhooksPost**
> Object ApiV1WebhooksPost (Object body = null)

Create Webhook

### Example
```csharp
using System;
using System.Diagnostics;
using Co.GetAnchor.Sdk.Api;
using Co.GetAnchor.Sdk.Client;
using Co.GetAnchor.Sdk.Model;

namespace Example
{
    public class ApiV1WebhooksPostExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: apikeyAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new WebhookApi();
            var body = new Object(); // Object |  (optional) 

            try
            {
                // Create Webhook
                Object result = apiInstance.ApiV1WebhooksPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhookApi.ApiV1WebhooksPost: " + e.Message );
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
<a name="apiv1webhookswebhookidget"></a>
# **ApiV1WebhooksWebhookIdGet**
> Object ApiV1WebhooksWebhookIdGet (string webhookId)

Fetch Webhook

### Example
```csharp
using System;
using System.Diagnostics;
using Co.GetAnchor.Sdk.Api;
using Co.GetAnchor.Sdk.Client;
using Co.GetAnchor.Sdk.Model;

namespace Example
{
    public class ApiV1WebhooksWebhookIdGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: apikeyAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new WebhookApi();
            var webhookId = webhookId_example;  // string | 

            try
            {
                // Fetch Webhook
                Object result = apiInstance.ApiV1WebhooksWebhookIdGet(webhookId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhookApi.ApiV1WebhooksWebhookIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **webhookId** | **string**|  | 

### Return type

**Object**

### Authorization

[apikeyAuth](../README.md#apikeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
