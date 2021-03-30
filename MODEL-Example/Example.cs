using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Conductus.MODEL.EXAMPLE
{
    public class Example
    {
        [JsonProperty("prop")]
        public string Prop { get; set; }
    }
}
