using System;

namespace Pragim.FirstProg
{
    class FirstSample
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("This is first sample program");
            //Console.Write("This is first sample program");
            //Console.Write("This is first sample program");
            //Console.WriteLine("This is first sample program");
            //Console.WriteLine("This is first sample program");



            double d = 200;
            //  object ob = 10;
            object ob1 = "pragim";
            object ob2 = 2000;

            // Boxing ==============

            int i = 10;

            object ob = i; // implicit boxing
            Console.WriteLine(ob);

            string s1 = i.ToString(); // explicit boxing
            Console.WriteLine(s1);

            // Boxing ==================


            // Un Boxing =============

            string refstring = "10";
          //  int refint = int.Parse(refstring); //  
            int refint2 = Convert.ToInt32(refstring);  // This will handle null type also

            double refdouble = double.Parse(refstring);
            double refdouble2 = Convert.ToDouble(refstring);

            Console.WriteLine(refint2);
            Console.WriteLine(refdouble);

            /* Un Boxing =============   */


            //  string d = "2017-08-15";
            //DateTime dt=  Convert.ToDateTime(d);
            //  dt.

            Console.WriteLine(i);
            Console.WriteLine("integer value:" + i + ":success"); // integer value:10 :success
            Console.WriteLine("double value:" + d);

            //Book b1 = new Book();
            //string[] allbooks = b1.GetBooks();
            //foreach (var item in allbooks)
            //{
            //    Console.WriteLine(item);

            //}

            Console.ReadLine();
        }
    }
}

