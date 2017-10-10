using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace CSharpTraining2
{
    class AccessSpecifier
    {
        static void Main()
        {
            InternalAccessSpecifier Obj = new InternalAccessSpecifier();
            Obj.PublicMethod();

            CallInternalMethod obj2 = new CallInternalMethod();
            obj2.CallInternal();

            AccessSpecifierMethods obj3 = new AccessSpecifierMethods();
            obj3.PublicMethod();
            obj3.InternalMethod();
            obj3.ProtectedInternalMethod();
            Console.ReadLine();
        }
       
    }
}
