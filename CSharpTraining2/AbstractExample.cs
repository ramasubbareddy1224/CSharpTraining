using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining2
{

    public abstract class VehicleBase
    {
     
        public virtual void BaseMethod()
        {

        }
    }
    public abstract class Vehicle : VehicleBase
    {

        protected string Color { get; set; }


        protected int EngineSize { get; set; }

        public virtual void FormatText()
        {
            Console.WriteLine(string.Format("Balino car with color:{0}, and Enginesize:{1} cc", Color, EngineSize));
        }

        public override void BaseMethod()
        {
            
        }

        public abstract void DisplayMessage();

       // public abstract void ShowName();
       
    }


    public class SuzikiBalino : Vehicle
    {

        public virtual void BalinoTest()
        {
            
        }
        //public override void Test()
        //{
        //    Console.WriteLine("This is Balino Test method");
        //}

        public override void DisplayMessage()
        {
            Color = "Royal Blue";
            EngineSize = 1;
            FormatText();
          //  Console.WriteLine(string.Format("Balino car with color:{0}, and Enginesize:{1} cc", Color, EngineSize));
        }

    }

    public sealed class SuzikiCiaz : Vehicle
    {

        public override void FormatText()
        {
            Console.WriteLine("My car color:"+Color);
            Console.WriteLine("My car engine size:"+EngineSize);
        }
        public override void DisplayMessage()
        {
            //Test();
            Color = "Navy Blue";
            EngineSize = 2;
            FormatText();
           // Console.WriteLine(string.Format("Balino car with color:{0}, and Enginesize:{1} cc", Color, EngineSize));
        }
    }

   
}
