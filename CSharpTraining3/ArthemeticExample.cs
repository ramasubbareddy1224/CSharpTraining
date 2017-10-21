using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining3
{
    class ArthemeticExample
    {
        static void Main()
        {
            Console.WriteLine("Enter First number");
            int firstNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            int secondNum = Convert.ToInt32(Console.ReadLine());

            int add = firstNum + secondNum;

            Console.WriteLine("Addition of two numbers:" + add);

            Console.ReadKey();

        }
    }
}
