
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Hathora.Models.Shared
{
    using Newtonsoft.Json;
using Hathora.Models.Shared;
    
    public class ActiveConnectionInfo
    {
        
        [JsonProperty("host")]
        public string Host { get; set; }
        
        
        [JsonProperty("port")]
        public float Port { get; set; }
        
        
        [JsonProperty("roomId")]
        public string RoomId { get; set; }
        
        
        [JsonProperty("status")]
        public ActiveConnectionInfoStatus Status { get; set; }
        
        
        [JsonProperty("transportType")]
        public TransportType TransportType { get; set; }
        
    }
}