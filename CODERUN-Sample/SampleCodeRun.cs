﻿using System;
using CODERUN.Framework;

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
            Console.WriteLine("Sample Code Run says Hello");
        }
    }
}