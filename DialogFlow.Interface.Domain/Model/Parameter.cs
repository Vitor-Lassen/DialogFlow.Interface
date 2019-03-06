using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace DialogFlow.Interface.Domain.Model
{
    public class Parameter
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("dataType")]
        public string DataType { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("value")]
        public string Value { get; set; }
        [JsonProperty("isList")]
        public string IsList { get; set; }
    }
}
