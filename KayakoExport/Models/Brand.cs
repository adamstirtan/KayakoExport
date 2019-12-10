using Newtonsoft.Json;

namespace KayakoExport.Models
{
    internal class Brand
    {
        [JsonProperty(PropertyName = "id")]
        public string BrandId { get; set; }

        [JsonProperty(PropertyName = "resource_type")]
        public string BrandType { get; set; }
    }
}