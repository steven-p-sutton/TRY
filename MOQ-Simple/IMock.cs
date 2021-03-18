using Moq;
using nsEmployee;
using System;
using System.Collections.Generic;

namespace Mock
{
    //public class IMock<T>
    public class IMock
    {
        //public <T> _mMock;
        //{
        //    _mMock = new <T>();
        //}
        //public Mock<T> Mock
        //{
        //    get => _mMock;
        //}
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
