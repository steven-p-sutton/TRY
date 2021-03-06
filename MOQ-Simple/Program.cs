using System;
using Moq;

// https://www.codeproject.com/articles/991028/using-moq-for-unit-testing
//
// Overview: Try an Employee, as yes not fully implemented, using a mocked, test only version
// 

namespace MOQ_Simple
{
    class Program
    {
        static void Main(string[] args)
        {
            MockEmployee mockEmployee = new MockEmployee();
            mockEmployee.Returns();
            mockEmployee.Verifyable();

            Console.WriteLine(mockEmployee.Get().Object.GetDateofJoining(1));

            Console.ReadLine();
        }
    }

    public class Employee
    {
        public virtual DateTime GetDateofJoining(int id) { throw new NotImplementedException(); }
    }
    public class MockEmployee
    {
        private Mock<Employee> _mEmployee;
  
        public MockEmployee()
        {
            _mEmployee = new Mock<Employee>();
        }
        public Mock<Employee> Get()
        {
            return _mEmployee;
        }
        public void Returns()
        {
            _mEmployee.Setup(x => x.GetDateofJoining(It.IsAny<int>()))
                .Returns((int x) => DateTime.Now);
        }
        public void Verifyable()
        {
            _mEmployee.Setup(x => x.GetDateofJoining(It.IsAny<int>()))
                .Verifiable();
        }
    }
}

