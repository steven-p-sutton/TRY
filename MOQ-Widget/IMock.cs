using System;

namespace Mock
{
    public class IMock
    {
        public virtual bool Verifyable { set; get; }
        public virtual bool Returns { set; get; }
        public virtual bool ReturnsAsync { set; get; }
        public virtual int Verify { set; get; }
        public virtual void Throws(Exception exception, string message)
        {
        }
        public virtual string message { get; set; }
    }
}
