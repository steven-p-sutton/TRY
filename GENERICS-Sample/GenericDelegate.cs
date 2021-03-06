using System;
using System.Collections.Generic;
using System.Text;

namespace nsGenericDelegate
{
    delegate T NumberChanger<T>(T n);

    public static class GenericDelegate
    {
        static int num = 10;

        public static int AddNum(int p)
        {
            num += p;
            return num;
        }
        public static int MultNum(int q)
        {
            num *= q;
            return num;
        }
        public static int getNum()
        {
            return num;
        }
    }
}
