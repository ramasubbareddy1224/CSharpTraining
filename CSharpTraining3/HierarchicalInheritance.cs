using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining3
{
    public class BaseHierarchicalInheritance
    {
        public void BaseMethod()
        {
            Console.WriteLine("Base Method");
        }
    }

    public class Derived1 : BaseHierarchicalInheritance
    {
        public void DerivedMethod()
        {
            Console.WriteLine("Derived 1 Method");
        }
    }

    public class Derived2 : BaseHierarchicalInheritance
    {
        public void Derived2Method()
        {
            Console.WriteLine("Derived 2 Method");
        }
    }
}
