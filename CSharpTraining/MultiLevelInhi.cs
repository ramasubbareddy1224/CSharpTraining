using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
    public class MultiLevelInhi
    {
        public void LevelBaseMethod()
        {
            Console.WriteLine("This is level one base class method");
        }
    }
    public class Level2Derived : MultiLevelInhi
    {
        public void Level2DerivedMethod()
        {
            LevelBaseMethod();
            Console.WriteLine("This is level two derived method");
        }
    }
    public class Level3Derived : Level2Derived
    {
        public void Level3DerivedMethod()
        {
            LevelBaseMethod();
            Level2DerivedMethod();
            Console.WriteLine("This is level 3 derived method");
        }
    }
}
