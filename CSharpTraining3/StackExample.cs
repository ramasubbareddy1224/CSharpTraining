using System;
using System.Collections;

namespace CSharpTraining3
{
   public class StackExample
    {
        public void PrintData()
        {
            Stack objStackList = new Stack();

            objStackList.Push("rama");
            objStackList.Push(10);
            objStackList.Push("krishna");
            objStackList.Push(45.8);

            Console.WriteLine("using foreach");
            foreach (var item in objStackList)
            {
                Console.WriteLine(item);
            }

            objStackList.Pop();

            Console.WriteLine("after pop");
            foreach (var item in objStackList)
            {
                Console.WriteLine(item);
            }


        }
    }
}
