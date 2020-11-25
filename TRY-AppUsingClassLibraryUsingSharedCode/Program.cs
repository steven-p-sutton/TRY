using System;
using nsClassLibraryUsingSharedCode;

namespace nsAppUsingClassLibraryUsingSharedCode
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            csClassLibraryUsingSharedCode a = new csClassLibraryUsingSharedCode();
            a.sClassLibraryUsingSharedCode = "Hello ClassLibraryUsingSharedCode World!";
            //csSharedCode.
            Console.WriteLine(a.sClassLibraryUsingSharedCode);
        }
    }
}
