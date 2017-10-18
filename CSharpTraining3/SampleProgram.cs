using System;

namespace CSharpTraining3
{
    class SampleProgram
    {
        static int localnum;
        static void Main()
        {

            Console.WriteLine(localnum);

            Console.Write("This is first program");

            int num =10;
            char gender = 'M';
            double price = 123.34;
            bool IsTrue = true;
            string name = "kiran";
            int growth = -2;

            int i = 2;
            int y = 3;
            class1 c1 = new class1();
            Console.WriteLine((c1.Add(10, 15)));
            Console.WriteLine(num);
            Console.WriteLine(gender);
            Console.WriteLine("your name is:" + name + "company growth:" + growth);
           // string output = string.Format("your name is:{0} company growth:{1}", name, growth);
            Console.WriteLine(string.Format("your name is:{0} company growth:{1}", name, growth));
            //Console.WriteLine(output););

            Console.Read();
        }
    }
    class class1
    {
        public int a;

        public int Add(int a, int b)
        {
            return a + b;
        }
    }
}
