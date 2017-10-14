using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining2
{
    public class SingleBaseInheritance
    {
        protected string Name { get;  set; }

        protected void BaseMethod()
        {
            Name = "Base Class Method";
            Console.WriteLine(Name);
        }
    }

    public class DerivedClass : SingleBaseInheritance
    {
        public void DerivedMethod()
        {
            BaseMethod();
            Name = "Derived Class Method";
            Console.WriteLine(Name);
        }
    }
}
