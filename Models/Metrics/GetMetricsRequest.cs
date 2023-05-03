///
 /// Code generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
 ///

namespace SDK.Models.Metrics;
using SDK.Utils;
using SDK.Models.Shared;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Net.Http;
using System.Text;

public class GetMetricsRequest
{
    [JsonProperty("appId")]
    public string AppId { get; set; }
    
    [JsonProperty("end")]
    public float? End { get; set; }
    
    [JsonProperty("metrics")]
    public IEnumerable<MetricNameEnum>? Metrics { get; set; }
    
    [JsonProperty("processId")]
    public string ProcessId { get; set; }
    
    [JsonProperty("start")]
    public float? Start { get; set; }
    
    [JsonProperty("step")]
    public float? Step { get; set; }
    
    internal static HttpRequestMessage BuildHttpRequestMessage(string operationId, GetMetricsRequest value)
    {
        if("GetMetrics" == operationId)
        {
            // serialize query parameters
            var queryParams = new List<string>();
            queryParams.Add(QueryParamSerializer.Serialize("simple",false, "appId", "", value.AppId));
            queryParams.Add(QueryParamSerializer.Serialize("form",true, "end", "", value.End));
            queryParams.Add(QueryParamSerializer.Serialize("form",true, "metrics", "", value.Metrics));
            queryParams.Add(QueryParamSerializer.Serialize("simple",false, "processId", "", value.ProcessId));
            queryParams.Add(QueryParamSerializer.Serialize("form",true, "start", "", value.Start));
            queryParams.Add(QueryParamSerializer.Serialize("form",true, "step", "", value.Step));

            var queryParamString = $"?{String.Join("&", queryParams)}";
            // add path params
            
            var appId = PathParamSerializer.Serialize("simple", false, value.AppId);
            
            
            
            var processId = PathParamSerializer.Serialize("simple", false, value.ProcessId);
            
            
            var message = new HttpRequestMessage(HttpMethod.Get, $"/metrics/v1/{appId}/process/{processId}" + queryParamString);
            return message;
        }
        throw new ArgumentException($"Attempt to build HttpRequestMessage for invalid operationId [{operationId}] for request type [GetMetricsRequest]");
    }
}