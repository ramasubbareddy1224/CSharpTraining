using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining3
{
    class BaseMultiLevelInheritance
    {
        public BaseMultiLevelInheritance()
        {

        }
        public void BaseMethod()
        {
            Console.WriteLine("Base Method");
        }
    }

    class Derived1MultiLevel : BaseMultiLevelInheritance
    {
        public Derived1MultiLevel()
        {

        }
        public void Derived1Method()
        {
            BaseMethod();
            Console.WriteLine("Derived Method");
        }
    }

    class Derived2MulitiLevel : Derived1MultiLevel
    {
        public Derived2MulitiLevel()
        {

        }
        public void Derived2Method()
        {
            BaseMethod();
            Derived1Method();
            Console.WriteLine("Derived2 Method");
        }
    }
}
