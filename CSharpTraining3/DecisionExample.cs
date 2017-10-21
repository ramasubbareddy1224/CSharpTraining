using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining3
{
    class DecisionExample
    {
        static void Main()
        {
            Console.WriteLine("Enter number");
            int num =Convert.ToInt32(Console.ReadLine());

            if (null > 0)
            {
                if (num > 100) // true or false
                {
                    Console.WriteLine("entered number is greater than 100");
                }
                else
                {
                    Console.WriteLine("less than 100");
                }
            }
            else
            {
                Console.WriteLine("Enter valid number");
            }

            Console.ReadKey();
        }
    }
}
