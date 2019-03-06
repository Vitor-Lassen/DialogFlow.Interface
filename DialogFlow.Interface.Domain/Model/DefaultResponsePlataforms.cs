using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DialogFlow.Interface.Domain.Model
{
    public class DefaultResponsePlataforms
    {
        [JsonProperty("facebook")]
        public bool? Facebook { get; set; }
    }
}
