
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace hathora.Models.Shared
{
    using hathora.Utils;
    using NodaTime;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Text;
    
public class AppConfig
{
    [JsonProperty("appName")]
    public string AppName { get; set; }
    
    [JsonProperty("authConfiguration")]
    public AppConfigAuthConfiguration AuthConfiguration { get; set; }
    
    internal static HttpRequestMessage BuildHttpRequestMessage(string operationId, AppConfig value, string baseUrl)
    {
        if("CreateApp" == operationId)
        {
            var message = new HttpRequestMessage(HttpMethod.Post, baseUrl + "/apps/v1/create");

            string json = JsonConvert.SerializeObject(value);
            message.Content = new StringContent(json, Encoding.UTF8, "application/json");
            return message;
        }
        throw new ArgumentException($"Attempt to build HttpRequestMessage for invalid operationId [{operationId}] for request type [AppConfig]");
    }
}
}