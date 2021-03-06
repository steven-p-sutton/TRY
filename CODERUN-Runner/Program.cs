using CODERUN.Framework;
using CODERUN.Sample;

namespace CODERUN.Runner
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var cr = new SampleCodeRun();
            CodeRun.Run(cr);     
        }
    }
}
