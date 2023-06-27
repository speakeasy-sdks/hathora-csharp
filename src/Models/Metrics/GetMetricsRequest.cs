
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Hathora.Models.Metrics
{
    using Hathora.Utils;
    using Hathora.Models.Shared;
    using NodaTime;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Text;
    
public class GetMetricsRequest
{
    [JsonProperty("appId")]
    public string AppId { get; set; }
    
    [JsonProperty("end")]
    public int? End { get; set; }
    
    [JsonProperty("metrics")]
    public List<MetricName>? Metrics { get; set; }
    
    [JsonProperty("processId")]
    public string ProcessId { get; set; }
    
    [JsonProperty("start")]
    public int? Start { get; set; }
    
    [JsonProperty("step")]
    public int? Step { get; set; }
    
    internal static HttpRequestMessage BuildHttpRequestMessage(string operationId, GetMetricsRequest value, string baseUrl)
    {
        if("GetMetrics" == operationId)
        {
            var queryParams = new List<string>();
            
            
            queryParams.Add(QueryParamSerializer.Serialize("form",true, "end", "", value.End));
            
            queryParams.Add(QueryParamSerializer.Serialize("form",true, "metrics", "", value.Metrics));
            
            
            queryParams.Add(QueryParamSerializer.Serialize("form",true, "start", "", value.Start));
            
            queryParams.Add(QueryParamSerializer.Serialize("form",true, "step", "", value.Step));
            var queryParamString = $"?{String.Join("&", queryParams)}";
            
            var appId = PathParamSerializer.Serialize("simple", false, value.AppId);
            
            
            
            var processId = PathParamSerializer.Serialize("simple", false, value.ProcessId);
            
            
            var message = new HttpRequestMessage(HttpMethod.Get, baseUrl + $"/metrics/v1/{appId}/process/{processId}" + queryParamString);
            return message;
        }
        throw new ArgumentException($"Attempt to build HttpRequestMessage for invalid operationId [{operationId}] for request type [GetMetricsRequest]");
    }
}
}