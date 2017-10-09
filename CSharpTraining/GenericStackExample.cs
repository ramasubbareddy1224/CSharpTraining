using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
    public class GenericStackExample : IArrayMethods
    {
        public void DisplayCollectionItems()
        {
            Stack<int> stObj = new Stack<int>();
            stObj.Push(10);
            stObj.Push(20);
            stObj.Push(30);
            Console.WriteLine(@"Print generic stack items using Foreach loop \ hi");
            foreach (var item in stObj)
            {
                Console.WriteLine(item);
            }
        }
    }
}
