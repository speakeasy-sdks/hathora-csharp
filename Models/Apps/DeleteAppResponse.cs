
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace hathora.Models.Apps
{
    using hathora.Utils;
    using hathora.Models.Shared;
    using NodaTime;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Text;
    
public class DeleteAppResponse {
    public string? ContentType { get; set; }
    
    public string? DeleteApp404ApplicationJSONString { get; set; }
    
    public string? DeleteApp500ApplicationJSONString { get; set; }
    
    public int StatusCode { get; set; }
    
    public HttpResponseMessage? RawResponse { get; set; }
    
}
}