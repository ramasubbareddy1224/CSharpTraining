using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining3
{
    public class ConstructorExample
    {

        int val = 10;

        static ConstructorExample()
        {
            Console.WriteLine("this is static constructor");
        }

        public ConstructorExample()
        {
            Console.WriteLine("this is constructor");
        }
        public ConstructorExample(int c) : this()
        {
            Console.WriteLine("one parameter constructor:" + c);
        }
        public ConstructorExample(int a, int b) : this(a)
        {
            Console.WriteLine(string.Format("two parameter constructor: {0},{1}", a, b));
        }

        public ConstructorExample(string a, int b)
        {
            Console.WriteLine(string.Format("two parameter constructor: {0},{1}", a, b));
        }

        public ConstructorExample(int a, string b)
        {
            Console.WriteLine(string.Format("two parameter constructor: {0},{1}", a, b));
        }

        public void PublicMethod(int a)
        {
            PrivateMethod();
            Console.WriteLine("public method");
        }

        private void PrivateMethod()
        {
            Console.WriteLine("private method");
        }
    }
}
