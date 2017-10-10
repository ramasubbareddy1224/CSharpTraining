using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
   public class CallInternalMethod
    {
        public void CallInternal()
        {
            InternalAccessSpecifier obj = new InternalAccessSpecifier();
            obj.InternalMethod();
            obj.PublicMethod();
        }
    }
}
