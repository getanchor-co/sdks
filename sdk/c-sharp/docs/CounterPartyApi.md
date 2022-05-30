# Co.GetAnchor.Sdk.Api.CounterPartyApi

All URIs are relative to *http://{{baseurl}}*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiV1BanksGet**](CounterPartyApi.md#apiv1banksget) | **GET** /api/v1/banks | List Banks
[**ApiV1CounterpartiesCounterpartyidGet**](CounterPartyApi.md#apiv1counterpartiescounterpartyidget) | **GET** /api/v1/counterparties/{counterpartyid} | Fetch Counter Party Copy
[**ApiV1CounterpartiesGet**](CounterPartyApi.md#apiv1counterpartiesget) | **GET** /api/v1/counterparties | List Counter Party
[**ApiV1CounterpartiesPost**](CounterPartyApi.md#apiv1counterpartiespost) | **POST** /api/v1/counterparties | Create Counter Party
[**ApiV1PaymentsVerifyAccountBankIdAccountNumberGet**](CounterPartyApi.md#apiv1paymentsverifyaccountbankidaccountnumberget) | **GET** /api/v1/payments/verify-account/{bankId}/{accountNumber} | Verify Account

<a name="apiv1banksget"></a>
# **ApiV1BanksGet**
> Object ApiV1BanksGet (string xAnchorKey = null)

List Banks

### Example
```csharp
using System;
using System.Diagnostics;
using Co.GetAnchor.Sdk.Api;
using Co.GetAnchor.Sdk.Client;
using Co.GetAnchor.Sdk.Model;

namespace Example
{
    public class ApiV1BanksGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: apikeyAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new CounterPartyApi();
            var xAnchorKey = xAnchorKey_example;  // string |  (optional) 

            try
            {
                // List Banks
                Object result = apiInstance.ApiV1BanksGet(xAnchorKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CounterPartyApi.ApiV1BanksGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **xAnchorKey** | **string**|  | [optional] 

### Return type

**Object**

### Authorization

[apikeyAuth](../README.md#apikeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiv1counterpartiescounterpartyidget"></a>
# **ApiV1CounterpartiesCounterpartyidGet**
> Object ApiV1CounterpartiesCounterpartyidGet (string counterpartyid)

Fetch Counter Party Copy

### Example
```csharp
using System;
using System.Diagnostics;
using Co.GetAnchor.Sdk.Api;
using Co.GetAnchor.Sdk.Client;
using Co.GetAnchor.Sdk.Model;

namespace Example
{
    public class ApiV1CounterpartiesCounterpartyidGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: apikeyAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new CounterPartyApi();
            var counterpartyid = counterpartyid_example;  // string | 

            try
            {
                // Fetch Counter Party Copy
                Object result = apiInstance.ApiV1CounterpartiesCounterpartyidGet(counterpartyid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CounterPartyApi.ApiV1CounterpartiesCounterpartyidGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **counterpartyid** | **string**|  | 

### Return type

**Object**

### Authorization

[apikeyAuth](../README.md#apikeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiv1counterpartiesget"></a>
# **ApiV1CounterpartiesGet**
> Object ApiV1CounterpartiesGet (string page = null, string size = null)

List Counter Party

### Example
```csharp
using System;
using System.Diagnostics;
using Co.GetAnchor.Sdk.Api;
using Co.GetAnchor.Sdk.Client;
using Co.GetAnchor.Sdk.Model;

namespace Example
{
    public class ApiV1CounterpartiesGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: apikeyAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new CounterPartyApi();
            var page = page_example;  // string |  (optional) 
            var size = size_example;  // string |  (optional) 

            try
            {
                // List Counter Party
                Object result = apiInstance.ApiV1CounterpartiesGet(page, size);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CounterPartyApi.ApiV1CounterpartiesGet: " + e.Message );
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
<a name="apiv1counterpartiespost"></a>
# **ApiV1CounterpartiesPost**
> Object ApiV1CounterpartiesPost (Object body = null)

Create Counter Party

### Example
```csharp
using System;
using System.Diagnostics;
using Co.GetAnchor.Sdk.Api;
using Co.GetAnchor.Sdk.Client;
using Co.GetAnchor.Sdk.Model;

namespace Example
{
    public class ApiV1CounterpartiesPostExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: apikeyAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new CounterPartyApi();
            var body = new Object(); // Object |  (optional) 

            try
            {
                // Create Counter Party
                Object result = apiInstance.ApiV1CounterpartiesPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CounterPartyApi.ApiV1CounterpartiesPost: " + e.Message );
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
<a name="apiv1paymentsverifyaccountbankidaccountnumberget"></a>
# **ApiV1PaymentsVerifyAccountBankIdAccountNumberGet**
> Object ApiV1PaymentsVerifyAccountBankIdAccountNumberGet (string bankId, int? accountNumber)

Verify Account

### Example
```csharp
using System;
using System.Diagnostics;
using Co.GetAnchor.Sdk.Api;
using Co.GetAnchor.Sdk.Client;
using Co.GetAnchor.Sdk.Model;

namespace Example
{
    public class ApiV1PaymentsVerifyAccountBankIdAccountNumberGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: apikeyAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new CounterPartyApi();
            var bankId = bankId_example;  // string | 
            var accountNumber = 56;  // int? | 

            try
            {
                // Verify Account
                Object result = apiInstance.ApiV1PaymentsVerifyAccountBankIdAccountNumberGet(bankId, accountNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CounterPartyApi.ApiV1PaymentsVerifyAccountBankIdAccountNumberGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **bankId** | **string**|  | 
 **accountNumber** | **int?**|  | 

### Return type

**Object**

### Authorization

[apikeyAuth](../README.md#apikeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
