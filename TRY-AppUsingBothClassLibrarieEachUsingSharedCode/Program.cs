using System;
using nsClassLibraryUsingSharedCode;
using nsAnotherClassLibraryUsingSharedCode;

namespace nsAppUsingBothClassLibrarieEachUsingSharedCode
{
    class Program
    {
        static void Main(string[] args)
        {
            csClassLibraryUsingSharedCode a1 = new csClassLibraryUsingSharedCode();
            a1.sClassLibraryUsingSharedCode = "Hello csClassLibraryUsingSharedCode World!";
            Console.WriteLine(a1.sClassLibraryUsingSharedCode);

            csSharedClass b1 = new csSharedClass();
            b1.sSharedClass = "Hello csSharedClass World!";
            Console.WriteLine(b1.sSharedClass);

            csAnotherClassLibraryUsingSharedCode a2 = new csAnotherClassLibraryUsingSharedCode();
            a2.sAnotherClassLibraryUsingSharedCode = "Hello csAnotherClassLibraryUsingSharedCode World!";
            Console.WriteLine(a2.sAnotherClassLibraryUsingSharedCode);

            b2.sharedClass.sSharedClass = "Hello csSharedClass World!";
            Console.WriteLine(b2.sSharedClass);
        }
    }
}
