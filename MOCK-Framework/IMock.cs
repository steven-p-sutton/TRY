using System;

namespace MOCK.Framework
{
    public class IMock
    {
        public enum RunType { SUCCESS = 0, EXCEPTION = 1 };
        public Exception ExceptionExpected { set; get; }
        public Exception ExceptionRaised { set; get; }
        public RunType Run { set; get; }
        public virtual bool Verifyable { set; get; }
        public virtual bool Returns { set; get; }
        public virtual bool ReturnsAsync { set; get; }
        public virtual int Verify { set; get; }
        public virtual RunType Throws { set; get; }
        //public string Message { set; get; }
        public virtual bool Input { set; get; }
        public virtual bool Output { set; get; }
        public virtual RunType Arrange { set; get; }
        public virtual RunType Test { set; get; }
        public virtual RunType Assert { set; get; }
    }
}
