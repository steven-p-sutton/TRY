using System;
using nsGenericArray;
using nsGenericMethod;
using nsGenericDelegate;

class Program
{
    static void Main(string[] args)
    {
        var a = new GenericArrayRun();
        //a.Run();

        var m = new GenericMethodRun();
        m.Run();

        var d = new GenericDelegateRun();
        d.Run();
    }
}
