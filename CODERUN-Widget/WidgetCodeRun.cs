using System;
using CODERUN.Framework;
using Conductus.WIDGET.Model.Core;
using MOCK.Framework;
using nsWidget;

namespace CODERUN.WidgetNS
{
    public class WidgetCodeRun : ICodeRunModule
    {
        public string Title
        {
            get { return "Widget MOQ Code Run"; }
        }

        public void Run()
        {
            try
            {
                var widget = new MWidget
                {
                    Run = IMock.RunType.SUCCESS,
                    Arrange = IMock.RunType.SUCCESS,
                    Test = IMock.RunType.SUCCESS,
                    Assert = IMock.RunType.SUCCESS
                };

                var widget2 = new MWidget
                {
                    Run = IMock.RunType.EXCEPTION,
                    Exception = new Exception("Widget Error"),
                    Throws = IMock.RunType.EXCEPTION,
                    Arrange = IMock.RunType.EXCEPTION,
                    Test = IMock.RunType.EXCEPTION,
                    Assert = IMock.RunType.EXCEPTION
                };
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
