using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Conductus.MODEL.EXAMPLE
{
    public class Example
    {
        [JsonProperty("str")]
        public string Str { get; set; }
        [JsonProperty("int")]
        public int Int { get; set; }
        [JsonProperty("list")]
        public List<string> List { get; set; }
    }
}
