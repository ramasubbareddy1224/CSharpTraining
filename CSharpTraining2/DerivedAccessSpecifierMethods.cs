using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining2
{
    public class DerivedAccessSpecifierMethods : AccessSpecifierMethods
    {
        public void DerivedMethod()
        {
            ProtectedMethod();
            PublicMethod();
            //no private method
        }
    }
}
