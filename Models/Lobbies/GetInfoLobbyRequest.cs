///
 /// Code generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
 ///

namespace SDK.Models.Lobbies;
using SDK.Utils;
using SDK.Models.Shared;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Net.Http;
using System.Text;

public class GetInfoLobbyRequest
{
    [JsonProperty("appId")]
    public string AppId { get; set; }
    
    [JsonProperty("roomId")]
    public string RoomId { get; set; }
    
    internal static HttpRequestMessage BuildHttpRequestMessage(string operationId, GetInfoLobbyRequest value)
    {
        if("GetInfoLobby" == operationId)
        {
            // add path params
            
            var appId = PathParamSerializer.Serialize("simple", false, value.AppId);
            
            var roomId = PathParamSerializer.Serialize("simple", false, value.RoomId);
            var message = new HttpRequestMessage(HttpMethod.Get, $"/lobby/v2/{appId}/info/{roomId}");
            return message;
        }
        throw new ArgumentException($"Attempt to build HttpRequestMessage for invalid operationId [{operationId}] for request type [GetInfoLobbyRequest]");
    }
}