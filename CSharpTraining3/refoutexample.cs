using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining3
{
    class refoutexample
    {
        public void PrintData(out int val)
        {
            val = 20;
            val = val + 10;
            Console.WriteLine("value inside method:" + val);
        }
    }
}
