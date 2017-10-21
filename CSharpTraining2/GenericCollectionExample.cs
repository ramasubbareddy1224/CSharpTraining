using System;
using System.Collections.Generic;

namespace CSharpTraining2
{
    class GenericCollectionExample
    {
        public void LoadItems()
        {
           
            List<int> lstInt = new List<int>();
            lstInt.Add(10);
            lstInt.Add(20);
            lstInt.Add(30);

            List<string> lstString = new List<string>();
            lstString.Add("rama");
            lstString.Add("siva");
            lstString.Add("krishna");         

            Console.WriteLine("using foreach loop");
            foreach (object item in lstString)
            {
                Console.WriteLine(item);
            }
        }
    }
}
