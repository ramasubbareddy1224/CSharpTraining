using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
    public class VarObjectKeywordExample : IArrayMethods
    {
        public void DisplayCollectionItems()
        {
           
            int i = 10;
            Console.WriteLine("int type:" + i.GetType().ToString());
            var j = "pragim";
            Console.WriteLine("var type:" + j.GetType().ToString());

            var k = 200;
            int w = k;

            i = 20;

            Console.WriteLine("Using object keyword");

            object oi = 10;
            int oj =Convert.ToInt32(oi);
        }
    }
}
