using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
   public class SingleInhiritance
    {
        public string Name { get; set; }

        public void BaseMethod()
        {
            Console.WriteLine("This is base class method");
        }
    }

    public class DerivedSingleInhiritance : SingleInhiritance
    {
        public void DerivedMethod()
        {
            Console.WriteLine("This is derived method");
            BaseMethod();

        }
    }
}
