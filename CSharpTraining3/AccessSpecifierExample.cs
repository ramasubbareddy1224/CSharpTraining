using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining3
{
    class AccessSpecifierExample
    {
        public int publicvar = 10;
        private int privatevar = 10;
        protected int protecedvar = 10;
        internal int internalvar = 10;
        protected internal int protinternalvar=10;

        public void PublicMethod()
        {          
            Console.WriteLine("public method");
            PrivateMethod();
        }
        private void PrivateMethod()
        {
            ProtectedMethod();
            Console.WriteLine("private method");
        }
        protected void ProtectedMethod()
        {
            Console.WriteLine("protected method");
        }
        internal void InternalMethod()
        {
            Console.WriteLine("Internal Method");
        }
        internal protected void ProtectedInternal()
        {
            Console.WriteLine("Protected Internal");
        }

    }
}
