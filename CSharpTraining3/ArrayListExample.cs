using System;
using System.Collections;

namespace CSharpTraining3
{
    public class ArrayListExample
    {
        public void PrintData()
        {
            // step 1 : create object for the collection
            ArrayList objArrayList = new ArrayList();

            // step 2 : add items to the collection
            objArrayList.Add("rama");
            objArrayList.Add(100);
            objArrayList.Add("siva");
            objArrayList.Add(72.7);
            objArrayList.Add('M');

            int num =Convert.ToInt32(objArrayList[1]);

            // step 2 : read items from the collection

            Console.WriteLine("using foreach");
            foreach (var item in objArrayList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("using for loop");
            for (int i = 0; i < objArrayList.Count; i++)
            {
                Console.WriteLine(objArrayList[i]);
            }

            objArrayList.Insert(1, "krishna");

            Console.WriteLine("after insert ");
            foreach (var item in objArrayList)
            {
                Console.WriteLine(item);
            }

            int[] items = { 10, 20 };

            //for (int j = 0; j < items.Length; j++)
            //{
            //    objArrayList.Add(items[j]);
            //}

            objArrayList.AddRange(items);

            Console.WriteLine("after addrange ");
            foreach (var item in objArrayList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("search element");
            if (objArrayList.Contains("rama"))
            {
                Console.WriteLine("Element found");
            }
            else
            {
                Console.WriteLine("Element not found");
            }

            Console.WriteLine("Total elements:" + objArrayList.Count);

            int[] itemsrange = { 30, 40 };

            objArrayList.InsertRange(2, itemsrange);
            Console.WriteLine("after insert range ");
            foreach (var item in objArrayList)
            {
                Console.WriteLine(item);
            }

            objArrayList.Remove("krishna");
            objArrayList.Remove("rama");
            Console.WriteLine("after remove ");
            foreach (var item in objArrayList)
            {
                Console.WriteLine(item);
            }


            objArrayList.RemoveAt(3);
            Console.WriteLine("after removeAt ");
            foreach (var item in objArrayList)
            {
                Console.WriteLine(item);
            }

            objArrayList.Reverse();
            Console.WriteLine("after reverse ");
            foreach (var item in objArrayList)
            {
                Console.WriteLine(item);
            }

            objArrayList.Clear();
            Console.WriteLine("after clear ");
            foreach (var item in objArrayList)
            {
                Console.WriteLine(item);
            }

            //  Console.WriteLine("check auto grow capacity:" + objArrayList.Capacity);

        }
    }
}
