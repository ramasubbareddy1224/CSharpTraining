using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training3Library
{
    public class InternalTestExample
    {

        InternalTest2Example obj = new InternalTest2Example();
        public void PublicMethod()
        {

            Console.WriteLine("public method");
        }
        internal void InternalMethod()
        {
            Console.WriteLine("internal method");
        }
    }
}
