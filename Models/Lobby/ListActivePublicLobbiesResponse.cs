
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace hathora.Models.Lobby
{
    using hathora.Utils;
    using hathora.Models.Shared;
    using NodaTime;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Text;
    
public class ListActivePublicLobbiesResponse {
    public string? ContentType { get; set; }
    
    public IEnumerable<Lobby>? Lobbies { get; set; }
    
    public int StatusCode { get; set; }
    
    public HttpResponseMessage? RawResponse { get; set; }
    
}
}