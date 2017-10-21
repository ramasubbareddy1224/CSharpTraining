using System;
using System.Collections;

namespace CSharpTraining2
{
    class QueueExample
    {
        public void LoadItems()
        {
            Queue lst = new Queue();
            lst.Enqueue("rama");
            lst.Enqueue(10);
            lst.Enqueue(20);
            lst.Enqueue("siva");

            Console.WriteLine("using foreach loop");
            foreach (object item in lst)
            {
                Console.WriteLine(item);
            }

            lst.Dequeue();

            Console.WriteLine("using foreach loop after dequeue");
            foreach (object item in lst)
            {
                Console.WriteLine(item);
            }
        }
    }
}
