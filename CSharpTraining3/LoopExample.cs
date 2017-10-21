using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining3
{
    class LoopExample
    {
        static void Main()
        {
            int i;
            Console.WriteLine("enter how many numbers you want to print");
            int num = Convert.ToInt32(Console.ReadLine());
            // using for loop
            // first time : only initialization and condition
            // going forward: increment/decrement
            // condition check
            
            for (i=1; i <= num; i++)   // 1<=10
            {
                if(i==5)
                    break;
                Console.WriteLine(i);
            }


            // while loop
            int j = 1;
            while (j <= num)
            {
                Console.WriteLine(i);
                j++;
            }
                       

            Console.Read();
        }
    }
}
