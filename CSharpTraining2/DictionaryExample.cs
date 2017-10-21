using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining2
{
    class DictionaryExample
    {
        public void LoadItems()
        {

            Dictionary<string,int> dicObj = new Dictionary<string, int>();

            dicObj.Add("pragim", 1);
            dicObj.Add("tech", 2);
            dicObj.Add("hyd", 3);

            Console.WriteLine("Print dictionary items using foreach loop");
            foreach (KeyValuePair<string, int> item in dicObj)
            {
                Console.WriteLine(string.Format("key:{0}, Value:{1}", item.Key, item.Value));
            }

        }
    }
}
