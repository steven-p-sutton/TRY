using System;
using Newtonsoft.Json;

namespace MOCK.Framework
{
    public class IMock
    {
        public enum RunType { SUCCESS = 0, EXCEPTION = 1 };
        [JsonProperty("run")] 
        public RunType Run { set; get; }
        [JsonProperty("input")]
        public virtual bool Input { set; get; }
        [JsonProperty("output")]
        public virtual bool Output { set; get; }
        [JsonProperty("exceptionExpected")]
        public Exception ExceptionExpected { set; get; }
        [JsonProperty("exceptionRaised")]
        public Exception ExceptionRaised { set; get; }
        [JsonProperty("verifyable")]
        public virtual bool Verifyable { set; get; }
        [JsonProperty("returns")]
        public virtual bool Returns { set; get; }
        [JsonProperty("returnsAsync")]
        public virtual bool ReturnsAsync { set; get; }
        [JsonProperty("verify")]
        public virtual int Verify { set; get; }
        [JsonProperty("throws")]
        public virtual RunType Throws { set; get; }
        [JsonProperty("arrange")]
        public virtual RunType Arrange { set; get; }
        [JsonProperty("test")]
        public virtual RunType Test { set; get; }
        [JsonProperty("assert")]
        public virtual RunType Assert { set; get; }
    }
}
