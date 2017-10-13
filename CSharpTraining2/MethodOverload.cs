using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining2
{
   public class MethodOverload
    {
        public void Overload()
        {
            Console.WriteLine("This is zero parameter overload");
        }
        
        public void Overload(int a)
        {
            Console.WriteLine("This is one int prarameter overload");
        }
        public void Overload(string a)
        {
            Console.WriteLine("This is one string prarameter overload");
        }
        public void Overload(string a,int b)
        {
            Console.WriteLine("This is one string prarameter overload");
        }
        public void Overload(int a, string b)
        {
            Console.WriteLine("This is one string prarameter overload");
        }

        public int Add(int a, int b)
        {
            return a + b;
        }
        
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }
        public int Add(int a, int b, int c, int d)
        {
            return a + b + c + d;
        }
       
    }
}
