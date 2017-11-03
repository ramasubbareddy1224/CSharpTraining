using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining3
{
    class ArrayExample
    {
        public void PrintData()
        {
            int a = 10;

            int[] intarray = { 10, 20, 30, 40 };
            //intarray[4] = 50;


            Console.WriteLine(intarray[0]);
            Console.WriteLine(intarray[1]);
            Console.WriteLine(intarray[2]);


            string[] stringarray = new string[3];
            stringarray[0] = "rama";
            stringarray[1] = "siva";
            stringarray[2] = "krishna";

          
           // stringarray[3] = "test user";

            Console.WriteLine(stringarray[0]);
            Console.WriteLine(stringarray[1]);
            Console.WriteLine(stringarray[2]);

            // read and store string values
            string[] names = new string[3];
            Console.WriteLine("Enter names");

            for (int i = 0; i < names.Length; i++)
            {
                names[i] = Console.ReadLine();
            }

            Console.WriteLine("Print names using foreach loop");

            foreach (var item in names)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("Print names using for loop");
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

        }
    }
}
