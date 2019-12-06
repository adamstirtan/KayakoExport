using Newtonsoft.Json;
using System;

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

        [JsonProperty(PropertyName = "requester")]
        public Requester Requester { get; set; }

        [JsonProperty(PropertyName = "creator")]
        public Creator Creator { get; set; }

        [JsonProperty(PropertyName = "identity")]
        public Identity Identity { get; set; }

        [JsonProperty(PropertyName = "assigned_agent")]
        public AssignedAgent AssignedAgent { get; set; }

        [JsonProperty(PropertyName = "assigned_team")]
        public AssignedTeam AssignedTeam { get; set; }

        [JsonProperty(PropertyName = "last_assigned_by")]
        public LastAssignedBy LastAssignedBy { get; set; }

        [JsonProperty(PropertyName = "brand")]
        public Brand Brand { get; set; }

        [JsonProperty(PropertyName = "priority")]
        public Priority Priority { get; set; }

        [JsonProperty(PropertyName = "read_marker")]
        public string ReadMarker { get; set; }

        [JsonProperty(PropertyName = "state")]
        public string State { get; set; }

        [JsonProperty(PropertyName = "post_count")]
        public int PostCount { get; set; }

        [JsonProperty(PropertyName = "has_notes")]
        public bool HasNotes { get; set; }

        [JsonProperty(PropertyName = "pinned_notes_count")]
        public int PinnedNotesCount { get; set; }

        [JsonProperty(PropertyName = "has_attachments")]
        public bool HasAttachments { get; set; }

        [JsonProperty(PropertyName = "last_post_preview")]
        public string LastPostPreview { get; set; }

        [JsonProperty(PropertyName = "last_message_preview")]
        public string LastMessagePreview { get; set; }

        [JsonProperty(PropertyName = "last_assigned_at")]
        public DateTime? LastAssignedAt { get; set; }

        [JsonProperty(PropertyName = "last_replied_at")]
        public DateTime? LastRepliedAt { get; set; }

        [JsonProperty(PropertyName = "last_opened_at")]
        public DateTime? LastOpenedAt { get; set; }

        [JsonProperty(PropertyName = "last_pending_at")]
        public DateTime? LastPendingAt { get; set; }

        [JsonProperty(PropertyName = "last_closed_at")]
        public DateTime? LastClosedAt { get; set; }

        [JsonProperty(PropertyName = "last_completed_at")]
        public DateTime? LastCompletedAt { get; set; }

        [JsonProperty(PropertyName = "last_agent_activity_at")]
        public DateTime? LastAgentActivityAt { get; set; }

        [JsonProperty(PropertyName = "last_customer_activity_at")]
        public DateTime? LastCustomerActivityAt { get; set; }

        [JsonProperty(PropertyName = "last_reply_by_agent_at")]
        public DateTime? LastReplyByAgentAt { get; set; }

        [JsonProperty(PropertyName = "last_reply_by_requester_at")]
        public DateTime? LastReplyByRequesterAt { get; set; }

        [JsonProperty(PropertyName = "agent_updated_at")]
        public DateTime? AgentUpdatedAt { get; set; }

        [JsonProperty(PropertyName = "latest_assignee_update")]
        public DateTime? LastestAssigneeUpdate { get; set; }

        [JsonProperty(PropertyName = "created_at")]
        public DateTime? CreatedAt { get; set; }

        [JsonProperty(PropertyName = "updated_at")]
        public DateTime? UpdatedAt { get; set; }

        [JsonProperty(PropertyName = "resource_url")]
        public string ResourceUrl { get; set; }
    }
}