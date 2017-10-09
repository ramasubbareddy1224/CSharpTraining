using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
    public class ArrayExample
    {
        public void PrintArrayItems()
        {
            string[] strArray = new string[4] { "str1", "str2", "str3", "str4" };
            Console.WriteLine("print 2nd value:" + strArray[1]);

            int[] intArray = new int[5];
            intArray[0] = 10;
            intArray[1] = 15;
            intArray[2] = 20;
            intArray[4] = 25;
            Console.WriteLine("print 4th value:" + intArray[4]);

            Console.WriteLine("Print values using For Loop");
            for (int i = 0; i < strArray.Length + 1; i++)
            {
                //if (i == 3)
                //    break;
                if (i == 0 || i == 2)
                    continue;

                Console.WriteLine(strArray[i]);

            }
            Console.WriteLine("Print values using Foreach Loop");
            foreach (string item in strArray)
            {
                Console.WriteLine(item);
            }


        }
        public void ScanArray()
        {
            int[] intArray = new int[5];
            intArray[0] = 10;
            intArray[1] = 15;
            intArray[2] = 20;
            intArray[4] = 25;
            Console.WriteLine("Please enter search element");
            int searchele = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(CheckArrayItems(intArray, searchele));
        }
        public bool CheckArrayItems(int[] array, int searchElement)
        {
            bool value = array.Contains(searchElement);
            return value;
        }
    }
}
