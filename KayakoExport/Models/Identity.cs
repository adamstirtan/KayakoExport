using Newtonsoft.Json;

namespace KayakoExport.Models
{
    internal class Identity
    {
        [JsonProperty(PropertyName = "id")]
        public string IdentityId { get; set; }

        [JsonProperty(PropertyName = "resource_type")]
        public string IdentityType { get; set; }
    }
}