using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining3
{
    class Student
    {
        public int ID;
        public string Name;
        public string Email;

        public void GetEmployee()
        {
            ID = 100;
            Name = "Rama";
            Email = "rama@microsoft.com";
            Console.WriteLine("employee details");
           // Console.WriteLine("employee Id:" + ID + " Name:" + Name + " Email:" + Email);
            Console.WriteLine(string.Format("employee Id:{0}, Name:{1}, Email:{2}", ID, Name, Email));
                       
        }

        public int GetEmployeeCount()
        {
            int count = 100;
            return count;
        }

    }
}
