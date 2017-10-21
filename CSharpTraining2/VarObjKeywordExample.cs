using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining2
{
    class VarObjKeywordExample
    {
        public void Execute()
        {
            int a;  // initialization/declare
            a = 10; // assignment
            Console.WriteLine("normal integer:" + a);

            var b=10;
            b = 20;
            Console.WriteLine("var keyword:" + b);

            object o = 10;
            Console.WriteLine("object value:"+o);
            o = "rama";
            Console.WriteLine("Object new value:"+o);

        }
    }
}
