using System;
using nsGenericArray;
using nsGenericMethod;

class Program
{
    static void Main(string[] args)
    {
        var a = new GenericArrayRun();
        a.Run();

        var m = new GenericMethodRun();
        m.Run();
    }
}
