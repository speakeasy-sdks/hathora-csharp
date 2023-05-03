///
 /// Code generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
 ///

namespace hathora.Models.Lobbies;
using hathora.Utils;
using hathora.Models.Shared;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Net.Http;
using System.Text;

public class CreatePublicLobbyResponse {
    public string? ContentType { get; set; }
    
    public string? CreatePublicLobby401ApplicationJSONString { get; set; }
    
    public string? CreatePublicLobby404ApplicationJSONString { get; set; }
    
    public string? CreatePublicLobby422ApplicationJSONString { get; set; }
    
    public string? CreatePublicLobby429ApplicationJSONString { get; set; }
    
    public string? CreatePublicLobby500ApplicationJSONString { get; set; }
    
    public Lobby? Lobby { get; set; }
    
    public int StatusCode { get; set; }
    
    public HttpResponseMessage? RawResponse { get; set; }
    
}
