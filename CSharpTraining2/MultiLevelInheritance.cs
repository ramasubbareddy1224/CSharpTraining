using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining2
{
   public class MultiLevelBaseInheritance
    {
        protected string Name { get; set; }

        protected void BaseMethod()
        {
            Name = "Base Class Method";
            Console.WriteLine(Name);
        }
    }
    public class DerivedLevel2Class : MultiLevelBaseInheritance
    {
        public void Level2Method()
        {
            BaseMethod();
            Name = "Level 2 Class Method";
            Console.WriteLine(Name);
        }
    }

    public class DerivedLevel3Class : DerivedLevel2Class
    {
        public void Level3Method()
        {
            Level2Method();
           // BaseMethod();         
            Name = "Level 3 Class Method";
            Console.WriteLine(Name);
        }
    }

}
