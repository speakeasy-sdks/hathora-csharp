///
 /// Code generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
 ///

namespace hathora.Models.Rooms;
using hathora.Utils;
using hathora.Models.Shared;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Net.Http;
using System.Text;

public class CreateRoomRequest
{
    [JsonProperty("RequestBody")]
    public CreateRoomRequestBody RequestBody { get; set; }
    
    [JsonProperty("appId")]
    public string AppId { get; set; }
    
    internal static HttpRequestMessage BuildHttpRequestMessage(string operationId, CreateRoomRequest value)
    {
        if("CreateRoom" == operationId)
        {
            // add path params
            
            
            var appId = PathParamSerializer.Serialize("simple", false, value.AppId);
            var message = new HttpRequestMessage(HttpMethod.Post, $"/rooms/v1/{appId}/create");

            string json = JsonConvert.SerializeObject(value.RequestBody);
            message.Content = new StringContent(json, Encoding.UTF8, "application/json");
            return message;
        }
        throw new ArgumentException($"Attempt to build HttpRequestMessage for invalid operationId [{operationId}] for request type [CreateRoomRequest]");
    }
}
