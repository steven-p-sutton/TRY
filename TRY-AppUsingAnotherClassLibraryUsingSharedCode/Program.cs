using System;
using nsAnotherClassLibraryUsingSharedCode;

namespace nsAppUsingAnotherClassLibraryUsingSharedCode
{
    class Program
    {
        static void Main(string[] args)
        {
            csAnotherClassLibraryUsingSharedCode a = new csAnotherClassLibraryUsingSharedCode();

            a.sAnotherClassLibraryUsingSharedCode = "Hello sAnotherClassLibraryUsingSharedCodeWorld!";
            Console.WriteLine(a.sAnotherClassLibraryUsingSharedCode);

            csSharedClass b = new csSharedClass();

            b.sSharedClass = "Hello csSharedClass World!";
            Console.WriteLine(b.sSharedClass);
        }
    }
}
