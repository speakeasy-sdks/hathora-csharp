///
 /// Code generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
 ///

namespace SDK.Models.Apps;
using SDK.Utils;
using SDK.Models.Shared;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Net.Http;
using System.Text;

public class UpdateAppResponse {
    public Application? Application { get; set; }
    
    public string? ContentType { get; set; }
    
    public int StatusCode { get; set; }
    
    public HttpResponseMessage? RawResponse { get; set; }
    
    public string? UpdateApp404ApplicationJSONString { get; set; }
    
    public string? UpdateApp422ApplicationJSONString { get; set; }
    
    public string? UpdateApp500ApplicationJSONString { get; set; }
    
}