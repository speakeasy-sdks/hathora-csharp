
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
    using System.Net.Http;
using Hathora.Models.Shared;
    
    public class GetLobbyInfoResponse {
        public string? ContentType { get; set; }
        
        public string? GetLobbyInfo404ApplicationJSONString { get; set; }
        
    /// <summary>
    /// Ok
    /// </summary>
        public Lobby? Lobby { get; set; }
        
        public int StatusCode { get; set; }
        
        public HttpResponseMessage? RawResponse { get; set; }
        
    }
}