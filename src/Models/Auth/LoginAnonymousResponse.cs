
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Hathora.Models.Auth
{
    using System.Net.Http;
    
    public class LoginAnonymousResponse {
        public string? ContentType { get; set; }
        
    /// <summary>
    /// Ok
    /// </summary>
        public LoginAnonymous200ApplicationJSON? LoginAnonymous200ApplicationJSONObject { get; set; }
        
        public string? LoginAnonymous404ApplicationJSONString { get; set; }
        
        public int StatusCode { get; set; }
        
        public HttpResponseMessage? RawResponse { get; set; }
        
    }
}