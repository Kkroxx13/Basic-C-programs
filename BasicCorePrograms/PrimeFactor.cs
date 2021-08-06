using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class PrimeFactor
    {
        
        public static void Factor(int a)
        {
            int b;
            for (b = 1; b <= a; b++)
            {
                if (a % b == 0)
                {
                    Console.WriteLine(b + " is a factor of " + a);
                }
            }
        }
    }
}
