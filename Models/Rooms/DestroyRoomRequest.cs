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

public class DestroyRoomRequest
{
    [JsonProperty("appId")]
    public string AppId { get; set; }
    
    [JsonProperty("roomId")]
    public string RoomId { get; set; }
    
    internal static HttpRequestMessage BuildHttpRequestMessage(string operationId, DestroyRoomRequest value)
    {
        if("DestroyRoom" == operationId)
        {
            // add path params
            
            var appId = PathParamSerializer.Serialize("simple", false, value.AppId);
            
            var roomId = PathParamSerializer.Serialize("simple", false, value.RoomId);
            var message = new HttpRequestMessage(HttpMethod.Post, $"/rooms/v1/{appId}/destroy/{roomId}");
            return message;
        }
        throw new ArgumentException($"Attempt to build HttpRequestMessage for invalid operationId [{operationId}] for request type [DestroyRoomRequest]");
    }
}
