///
 /// Code generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
 ///

namespace hathora.Models.Deployment;
using hathora.Utils;
using hathora.Models.Shared;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Net.Http;
using System.Text;

public class CreateDeploymentResponse {
    public string? ContentType { get; set; }
    
    public string? CreateDeployment404ApplicationJSONString { get; set; }
    
    public string? CreateDeployment422ApplicationJSONString { get; set; }
    
    public string? CreateDeployment500ApplicationJSONString { get; set; }
    
    public Deployment? Deployment { get; set; }
    
    public int StatusCode { get; set; }
    
    public HttpResponseMessage? RawResponse { get; set; }
    
}
