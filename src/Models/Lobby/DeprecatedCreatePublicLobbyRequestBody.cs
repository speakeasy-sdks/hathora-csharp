
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
    using Newtonsoft.Json;
using Hathora.Models.Shared;
    
    public class DeprecatedCreatePublicLobbyRequestBody
    {
        
        [JsonProperty("initialConfig")]
        public DeprecatedCreatePublicLobbyRequestBodyInitialConfig InitialConfig { get; set; }
        
        
        [JsonProperty("region")]
        public Region Region { get; set; }
        
    }
}