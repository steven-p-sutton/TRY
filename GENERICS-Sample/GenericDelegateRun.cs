using System;
using System.Collections.Generic;
using System.Text;

namespace nsGenericDelegate
{
    class GenericDelegateRun
    {
        public void Run()
        {
            //GenericDelegate gd = new GenericDelegate();

            //create delegate instances
            NumberChanger<int> nc1 = new NumberChanger<int>(GenericDelegate.AddNum);
            NumberChanger<int> nc2 = new NumberChanger<int>(GenericDelegate.MultNum);

            //calling the methods using the delegate objects
            nc1(25);
            Console.WriteLine("Value of Num: {0}", GenericDelegate.getNum());

            nc2(5);
            Console.WriteLine("Value of Num: {0}", GenericDelegate.getNum());
            Console.ReadKey();
        }
    }
}
