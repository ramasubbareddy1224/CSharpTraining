using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining3
{
    class ExceptionExample
    {
        public void PrintData()
        {
            try
            {
                // open file 
                int[] intarray = new int[2];
                intarray[0] = 10;
                intarray[1] = 20;
                intarray[2] = 30;

                try
                {

                    int val = 0;
                    int output = 20 / val;
                }
                catch
                {
                    Console.WriteLine("error occured");
                }
                finally
                { }

                Console.WriteLine("Try block completed");
            }

            catch (IndexOutOfRangeException ex)
            {

                Console.WriteLine("Exception accurred:" + ex.StackTrace);
                Console.WriteLine("sorry for the inconvenince.concta admin");
            }
            //catch(DivideByZeroException ex)
            //{
            //    Console.WriteLine("Exception accurred:" + ex.StackTrace);
            //    Console.WriteLine("sorry for the inconvenince.concta admin");
            //}

            catch (Exception ex)
            {
                Console.WriteLine("Exception accurred:" + ex.StackTrace);
                Console.WriteLine("sorry for the inconvenince.concta admin");
            }
            finally
            {
                // close file
                Console.WriteLine("This is finally block");
            }

           // Exception ex = new IndexOutOfRangeException();
           // Exception ex1 = new DivideByZeroException();
        }
    }
}
