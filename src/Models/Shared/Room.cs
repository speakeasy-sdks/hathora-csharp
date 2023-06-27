
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
    
public class Room
{
    [JsonProperty("allocations")]
    public List<RoomAllocation> Allocations { get; set; }
    
    [JsonProperty("appId")]
    public string AppId { get; set; }
    
    [JsonProperty("currentAllocation")]
    public RoomCurrentAllocation CurrentAllocation { get; set; }
    
    [JsonProperty("roomId")]
    public string RoomId { get; set; }
    
    [JsonProperty("status")]
    public RoomStatus Status { get; set; }
    
}
}