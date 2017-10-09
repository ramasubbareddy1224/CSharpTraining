using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
    public class SuzikiBalino : Vehicle
    {
        public override void EngineSize()
        {
            ModelName = "Suziki Balino";
            Color = "White";
            // this is 2 cc engine of Suziki Balino
            Console.WriteLine("This is 2 cc engine of " + ModelName + " with" + Color);
        }
    }
}
