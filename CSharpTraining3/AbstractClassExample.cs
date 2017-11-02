using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining3
{
    public abstract class VehicleBase
    {

    }
   public abstract class Vehicle : VehicleBase
    {
        public Vehicle()
        {
            Console.WriteLine("abstract vehicle class constructor");
        }
        public string Color { get; set; }

        public void BaseMethod()
        {
            Console.WriteLine("Base Method");
        }
        public virtual void TestMethod()
        {
            Console.WriteLine("normal test method");
        }
        public abstract void DisplayMessage();
    }

    public class SuzikiBalino : Vehicle
    {
        public SuzikiBalino()
        {
            Console.WriteLine("suziki balino class constructor");
        }
        public override void TestMethod()
        {
            Console.WriteLine("suziki balino test method");
        }
        public override void DisplayMessage()
        {
            TestMethod();
            Color = "Royal Blue";
            Console.WriteLine("Suziki Balino with : " + Color);
        }
    }
    public class SuzikiBalinoSuzikiCiaz : Vehicle
    {
        public override void DisplayMessage()
        {
            TestMethod();
            Color = "Silver";
            Console.WriteLine("Suziki Ciaz with : " + Color);
        }
        public int DisplayMessage(int a)
        {
            return 10;
        }
    }
}
