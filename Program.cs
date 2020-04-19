using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring variables
            int a = 0, b = 0;

            //Requesting data from the user
            Console.Write(" Enter the first number: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write(" Enter the second number: ");
            b = Convert.ToInt32(Console.ReadLine());

            if (a < b)
            {
                while (a <= b)
                {
                    if (a % 5 == 0)
                    {
                        Console.WriteLine(" {0}", a);
                    }

                    a++;
                }
            }
            else
            {
                if ((a == b) && (a % 5 == 0))
                {
                    Console.WriteLine(" {o}", a);
                }
                else
                {
                    if (b < a)
                    {
                        while (b <= a)
                        {
                            if (b % 5 == 0)
                            {
                               Console.WriteLine(" {0}", b);
                              
                            }

                            b++;
                        }
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
