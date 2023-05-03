///
 /// Code generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
 ///

namespace SDK.Models.Deployment;
using SDK.Utils;
using SDK.Models.Shared;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Net.Http;
using System.Text;

public class GetInfoDeploymentRequest
{
    [JsonProperty("appId")]
    public string AppId { get; set; }
    
    [JsonProperty("deploymentId")]
    public float DeploymentId { get; set; }
    
    internal static HttpRequestMessage BuildHttpRequestMessage(string operationId, GetInfoDeploymentRequest value)
    {
        if("GetInfoDeployment" == operationId)
        {
            // add path params
            
            var appId = PathParamSerializer.Serialize("simple", false, value.AppId);
            
            var deploymentId = PathParamSerializer.Serialize("simple", false, value.DeploymentId);
            var message = new HttpRequestMessage(HttpMethod.Get, $"/deployments/v1/{appId}/info/{deploymentId}");
            return message;
        }
        throw new ArgumentException($"Attempt to build HttpRequestMessage for invalid operationId [{operationId}] for request type [GetInfoDeploymentRequest]");
    }
}
