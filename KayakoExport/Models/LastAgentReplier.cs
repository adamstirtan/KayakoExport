using Newtonsoft.Json;

namespace KayakoExport.Models
{
    internal class LastAgentReplier
    {
        [JsonProperty(PropertyName = "id")]
        public long LastAgentReplierId { get; set; }

        [JsonProperty(PropertyName = "resource_type")]
        public string LastAgentReplierType { get; set; }
    }
}