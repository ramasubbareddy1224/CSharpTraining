using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
   public class HierarchicalInhi
    {
        public void BaseMethod()
        {
            Console.WriteLine("This is base method");
        }
    }
    public class HiLevel1DerivedClass : HierarchicalInhi
    {
        public void Level1DerivedMethod()
        {
            Console.WriteLine("This is level 1 derived method");
            BaseMethod();
        }
    }
    public class HiLevel2DerivedClass : HierarchicalInhi
    {
        public void Level2DerivedMethod()
        {
            BaseMethod();
            Console.WriteLine("This is level2 derived method");
        }
    }
}
