using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
    public class StaticCtorExample
    {
        static StaticCtorExample()
        {
            Console.WriteLine("This is static constructor");
        }
        public StaticCtorExample()
        {
            Console.WriteLine("This is normal/instance constructor");
        }

    }
}
