
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace hathora.Discovery
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Text;
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using NodaTime;
    using hathora.Models.Shared;
    using hathora.Models.Discovery;
    using hathora.Utils;

    public interface IDiscoverySDK
    {
        Task<GetPingServiceEndpointsResponse> GetPingServiceEndpointsAsync();
    }

    public class DiscoverySDK: IDiscoverySDK
    {

        public SDKConfig Config { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "0.0.1";
        private const string _sdkGenVersion = "internal";
        private const string _openapiDocVersion = "0.0.1";
        public Uri ServerUrl { get { return _defaultClient.Client.BaseAddress; } }
        private SpeakeasyHttpClient _defaultClient;
        private SpeakeasyHttpClient _securityClient;

        public DiscoverySDK(SpeakeasyHttpClient defaultClient, SpeakeasyHttpClient securityClient, SDKConfig config)
        {
            _defaultClient = defaultClient;
            _securityClient = securityClient;
            Config = config;
        }

        
    public async Task<GetPingServiceEndpointsResponse> GetPingServiceEndpointsAsync()
    {
        string baseUrl = "";
        var message = new HttpRequestMessage(HttpMethod.Get, baseUrl + "/discovery/v1/ping");
        var client = _defaultClient;

        message.Headers.Add("user-agent", $"speakeasy-sdk/{_language} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
        var httpResponseMessage = await client.SendAsync(message);
        var response = new GetPingServiceEndpointsResponse
        {
            StatusCode = (int)httpResponseMessage.StatusCode,
            ContentType = httpResponseMessage.Content.Headers.ContentType?.MediaType,
            RawResponse = httpResponseMessage
        };
        if((response.StatusCode == 200))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.DiscoveryResponse = JsonConvert.DeserializeObject<List<DiscoveryResponse>>(await httpResponseMessage.Content.ReadAsStringAsync(), new FlexibleObjectDeserializer());
            }
            return response;
        }
        return response;
    }

        
    }
}