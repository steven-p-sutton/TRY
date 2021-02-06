using System;
using Moq;

// https://www.codeproject.com/articles/991028/using-moq-for-unit-testing

namespace MOQ_Simple
{
    class Program
    {
        static void Main(string[] args)
        {
            var employee = new Mock<Employee>();
            employee.Setup(x => x.GetDateofJoining(It.IsAny<int>())).Returns((int x) => DateTime.Now);

            Console.WriteLine(employee.Object.GetDateofJoining(1));
            Console.ReadLine();
        }
    }

    public class Employee
    {
        public virtual DateTime GetDateofJoining(int id)
        {
            throw new NotImplementedException();
        }
    }
}
