
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Hathora.Models.Apps
{
    using Hathora.Utils;
    using Hathora.Models.Shared;
    using NodaTime;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Text;
    
public class CreateAppSecurity
{
    [JsonProperty("auth0")]
    public string Auth0 { get; set; }
    
    // Operation security
    public static void Apply(CreateAppSecurity security, HttpRequestMessage message)
    {
        if(security == null)
        {
            return;
        }
        if(security.Auth0 != null)
        {
            message.Headers.Add("Authorization", Utilities.PrefixBearer(Utilities.ToString(security.Auth0)));
        }
    }
}
}