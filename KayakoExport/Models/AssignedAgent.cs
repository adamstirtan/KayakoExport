using Newtonsoft.Json;

namespace KayakoExport.Models
{
    internal class AssignedAgent
    {
        [JsonProperty(PropertyName = "id")]
        public string AssignedAgentId { get; set; }

        [JsonProperty(PropertyName = "resource_type")]
        public string AssignedAgentType { get; set; }
    }
}