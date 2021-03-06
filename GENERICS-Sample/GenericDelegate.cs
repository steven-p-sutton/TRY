using System;
using System.Collections.Generic;
using System.Text;

namespace nsGenericDelegate
{
    delegate T NumberChanger<T>(T n);

    public class GenericDelegate
    {
        int num = 10;

        public int AddNum(int p)
        {
            num += p;
            return num;
        }
        public int MultNum(int q)
        {
            num *= q;
            return num;
        }
        public int getNum()
        {
            return num;
        }
    }
}
