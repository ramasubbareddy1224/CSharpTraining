using System;
using System.Collections;

namespace CSharpTraining3
{
    class QueueExample
    {
        public void PrintData()
        {
            Queue objQueueList = new Queue();
            objQueueList.Enqueue("rama");
            objQueueList.Enqueue(10);
            objQueueList.Enqueue("krishna");
            objQueueList.Enqueue(45.4);
            objQueueList.Enqueue(20);

            

            Console.WriteLine("using foreach");
            foreach (var item in objQueueList)
            {
                Console.WriteLine(item);
            }

            objQueueList.Dequeue();

            Console.WriteLine("after dequeue");
            foreach (var item in objQueueList)
            {
                Console.WriteLine(item);
            }

           // objQueueList.Ca
            // 8 elements
            objQueueList.TrimToSize();
            // 5 elements
        }
    }
}
