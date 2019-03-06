using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DialogFlow.Interface.Domain.Model
{
    public abstract class Message
    {
        [JsonProperty("type")]
        public int Type { get; set; }

        [JsonProperty("lang")]
        public string Lang { get; set; }

        [JsonProperty("plataform")]
        public string Plataform { get; set; }
    }
}
