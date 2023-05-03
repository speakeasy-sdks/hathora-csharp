///
 /// Code generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
 ///

namespace hathora.Models.Builds;
using hathora.Utils;
using hathora.Models.Shared;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Net.Http;
using System.Text;

public class DeleteBuildResponse {
    public string? ContentType { get; set; }
    
    public string? DeleteBuild404ApplicationJSONString { get; set; }
    
    public string? DeleteBuild422ApplicationJSONString { get; set; }
    
    public string? DeleteBuild500ApplicationJSONString { get; set; }
    
    public int StatusCode { get; set; }
    
    public HttpResponseMessage? RawResponse { get; set; }
    
}
