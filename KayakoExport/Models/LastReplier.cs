using Newtonsoft.Json;

namespace KayakoExport.Models
{
    internal class LastReplier
    {
        [JsonProperty(PropertyName = "id")]
        public long LastReplierId { get; set; }

        [JsonProperty(PropertyName = "resource_type")]
        public string LastReplierType { get; set; }
    }
}