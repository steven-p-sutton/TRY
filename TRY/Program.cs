using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRY
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TRY");
            A A0 = new A();
            Console.WriteLine(A0.a);

            A A1 = new A("1st");
            Console.WriteLine(A1.a);

            A A2 = new A("First", "Second");
            Console.WriteLine(A2.a);

            A A3 = new A
            {
                a = "1"
            };
            Console.WriteLine(A3.a);
        }
    }
    public class A
    {
        public A()
        {
        }
        public A(string one)
        {
            a = one;
        }
        public A(string one, string two)
        {
            a = one + " " + two;
        }
        public string a;
    }
}
  
