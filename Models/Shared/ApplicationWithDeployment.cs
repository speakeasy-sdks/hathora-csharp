///
 /// Code generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
 ///

namespace SDK.Models.Shared;
using SDK.Utils;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Net.Http;
using System.Text;

public class ApplicationWithDeployment
{
    [JsonProperty("appId")]
    public string AppId { get; set; }
    
    [JsonProperty("appName")]
    public string AppName { get; set; }
    
    [JsonProperty("appSecret")]
    public string AppSecret { get; set; }
    
    [JsonProperty("authConfiguration")]
    public ApplicationWithDeploymentAuthConfiguration AuthConfiguration { get; set; }
    
    [JsonProperty("createdAt")]
    public DateTime CreatedAt { get; set; }
    
    [JsonProperty("createdBy")]
    public string CreatedBy { get; set; }
    
    [JsonProperty("deletedAt")]
    public DateTime DeletedAt { get; set; }
    
    [JsonProperty("deletedBy")]
    public string DeletedBy { get; set; }
    
    [JsonProperty("deployment")]
    public Deployment Deployment { get; set; }
    
    [JsonProperty("orgId")]
    public string OrgId { get; set; }
    
}
