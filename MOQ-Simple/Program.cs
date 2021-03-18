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
            //employee._mEmployee.Setup(x => x.GetDateOfJoining(It.IsAny<int>())).Returns((int x) => DateTime.Now);
            employee.SetReturns();
            Console.WriteLine(employee.Mock.Object.GetDateOfJoining(1));
            employee.DoAssert();

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
        public void SetReturns();
        public void SetVerifyable();
        public void DoVerify(int n = 1);
    }
    public class MEmployee : IMock
    {
        public Mock<Employee> _mEmployee;

        public DateTime _initlal;
        public int _verify;

        public Mock<Employee> Mock
        {
            get => _mEmployee;
        }

        public MEmployee()
        {
            _mEmployee = new Mock<Employee>();
            this.SetReturns();
            this.SetVerifyable();
            _initlal = DateTime.Now;
            _verify = 1;
        }
        //public Mock<Employee> Mock()
        //{
        //    //_mEmployee.Setup(x => x.GetDateOfJoining(It.IsAny<int>())).Returns((int x) => DateTime.Now);
        //    return _mEmployee;
        //}
        public void SetReturns()
        {
               _mEmployee.Setup(x => x.GetDateOfJoining(It.IsAny<int>()))
                    .Returns((int x) => DateTime.Now);
        }
        public void SetVerifyable()
        {
                _mEmployee.Setup(x => x.GetDateOfJoining(It.IsAny<int>()))
                    .Verifiable();
        }
        public void DoVerify(int n)
        {
            if (n == 0)
                _mEmployee.Verify(x => x.GetDateOfJoining(It.IsAny<int>()), Times.Never());
            else if (n == 1)
                _mEmployee.Verify(x => x.GetDateOfJoining(It.IsAny<int>()), Times.Once());
            else
                _mEmployee.Verify(x => x.GetDateOfJoining(It.IsAny<int>()), Times.Exactly(n));
        }
        public void DoAssert()
        {
            this.DoVerify(_verify);
        }
    }
}

