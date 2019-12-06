﻿using Newtonsoft.Json;

namespace KayakoExport.Models
{
    internal class Status
    {
        [JsonProperty(PropertyName = "id")]
        public long Id { get; set; }

        [JsonProperty(PropertyName = "resource_type")]
        public string ResourceType { get; set; }
    }
}