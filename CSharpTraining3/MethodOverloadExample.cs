using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining3
{
    class MethodOverloadExample
    {
        public void OverloadMethod()
        {
            Console.WriteLine("zero parameters");

        }
        public void OverloadMethod(int a)
        {
            Console.WriteLine(string.Format("one parameter:{0}",a));
        }
        // This is incorrect overloading
        //public int OverloadMethod(int a)
        //{
        //    Console.WriteLine(string.Format("one parameter:{0}", a));

        //    return 10;
        //}
        public void OverloadMethod(string a)
        {
            Console.WriteLine(string.Format("one parameter:{0}", a));
        }
        public void OverloadMethod(int a,int b)
        {
            Console.WriteLine(string.Format("two parameter:{0},{1}", a,b));
        }
        public void OverloadMethod(int a, string b)
        {
            Console.WriteLine(string.Format("two parameter:{0},{1}", a, b));
        }
    }
}
