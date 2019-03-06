using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DialogFlow.Interface.Domain.Model
{
    public class Context
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("parameters")]
        public Parameter Parameters  { get; set; }
        [JsonProperty("lifespan")]
        public int Lifespan  { get; set; }

    }
}
