
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace hathora.Models.Rooms
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
    
public class GetActiveRoomsForProcessRequest
{
    [JsonProperty("appId")]
    public string AppId { get; set; }
    
    [JsonProperty("processId")]
    public string ProcessId { get; set; }
    
    internal static HttpRequestMessage BuildHttpRequestMessage(string operationId, GetActiveRoomsForProcessRequest value)
    {
        if("GetActiveRoomsForProcess" == operationId)
        {
            // add path params
                    
                    var appId = PathParamSerializer.Serialize("simple", false, value.AppId);
                    
                    var processId = PathParamSerializer.Serialize("simple", false, value.ProcessId);
            var message = new HttpRequestMessage(HttpMethod.Get, $"/rooms/v1/{appId}/list/{processId}/active");
            return message;
        }
        throw new ArgumentException($"Attempt to build HttpRequestMessage for invalid operationId [{operationId}] for request type [GetActiveRoomsForProcessRequest]");
    }
}
}