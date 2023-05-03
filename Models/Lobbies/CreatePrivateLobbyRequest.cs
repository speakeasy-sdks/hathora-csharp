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

public class CreatePrivateLobbyRequest
{
    [JsonProperty("Authorization")]
    public string Authorization { get; set; }
    
    [JsonProperty("RequestBody")]
    public CreatePrivateLobbyRequestBody RequestBody { get; set; }
    
    [JsonProperty("appId")]
    public string AppId { get; set; }
    
    [JsonProperty("roomId")]
    public string? RoomId { get; set; }
    
    internal static HttpRequestMessage BuildHttpRequestMessage(string operationId, CreatePrivateLobbyRequest value)
    {
        if("CreatePrivateLobby" == operationId)
        {
            // serialize query parameters
            var queryParams = new List<string>();
            queryParams.Add(QueryParamSerializer.Serialize("simple",false, "Authorization", "", value.Authorization));
            queryParams.Add(QueryParamSerializer.Serialize("simple",false, "appId", "", value.AppId));
            queryParams.Add(QueryParamSerializer.Serialize("form",true, "roomId", "", value.RoomId));

            var queryParamString = $"?{String.Join("&", queryParams)}";
            // add path params
            
            
            
            var appId = PathParamSerializer.Serialize("simple", false, value.AppId);
            
            var message = new HttpRequestMessage(HttpMethod.Post, $"/lobby/v2/{appId}/create/private" + queryParamString);
            message.Headers.Add("Authorization", HeaderParamSerializer.Serialize(false, value.Authorization));
            message.Headers.Add("unknown", HeaderParamSerializer.Serialize(false, value.RequestBody));
            message.Headers.Add("appId", HeaderParamSerializer.Serialize(false, value.AppId));
            message.Headers.Add("roomId", HeaderParamSerializer.Serialize(true, value.RoomId));

            string json = JsonConvert.SerializeObject(value.RequestBody);
            message.Content = new StringContent(json, Encoding.UTF8, "application/json");
            return message;
        }
        throw new ArgumentException($"Attempt to build HttpRequestMessage for invalid operationId [{operationId}] for request type [CreatePrivateLobbyRequest]");
    }
}
