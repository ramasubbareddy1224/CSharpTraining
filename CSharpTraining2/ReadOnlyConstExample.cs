using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining2
{
    class ReadOnlyConstExample
    {
        const double PI = 3.14;
        int a = 10;

        readonly int b = 10;

        public ReadOnlyConstExample()
        {
            b = 20;
        }
        public void Execute()
        {
            // PI = 20;
            a = 20;
            //b = 20;
            Console.WriteLine(PI);
        }
    }
}
