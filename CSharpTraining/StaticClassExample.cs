using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
    public static class StaticClassExample
    {
        public static int count = 10;

        //int b = 10;
        public static void PrintData()
        {
            int a = 10;
            NoNStaticClass nonObj = new NoNStaticClass();
            Console.WriteLine("Print Static Data");
            Type = "static data using Property";
            Console.WriteLine(Type);
        }
        public static string Type { get; set; }
    }

    public class NoNStaticClass
    {
        public void NormalMethod()
        {
            Console.WriteLine("This is normal method");
        }

        public static void StaticMethod()
        {
            int a = 10;
            Console.WriteLine("This is static method");
        }
    }
}
