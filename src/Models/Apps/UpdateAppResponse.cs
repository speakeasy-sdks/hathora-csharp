
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Hathora.Models.Apps
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
    
public class UpdateAppResponse {
    public Application? Application { get; set; }
    
    public string? ContentType { get; set; }
    
    public int StatusCode { get; set; }
    
    public HttpResponseMessage? RawResponse { get; set; }
    
    public string? UpdateApp404ApplicationJSONString { get; set; }
    
    public string? UpdateApp500ApplicationJSONString { get; set; }
    
}
}