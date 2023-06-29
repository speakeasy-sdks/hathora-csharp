
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Hathora.Models.Apps
{
    using System;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;
using Hathora.Models.Shared;
using Hathora.Utils;
    
    public class UpdateAppRequest
    {
        
        [JsonProperty("AppConfig")]
        public AppConfig AppConfig { get; set; }
        
        
        [JsonProperty("appId")]
        public string AppId { get; set; }
        
        internal static HttpRequestMessage BuildHttpRequestMessage(string operationId, UpdateAppRequest value, string baseUrl)
        {
            if("UpdateApp" == operationId)
            {
                
                
                var appId = PathParamSerializer.Serialize("simple", false, value.AppId);
                var message = new HttpRequestMessage(HttpMethod.Post, baseUrl + $"/apps/v1/update/{appId}");

                string json = JsonConvert.SerializeObject(value.AppConfig);
                message.Content = new StringContent(json, Encoding.UTF8, "application/json");
                return message;
            }
            throw new ArgumentException($"Attempt to build HttpRequestMessage for invalid operationId [{operationId}] for request type [UpdateAppRequest]");
        }
    }
}