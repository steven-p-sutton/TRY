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
            Console.WriteLine(employee.Mock().Object.GetDateOfJoining(1));
            employee.Assert();

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
        public void Returns(bool yes = true);
        public void Verifyable(bool yes = true);
        public void Verify(int n = 1);
    }

    public class MEmployee : IMock
    {
        private Mock<Employee> _mEmployee;
        private DateTime _initlal;
        private int _verify;

        public MEmployee()
        {
            _mEmployee = new Mock<Employee>();
            this.Returns(true);
            this.Verifyable(true);
            _initlal = DateTime.Now;
            _verify = 1;
        }
        public MEmployee(DateTime initial, int verify = 1, bool yesVerifyable = true, bool yesReturns = true)
        {
            _mEmployee = new Mock<Employee>();
            this.Returns(yesReturns);
            this.Verifyable(yesVerifyable);
            _initlal = initial;
            _verify = verify;
        }
        public Mock<Employee> Mock()
        {
            return _mEmployee;
        }
        public void Returns(bool yes = true)
        {
            //if (yes)
                _mEmployee.Setup(x => x.GetDateOfJoining(It.IsAny<int>()))
                    .Returns((int x) => DateTime.Now);
            //else
            //    _mEmployee.Setup(x => x.GetDateOfJoining(It.IsAny<int>()));
        }
        public void Verifyable(bool yes = true)
        {
            //if (yes)
                _mEmployee.Setup(x => x.GetDateOfJoining(It.IsAny<int>()))
                    .Verifiable();
            //else
            //    _mEmployee.Setup(x => x.GetDateOfJoining(It.IsAny<int>()));
        }
        public void Verify(int n)
        {
            if (n == 0)
                _mEmployee.Verify(x => x.GetDateOfJoining(It.IsAny<int>()), Times.Never());
            else if (n == 1)
                _mEmployee.Verify(x => x.GetDateOfJoining(It.IsAny<int>()), Times.Once());
            else
                _mEmployee.Verify(x => x.GetDateOfJoining(It.IsAny<int>()), Times.Exactly(n));
        }
        public void Assert()
        {
            this.Verify(_verify);
        }
    }
}

