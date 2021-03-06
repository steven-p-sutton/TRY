using System;

namespace CODERUN.Framework
{
    public interface ICodeRun
    {
        public string Title { get; }
        public void Run();
    }

    public static class CodeRun
    {
        public static void Run(ICodeRun code)
        {
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine($"{code.Title}");
            Console.WriteLine("*****************************************************************************");

            code.Run();
        }
    }
}
