
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Hathora.Apps
{
    using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Hathora.Models.Apps;
using Hathora.Models.Shared;
using Hathora.Utils;

    public interface IAppsSDK
    {
        Task<CreateAppResponse> CreateAsync(CreateAppSecurity security, AppConfig? request = null);
        Task<DeleteAppResponse> DeleteAsync(DeleteAppSecurity security, DeleteAppRequest request);
        Task<GetAppInfoResponse> GetAppInfoAsync(GetAppInfoSecurity security, GetAppInfoRequest request);
        Task<GetAppsResponse> GetAppsAsync(GetAppsSecurity security);
        Task<GetBuildInfoResponse> GetBuildInfoAsync(GetBuildInfoSecurity security, GetBuildInfoRequest request);
        Task<GetBuildsResponse> GetBuildsAsync(GetBuildsSecurity security, GetBuildsRequest request);
        Task<UpdateAppResponse> UpdateAsync(UpdateAppSecurity security, UpdateAppRequest? request = null);
    }

    public class AppsSDK: IAppsSDK
    {

        public SDKConfig Config { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "0.0.1";
        private const string _sdkGenVersion = "internal";
        private const string _openapiDocVersion = "0.0.1";
        public Uri ServerUrl { get { return _defaultClient.Client.BaseAddress; } }
        private SpeakeasyHttpClient _defaultClient;
        private SpeakeasyHttpClient _securityClient;

        public AppsSDK(SpeakeasyHttpClient defaultClient, SpeakeasyHttpClient securityClient, SDKConfig config)
        {
            _defaultClient = defaultClient;
            _securityClient = securityClient;
            Config = config;
        }

        
    public async Task<CreateAppResponse> CreateAsync(CreateAppSecurity security, AppConfig? request = null)
    {
        string baseUrl = "";
        var message = AppConfig.BuildHttpRequestMessage("CreateApp", request, baseUrl);
        var client = _defaultClient;
        CreateAppSecurity.Apply(security, message);

        message.Headers.Add("user-agent", $"speakeasy-sdk/{_language} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
        var httpResponseMessage = await client.SendAsync(message);
        var response = new CreateAppResponse
        {
            StatusCode = (int)httpResponseMessage.StatusCode,
            ContentType = httpResponseMessage.Content.Headers.ContentType?.MediaType,
            RawResponse = httpResponseMessage
        };
        if((response.StatusCode == 201))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.Application = JsonConvert.DeserializeObject<Application>(await httpResponseMessage.Content.ReadAsStringAsync(), new FlexibleObjectDeserializer());
            }
            return response;
        }
        if((response.StatusCode == 422))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.CreateApp422ApplicationJSONString = await response.RawResponse.Content.ReadAsStringAsync();
            }
            return response;
        }
        if((response.StatusCode == 500))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.CreateApp500ApplicationJSONString = await response.RawResponse.Content.ReadAsStringAsync();
            }
            return response;
        }
        return response;
    }

        
    public async Task<DeleteAppResponse> DeleteAsync(DeleteAppSecurity security, DeleteAppRequest request)
    {
        string baseUrl = "";
        var message = DeleteAppRequest.BuildHttpRequestMessage("DeleteApp", request, baseUrl);
        var client = _defaultClient;
        DeleteAppSecurity.Apply(security, message);

        message.Headers.Add("user-agent", $"speakeasy-sdk/{_language} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
        var httpResponseMessage = await client.SendAsync(message);
        var response = new DeleteAppResponse
        {
            StatusCode = (int)httpResponseMessage.StatusCode,
            ContentType = httpResponseMessage.Content.Headers.ContentType?.MediaType,
            RawResponse = httpResponseMessage
        };
        if((response.StatusCode == 204))
        {
            return response;
        }
        if((response.StatusCode == 404))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.DeleteApp404ApplicationJSONString = await response.RawResponse.Content.ReadAsStringAsync();
            }
            return response;
        }
        if((response.StatusCode == 500))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.DeleteApp500ApplicationJSONString = await response.RawResponse.Content.ReadAsStringAsync();
            }
            return response;
        }
        return response;
    }

        
    public async Task<GetAppInfoResponse> GetAppInfoAsync(GetAppInfoSecurity security, GetAppInfoRequest request)
    {
        string baseUrl = "";
        var message = GetAppInfoRequest.BuildHttpRequestMessage("GetAppInfo", request, baseUrl);
        var client = _defaultClient;
        GetAppInfoSecurity.Apply(security, message);

        message.Headers.Add("user-agent", $"speakeasy-sdk/{_language} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
        var httpResponseMessage = await client.SendAsync(message);
        var response = new GetAppInfoResponse
        {
            StatusCode = (int)httpResponseMessage.StatusCode,
            ContentType = httpResponseMessage.Content.Headers.ContentType?.MediaType,
            RawResponse = httpResponseMessage
        };
        if((response.StatusCode == 200))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.Application = JsonConvert.DeserializeObject<Application>(await httpResponseMessage.Content.ReadAsStringAsync(), new FlexibleObjectDeserializer());
            }
            return response;
        }
        if((response.StatusCode == 404))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.GetAppInfo404ApplicationJSONString = await response.RawResponse.Content.ReadAsStringAsync();
            }
            return response;
        }
        return response;
    }

        
    public async Task<GetAppsResponse> GetAppsAsync(GetAppsSecurity security)
    {
        string baseUrl = "";
        var message = new HttpRequestMessage(HttpMethod.Get, baseUrl + "/apps/v1/list");
        var client = _defaultClient;
        GetAppsSecurity.Apply(security, message);

        message.Headers.Add("user-agent", $"speakeasy-sdk/{_language} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
        var httpResponseMessage = await client.SendAsync(message);
        var response = new GetAppsResponse
        {
            StatusCode = (int)httpResponseMessage.StatusCode,
            ContentType = httpResponseMessage.Content.Headers.ContentType?.MediaType,
            RawResponse = httpResponseMessage
        };
        if((response.StatusCode == 200))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.ApplicationWithDeployments = JsonConvert.DeserializeObject<List<ApplicationWithDeployment>>(await httpResponseMessage.Content.ReadAsStringAsync(), new FlexibleObjectDeserializer());
            }
            return response;
        }
        return response;
    }

        
    public async Task<GetBuildInfoResponse> GetBuildInfoAsync(GetBuildInfoSecurity security, GetBuildInfoRequest request)
    {
        string baseUrl = "";
        var message = GetBuildInfoRequest.BuildHttpRequestMessage("GetBuildInfo", request, baseUrl);
        var client = _defaultClient;
        GetBuildInfoSecurity.Apply(security, message);

        message.Headers.Add("user-agent", $"speakeasy-sdk/{_language} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
        var httpResponseMessage = await client.SendAsync(message);
        var response = new GetBuildInfoResponse
        {
            StatusCode = (int)httpResponseMessage.StatusCode,
            ContentType = httpResponseMessage.Content.Headers.ContentType?.MediaType,
            RawResponse = httpResponseMessage
        };
        if((response.StatusCode == 200))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.Build = JsonConvert.DeserializeObject<Build>(await httpResponseMessage.Content.ReadAsStringAsync(), new FlexibleObjectDeserializer());
            }
            return response;
        }
        if((response.StatusCode == 404))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.GetBuildInfo404ApplicationJSONString = await response.RawResponse.Content.ReadAsStringAsync();
            }
            return response;
        }
        return response;
    }

        
    public async Task<GetBuildsResponse> GetBuildsAsync(GetBuildsSecurity security, GetBuildsRequest request)
    {
        string baseUrl = "";
        var message = GetBuildsRequest.BuildHttpRequestMessage("GetBuilds", request, baseUrl);
        var client = _defaultClient;
        GetBuildsSecurity.Apply(security, message);

        message.Headers.Add("user-agent", $"speakeasy-sdk/{_language} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
        var httpResponseMessage = await client.SendAsync(message);
        var response = new GetBuildsResponse
        {
            StatusCode = (int)httpResponseMessage.StatusCode,
            ContentType = httpResponseMessage.Content.Headers.ContentType?.MediaType,
            RawResponse = httpResponseMessage
        };
        if((response.StatusCode == 200))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.Builds = JsonConvert.DeserializeObject<List<Build>>(await httpResponseMessage.Content.ReadAsStringAsync(), new FlexibleObjectDeserializer());
            }
            return response;
        }
        if((response.StatusCode == 404))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.GetBuilds404ApplicationJSONString = await response.RawResponse.Content.ReadAsStringAsync();
            }
            return response;
        }
        return response;
    }

        
    public async Task<UpdateAppResponse> UpdateAsync(UpdateAppSecurity security, UpdateAppRequest? request = null)
    {
        string baseUrl = "";
        var message = UpdateAppRequest.BuildHttpRequestMessage("UpdateApp", request, baseUrl);
        var client = _defaultClient;
        UpdateAppSecurity.Apply(security, message);

        message.Headers.Add("user-agent", $"speakeasy-sdk/{_language} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
        var httpResponseMessage = await client.SendAsync(message);
        var response = new UpdateAppResponse
        {
            StatusCode = (int)httpResponseMessage.StatusCode,
            ContentType = httpResponseMessage.Content.Headers.ContentType?.MediaType,
            RawResponse = httpResponseMessage
        };
        if((response.StatusCode == 200))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.Application = JsonConvert.DeserializeObject<Application>(await httpResponseMessage.Content.ReadAsStringAsync(), new FlexibleObjectDeserializer());
            }
            return response;
        }
        if((response.StatusCode == 404))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.UpdateApp404ApplicationJSONString = await response.RawResponse.Content.ReadAsStringAsync();
            }
            return response;
        }
        if((response.StatusCode == 500))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.UpdateApp500ApplicationJSONString = await response.RawResponse.Content.ReadAsStringAsync();
            }
            return response;
        }
        return response;
    }

        
    }
}