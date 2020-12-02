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
            A A1 = new A();
            B B1 = new B();
            A1.a = "A1.a";
            Console.WriteLine(A1.a);
            B1.a = "B1.a";
            Console.WriteLine(B1.a);
            B1.b = "B1.b";
            Console.WriteLine(B1.b);
        }
    }
    public class A
    {
        public string a;
    }
    public class B : A
    {
        public string b;
    }
}
