
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Hathora.Models.Lobby
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
    
public class DeprecatedCreatePublicLobbyRequest
{
    [JsonProperty("RequestBody")]
    public DeprecatedCreatePublicLobbyRequestBody RequestBody { get; set; }
    
    [JsonProperty("appId")]
    public string AppId { get; set; }
    
    [JsonProperty("roomId")]
    public string? RoomId { get; set; }
    
    internal static HttpRequestMessage BuildHttpRequestMessage(string operationId, DeprecatedCreatePublicLobbyRequest value, string baseUrl)
    {
        if("DeprecatedCreatePublicLobby" == operationId)
        {
            var queryParams = new List<string>();
            
            
            
            queryParams.Add(QueryParamSerializer.Serialize("form",true, "roomId", "", value.RoomId));
            var queryParamString = $"?{String.Join("&", queryParams)}";
            
            
            var appId = PathParamSerializer.Serialize("simple", false, value.AppId);
            
            var message = new HttpRequestMessage(HttpMethod.Post, baseUrl + $"/lobby/v2/{appId}/create/public" + queryParamString);
            
            
            

            string json = JsonConvert.SerializeObject(value.RequestBody);
            message.Content = new StringContent(json, Encoding.UTF8, "application/json");
            return message;
        }
        throw new ArgumentException($"Attempt to build HttpRequestMessage for invalid operationId [{operationId}] for request type [DeprecatedCreatePublicLobbyRequest]");
    }
}
}