using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
    public  abstract class TaskVehicle
    {
        public TaskVehicle()
        {

        }
        public int Power { get; set; }
        public string Color { get; set; }

        public  abstract void Steer();

    }

    public class AirPlane : TaskVehicle
    {
        public override void Steer()
        {
            Power = 2000;
            int superpower = Power * 1000;
            Color = "White";
            Console.WriteLine(string.Format("This is airplane with power :{0} , Color:{1} ", superpower, Color));
        }
        public void Fly()
        {
            
            Console.WriteLine("This is flying");
        }
    }

    public class Ship : TaskVehicle
    {
        public override void Steer()
        {
            Power = 1000;
            Color = "Indian Navy";
            Console.WriteLine(string.Format("This is ship with power :{0} , Color:{1} ", Power, Color));

        }

        public virtual void Sail()
        {
            Console.WriteLine("Ship Sail");
        }
    }

    public class CargoShip : Ship
    {
        public int CargoCapacity { get; set; }

        public override void Steer()
        {
            base.Steer();

            Power = 1500;
            Color = "Blue";
            Console.WriteLine(string.Format("This is ship with power :{0} , Color:{1} ", Power, Color));

        }
        public override void Sail()
        {
            Console.WriteLine("Cargo Ship sail");
        }
        public  virtual void Cargoshipmethod()
        {
            Console.WriteLine("This is Cargo ship method");
        }

    }

    public sealed class PassengerShip : Ship
    {
        public int CargoCapacity { get; set; }

        public override void Steer()
        {
            base.Steer();

            Power = 1500;
            Color = "Blue";
            Console.WriteLine(string.Format("This is ship with power :{0} , Color:{1} ", Power, Color));

        }
        public override void Sail()
        {
            Console.WriteLine("Passenger Ship sail");
        }
        //public sealed virtual void Cargoshipmethod()
        //{
        //    Console.WriteLine("This is Cargo ship method");
        //}

    }

    public class OilCargoShip : CargoShip
    {
        public override void Sail()
        {
            Console.WriteLine("This is Oil Cargo Ship Sail");
        }
    }



}
