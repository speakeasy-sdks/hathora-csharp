
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace hathora.Models.Auth
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
    
public class LoginAnonymousRequest
{
    [JsonProperty("appId")]
    public string AppId { get; set; }
    
    internal static HttpRequestMessage BuildHttpRequestMessage(string operationId, LoginAnonymousRequest value)
    {
        if("LoginAnonymous" == operationId)
        {
            // add path params
                    
                    var appId = PathParamSerializer.Serialize("simple", false, value.AppId);
            var message = new HttpRequestMessage(HttpMethod.Post, $"/auth/v1/{appId}/login/anonymous");
            return message;
        }
        throw new ArgumentException($"Attempt to build HttpRequestMessage for invalid operationId [{operationId}] for request type [LoginAnonymousRequest]");
    }
}
}