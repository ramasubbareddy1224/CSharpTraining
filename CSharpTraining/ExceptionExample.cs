using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
    public class ExceptionExample
    {
        public void GenerateException()
        {
            int value = 0;
            try
            {
                Console.WriteLine("Enter number");
                 value = Convert.ToInt32(Console.ReadLine());
                try
                {
                    int output = 20 / value;
                    Console.WriteLine("Output:" + output);
                }
                catch (DivideByZeroException excast)
                {
                    Console.WriteLine("Do not enter zero");
                }
                finally {
                    Console.WriteLine("This is nested finally block");
                }

            }
            catch (Exception exbase)
            {
                Console.WriteLine("This is Base exception deatails:" + exbase.Message);
                Console.WriteLine("stack trace" + exbase.StackTrace);
            }
            //catch (DivideByZeroException exdivide)
            //{
            //    Console.WriteLine("Do not enter zero");
            //}
            //catch (FormatException excast)
            //{
            //    Console.WriteLine("Please enter number only");
            //}
            finally
            {
                Console.WriteLine("This is Finally block");
            }

            Console.WriteLine("This is sample message");
            //try
            //{
            //    Console.WriteLine("Only Try and finally");
            //    int output = 20 / value;
            //}
           
            //finally
            //{
            //    Console.WriteLine("second Finally block");
            //}


        }

        public void GenerateExceptionOutside()
        {
            Console.WriteLine("Enter number");
           // throw new Exception("This is throw exceptin");
            int value = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("This is last statement");

        }

    }
}
