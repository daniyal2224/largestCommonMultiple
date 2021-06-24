using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number
{
    static class Number
    {
        public static int BMM(int a, int b)
        {
            int k = 0;
            do
            {
                k = a % b;
                a = b;
                b= k;
            } while (k > 0);
            return a;
        }
        //
        public static int Kmm(int a, int b)
        {
            int k = (a * b) / BMM(a, b);
            return k;
        }

    }
}
