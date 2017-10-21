using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining2
{
    class StaticClassExample
    {
        public int i =20;
        public static int myStaticVariable = 0;
        public static int MyStaticProperty { get; set; }
        public static void MyStaticMethod()
        {
            Console.WriteLine("This is a static method.");
        }

    }

}

