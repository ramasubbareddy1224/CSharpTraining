using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CSharpTraining
{
   public class ArrayListExample :IArrayMethods,IArrayNewMethods
    {
        public void DisplayCollectionItems()
        {
            ArrayList alObj = new ArrayList();
            alObj.Add("pragim");
            alObj.Add(10);
            alObj.Add("tech");

            Console.WriteLine("using for loop");
            for (int i = 0; i < alObj.Count; i++)
            {
                Console.WriteLine(alObj[i]);
            }
            Console.WriteLine("using foreach loop");
            foreach (var item in alObj)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("remove pragim");
            //alObj.Remove("pragim");
            alObj.RemoveAt(0);
            foreach (var item in alObj)
            {
                Console.WriteLine(item);
            }

            ArrayList alObj2 = new ArrayList();
            alObj2.AddRange(alObj);
            Console.WriteLine("copy items into new arrayList");
            foreach (var item in alObj2)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("clear items from first arraylist");
            alObj.Clear();
            foreach (var item in alObj)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("add items by index into first arraylist");
            alObj.Insert(0, "pragim");
            alObj.Insert(1, "tech");
            alObj.InsertRange(1, alObj2); // 10,tech
            foreach (var item in alObj)
            {
                Console.WriteLine(item);
            }

           // alObj2.

        }

        public void ExtraMethod()
        {
            Console.WriteLine("This is Extra Method");
        }
    }
}
