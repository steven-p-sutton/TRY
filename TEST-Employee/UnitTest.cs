using System;
using Xunit;
using Conductus.EMPLOYEE.Model;

namespace Conductus.EMPLOYEE.Test
{
    public class UnitTest
    {
        [Fact]
        public void Test1()
        {
            var employee = new MEmployee
            {
                Run = RunType.SUCCESS,
                Arrange = true,
                Test = true,
                Assert = true
            };
        }

        [Fact]
        public void Test2()
        {
            var employee = new MEmployee
            {
                Run = RunType.EXCEPTION,
                ExceptionExpected = new Exception("Employee Error"),
                Throws = true,
                Arrange = true
            };

            employee.ExceptionRaised = Assert.Throws<Exception>(() => employee.Test = true);
            Assert.Equal(employee.ExceptionExpected.Message, employee.ExceptionRaised.Message);
            employee.Assert = true;
        }
    }
}
