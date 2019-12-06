using Newtonsoft.Json;

namespace KayakoExport.Models
{
    internal class SourceChannel
    {
        [JsonProperty(PropertyName = "id")]
        public long Id { get; set; }

        [JsonProperty(PropertyName = "resource_type")]
        public string Resource_Type { get; set; }
    }
}