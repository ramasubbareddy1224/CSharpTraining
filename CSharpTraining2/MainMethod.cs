using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining2
{
    class MainMethod
    {
        static void Main(string[] args)
        {
            int count = 10;
            int num = 5;
            string name = "rama";
            //ConstructorExample obj = new ConstructorExample();

            //ConstructorExample obj2 = new ConstructorExample();

            //ConstructorExample obj3 = new ConstructorExample(count,num);

            // obj.TestMethod();
            Console.WriteLine("Enter student id");
            int studentId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter student name");
            string studentname = Console.ReadLine();
            ConstructorExample2 obj = new ConstructorExample2(studentId,studentname);

            obj.PrintStudentDetails();

            Console.ReadLine();
        }
    }
}
