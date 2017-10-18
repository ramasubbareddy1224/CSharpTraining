using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining2
{
    class ExceptionHandling
    {
        public void CallException()
        {
            try
            {
                int[] num = new int[3];
                num[0] = 10;
                num[1] = 20;
                num[2] = 30;
                // num[3] = 40;

                int a = 0;
                int output = 10 / a;
                Console.WriteLine("try completed successfully");
            }
           
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("sorry for the inconvenience. contact admin.gmail.com");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("sorry for the inconvenience. contact admin.gmail.com");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            catch (Exception ex)
            {
                Console.WriteLine("sorry for the inconvenience. contact admin.gmail.com");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                Console.WriteLine("this is finally block");
            }
        }
    }
}
