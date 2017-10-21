using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining2
{
    class TernaryOperatorExample
    {
        public void Execute()
        {
            int num = 10;
            string output = "";
            if (num > 10)
            {
                output = "value is greater than 10";
            }
            else
            {
                output = "less than 10";
            }

            Console.WriteLine("using if else");
            Console.WriteLine(output);

            output = num > 10 ? "value is greater than 10" : "less than 10";

            Console.WriteLine("using ternary operator");
            Console.WriteLine(output);
        }
    }
}
