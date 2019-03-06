using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace DialogFlow.Interface.Domain.Model
{
    public class Intent
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("parentId")]
        public string ParentId { get; set; }

        [JsonProperty("rootParentId")]
        public string RootParentId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("auto")]
        public bool Auto  { get; set; }

        [JsonProperty("contexts")]
        public List<string> Contexts { get; set; }

        [JsonProperty("responses")]
        public List<Response> Responses  { get; set; }

        [JsonProperty("priority")]
        public int Priority  { get; set; }

        [JsonProperty("webhookUsed")]
        public bool WebhookUsed  { get; set; }

        [JsonProperty("webhookForSlotFilling")]
        public bool WebhookForSlotFilling  { get; set; }

        [JsonProperty("lastUpdate")]
        public long LastUpdate { get { return DateTimeOffset.Now.ToUnixTimeSeconds(); } set { } }

        [JsonProperty("fallbackIntent")]
        public bool FallbackIntent { get; set; }

        [JsonProperty("events")]
        public List<Event> Events { get; set; }

        [JsonIgnore]
        public List<UserSay> UserSays { get; set; }
    }
}
