using System;
using System.Collections.Generic;
using System.Text;

namespace nsGenericDelegate
{
    class GenericDelegateRun
    {
        public void Run()
        {
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("Generic Delegate");
            Console.WriteLine("**************************************************************************");

            GenericDelegate gd = new GenericDelegate();

            //create delegate instances
            NumberChanger<int> nc1 = new NumberChanger<int>(gd.AddNum);
            NumberChanger<int> nc2 = new NumberChanger<int>(gd.MultNum);

            //calling the methods using the delegate objects
            nc1(25);
            Console.WriteLine("Value of Num: {0}", gd.getNum());

            nc2(5);
            Console.WriteLine("Value of Num: {0}", gd.getNum());
            Console.WriteLine("\n");

        }
    }
}
