using System;
using Conductus.CODERUN.Model.Core;
using Conductus.EXAMPLE.CODERUN;

namespace Conductus.CODERUN.Try
{
    class Program
    {
        static void Main(string[] args)
        {
            global::CodeRun.Run(new CodeRunTry());
            global::CodeRun.Run(new CodeRunExample());
        }
    }
}
