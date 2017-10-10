using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining2
{
   public class AccessSpecifierMethods
    {
        public void PublicMethod()
        {
            Console.WriteLine("This is public method");
        }
        private void PrivateMethod()
        {
            Console.WriteLine("This is private method");
        }

        protected void ProtectedMethod()
        {
            Console.WriteLine("This is protected method");
        }

        internal void InternalMethod()
        {
            Console.WriteLine("This is internal Method");
        }
        protected internal void ProtectedInternalMethod()
        {
            Console.WriteLine("This is protectedInternal method");
        }
    }
       
}
