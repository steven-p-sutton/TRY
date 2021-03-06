using System;

namespace CODERUN
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var cr = new SampleCodeRun();
            CODERUN.CodeRun.Run(cr);
        }
    }

    public interface ICodeRun
    {
        public string Title { get; }
        public void Run();
    }

    static class CodeRun
    {
        public static void Run(ICodeRun code)
        {
            code.Run();
        }
    }

    public class SampleCodeRun : ICodeRun
    {
        public string Title {
            get { return "Sample Code Run"; } 
        }

        public void Run()
        {
            Console.WriteLine("Sample Code Run says Hello");
        }
    }
}
