///
 /// Code generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
 ///

namespace SDK.Models.Rooms;
using SDK.Utils;
using SDK.Models.Shared;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Net.Http;
using System.Text;

public class GetInactiveRoomsForProcessRequest
{
    [JsonProperty("appId")]
    public string AppId { get; set; }
    
    [JsonProperty("processId")]
    public string ProcessId { get; set; }
    
    internal static HttpRequestMessage BuildHttpRequestMessage(string operationId, GetInactiveRoomsForProcessRequest value)
    {
        if("GetInactiveRoomsForProcess" == operationId)
        {
            // add path params
            
            var appId = PathParamSerializer.Serialize("simple", false, value.AppId);
            
            var processId = PathParamSerializer.Serialize("simple", false, value.ProcessId);
            var message = new HttpRequestMessage(HttpMethod.Get, $"/rooms/v1/{appId}/list/{processId}/inactive");
            return message;
        }
        throw new ArgumentException($"Attempt to build HttpRequestMessage for invalid operationId [{operationId}] for request type [GetInactiveRoomsForProcessRequest]");
    }
}
