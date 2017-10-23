using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining3
{
    class MainMethod
    {
        static void Main()
        {
            //Student objStudent = new Student();
            //objStudent.GetEmployee();
            //int count = objStudent.GetEmployeeCount();
            //Console.WriteLine("employee count:" + count);
            //// Console.WriteLine("employee count:" + objStudent.GetEmployeeCount());

            //Student objStudent1 = new Student();
            //Console.WriteLine(objStudent1.GetEmployeeCount());

            Addition objAdd = new Addition();

            Console.WriteLine("enter first number");
            int first =Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter second number");
            int second = Convert.ToInt32(Console.ReadLine());

            int result = objAdd.Add(first,second);
            Console.WriteLine("addition of two number:"+result);


            Console.Read();
        }
    }
}
