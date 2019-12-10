using Newtonsoft.Json;

namespace KayakoExport.Models
{
    internal class LastAssignedBy
    {
        [JsonProperty(PropertyName = "id")]
        public string LastAssignedById { get; set; }

        [JsonProperty(PropertyName = "resource_type")]
        public string LastAssignedByType { get; set; }
    }
}