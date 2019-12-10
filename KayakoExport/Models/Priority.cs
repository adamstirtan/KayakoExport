using Newtonsoft.Json;

namespace KayakoExport.Models
{
    internal class Priority
    {
        [JsonProperty(PropertyName = "id")]
        public long PriorityId { get; set; }

        [JsonProperty(PropertyName = "resource_type")]
        public string PriorityType { get; set; }
    }
}