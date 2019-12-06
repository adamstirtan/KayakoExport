using Newtonsoft.Json;

namespace KayakoExport.Models
{
    internal class Case
    {
        [JsonProperty(PropertyName = "id")]
        public long Id { get; set; }

        [JsonProperty(PropertyName = "subject")]
        public string Subject { get; set; }

        [JsonProperty(PropertyName = "portal")]
        public string Portal { get; set; }

        [JsonProperty(PropertyName = "source_channel")]
        public SourceChannel SourceChannel { get; set; }

        [JsonProperty(PropertyName = "last_public_channel")]
        public LastPublicChannel LastPublicChannel { get; set; }
    }
}