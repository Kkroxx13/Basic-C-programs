using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class Harmonic
    {
        public  void Harmonicnum(int n)
        {
            int i;
            double s = 0.0;
            for (i = 1; i <= n; i++)
            {
                Console.Write("1/{0} + ", i);
                s += 1 / (float)i;
            }
            Console.Write("\nSum of Series upto {0} terms : {1} \n", n, s);
        }
    }
}
