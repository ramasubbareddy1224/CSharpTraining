using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
   public class InternalAccessSpecifier
    {
        public void PublicMethod()
        {
            Console.WriteLine("This is public method");
        }
        internal void InternalMethod()
        {
            Console.WriteLine("This is internal Method");
        }
    }
}
