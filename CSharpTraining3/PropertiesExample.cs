using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining3
{
    public class PropertiesExample
    {
        public int Id;
        public string Name;
        public string Email;
        public int EmployeeCount = 100;

        public int PropId { get; set; }

        public string PropFirstName { get; set; }
        public string PropLastName { get; set; }
        public string PropEmail { get; set; }

        public int PropEmployeeCount { get; private set; }

        public string PropFullName
        {
            get
            {
                return PropFirstName + "  " + PropLastName;
            }
        }

        //private int _phone;

        //public int Phone
        //{
        //    get { return _phone; }
        //    set { _phone = value; }
        //}



        public void PrintEmployeeDetails()
        {
            PropEmployeeCount = 100;
            Console.WriteLine(string.Format("employee Id:{0} \n Name:{1} \n Email:{2}", Id, Name, Email));
            Console.WriteLine(string.Format("employee Id:{0} \n Name:{1} \n Email:{2}", PropId, PropFullName, PropEmail));

        }

    }
}
