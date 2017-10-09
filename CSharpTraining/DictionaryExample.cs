using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
    public class DictionaryExample : IArrayMethods
    {
        public void DisplayCollectionItems()
        {
            Dictionary<string, int> dicObj = new Dictionary<string, int>();
            dicObj.Add("pragim", 1);
            dicObj.Add("tech", 2);
            dicObj.Add("hyd", 3);

            Console.WriteLine("Print dictionary items using foreach loop");
            foreach (KeyValuePair<string, int> item in dicObj)
            {
                Console.WriteLine(string.Format("key:{0}, Value:{1}", item.Key, item.Value));
            }

            Console.WriteLine("Print only Dictionary keys");
            //  bool val = dicObj.ContainsKey("tech1");
            if (dicObj.ContainsKey("tech1"))
            {
              
                Console.WriteLine("Value found in Dictionary");
            }
            else
            {
                Console.WriteLine("Value not found in Dictionary");
            }
            Console.WriteLine("Using Ternary Operator");
            string value = dicObj.ContainsKey("tech") ? "Value found in Dictionary" : "Value not found in Dictionary";
            Console.WriteLine(value);



        }
    }
}
