using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining3
{
    class StaticExample
    {
        public int length = 100;
        static public int count = 10;
        static public string Name { get; set; }

       static public void PrintData()
        {
            Console.WriteLine("This is static method");
        }
    }
}
