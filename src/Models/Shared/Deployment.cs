
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
    using Hathora.Utils;
    using NodaTime;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Text;
    
public class Deployment
{
    [JsonProperty("appId")]
    public string AppId { get; set; }
    
    [JsonProperty("buildId")]
    public float BuildId { get; set; }
    
    [JsonProperty("containerPort")]
    public int ContainerPort { get; set; }
    
    [JsonProperty("createdAt")]
    public DateTime CreatedAt { get; set; }
    
    [JsonProperty("createdBy")]
    public string CreatedBy { get; set; }
    
    [JsonProperty("deploymentId")]
    public float DeploymentId { get; set; }
    
    [JsonProperty("env")]
    public List<DeploymentEnv> Env { get; set; }
    
    [JsonProperty("planName")]
    public PlanName PlanName { get; set; }
    
    [JsonProperty("requestedCPU")]
    public float RequestedCPU { get; set; }
    
    [JsonProperty("requestedMemoryMB")]
    public float RequestedMemoryMB { get; set; }
    
    [JsonProperty("roomsPerProcess")]
    public int RoomsPerProcess { get; set; }
    
    [JsonProperty("transportType")]
    public TransportType TransportType { get; set; }
    
}
}