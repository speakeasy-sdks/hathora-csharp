
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Hathora.Models.Deployment
{
    using System;
using System.Net.Http;
using Newtonsoft.Json;
using Hathora.Utils;
    
    public class GetDeploymentInfoRequest
    {
        
        [JsonProperty("appId")]
        public string AppId { get; set; }
        
        
        [JsonProperty("deploymentId")]
        public float DeploymentId { get; set; }
        
        internal static HttpRequestMessage BuildHttpRequestMessage(string operationId, GetDeploymentInfoRequest value, string baseUrl)
        {
            if("GetDeploymentInfo" == operationId)
            {
                
                var appId = PathParamSerializer.Serialize("simple", false, value.AppId);
                
                var deploymentId = PathParamSerializer.Serialize("simple", false, value.DeploymentId);
                var message = new HttpRequestMessage(HttpMethod.Get, baseUrl + $"/deployments/v1/{appId}/info/{deploymentId}");
                return message;
            }
            throw new ArgumentException($"Attempt to build HttpRequestMessage for invalid operationId [{operationId}] for request type [GetDeploymentInfoRequest]");
        }
    }
}