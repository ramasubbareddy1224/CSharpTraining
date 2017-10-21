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

            //Console.WriteLine("Enter student id");
            //int studentId = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter student name");
            //string studentname = Console.ReadLine();
            //ConstructorExample2 obj = new ConstructorExample2(studentId,studentname);

            //obj.PrintStudentDetails();

            //  MethodOverload obj = new MethodOverload();
            // obj.Overload();

            // obj.Overload(count);

            // PropertiesExample obj = new PropertiesExample();
            // obj.StudentId = 100;
            // obj.FirstName = "Christopher";
            // obj.Lastname = "Nolan";
            // obj.Email = "nolan@gmail.com";

            // // acccess properties
            // obj.PropStudentId = 100;
            // obj.PropFirstName = "Christopher";
            // obj.PropLastName = "Nolan";
            // obj.PropEmail = "nolan@gmail.com";
            // // obj.PropFullName = "aaa";
            //// obj.PropFullName = "aaa";


            // Console.WriteLine("My full Name:" + obj.PropFullName);

            // Console.WriteLine("My full Name:"+obj.GetFullName());

            // obj.PrintStudentDetails();


            //Console.WriteLine("Ebook details");
            //EBook obj = new EBook();
            //obj.BuyBook();

            //Console.WriteLine("\n");
            //Console.WriteLine("PaperBook details");
            //PaperBook obj2 = new PaperBook();
            //obj2.BuyBook();

            // DerivedClass obj = new DerivedClass();
            //obj.Name = "Main Method Call";
            // obj.
            // obj.
            //obj.DerivedMethod();

            //Derived1Class obj = new Derived1Class();
            //obj.Derived1Method();

            //DerivedLevel3Class obj = new DerivedLevel3Class();
            //obj.Level3Method();

            //PaperBookDerived obj = new PaperBookDerived();
            //obj.CourerBook();

            // SuzikiBalino obj = new SuzikiBalino();
            //// obj.Test();
            // obj.DisplayMessage();

            // ClassImplement obj = new ClassImplement();
            //StringBuilderExample obj = new StringBuilderExample();
            //obj.PrintData();

            //ArrayExample obj = new ArrayExample();
            //obj.CallArray();

            //ArrayExample2 obj = new ArrayExample2();
            //Console.WriteLine("Your total Marks:" + obj.PrintStudentMarks());

            //ExceptionHandling obj = new ExceptionHandling();
            //obj.CallException();

            //ArrayListExample obj = new ArrayListExample();
            //obj.LoadItems();

            //StackExample obj = new StackExample();
            //obj.LoadItems();

            QueueExample obj = new QueueExample();
            obj.LoadItems();


            Console.ReadLine();
        }
    }
}
