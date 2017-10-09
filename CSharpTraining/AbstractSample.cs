using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
    public abstract class VehicleBase
    {
        public string Color { get; set; }
    }
    public abstract class Vehicle : VehicleBase
    {
        public string ModelName { get; set; }
        public void DeliveryMessage()
        {
            Console.WriteLine("Your vehicle delivered successfully. Thank you !!");
        }
        public abstract void EngineSize();

    }
    public class SuzikiCiaz : Vehicle
    {
        public override void EngineSize()
        {
            ModelName = "Suziki Ciaz";
            Color = "Royal Blue";
            // this is 1 cc engine of Suziki Ciaz with color royal blue
            Console.WriteLine(string.Format("This is 1 cc engine of {0} with {1}", ModelName, Color));
        }


    }
   
    //public class SuzikiBalino : Vehicle
    //{
    //    public override void EngineSize()
    //    {
    //        ModelName = "Suziki Balino";
    //        Color = "White";
    //        // this is 2 cc engine of Suziki Balino
    //        Console.WriteLine("This is 2 cc engine of " + ModelName + " with" + Color);
    //    }
    //}
}
