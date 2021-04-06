using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Conductus.EXAMPLE.Model
{
    public class EExample : IExample
    {
        [JsonProperty("str")]
        public string Str 
        {
            get
            {
                throw new NotImplementedException(); 
            }
            
            set
            {
                throw new NotImplementedException(); 
            }
        }
        [JsonProperty("int")]
        public int Int 
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
        [JsonProperty("list")]
        public List<string> Repository 
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            } 
        }
        public int Add(string item)
        {
            throw new NotImplementedException();
        }
        public string Remove(int idx)
        {
            throw new NotImplementedException();
        }
        public int Find(string item)
        {
            throw new NotImplementedException();
        }
    }
}
