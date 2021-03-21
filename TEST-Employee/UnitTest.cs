using System;
using Xunit;
using MOQ.Framework;
using nsEmployee;

namespace TEST_Employee
{
    public class UnitTest
    {
        [Fact]
        public void Test1()
        {
            var employee = new MEmployee
            {
                Run = IMock.RunType.SUCCESS,
                Arrange = IMock.RunType.SUCCESS,
                Test = IMock.RunType.SUCCESS,
                Assert = IMock.RunType.SUCCESS
            };
        }

        [Fact]
        public void Test2()
        {
            var employee = new MEmployee
            {
                Run = IMock.RunType.EXCEPTION,
                Exception = new Exception("Employee Error"),
                Throws = IMock.RunType.EXCEPTION,
                Arrange = IMock.RunType.EXCEPTION,
                Test = IMock.RunType.EXCEPTION,
                Assert = IMock.RunType.EXCEPTION
            };
        }
    }
}
