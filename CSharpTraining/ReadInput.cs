using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
    public class ReadInput
    {
        static void Main(string[] args)
        {
            int studentId;
            int phone;
            string name;
            Console.WriteLine("This is for reading input");

            Console.WriteLine("Please enter student ID");
            studentId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter phone number");
            //int.TryParse()
            phone = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter name");
            name = Console.ReadLine();

          //  string finaldata = string.Format("Your complete details: id:{0}, phone:{1},name:{2}", studentId, phone, name);
           // Console.WriteLine(finaldata);
            Console.WriteLine(string.Format("Your complete details: id:{0}, phone:{1},name:{2}", studentId, phone, name));

            Console.ReadLine();
        }
    }
}
