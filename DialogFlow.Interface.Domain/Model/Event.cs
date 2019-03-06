using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
namespace DialogFlow.Interface.Domain.Model
{
    public class Event
    {
        [JsonProperty("name")]
        public string Name { get; set; }

    }
}
