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

            a.sharedClass.sSharedClass = "Hello csSharedClass World!";
            Console.WriteLine(a.sharedClass.sSharedClass);
        }
    }
}
