using Newtonsoft.Json;

namespace KayakoExport.Models
{
    internal class AssignedTeam
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "resource_type")]
        public string ResourceType { get; set; }
    }
}