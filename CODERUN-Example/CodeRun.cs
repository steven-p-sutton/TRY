using System;
using Conductus.CODERUN.Model.Core;
using Conductus.EXAMPLE.Model;

namespace Conductus.EXAMPLE.CODERUN
{
    public class CodeRunExample : ICodeRunModule
    {
        public string Title
        {
            get { return "RunCode Example"; }
        }

        public void Run()
        {
            var module = new Example();
            var mock = new MExample();
            var empty = new EExample();
            var host = new HExample();
        }
    }
}
