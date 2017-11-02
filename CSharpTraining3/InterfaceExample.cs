using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining3
{

    public class BaseC
    {

    }
    public interface ITest
    {
        void TestMethod();

    }

    public interface IVehicle
    {
        string Color { get; set; }
        void DisplayMessage();

        void TestMethod();

    }

    public class SuzikiBalinoInterface : BaseC, IVehicle, ITest
    {
        public string Color { get; set; }

        public void DisplayMessage()
        {

            Color = "Royal Blue";
            Console.WriteLine("Suziki Balino with : " + Color);
        }

        void ITest.TestMethod()
        {
            Console.WriteLine("Test Method from ITest Interface");
        }
        void IVehicle.TestMethod()
        {
            Console.WriteLine("Test Method from IVehicle Interface");
        }
    }
    public class SuzikiCiazInterface : IVehicle
    {
        public SuzikiCiazInterface()
        {
            Console.WriteLine("ciaz constructor");
        }
        public string Color { get; set; }

        public void DisplayMessage()
        {
            Color = "Silver";
            Console.WriteLine("Suziki Ciaz with : " + Color);
        }

        public void TestMethod()
        {
            Console.WriteLine("Test Method");
        }
    }
}
