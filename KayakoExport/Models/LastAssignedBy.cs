﻿using Newtonsoft.Json;

namespace KayakoExport.Models
{
    internal class LastAssignedBy
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "resource_type")]
        public string ResourceType { get; set; }
    }
}