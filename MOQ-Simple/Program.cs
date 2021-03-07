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
            var employee = new MEmployee();
            employee.Returns();
            employee.Verifyable();

            Console.WriteLine(employee.Mock().Object.GetDateOfJoining(1));

            employee.Verify();

            Console.ReadLine();
        }
    }

    public interface IEmployee
    {
        public DateTime GetDateOfJoining(int id);
    }
    public class Employee : IEmployee
    {
        public virtual DateTime GetDateOfJoining(int id) { throw new NotImplementedException(); }
    }

    public interface IMock
    {
        //public Mock<Employee> Mock();
        public void Returns();
        public void Verifyable();
        public void Verify(int n = 1);
    }

    public class MEmployee : IMock
    {
        private Mock<Employee> _mEmployee;
  
        public MEmployee()
        {
            _mEmployee = new Mock<Employee>();
        }
        public Mock<Employee> Mock()
        {
            return _mEmployee;
        }
        public void Returns()
        {
            _mEmployee.Setup(x => x.GetDateOfJoining(It.IsAny<int>()))
                .Returns((int x) => DateTime.Now);
        }
        public void Verifyable()
        {
            _mEmployee.Setup(x => x.GetDateOfJoining(It.IsAny<int>()))
                .Verifiable();
        }
        public void Verify(int n = 1)
        {
            if (n == 0)
                _mEmployee.Verify(x => x.GetDateOfJoining(It.IsAny<int>()), Times.Never());
            else if (n == 1)
                _mEmployee.Verify(x => x.GetDateOfJoining(It.IsAny<int>()), Times.Once());
            else
                _mEmployee.Verify(x => x.GetDateOfJoining(It.IsAny<int>()), Times.Exactly(n));
        }
    }
}

