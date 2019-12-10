using Newtonsoft.Json;

namespace KayakoExport.Models
{
    internal class Creator
    {
        [JsonProperty(PropertyName = "id")]
        public long CreatorId { get; set; }

        [JsonProperty(PropertyName = "resource_type")]
        public string CreatorType { get; set; }
    }
}