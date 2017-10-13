using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining2
{
    public class PropertiesExample
    {


        public int StudentId;
        public string FirstName, Lastname, FullName;
        public string Email;

        private int _propStudentId;
        public int PropStudentId
        {
            get
            {
                return _propStudentId ;
            }
            set
            {
                _propStudentId = value;
            }
        }

        public string PropFirstName { get; set; }
        public string PropLastName { get; set; }
        public string PropFullName {
            get
            {
                return PropFirstName + " " + PropLastName;
            }
           // private set; 
        }
        public string PropEmail { get; set; }


        public void PrintStudentDetails()
        {
            FullName = FirstName + " " + Lastname;
            Console.WriteLine("Student Id:" + StudentId);
            Console.WriteLine("Student First Name:" + FirstName);
            Console.WriteLine("Student Last Name:" + Lastname);
            Console.WriteLine("Student Full Name:" + FullName);
            Console.WriteLine("Student Email:" + Email);
        }

        public void PrintPropStudentDetails()
        {

        }


        public string GetFullName()
        {
            return FirstName + " " + Lastname;
        }

    }
}
