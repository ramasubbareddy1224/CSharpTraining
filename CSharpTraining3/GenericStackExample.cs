using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining3
{
    class GenericStackExample
    {
        public void PrintData()
        {
            Stack<int> objStackList = new Stack<int>();

            objStackList.Push(10);
            objStackList.Push(45);

            Console.WriteLine("using foreach");
            foreach (var item in objStackList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
