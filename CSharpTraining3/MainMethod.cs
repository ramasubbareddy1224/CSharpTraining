using System;
using Training3Library;

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

            //Addition objAdd = new Addition();

            //Console.WriteLine("enter first number");
            //int first =Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("enter second number");
            //int second = Convert.ToInt32(Console.ReadLine());

            //int result = objAdd.Add(first,second);
            //Console.WriteLine("addition of two number:"+result);

            //AccessSpecifierExample obj = new AccessSpecifierExample();
            //obj.PublicMethod();
            //obj.pr

            //InternalTestExample obj = new InternalTestExample();

            int count = 10;
            string name = "rama";
            //ConstructorExample obj = new ConstructorExample(count,20);
            //ConstructorExample obj2 = new ConstructorExample(count, 20);

            //MethodOverloadExample obj = new MethodOverloadExample();
            //obj.OverloadMethod(10, name);

            //PropertiesExample obj = new PropertiesExample();

            //obj.Id = 100;
            //obj.Name = "rama";
            //obj.Email = "rama@microsoft.com";
            //obj.EmployeeCount = 50;

            //obj.PropId = 101;
            //obj.PropFirstName = "rama1";
            //obj.PropLastName = "subba";
            //obj.PropEmail = "rama1@microsoft.com";
            ////obj.PropEmployeeCount = 10;



            //obj.PrintEmployeeDetails();

            //Console.WriteLine("propFullName:" + obj.PropFullName);

            //Console.WriteLine("employee count:"+obj.EmployeeCount);
            //  Console.WriteLine("propemployee count:" + obj.PropEmployeeCount);


            //DerivedSingleInheritace obj = new DerivedSingleInheritace();
            //obj.DerivedMethod();

            Derived2MulitiLevel obj = new Derived2MulitiLevel();
            obj.Derived2Method();

            Console.Read();
        }
    }
}
