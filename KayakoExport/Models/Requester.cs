using Newtonsoft.Json;

namespace KayakoExport.Models
{
    internal class Requester
    {
        [JsonProperty(PropertyName = "id")]
        public string RequesterId { get; set; }

        [JsonProperty(PropertyName = "resource_type")]
        public string RequesterType { get; set; }
    }
}