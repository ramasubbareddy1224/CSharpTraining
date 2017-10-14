using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining2
{
   public class HierarchicalBaseInheritance
    {
        protected string Name { get; set; }

        protected void BaseMethod()
        {
            Name = "Base Class Method";
            Console.WriteLine(Name);
        }
    }

    public class Derived1Class : HierarchicalBaseInheritance
    {
        public void Derived1Method()
        {
            BaseMethod();
            Name = "Derived1 Class Method";
            Console.WriteLine(Name);
        }
    }

    public class Derived2Class : HierarchicalBaseInheritance
    {
        public void Derived2Method()
        {
            BaseMethod();
            Name = "Derived2 Class Method";
            Console.WriteLine(Name);
        }
    }
}
