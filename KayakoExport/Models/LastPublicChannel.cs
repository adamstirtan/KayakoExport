using Newtonsoft.Json;

namespace KayakoExport.Models
{
    internal class LastPublicChannel
    {
        [JsonProperty(PropertyName = "id")]
        public string LastPublicChannelId { get; set; }

        [JsonProperty(PropertyName = "resource_type")]
        public string LastPublicChannelType { get; set; }
    }
}