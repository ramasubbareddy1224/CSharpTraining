using System;
using System.Collections;

namespace CSharpTraining2
{
    class StackExample
    {
        public void LoadItems()
        {
            Stack lst = new Stack();
            lst.Push("rama");
            lst.Push(10);
            lst.Push(20);
            lst.Push("siva");

            Console.WriteLine("using foreach loop");
            foreach (object item in lst)
            {
                Console.WriteLine(item);
            }

            lst.Pop();
            lst.Pop();

            Console.WriteLine("using foreach loop after Pop");
            foreach (object item in lst)
            {
                Console.WriteLine(item);
            }
        }
    }
}
