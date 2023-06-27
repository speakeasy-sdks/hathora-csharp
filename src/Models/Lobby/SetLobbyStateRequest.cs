
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace hathora.Models.Lobby
{
    using hathora.Utils;
    using hathora.Models.Shared;
    using NodaTime;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Text;
    
public class SetLobbyStateRequest
{
    [JsonProperty("RequestBody")]
    public SetLobbyStateRequestBody RequestBody { get; set; }
    
    [JsonProperty("appId")]
    public string AppId { get; set; }
    
    [JsonProperty("roomId")]
    public string RoomId { get; set; }
    
    internal static HttpRequestMessage BuildHttpRequestMessage(string operationId, SetLobbyStateRequest value, string baseUrl)
    {
        if("SetLobbyState" == operationId)
        {
            
            
            var appId = PathParamSerializer.Serialize("simple", false, value.AppId);
            
            var roomId = PathParamSerializer.Serialize("simple", false, value.RoomId);
            var message = new HttpRequestMessage(HttpMethod.Post, baseUrl + $"/lobby/v2/{appId}/setState/{roomId}");

            string json = JsonConvert.SerializeObject(value.RequestBody);
            message.Content = new StringContent(json, Encoding.UTF8, "application/json");
            return message;
        }
        throw new ArgumentException($"Attempt to build HttpRequestMessage for invalid operationId [{operationId}] for request type [SetLobbyStateRequest]");
    }
}
}