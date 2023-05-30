
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace hathora.Models.Apps
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
    
public class GetBuildInfoRequest
{
    [JsonProperty("appId")]
    public string AppId { get; set; }
    
    [JsonProperty("buildId")]
    public float BuildId { get; set; }
    
    internal static HttpRequestMessage BuildHttpRequestMessage(string operationId, GetBuildInfoRequest value)
    {
        if("GetBuildInfo" == operationId)
        {
            // add path params
                    
                    var appId = PathParamSerializer.Serialize("simple", false, value.AppId);
                    
                    var buildId = PathParamSerializer.Serialize("simple", false, value.BuildId);
            var message = new HttpRequestMessage(HttpMethod.Get, $"/builds/v1/{appId}/info/{buildId}");
            return message;
        }
        throw new ArgumentException($"Attempt to build HttpRequestMessage for invalid operationId [{operationId}] for request type [GetBuildInfoRequest]");
    }
}
}