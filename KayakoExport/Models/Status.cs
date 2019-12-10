using Newtonsoft.Json;

namespace KayakoExport.Models
{
    internal class Status
    {
        [JsonProperty(PropertyName = "id")]
        public long StatusId { get; set; }

        [JsonProperty(PropertyName = "resource_type")]
        public string StatusType { get; set; }
    }
}