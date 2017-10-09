using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
    public class MethodOverload
    {
        public void GetStudent()
        {
            Console.WriteLine("This is get student with zero arguments");
        }
        public void GetStudent(int studentId)
        {
            Console.WriteLine("This is get student with one argument studentId:" + studentId);
        }
        public void GetStudent(int studentId, string studentName)
        {
            Console.WriteLine(string.Format("This is get student with two arguments studentId:{0} studentName:{1}", studentId, studentName));
        }
        public void GetStudent(string studentName, int studentId)
        {
            Console.WriteLine(string.Format("This is get student with two arguments studentId:{1} studentName:{0}", studentName, studentId));

        }
        public void GetStudent(string studentId)
        {
            Console.WriteLine("This is get student with one argument studentId:" + studentId);
        }


    }
}
