using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
    public class MainMethod
    {
        static void Main(string[] args)
        {
            //Student studentObj = new Student();
            // studentObj.Name

            // CtorExample ctordefault = new CtorExample();
            // CtorExample ctoronepram = new CtorExample("pragim");
            //  CtorExample ctorObj = new CtorExample("pragim","pragim@gmail.com",989812312);
            // CtorExample ctorObj1 = new CtorExample("ABC", "abc@gmail.com", 589812312);


            // StaticCtorExample staticObj = new StaticCtorExample();

            // StaticCtorExample staticObj2 = new StaticCtorExample();

            // StaticCtorExample staticObj3 = new StaticCtorExample();

            //MethodOverload methodObj = new MethodOverload();
            //methodObj.GetStudent();
            //methodObj.GetStudent(102121);
            //methodObj.GetStudent(102121, "ABC");

            //SingleInhiritance singleObj = new SingleInhiritance();
            //singleObj.BaseMethod();

            //  DerivedSingleInhiritance derivedObj = new DerivedSingleInhiritance();
            //derivedObj.DerivedMethod();

            //Level3Derived level3derivedObj = new Level3Derived();
            //level3derivedObj.Level3DerivedMethod();

            // HiLevel2DerivedClass level2derivedobj = new HiLevel2DerivedClass();
            //level2derivedobj.Level2DerivedMethod();

            //SuzikiCiaz derivedAbstractObj = new SuzikiCiaz();
            //derivedAbstractObj.EngineSize();
            //derivedAbstractObj.DeliveryMessage();

            //SuzikiBalino derivedAbstractObj2 = new SuzikiBalino();
            //derivedAbstractObj2.EngineSize();
            //derivedAbstractObj2.DeliveryMessage();

            //Ship shipObject = new Ship();
            //shipObject.Steer();

            //CargoShip cargoShipObject = new CargoShip();
            //cargoShipObject.Steer();
            //cargoShipObject.Sail();

            // OilCargoShip oilCshipObject = new OilCargoShip();
            // oilCshipObject.Sail();

            //PartialEmployee empObj = new PartialEmployee();
            //Console.WriteLine("Total Employee Count:" + empObj.GetEmployeeCount());


            //IEmployee empObj;
            //IEmployeeV2 empObjv2;
            //Console.WriteLine("select emplyoee type ");
            //string empType = Console.ReadLine();
            //if (empType == EmployeeType.Contract.ToString())
            //{
            //    empObj = new ContractEmployeeInterface();
            //    empObjv2 = new ContractEmployeeInterface();
            //}
            //else
            //{
            //    empObj = new PermanentEmployeeInterface();
            //    empObjv2 = new PermanentEmployeeInterface();
            //}

            //Console.WriteLine("Total Employee Count:" + empObj.EmployeeCount());
            //empObjv2.EmployeeRole();

            //StringBuilderExp SBObj = new StringBuilderExp();
            //Console.WriteLine(SBObj.GetString());
            //Console.WriteLine(SBObj.IsEmployeePermanent());

            //ArrayExample arrayObj = new ArrayExample();
            //arrayObj.PrintArrayItems();

            // Console.WriteLine("Please enter day");
            //  string day = Console.ReadLine();

            //   Week dayEnum = (Week)Enum.Parse(typeof(Week), day);

            //if (dayEnum == Week.Sunday)
            //{
            //    Console.WriteLine("you have entered:" + Week.Sunday.ToString());
            //}
            //else if (day == Week.Monday.ToString())
            //{
            //    Console.WriteLine("you have entered:" + Week.Monday.ToString());
            //}
            //else if (day == Week.TuesDay.ToString())
            //{
            //    Console.WriteLine("you have entered:" + Week.TuesDay.ToString());
            //}
            //else
            //{
            //    Console.WriteLine("Not handled in the code");
            //}


            // using Switch Block

            //switch (dayEnum)
            //{
            //    case Week.Sunday:
            //         Console.WriteLine("You have entered:" + Week.Sunday.ToString());                    
            //        break;
            //    case Week.Monday:
            //        break;
            //    case Week.TuesDay:
            //        break;
            //    case Week.WednesDay:
            //        break;
            //    case Week.ThursDay:
            //        break;
            //    case Week.FriDay:
            //        break;
            //    case Week.SaturDay:
            //        break;
            //    default:
            //        Console.WriteLine("You have entered invalid day");
            //        break;
            //}

            //ExceptionExample exceptionObj = new ExceptionExample();
            //exceptionObj.GenerateException();

            //try
            //{
            //    ExceptionExample exceptionObj = new ExceptionExample();
            //    exceptionObj.GenerateExceptionOutside();
            //}
            //catch (Exception exbase)
            //{
            //    Console.WriteLine("This is Base exception deatails:" + exbase.Message);
            //    Console.WriteLine("stack trace" + exbase.StackTrace);
            //}

            //ArrayListExample alListObj = new ArrayListExample();
            //alListObj.DisplayArrayList();

            //IArrayMethods stackObj = new ReadOnlyConstExample(10);
            //stackObj.DisplayCollectionItems();
            // Console.WriteLine(stackObj.ToString());

            //RefOutExample refoutObj = new RefOutExample();
            //refoutObj.PrintItems();

            //ArrayExample arrayObj = new ArrayExample();
            //arrayObj.ScanArray();

            //StaticClassExample.PrintData();

            //NoNStaticClass nonSCObj = new NoNStaticClass();
            //nonSCObj.NormalMethod();
            //NoNStaticClass.StaticMethod();

            //FileStreamExample fsObj = new FileStreamExample();
            //fsObj.ExecuteFile();

            //StreamWriterExample swObj = new StreamWriterExample();
            //swObj.WriteContent();

            //StreamReaderExample srObj = new StreamReaderExample();
            //srObj.ReadContent();

            //StructExample stObj;
            //stObj.ID = 1;
            //stObj.Name = "student 1";
            //stObj.Email = "student1@gmail.com";
            //Console.WriteLine(string.Format("ID :{0},Name:{1},Email{2}",stObj.ID,stObj.Name,stObj.Email));
            //stObj.AssignValues();
            //Console.WriteLine(string.Format("ID :{0},Name:{1},Email{2}", stObj.ID, stObj.Name, stObj.Email));

            //int count = 5;
            //for (int i = 1; i <=count; i++)
            //{
            //    //for (int r = i; r <=count; r++)
            //    //{
            //    //     Console.Write(new string(' ',1));
            //    //}
            //    Console.Write(Indent(count - i));                
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(j);
            //    }
            //    for (int k = i-1; k >= 1; k--)
            //    {
            //        Console.Write(k);
            //    }
            //    Console.WriteLine();
            //}


            //// Lower part
            //for (int i = count, r = 1; i >= 1; i--, r++)
            //{

            //    Console.Write(Indent(r));
            //    for (int j = 1; j < i; j++)
            //    {
            //        Console.Write(j);
            //    }
            //    for (int k = (i - 1) - 1; k >= 1; k--)
            //    {
            //        Console.Write(k);
            //    }

            //    Console.WriteLine();
            //}


            //IExcersice vwObj = new PrintOneTwoOneTwice();
            //vwObj.PrintData();
            //Console.WriteLine("enter a value");
            //int a = int.Parse(Console.ReadLine());
            //Console.WriteLine("enter b value");
            //int b = int.Parse(Console.ReadLine());
            //int add, sub, mul, div = 0;
            //AddSubtractUsingout Obj = new AddSubtractUsingout();
            //Obj.PrintData(a, b, out add, out sub, out mul, out div);
            //Console.WriteLine("addition:"+add);
            //Console.WriteLine("subtraction"+sub);
            //Console.WriteLine("mul:"+mul);
            //Console.WriteLine("divi:"+div);

            string s = "pragimi tech kuk hyd telangana";
            Console.WriteLine(s.WhiteSpaceCount());              


            Console.ReadLine();
        }
        public static string Indent(int count)
        {

            return "".PadLeft(count);
        }

    }

}
