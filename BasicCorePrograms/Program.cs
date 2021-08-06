using System;

namespace BasicCorePrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            bool loopbreak = true;
            while (loopbreak)
            {
                Console.WriteLine("1.Program to Replace username with string");
                Console.WriteLine("2.Program to check leapyear or not");
                Console.WriteLine("3.Program to display harmonic number for n terms ");
                Console.WriteLine("4.Program to display prime factorization of a number ");

                Console.WriteLine("Please select a program");
                int input = Convert.ToInt32(Console.ReadLine());

                




                    switch (input)
                    {

                        case 1:
                            Console.WriteLine("Enter Username");
                            string username = Console.ReadLine();
                            ReplaceString.Replace(username);
                            break;

                        case 2:

                            Console.WriteLine("Enter the Year in four digits");
                            int year = Convert.ToInt32(Console.ReadLine());
                            LeapYear.Leap(year);
                            break;

                        case 3:
                            int i;
                            double s = 0.0;
                            Console.WriteLine("Input the number of terms");
                            int n = Convert.ToInt32(Console.ReadLine());
                            Harmonic number = new Harmonic();
                            number.Harmonicnum(n);
                            break;

                        case 4:

                            Console.WriteLine("Please enter your integer: ");
                            int a = int.Parse(Console.ReadLine());
                            PrimeFactor.Factor(a);
                            break;

                        default:
                            Console.WriteLine("Please enter valid choice");
                            loopbreak = false;
                            break;



                    }
                if (loopbreak)
                    Console.WriteLine("Please enter valid option");
                
            }
            
        }
    }
}
