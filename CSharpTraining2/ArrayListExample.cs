using System;
using System.Collections;

namespace CSharpTraining2
{
    class ArrayListExample
    {
        public void LoadItems()
        {


            ArrayList lst = new ArrayList();
            lst.Add("rama");
            lst.Add(10);
            lst.Add(20);
            lst.Add("siva");

            //int num=Convert.ToInt32(lst[1]);

            Console.WriteLine("using for loop");
            for (int i = 0; i < lst.Count; i++)
            {
                Console.WriteLine(lst[i]);
            }

            Console.WriteLine("using foreach loop");
            foreach (object item in lst)
            {
                Console.WriteLine(item);
            }

            // insert into list
            lst.Insert(1, 100);

            Console.WriteLine("foreach loop after insert");
            foreach (object item in lst)
            {
                Console.WriteLine(item);
            }

            // remove from the list

            lst.RemoveAt(3);
            Console.WriteLine("foreach loop after remove");
            foreach (object item in lst)
            {
                Console.WriteLine(item);
            }

            if (lst.Contains("rama"))
            {
                Console.WriteLine("element rama found in collection");
            }

            int[] items = { 1, 2, 3 };
            lst.AddRange(items);

            Console.WriteLine("foreach loop after add range");
            foreach (object item in lst)
            {
                Console.WriteLine(item);
            }

            // clear items from list

            //lst.Clear();

            //Console.WriteLine("foreach loop after clear");
            //foreach (object item in lst)
            //{
            //    Console.WriteLine(item);
            //}


        }
    }
}
