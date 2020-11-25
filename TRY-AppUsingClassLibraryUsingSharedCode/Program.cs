using System;
using nsClassLibraryUsingSharedCode;

namespace nsAppUsingClassLibraryUsingSharedCode
{
    class Program
    {
        static void Main(string[] args)
        {
            csClassLibraryUsingSharedCode a = new csClassLibraryUsingSharedCode();

            a.sClassLibraryUsingSharedCode = "Hello ClassLibraryUsingSharedCode World!";
            Console.WriteLine(a.sClassLibraryUsingSharedCode);

            csSharedClass b = new csSharedClass();

            b.sSharedClass = "Hello csSharedClass World!";
            Console.WriteLine(b.sSharedClass);
        }
    }
}
