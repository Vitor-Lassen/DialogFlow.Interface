using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DialogFlow.Interface.Domain.Model
{
    public class UserSay
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("data")]
        public UserSayData data { get; set; }

        [JsonProperty("isTemplate")]
        public bool IsTemplate { get; set; }
        
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("updated")]
        public long Updated { get { return DateTimeOffset.Now.ToUnixTimeSeconds(); } set { } }
    }
}
