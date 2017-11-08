using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining3
{
    class TernaryOperatorExample
    {
        public void PrintData()
        {
            int x = 20, y = 10;

            if (x > y)
            {
                Console.WriteLine("x is greater than y");
            }
            else
            {
                Console.WriteLine("x is less than or equal to y");
            }
            
            var result = x > y ? "x is greater than y" : "x is less than or equal to y";
            Console.WriteLine(result);

        }
    }
}
