
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Hathora.Models.Shared
{
    using Newtonsoft.Json;
    
    public enum RoomStatus
    {
    	[JsonProperty("scheduling")]
		Scheduling,
		[JsonProperty("active")]
		Active,
		[JsonProperty("suspended")]
		Suspended,
		[JsonProperty("destroyed")]
		Destroyed,
    }
}