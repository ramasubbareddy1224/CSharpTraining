using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining2
{
    class ArrayExample
    {
        public void CallArray()
        { 
            //10,20,30

            int num1 = 10;
            int num2 = 20;
            int num3 = 30;

            // declartion type 1
            int[] numarray = { 10, 20, 30 };

            // declartion type 2
            int[] numarray2 = new int[3];
            numarray2[0] = 1;
            numarray2[1] = 2;
            numarray2[2] = 3;

            // declaration type 3
            int[] numarray3 = new int[3] { 1, 2, 3};


            Console.WriteLine("Indiviaul index access");

            Console.WriteLine(numarray[0]);
            Console.WriteLine(numarray[1]);
            Console.WriteLine(numarray[2]);

            Console.WriteLine("using foreach loop");

            foreach (int name in numarray)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("Using for loop");
            for (int i = 0; i < numarray.Length; i++)
            {
                Console.WriteLine(numarray[i]);
            }

            string[] names = { "rama", "siva", "krishna" };

        }
    }
}
