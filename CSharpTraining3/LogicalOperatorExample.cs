using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining3
{
    class LogicalOperatorExample
    {
        static void Main()
        {
            Console.WriteLine("Enter vowel");
            char text = Convert.ToChar(Console.ReadLine());

            if (text == 'a' || text == 'e' || text == 'i' || text == 'o' || text == 'u')
            {
                Console.WriteLine("This is vowel");
            }
            else
            {
                Console.WriteLine("This is not vowel");
            }

            Console.WriteLine("Enter number");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num > 0 && num < 100)
            {
                Console.WriteLine("This is integer and less than 100:" + num);
            }

        }
    }
}
