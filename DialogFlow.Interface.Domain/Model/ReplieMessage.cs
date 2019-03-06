using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DialogFlow.Interface.Domain.Model
{
    public class ReplieMessage :Message
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("replies")]
        public string [] Replies  { get; set; }

    }
}
