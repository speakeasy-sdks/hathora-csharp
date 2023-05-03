///
 /// Code generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
 ///

namespace SDK.Models.Lobbies;
using SDK.Utils;
using SDK.Models.Shared;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Net.Http;
using System.Text;

public class CreateLobbyCreateLobbyRequest
{
    [JsonProperty("initialConfig")]
    public Dictionary<string, object> InitialConfig { get; set; }
    
    [JsonProperty("region")]
    public RegionEnum Region { get; set; }
    
    [JsonProperty("visibility")]
    public CreateLobbyCreateLobbyRequestVisibilityEnum Visibility { get; set; }
    
}
