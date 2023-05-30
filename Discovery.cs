
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
    using System.Net.Http;
    using System.Text;
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using hathora.Models.Shared;
    using hathora.Models.Discovery;
    using hathora.Utils;

    public interface IDiscoverySDK
    {
        Task<GetPingServiceEndpointsResponse> GetPingServiceEndpointsAsync();
    }

    public class DiscoverySDK: IDiscoverySDK
    {

        private const string language = "csharp";
        private const string sdkVersion = "0.0.1";
        private const string sdkGenVersion = "internal";
        public Uri ServerUrl { get { return _defaultClient.BaseAddress; } }
        private HttpClient _defaultClient;
        private HttpClient _securityClient;

        public DiscoverySDK(HttpClient defaultClient, HttpClient securityClient)
        {
            _defaultClient = defaultClient;
            _securityClient = securityClient;
        }

        
    public async Task<GetPingServiceEndpointsResponse> GetPingServiceEndpointsAsync()
    {
        string baseUrl = "";
        var message = new HttpRequestMessage(HttpMethod.Get, baseUrl + "/discovery/v1/ping");
        var httpResponseMessage = await _defaultClient.SendAsync(message);
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
                response.DiscoveryResponse = JsonConvert.DeserializeObject<IEnumerable<DiscoveryResponse>>(await httpResponseMessage.Content.ReadAsStringAsync(), new FlexibleObjectDeserializer());
            }
            return response;
        }
        return response;
    }

        
    }
}