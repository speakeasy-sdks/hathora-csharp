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

public class CreateLobbyResponse {
    public string? ContentType { get; set; }
    
    public string? CreateLobby401ApplicationJSONString { get; set; }
    
    public string? CreateLobby404ApplicationJSONString { get; set; }
    
    public string? CreateLobby422ApplicationJSONString { get; set; }
    
    public string? CreateLobby429ApplicationJSONString { get; set; }
    
    public string? CreateLobby500ApplicationJSONString { get; set; }
    
    public Lobby? Lobby { get; set; }
    
    public int StatusCode { get; set; }
    
    public HttpResponseMessage? RawResponse { get; set; }
    
}
