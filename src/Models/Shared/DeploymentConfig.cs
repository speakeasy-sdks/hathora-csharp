
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
    using System.Collections.Generic;
using Newtonsoft.Json;
using Hathora.Models.Shared;
    
    public class DeploymentConfig
    {
        
        [JsonProperty("containerPort")]
        public int ContainerPort { get; set; }
        
        
        [JsonProperty("env")]
        public List<DeploymentConfigEnv> Env { get; set; }
        
        
        [JsonProperty("planName")]
        public PlanName PlanName { get; set; }
        
        
        [JsonProperty("roomsPerProcess")]
        public int RoomsPerProcess { get; set; }
        
        
        [JsonProperty("transportType")]
        public TransportType TransportType { get; set; }
        
    }
}