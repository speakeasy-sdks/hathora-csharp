
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
using Hathora.Models.Shared;
    
    public class ApplicationAuthConfiguration
    {
    /// <summary>
    /// Construct a type with a set of properties K of type T
    /// </summary>
        
        [JsonProperty("anonymous")]
        public RecordStringNever? Anonymous { get; set; }
        
        
        [JsonProperty("google")]
        public ApplicationAuthConfigurationGoogle? Google { get; set; }
        
    /// <summary>
    /// Construct a type with a set of properties K of type T
    /// </summary>
        
        [JsonProperty("nickname")]
        public RecordStringNever? Nickname { get; set; }
        
    }
}