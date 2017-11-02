using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining3
{
   public class BaseInheritance
    {
        public BaseInheritance()
        {
            Console.WriteLine("Base Constructor");
        }
        public string Name { get; set; }
        public void BaseMethod()
        {
             Name = "Base Method";
            Console.WriteLine(Name);
        }
        public void TestMethod()
        {
            Console.WriteLine("Base Test Method");
        }
       
    }

    public class DerivedSingleInheritace : BaseInheritance
    {
        public DerivedSingleInheritace()
        {
            Console.WriteLine("Derived Constructor");
        }
        public void DerivedMethod()
        {

            TestMethod();
            base.TestMethod();          
            BaseMethod();
            Name = "Derived Method";
            Console.WriteLine(Name);
        }
        public new void TestMethod()
        {
            Console.WriteLine("Derive Test Method");
        }
    }

}
