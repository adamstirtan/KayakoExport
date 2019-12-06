using System;

using Newtonsoft.Json;

namespace KayakoExport.Models
{
    internal class Conversation
    {
        [JsonProperty(PropertyName = "id")]
        public long Id { get; set; }

        [JsonProperty(PropertyName = "uuid")]
        public string Uuid { get; set; }

        [JsonProperty(PropertyName = "subject")]
        public string Subject { get; set; }

        [JsonProperty(PropertyName = "channel")]
        public string Channel { get; set; }

        [JsonProperty(PropertyName = "requester")]
        public Requester Requester { get; set; }

        [JsonProperty(PropertyName = "creator")]
        public Creator Creator { get; set; }

        [JsonProperty(PropertyName = "last_replier")]
        public LastReplier LastReplier { get; set; }

        [JsonProperty(PropertyName = "last_agent_replier")]
        public LastAgentReplier LastAgentReplier { get; set; }

        [JsonProperty(PropertyName = "assigned_agent")]
        public AssignedAgent AssignedAgent { get; set; }

        [JsonProperty(PropertyName = "assigned_team")]
        public AssignedTeam AssignedTeam { get; set; }

        [JsonProperty(PropertyName = "status")]
        public Status Status { get; set; }

        [JsonProperty(PropertyName = "is_closed")]
        public bool IsClosed { get; set; }

        [JsonProperty(PropertyName = "priority")]
        public Priority Priority { get; set; }

        [JsonProperty(PropertyName = "last_message_preview")]
        public string LastMessagePreview { get; set; }

        [JsonProperty(PropertyName = "last_message_status")]
        public string LastMessageStatus { get; set; }

        [JsonProperty(PropertyName = "last_replied_at")]
        public DateTime? LastRepliedAt { get; set; }

        [JsonProperty(PropertyName = "created_at")]
        public DateTime? CreatedAt { get; set; }

        [JsonProperty(PropertyName = "updated_at")]
        public DateTime? UpdatedAt { get; set; }

        [JsonProperty(PropertyName = "resource_url")]
        public string ResourceUrl { get; set; }
    }
}