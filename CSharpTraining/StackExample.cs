using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
   public class StackExample :IArrayMethods
    {
        
        public void DisplayCollectionItems()
        {
            Stack stkObj = new Stack();
            stkObj.Push("pragim");
            stkObj.Push("tech");
            stkObj.Push(100);

            Console.WriteLine("Print Stack values using Foreach");
            foreach (var item in stkObj)
            {
                Console.WriteLine(item);
            }

            object[] arrayStack = new object[10];
            arrayStack = stkObj.ToArray();

            Console.WriteLine("Print array values using Foreach");
            foreach (var item in arrayStack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
