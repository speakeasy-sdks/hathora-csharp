
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Hathora.Metrics
{
    using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Hathora.Models.Metrics;
using Hathora.Models.Shared;
using Hathora.Utils;

    public interface IMetricsSDK
    {
        Task<GetMetricsResponse> GetMetricsAsync(GetMetricsSecurity security, GetMetricsRequest request);
    }

    public class MetricsSDK: IMetricsSDK
    {

        public SDKConfig Config { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "0.0.1";
        private const string _sdkGenVersion = "internal";
        private const string _openapiDocVersion = "0.0.1";
        public Uri ServerUrl { get { return _defaultClient.Client.BaseAddress; } }
        private SpeakeasyHttpClient _defaultClient;
        private SpeakeasyHttpClient _securityClient;

        public MetricsSDK(SpeakeasyHttpClient defaultClient, SpeakeasyHttpClient securityClient, SDKConfig config)
        {
            _defaultClient = defaultClient;
            _securityClient = securityClient;
            Config = config;
        }

        
    public async Task<GetMetricsResponse> GetMetricsAsync(GetMetricsSecurity security, GetMetricsRequest request)
    {
        string baseUrl = "";
        var message = GetMetricsRequest.BuildHttpRequestMessage("GetMetrics", request, baseUrl);
        var client = _defaultClient;
        GetMetricsSecurity.Apply(security, message);

        message.Headers.Add("user-agent", $"speakeasy-sdk/{_language} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
        var httpResponseMessage = await client.SendAsync(message);
        var response = new GetMetricsResponse
        {
            StatusCode = (int)httpResponseMessage.StatusCode,
            ContentType = httpResponseMessage.Content.Headers.ContentType?.MediaType,
            RawResponse = httpResponseMessage
        };
        if((response.StatusCode == 200))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.MetricsResponse = JsonConvert.DeserializeObject<MetricsResponse>(await httpResponseMessage.Content.ReadAsStringAsync(), new FlexibleObjectDeserializer());
            }
            return response;
        }
        if((response.StatusCode == 404))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.GetMetrics404ApplicationJSONString = await response.RawResponse.Content.ReadAsStringAsync();
            }
            return response;
        }
        if((response.StatusCode == 422))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.GetMetrics422ApplicationJSONString = await response.RawResponse.Content.ReadAsStringAsync();
            }
            return response;
        }
        return response;
    }

        
    }
}