using Newtonsoft.Json;

namespace KayakoExport.Models
{
    internal class AssignedTeam
    {
        [JsonProperty(PropertyName = "id")]
        public string AssignedTeamId { get; set; }

        [JsonProperty(PropertyName = "resource_type")]
        public string AssignedTeamType { get; set; }
    }
}