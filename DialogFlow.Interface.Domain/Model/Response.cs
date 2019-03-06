using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DialogFlow.Interface.Domain.Model
{
    public class Response
    {
        [JsonProperty("resetContexts")]
        public bool ResetContexts { get; set; }

        [JsonProperty("action")]
        public string Action { get; set; }

        [JsonProperty("affectedContexts")]
        public List<Context> AffectedContexts  { get; set; }

        [JsonProperty("parameters")]
        public List<Parameter> Parameters { get; set; }

        [JsonProperty("messages")]
        public List<object> Messages  { get; set; }

        [JsonProperty("defaultResponsePlatforms")]
        public DefaultResponsePlataforms DefaultResponsePlataforms { get; set; }

        [JsonProperty("speech")]
        public List<string> speech { get; set; }

    }
}
