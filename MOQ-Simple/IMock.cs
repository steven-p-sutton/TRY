using Moq;
using nsEmployee;
using System;
using System.Collections.Generic;

namespace Mock
{
    //public class IMock<T>
    public class IMock
    {
        //public Mock<T> _mMock;
        //public IMock()
        //{
        //    _mMock = new Mock<T>();
        //}
        //public Mock<T> Mock
        //{
        //    get => _mMock;
        //}
        public virtual bool Verifyable { set; get; }
        public virtual bool Returns { set; get; }
        public virtual int Verify { set; get; }
    }
}
