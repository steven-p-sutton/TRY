using System;
using CODERUN.Framework;
using nsSample;

namespace CODERUN.Sample
{
    public class SampleCodeRun : ICodeRunModule
    {
        public string Title
        {
            get { return "Sample Code Run"; }
        }

        public void Run()
        {
            SampleClass sample = new SampleClass();
            Console.WriteLine(sample.Hello("Steve"));
        }
    }
}
