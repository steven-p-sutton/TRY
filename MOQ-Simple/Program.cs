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
            employee.Verifyable = true;
            employee.Returns = true;
            Console.WriteLine(employee.Mock.Object.GetDateOfJoining(1));
            employee.Verify = 1;
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
    public abstract class IMock
    {
        public abstract bool Verifyable { set; }
        public abstract bool Returns { set; }
        public abstract int Verify { set; }
        public abstract void Assert();
    }
    public class MEmployee
    {
        public Mock<Employee> _mEmployee;

        public Mock<Employee> Mock
        {
            get => _mEmployee;
        }

        public MEmployee()
        {
            _mEmployee = new Mock<Employee>();
        }
        public bool Returns
        {
            set =>
               _mEmployee.Setup(x => x.GetDateOfJoining(It.IsAny<int>()))
                    .Returns((int x) => DateTime.Now);
        }
        public bool Verifyable
        {
            set =>
                _mEmployee.Setup(x => x.GetDateOfJoining(It.IsAny<int>()))
                    .Verifiable();
        }
        public int Verify
        {
            set
            {
                if (value == 0)
                     _mEmployee.Verify(x => x.GetDateOfJoining(It.IsAny<int>()), Times.Never());
                else if (value == 1)
                    _mEmployee.Verify(x => x.GetDateOfJoining(It.IsAny<int>()), Times.Once());
                else
                    _mEmployee.Verify(x => x.GetDateOfJoining(It.IsAny<int>()), Times.Exactly(value));
            }
        }
        public void Assert()
        {
        }
    }
}

