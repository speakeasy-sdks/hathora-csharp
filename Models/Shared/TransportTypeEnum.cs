///
 /// Code generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
 ///

namespace hathora.Models.Shared;
using hathora.Utils;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Net.Http;
using System.Text;

public enum TransportTypeEnum
{
    	[JsonProperty("tcp")]
	Tcp,
	[JsonProperty("udp")]
	Udp,
	[JsonProperty("tls")]
	Tls,
}
