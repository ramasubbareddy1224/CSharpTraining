using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining3
{
   class StaticExample2
    {
        static public int Length = 100;

       static string name = "rama";

        public void PrintData()
        {
            
            Console.WriteLine("length is:" + Length);
        }

       static private int getdata()
        {
            return 10;
        }
    }
}
