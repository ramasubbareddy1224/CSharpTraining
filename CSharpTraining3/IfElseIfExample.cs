using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining3
{
    class IfElseIfExample
    {
        static void Main()
        {
            Console.WriteLine("Enter vowel");
            char text = Convert.ToChar(Console.ReadLine());
            if (text == 'a')
            {
                Console.WriteLine("This is a vowel");
            }
            else if (text == 'e')
            {
                Console.WriteLine("This is a vowel");
            }
            else if (text == 'i')
            {
                Console.WriteLine("This is a vowel");
            }
            else if (text == 'o')
            {
                Console.WriteLine("This is a vowel");
            }
            else if (text == 'u')
            {
                Console.WriteLine("This is a vowel");
            }
            else
            {
                Console.WriteLine("This is not a vowel");
            }

            Console.ReadLine();
        }
    }
}
