using System;
using CODERUN.Framework;
using nsGenericDelegate;

namespace CODERUN.GenericDelegate
{
    public class GenericDelegateRun : ICodeRunModule
    {
        public string Title
        {
            get { return "Generic Delegate"; }
        }
        public void Run()
        {
            //create delegate instances
            NumberChanger<int> nc1 = new NumberChanger<int>(nsGenericDelegate.GenericDelegate.AddNum);
            NumberChanger<int> nc2 = new NumberChanger<int>(nsGenericDelegate.GenericDelegate.MultNum);

            //calling the methods using the delegate objects
            nc1(25);
            Console.WriteLine("Value of Num: {0}", nsGenericDelegate.GenericDelegate.getNum());

            nc2(5);
            Console.WriteLine("Value of Num: {0}", nsGenericDelegate.GenericDelegate.getNum());

            Console.WriteLine("\n");
        }
    }
}
