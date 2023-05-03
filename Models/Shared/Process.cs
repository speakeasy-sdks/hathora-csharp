///
 /// Code generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
 ///

namespace hathora.Models.Shared;
using hathora.Utils;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Net.Http;
using System.Text;

public class Process
{
    [JsonProperty("activeConnections")]
    public float ActiveConnections { get; set; }
    
    [JsonProperty("appId")]
    public string AppId { get; set; }
    
    [JsonProperty("deploymentId")]
    public float DeploymentId { get; set; }
    
    [JsonProperty("draining")]
    public bool Draining { get; set; }
    
    [JsonProperty("egressedBytes")]
    public float EgressedBytes { get; set; }
    
    [JsonProperty("host")]
    public string Host { get; set; }
    
    [JsonProperty("idleSince")]
    public DateTime IdleSince { get; set; }
    
    [JsonProperty("port")]
    public float Port { get; set; }
    
    [JsonProperty("processId")]
    public string ProcessId { get; set; }
    
    [JsonProperty("region")]
    public RegionEnum Region { get; set; }
    
    [JsonProperty("roomSlotsAvailable")]
    public float RoomSlotsAvailable { get; set; }
    
    [JsonProperty("roomsPerProcess")]
    public float RoomsPerProcess { get; set; }
    
    [JsonProperty("startedAt")]
    public DateTime StartedAt { get; set; }
    
    [JsonProperty("startingAt")]
    public DateTime StartingAt { get; set; }
    
    [JsonProperty("stoppingAt")]
    public DateTime StoppingAt { get; set; }
    
    [JsonProperty("terminatedAt")]
    public DateTime TerminatedAt { get; set; }
    
}
