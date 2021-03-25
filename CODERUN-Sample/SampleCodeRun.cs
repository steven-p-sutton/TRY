using System;
using Conductus.CODERUN.Framework;
using SAMPLE;

namespace Conductus.CODERUN.SAMPLE
{
    public class SampleCodeRun : ICodeRunModule
    {
        public string Title
        {
            get { return "Sample Code Run"; }
        }

        public void Run()
        {
            var sample = new SampleClass();
            Console.WriteLine(sample.Hello("Steve"));
        }
    }
}
