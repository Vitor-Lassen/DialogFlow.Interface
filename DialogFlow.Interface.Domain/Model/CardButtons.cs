using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DialogFlow.Interface.Domain.Model
{
    public class CardButtons
    {
        [JsonProperty("text")]
        public string  Text{ get; set; }

        [JsonProperty("postback")]
        public string Postback { get; set; }
}
}
