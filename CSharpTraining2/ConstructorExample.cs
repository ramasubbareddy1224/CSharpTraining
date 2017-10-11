using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining2
{
    public class ConstructorExample
    {
        int value = 10;

        static ConstructorExample()
        {
            Console.WriteLine("This is static constructor");
        }
               
        public ConstructorExample()
        {
            Console.WriteLine("This is default constructor");
        }

        public ConstructorExample(int a) :this()
        {
            Console.WriteLine(string.Format("This is a parameterized constructor : a {0} ", a));
        }
        public ConstructorExample(int a, int b):this(a)
        {
            
            Console.WriteLine(string.Format("This is a parameterized constructor : a : {0}, b:{1} ", a, b));
        }

        public ConstructorExample(int a, string b)
        {
            Console.WriteLine(string.Format("This is a parameterized constructor : a: {0} , b:{1} ",a, b));
        }
        public void TestMethod()
        {
            DisplayMethod(value);
            Console.WriteLine("Print Test method");
        }
        //static void TestMethod()
        //{
        //    DisplayMethod(value);
        //    Console.WriteLine("Print Test method");
        //}
        public void DisplayMethod(int a)
        {
            Console.WriteLine("This is display method");
        }
    }
}
