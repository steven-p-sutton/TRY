using System;
using nsGenericArray;
using nsGenericMethod;
using nsGenericDelegate;

// Based on :https://www.tutorialspoint.com/csharp/csharp_generics.htm

class Program
{
    static void Main(string[] args)
    {
        var a = new GenericArrayRun();
        a.Run();

        var m = new GenericMethodRun();
        m.Run();

        var d = new GenericDelegateRun();
        d.Run();
    }
}
