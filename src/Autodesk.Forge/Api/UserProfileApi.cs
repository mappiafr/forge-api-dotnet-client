/* 
 * Forge SDK
 *
 * The Forge Platform contains an expanding collection of web service components that can be used with Autodesk cloud-based products or your own technologies. Take advantage of Autodesk’s expertise in design and engineering.
 *
 * OpenAPI spec version: 0.1.0
 * Contact: forge.help@autodesk.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using Newtonsoft.Json.Linq;
using Autodesk.Forge.Client;
using Autodesk.Forge.Model;
using Version=Autodesk.Forge.Model.Version;

namespace Autodesk.Forge
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IUserProfileApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Returns the profile information of an authorizing end user.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Autodesk.Forge.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>UserProfile</returns>
        /*UserProfile*/dynamic GetUserProfile ();

        /// <summary>
        /// Returns the profile information of an authorizing end user.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Autodesk.Forge.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of UserProfile</returns>
        ApiResponse</*UserProfile*/dynamic> GetUserProfileWithHttpInfo ();
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Returns the profile information of an authorizing end user.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Autodesk.Forge.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of UserProfile</returns>
        System.Threading.Tasks.Task</*UserProfile*/dynamic> GetUserProfileAsync ();

        /// <summary>
        /// Returns the profile information of an authorizing end user.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Autodesk.Forge.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (UserProfile)</returns>
        System.Threading.Tasks.Task<ApiResponse</*UserProfile*/dynamic>> GetUserProfileAsyncWithHttpInfo ();
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class UserProfileApi : IUserProfileApi
    {
        private Autodesk.Forge.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserProfileApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UserProfileApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            ExceptionFactory = Autodesk.Forge.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserProfileApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public UserProfileApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = Autodesk.Forge.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.Options.BaseUrl.ToString();
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
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Autodesk.Forge.Client.ExceptionFactory ExceptionFactory
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
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
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
        /// Returns the profile information of an authorizing end user. 
        /// </summary>
        /// <exception cref="Autodesk.Forge.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>UserProfile</returns>
        public /*UserProfile*/dynamic GetUserProfile ()
        {
             ApiResponse</*UserProfile*/dynamic> localVarResponse = GetUserProfileWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Returns the profile information of an authorizing end user. 
        /// </summary>
        /// <exception cref="Autodesk.Forge.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of UserProfile</returns>
        public ApiResponse< /*UserProfile*/dynamic > GetUserProfileWithHttpInfo ()
        {

            var localVarPath = "/userprofile/v1/users/@me";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/vnd.api+json", 
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // authentication (oauth2_access_code) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetUserProfile", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse</*UserProfile*/dynamic>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                /*(UserProfile)*/ Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserProfile)));
            
        }

        /// <summary>
        /// Returns the profile information of an authorizing end user. 
        /// </summary>
        /// <exception cref="Autodesk.Forge.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of UserProfile</returns>
        public async System.Threading.Tasks.Task</*UserProfile*/dynamic> GetUserProfileAsync ()
        {
             ApiResponse</*UserProfile*/dynamic> localVarResponse = await GetUserProfileAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Returns the profile information of an authorizing end user. 
        /// </summary>
        /// <exception cref="Autodesk.Forge.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (UserProfile)</returns>
        public async System.Threading.Tasks.Task<ApiResponse</*UserProfile*/dynamic>> GetUserProfileAsyncWithHttpInfo ()
        {

            var localVarPath = "/userprofile/v1/users/@me";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/vnd.api+json", 
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // authentication (oauth2_access_code) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetUserProfile", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse</*UserProfile*/dynamic>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                /*(UserProfile)*/ Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserProfile)));
            
        }

    }
}
