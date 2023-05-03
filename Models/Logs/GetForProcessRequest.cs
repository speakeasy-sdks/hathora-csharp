///
 /// Code generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
 ///

namespace SDK.Models.Logs;
using SDK.Utils;
using SDK.Models.Shared;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Net.Http;
using System.Text;

public class GetForProcessRequest
{
    [JsonProperty("appId")]
    public string AppId { get; set; }
    
    [JsonProperty("follow")]
    public bool? Follow { get; set; }
    
    [JsonProperty("processId")]
    public string ProcessId { get; set; }
    
    [JsonProperty("tailLines")]
    public float? TailLines { get; set; }
    
    internal static HttpRequestMessage BuildHttpRequestMessage(string operationId, GetForProcessRequest value)
    {
        if("GetForProcess" == operationId)
        {
            // serialize query parameters
            var queryParams = new List<string>();
            queryParams.Add(QueryParamSerializer.Serialize("simple",false, "appId", "", value.AppId));
            queryParams.Add(QueryParamSerializer.Serialize("form",true, "follow", "", value.Follow));
            queryParams.Add(QueryParamSerializer.Serialize("simple",false, "processId", "", value.ProcessId));
            queryParams.Add(QueryParamSerializer.Serialize("form",true, "tailLines", "", value.TailLines));

            var queryParamString = $"?{String.Join("&", queryParams)}";
            // add path params
            
            var appId = PathParamSerializer.Serialize("simple", false, value.AppId);
            
            
            var processId = PathParamSerializer.Serialize("simple", false, value.ProcessId);
            
            var message = new HttpRequestMessage(HttpMethod.Get, $"/logs/v1/{appId}/process/{processId}" + queryParamString);
            return message;
        }
        throw new ArgumentException($"Attempt to build HttpRequestMessage for invalid operationId [{operationId}] for request type [GetForProcessRequest]");
    }
}
