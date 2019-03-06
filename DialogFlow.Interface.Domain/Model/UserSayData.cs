using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DialogFlow.Interface.Domain.Model
{
    public class UserSayData
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("meta")]
        public string Meta { get; set; }

        [JsonProperty("userDefined")]
        public bool UserDefined { get; set; }
    }
}
