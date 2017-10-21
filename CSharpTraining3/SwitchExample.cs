using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining3
{
    class SwitchExample
    {
        static void Main()
        {
            Console.WriteLine("Enter vowel");
            char text = Convert.ToChar(Console.ReadLine());

            int num = 4;

            /// char, string, numbers
            switch (num)
            {
                case 'a':                  
                case 'e':                 
                case 'i':
                    Console.WriteLine("This is a vowel");
                    break;
                case 'o':
                    Console.WriteLine("This is a vowel");
                    break;
                case 'u':
                    Console.WriteLine("This is a vowel");
                    break;
                default:
                    Console.WriteLine("This is not a vowel");
                    break;
            }

            Console.Read();

        }
    }
}
