using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining3
{
    class TypeConversionExample
    {
        static void Main()
        {
            // Boxing 

            int a = 10;
            Console.WriteLine("before convert:" + a);

            string text = Convert.ToString(a);
            string text2 = a.ToString();
            Console.WriteLine("after convert:" + text);


            // Un Boxing  int 16, 32, 64
            string numvalue = "10";
            Console.WriteLine("before convert:" + a);
            int num = Convert.ToInt32(numvalue);
            int num2 = int.Parse(numvalue);
            Console.WriteLine("after convert:" + text);

            Console.Read();

        }
    }
}
