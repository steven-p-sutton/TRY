using System.Collections.Generic;
using Newtonsoft.Json;

namespace Conductus.EXAMPLE.Model
{
    public class Example : IExample
    {
        [JsonProperty("str")]
        public string Str { get; set; }
        [JsonProperty("int")]
        public int Int { get; set; }
        [JsonProperty("list")]
        public List<string> Repository { get; set; }
        public int Add(string item)
        {
            this.Repository.Add(item);
            return Repository.IndexOf(item);
        }
        public string Remove(int idx)
        {
            string item = this.Repository[idx];
            this.Repository.Remove(item);
            return item;
        }
        public int Find (string item)
        {
            return this.Repository.IndexOf(item);
        }
    }
}
