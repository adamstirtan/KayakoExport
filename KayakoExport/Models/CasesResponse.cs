using Newtonsoft.Json;

namespace KayakoExport.Models
{
    internal class CasesResponse
    {
        [JsonProperty(PropertyName = "status")]
        public int Status { get; set; }

        [JsonProperty(PropertyName = "data")]
        public Case[] Cases { get; set; }

        [JsonProperty(PropertyName = "resource")]
        public string Resource { get; set; }

        [JsonProperty(PropertyName = "offset")]
        public int Offset { get; set; }

        [JsonProperty(PropertyName = "limit")]
        public int Limit { get; set; }

        [JsonProperty(PropertyName = "total_count")]
        public int TotalCount { get; set; }

        [JsonProperty(PropertyName = "next_url")]
        public string NextUrl { get; set; }

        [JsonProperty(PropertyName = "last_url")]
        public string LastUrl { get; set; }

        [JsonProperty(PropertyName = "session_id")]
        public string SessionId { get; set; }
    }
}