
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace hathora.Models.Shared
{
    using hathora.Utils;
    using NodaTime;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Text;
    
public class RoomWithoutAllocationsCurrentAllocation
{
    [JsonProperty("processId")]
    public string ProcessId { get; set; }
    
    [JsonProperty("roomAllocationId")]
    public string RoomAllocationId { get; set; }
    
    [JsonProperty("scheduledAt")]
    public DateTime ScheduledAt { get; set; }
    
    [JsonProperty("unscheduledAt")]
    public DateTime UnscheduledAt { get; set; }
    
}
}