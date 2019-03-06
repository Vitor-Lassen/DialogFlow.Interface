using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DialogFlow.Interface.Domain.Model
{
    public class TextMessage : Message
    {
        [JsonProperty("speech")]
        public string Speech { get; set; }    

    }
}
