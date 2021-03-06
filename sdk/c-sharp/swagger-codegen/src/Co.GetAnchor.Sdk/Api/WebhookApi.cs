/* 
 * Anchor API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using Co.GetAnchor.Sdk.Client;

namespace Co.GetAnchor.Sdk.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public interface IWebhookApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// List Webhooks
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Co.GetAnchor.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page"> (optional)</param>
        /// <param name="size"> (optional)</param>
        /// <returns>Object</returns>
        Object ApiV1WebhooksGet (string page = null, string size = null);

        /// <summary>
        /// List Webhooks
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Co.GetAnchor.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page"> (optional)</param>
        /// <param name="size"> (optional)</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> ApiV1WebhooksGetWithHttpInfo (string page = null, string size = null);
        /// <summary>
        /// Create Webhook
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Co.GetAnchor.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Object</returns>
        Object ApiV1WebhooksPost (Object body = null);

        /// <summary>
        /// Create Webhook
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Co.GetAnchor.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> ApiV1WebhooksPostWithHttpInfo (Object body = null);
        /// <summary>
        /// Fetch Webhook
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Co.GetAnchor.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="webhookId"></param>
        /// <returns>Object</returns>
        Object ApiV1WebhooksWebhookIdGet (string webhookId);

        /// <summary>
        /// Fetch Webhook
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Co.GetAnchor.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="webhookId"></param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> ApiV1WebhooksWebhookIdGetWithHttpInfo (string webhookId);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// List Webhooks
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Co.GetAnchor.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page"> (optional)</param>
        /// <param name="size"> (optional)</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> ApiV1WebhooksGetAsync (string page = null, string size = null);

        /// <summary>
        /// List Webhooks
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Co.GetAnchor.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page"> (optional)</param>
        /// <param name="size"> (optional)</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ApiV1WebhooksGetAsyncWithHttpInfo (string page = null, string size = null);
        /// <summary>
        /// Create Webhook
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Co.GetAnchor.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> ApiV1WebhooksPostAsync (Object body = null);

        /// <summary>
        /// Create Webhook
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Co.GetAnchor.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ApiV1WebhooksPostAsyncWithHttpInfo (Object body = null);
        /// <summary>
        /// Fetch Webhook
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Co.GetAnchor.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="webhookId"></param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> ApiV1WebhooksWebhookIdGetAsync (string webhookId);

        /// <summary>
        /// Fetch Webhook
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Co.GetAnchor.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="webhookId"></param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ApiV1WebhooksWebhookIdGetAsyncWithHttpInfo (string webhookId);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public partial class WebhookApi : IWebhookApi
    {
        private Co.GetAnchor.Sdk.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookApi"/> class.
        /// </summary>
        /// <returns></returns>
        public WebhookApi(String basePath)
        {
            this.Configuration = new Co.GetAnchor.Sdk.Client.Configuration { BasePath = basePath };

            ExceptionFactory = Co.GetAnchor.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookApi"/> class
        /// </summary>
        /// <returns></returns>
        public WebhookApi()
        {
            this.Configuration = Co.GetAnchor.Sdk.Client.Configuration.Default;

            ExceptionFactory = Co.GetAnchor.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public WebhookApi(Co.GetAnchor.Sdk.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Co.GetAnchor.Sdk.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = Co.GetAnchor.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Co.GetAnchor.Sdk.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Co.GetAnchor.Sdk.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// List Webhooks 
        /// </summary>
        /// <exception cref="Co.GetAnchor.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page"> (optional)</param>
        /// <param name="size"> (optional)</param>
        /// <returns>Object</returns>
        public Object ApiV1WebhooksGet (string page = null, string size = null)
        {
             ApiResponse<Object> localVarResponse = ApiV1WebhooksGetWithHttpInfo(page, size);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List Webhooks 
        /// </summary>
        /// <exception cref="Co.GetAnchor.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page"> (optional)</param>
        /// <param name="size"> (optional)</param>
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > ApiV1WebhooksGetWithHttpInfo (string page = null, string size = null)
        {

            var localVarPath = "/api/v1/webhooks";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (page != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter
            if (size != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "size", size)); // query parameter
            // authentication (apikeyAuth) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(this.Configuration.Username) || !String.IsNullOrEmpty(this.Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password);
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ApiV1WebhooksGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Object) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
        }

        /// <summary>
        /// List Webhooks 
        /// </summary>
        /// <exception cref="Co.GetAnchor.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page"> (optional)</param>
        /// <param name="size"> (optional)</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> ApiV1WebhooksGetAsync (string page = null, string size = null)
        {
             ApiResponse<Object> localVarResponse = await ApiV1WebhooksGetAsyncWithHttpInfo(page, size);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List Webhooks 
        /// </summary>
        /// <exception cref="Co.GetAnchor.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page"> (optional)</param>
        /// <param name="size"> (optional)</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> ApiV1WebhooksGetAsyncWithHttpInfo (string page = null, string size = null)
        {

            var localVarPath = "/api/v1/webhooks";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (page != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter
            if (size != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "size", size)); // query parameter
            // authentication (apikeyAuth) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(this.Configuration.Username) || !String.IsNullOrEmpty(this.Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password);
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ApiV1WebhooksGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Object) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
        }

        /// <summary>
        /// Create Webhook 
        /// </summary>
        /// <exception cref="Co.GetAnchor.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Object</returns>
        public Object ApiV1WebhooksPost (Object body = null)
        {
             ApiResponse<Object> localVarResponse = ApiV1WebhooksPostWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create Webhook 
        /// </summary>
        /// <exception cref="Co.GetAnchor.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > ApiV1WebhooksPostWithHttpInfo (Object body = null)
        {

            var localVarPath = "/api/v1/webhooks";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
            // authentication (apikeyAuth) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(this.Configuration.Username) || !String.IsNullOrEmpty(this.Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password);
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ApiV1WebhooksPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Object) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
        }

        /// <summary>
        /// Create Webhook 
        /// </summary>
        /// <exception cref="Co.GetAnchor.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> ApiV1WebhooksPostAsync (Object body = null)
        {
             ApiResponse<Object> localVarResponse = await ApiV1WebhooksPostAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create Webhook 
        /// </summary>
        /// <exception cref="Co.GetAnchor.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> ApiV1WebhooksPostAsyncWithHttpInfo (Object body = null)
        {

            var localVarPath = "/api/v1/webhooks";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
            // authentication (apikeyAuth) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(this.Configuration.Username) || !String.IsNullOrEmpty(this.Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password);
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ApiV1WebhooksPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Object) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
        }

        /// <summary>
        /// Fetch Webhook 
        /// </summary>
        /// <exception cref="Co.GetAnchor.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="webhookId"></param>
        /// <returns>Object</returns>
        public Object ApiV1WebhooksWebhookIdGet (string webhookId)
        {
             ApiResponse<Object> localVarResponse = ApiV1WebhooksWebhookIdGetWithHttpInfo(webhookId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Fetch Webhook 
        /// </summary>
        /// <exception cref="Co.GetAnchor.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="webhookId"></param>
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > ApiV1WebhooksWebhookIdGetWithHttpInfo (string webhookId)
        {
            // verify the required parameter 'webhookId' is set
            if (webhookId == null)
                throw new ApiException(400, "Missing required parameter 'webhookId' when calling WebhookApi->ApiV1WebhooksWebhookIdGet");

            var localVarPath = "/api/v1/webhooks/{webhookId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (webhookId != null) localVarPathParams.Add("webhookId", this.Configuration.ApiClient.ParameterToString(webhookId)); // path parameter
            // authentication (apikeyAuth) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(this.Configuration.Username) || !String.IsNullOrEmpty(this.Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password);
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ApiV1WebhooksWebhookIdGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Object) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
        }

        /// <summary>
        /// Fetch Webhook 
        /// </summary>
        /// <exception cref="Co.GetAnchor.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="webhookId"></param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> ApiV1WebhooksWebhookIdGetAsync (string webhookId)
        {
             ApiResponse<Object> localVarResponse = await ApiV1WebhooksWebhookIdGetAsyncWithHttpInfo(webhookId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Fetch Webhook 
        /// </summary>
        /// <exception cref="Co.GetAnchor.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="webhookId"></param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> ApiV1WebhooksWebhookIdGetAsyncWithHttpInfo (string webhookId)
        {
            // verify the required parameter 'webhookId' is set
            if (webhookId == null)
                throw new ApiException(400, "Missing required parameter 'webhookId' when calling WebhookApi->ApiV1WebhooksWebhookIdGet");

            var localVarPath = "/api/v1/webhooks/{webhookId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (webhookId != null) localVarPathParams.Add("webhookId", this.Configuration.ApiClient.ParameterToString(webhookId)); // path parameter
            // authentication (apikeyAuth) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(this.Configuration.Username) || !String.IsNullOrEmpty(this.Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password);
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ApiV1WebhooksWebhookIdGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Object) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
        }

    }
}
