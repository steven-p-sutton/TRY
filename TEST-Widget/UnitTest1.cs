using System;
using Xunit;
using MOCK.Framework;
using nsWidget;

namespace TEST_Widget
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var employee = new MWidget
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
            var employee = new MWidget
            {
                Run = IMock.RunType.EXCEPTION,
                Exception = new Exception("Widget Error"),
                Throws = IMock.RunType.EXCEPTION,
                Arrange = IMock.RunType.EXCEPTION,
                Test = IMock.RunType.EXCEPTION,
                Assert = IMock.RunType.EXCEPTION
            };
        }
    }
}
