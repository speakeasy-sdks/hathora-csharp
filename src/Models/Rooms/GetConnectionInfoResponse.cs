
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Hathora.Models.Rooms
{
    using Hathora.Utils;
    using Hathora.Models.Shared;
    using NodaTime;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Text;
    
public class GetConnectionInfoResponse {
    public object? ConnectionInfo { get; set; }
    
    public string? ContentType { get; set; }
    
    public string? GetConnectionInfo400ApplicationJSONString { get; set; }
    
    public string? GetConnectionInfo404ApplicationJSONString { get; set; }
    
    public string? GetConnectionInfo500ApplicationJSONString { get; set; }
    
    public int StatusCode { get; set; }
    
    public HttpResponseMessage? RawResponse { get; set; }
    
}
}