using System;
using nsAnotherClassLibraryUsingSharedCode;

namespace nsAppUsingAnotherClassLibraryUsingSharedCode
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            csAnotherClassLibraryUsingSharedCode a = new csAnotherClassLibraryUsingSharedCode();
            a.sAnotherClassLibraryUsingSharedCode = "Hello sAnotherClassLibraryUsingSharedCodeWorld!";
            //csSharedCode.
            Console.WriteLine(a.sAnotherClassLibraryUsingSharedCode);
        }
    }
}
