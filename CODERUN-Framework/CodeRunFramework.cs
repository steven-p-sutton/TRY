using System;

namespace CODERUN
{
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
}
