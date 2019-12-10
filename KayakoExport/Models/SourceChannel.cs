using Newtonsoft.Json;

namespace KayakoExport.Models
{
    internal class SourceChannel
    {
        [JsonProperty(PropertyName = "id")]
        public string SourceChannelId { get; set; }

        [JsonProperty(PropertyName = "resource_type")]
        public string SourceChannelType { get; set; }
    }
}