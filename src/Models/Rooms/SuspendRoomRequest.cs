
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Hathora.Models.Rooms
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
    
public class SuspendRoomRequest
{
    [JsonProperty("appId")]
    public string AppId { get; set; }
    
    [JsonProperty("roomId")]
    public string RoomId { get; set; }
    
    internal static HttpRequestMessage BuildHttpRequestMessage(string operationId, SuspendRoomRequest value, string baseUrl)
    {
        if("SuspendRoom" == operationId)
        {
            
            var appId = PathParamSerializer.Serialize("simple", false, value.AppId);
            
            var roomId = PathParamSerializer.Serialize("simple", false, value.RoomId);
            var message = new HttpRequestMessage(HttpMethod.Post, baseUrl + $"/rooms/v1/{appId}/suspend/{roomId}");
            return message;
        }
        throw new ArgumentException($"Attempt to build HttpRequestMessage for invalid operationId [{operationId}] for request type [SuspendRoomRequest]");
    }
}
}