using System;
using Xunit;
using Conductus.MOCK.Framework;
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
                ExceptionExpected = new Exception("Employee Error"),
                Throws = IMock.RunType.EXCEPTION,
                Arrange = IMock.RunType.EXCEPTION
            };

            employee.ExceptionRaised = Assert.Throws<Exception>(() => employee.Test = IMock.RunType.EXCEPTION);
            Assert.Equal(employee.ExceptionExpected.Message, employee.ExceptionRaised.Message);
            employee.Assert = IMock.RunType.EXCEPTION;
        }
    }
}
