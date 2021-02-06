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
            // Create a fake (mocked) version of our object using it's definition, either temp, or real, 
            // but we do not want to use the unerlying implemetation and the mock wrappwe around it
            // will prevent the real semantics being invoked. Instead the mock version will intercept and
            // the redfined, mocked, semantics invokded instead.

            // Created a mocked wrapper containg the object we want (Employee). In reality it hives the object's
            // interface and makes this available to define the mock semantics in a later step.

            var employee = new Mock<Employee>();

            // Define the alternative, mocked, semantics for our object (Employee)
            // takes an int & returns a DateTime (see Employee class below)

            employee.Setup(x => x.GetDateofJoining
            (
                It.IsAny<int>())
            )
            .Returns((int x) => DateTime.Now);

            // Define the test. In this case it uses the mocked object (Employee). It is important to understand that
            // the mocked object is not the test subject, but instead the environment required.

            Console.WriteLine(employee.Object.GetDateofJoining(1));

            Console.ReadLine();
        }
    }

    // This is the object dependency of the test, that either we don't want, or can't use in our test. It is NOT
    // the test subject, but instead the environment required.

    public class Employee
    {
        public virtual DateTime GetDateofJoining(int id)
        {
            throw new NotImplementedException();
        }
    }
}
