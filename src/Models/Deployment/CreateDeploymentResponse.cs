
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
    using System.Net.Http;
using Hathora.Models.Shared;
    
    public class CreateDeploymentResponse {
        public string? ContentType { get; set; }
        
        public string? CreateDeployment400ApplicationJSONString { get; set; }
        
        public string? CreateDeployment404ApplicationJSONString { get; set; }
        
        public string? CreateDeployment500ApplicationJSONString { get; set; }
        
        public Deployment? Deployment { get; set; }
        
        public int StatusCode { get; set; }
        
        public HttpResponseMessage? RawResponse { get; set; }
        
    }
}