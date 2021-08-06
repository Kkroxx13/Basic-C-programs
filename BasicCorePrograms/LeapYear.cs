using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class LeapYear
    {
       public static void Leap(int year)
        {
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine("{0} is a Leap Year", year);
            }
            else
            {
                Console.WriteLine("{0} is not a Leap Year", year);
            }
        }
    }
}
