# Co.GetAnchor.Sdk.Api.EventApi

All URIs are relative to *http://{{baseurl}}*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiV1EventsEventIdGet**](EventApi.md#apiv1eventseventidget) | **GET** /api/v1/events/{eventId} | Fetch Event
[**ApiV1EventsGet**](EventApi.md#apiv1eventsget) | **GET** /api/v1/events | List Event

<a name="apiv1eventseventidget"></a>
# **ApiV1EventsEventIdGet**
> Object ApiV1EventsEventIdGet (string eventId)

Fetch Event

### Example
```csharp
using System;
using System.Diagnostics;
using Co.GetAnchor.Sdk.Api;
using Co.GetAnchor.Sdk.Client;
using Co.GetAnchor.Sdk.Model;

namespace Example
{
    public class ApiV1EventsEventIdGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: apikeyAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new EventApi();
            var eventId = eventId_example;  // string | 

            try
            {
                // Fetch Event
                Object result = apiInstance.ApiV1EventsEventIdGet(eventId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EventApi.ApiV1EventsEventIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventId** | **string**|  | 

### Return type

**Object**

### Authorization

[apikeyAuth](../README.md#apikeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiv1eventsget"></a>
# **ApiV1EventsGet**
> Object ApiV1EventsGet (int? size = null, string type = null, int? page = null)

List Event

### Example
```csharp
using System;
using System.Diagnostics;
using Co.GetAnchor.Sdk.Api;
using Co.GetAnchor.Sdk.Client;
using Co.GetAnchor.Sdk.Model;

namespace Example
{
    public class ApiV1EventsGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: apikeyAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new EventApi();
            var size = 56;  // int? |  (optional) 
            var type = type_example;  // string |  (optional) 
            var page = 56;  // int? |  (optional) 

            try
            {
                // List Event
                Object result = apiInstance.ApiV1EventsGet(size, type, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EventApi.ApiV1EventsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **size** | **int?**|  | [optional] 
 **type** | **string**|  | [optional] 
 **page** | **int?**|  | [optional] 

### Return type

**Object**

### Authorization

[apikeyAuth](../README.md#apikeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
