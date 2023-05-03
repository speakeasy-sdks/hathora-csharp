///
 /// Code generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
 ///

namespace hathora.Models.Rooms;
using hathora.Utils;
using hathora.Models.Shared;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Net.Http;
using System.Text;

public class GetActiveRoomsForProcessResponse {
    public string? ContentType { get; set; }
    
    public string? GetActiveRoomsForProcess404ApplicationJSONString { get; set; }
    
    public IEnumerable<RoomWithoutAllocations>? RoomWithoutAllocations { get; set; }
    
    public int StatusCode { get; set; }
    
    public HttpResponseMessage? RawResponse { get; set; }
    
}
