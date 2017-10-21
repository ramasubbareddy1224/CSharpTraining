using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining3
{
    class UnaryOperatorExample
    {
        static void Main()
        {
            int num = 10;
            Console.WriteLine("before increment:" + num);


            int output = num++;

            Console.WriteLine("output varible value:" + output);
            Console.WriteLine("after increment num value:" + num);

            int test = 10;
            int calcuate = test++ + ++test + test++ + ++test + ++test;    // 10 + 12

            Console.WriteLine("Test variable value:"+ calcuate);

            int decrementValue = 10;
            Console.WriteLine("before decrement:"+decrementValue);
            int outputdecrement = --decrementValue;
            Console.WriteLine("output varible value:" + outputdecrement);
            Console.WriteLine("decrement increment num value:" + decrementValue);


             test = 10;
            int calcuate1 = test++ + ++test + test-- + --test + test++; // 10 +12 + 12 +10 + 10
            Console.WriteLine("calculate1 value:"+calcuate1);

            Console.Read();

        }
    }
}
