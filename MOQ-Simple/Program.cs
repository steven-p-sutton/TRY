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
            Console.WriteLine(new MEmployee().Setup().Object.GetDateofJoining(1));

            Console.ReadLine();
        }
    }

    public class Employee
    {
        public virtual DateTime GetDateofJoining(int id) { throw new NotImplementedException(); }
    }
    public class MEmployee
    {
        private Mock<Employee> _mEmployee;
        public MEmployee()
        {
            _mEmployee = new Mock<Employee>();
        }
        public Mock<Employee> GetMEmployee()
        {
            return _mEmployee;
        }
        public Mock<Employee> Setup()
        {
            _mEmployee.Setup(x => x.GetDateofJoining(It.IsAny<int>()))
                .Returns((int x) => DateTime.Now);
            return _mEmployee;
        }
    }
}

