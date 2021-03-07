using CODERUN.Framework;
using CODERUN.Sample;
using CODERUN.GenericArray;

namespace CODERUN.Runner
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var cr = new SampleCodeRun();
            CodeRun.Run(cr);

            var ga = new GenericArrayCodeRun();
            CodeRun.Run(ga);
        }
    }
}
