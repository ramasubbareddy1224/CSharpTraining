using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
    public class QueueExample : IArrayMethods,IArrayNewMethods
    {
        public void DisplayCollectionItems()
        {
            Queue quObj = new Queue();
            quObj.Enqueue("pragim");
            quObj.Enqueue("tech");
            quObj.Enqueue("hyd");
            quObj.Enqueue(100);
            Console.WriteLine("Print Queue items using Foreach loop");
            foreach (var item in quObj)
            {
                Console.WriteLine(item);
            }
            quObj.Dequeue();
            quObj.Dequeue();
            Console.WriteLine("Print Queue items using Foreach loop");
            foreach (var item in quObj)
            {
                Console.WriteLine(item);
            }

        }

        public void ExtraMethod()
        {
            Console.WriteLine("This is extra methods");
        }
    }
}
