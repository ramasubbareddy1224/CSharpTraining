using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
    public class CtorExample
    {
        //string _name = "abc";
        //string _email = "abc@gmail.com";
        //int _phone=999999;
        public CtorExample()
        {
            Console.WriteLine("Calling Constructor");
        }
        public CtorExample(string Name):this(Name,"abc@gmail.com",999999)
        {
            //Console.WriteLine("Calling constructor with param1:" + Name);
        }
        public CtorExample(string name, string email,int phone)
        {
            //this._name = name;
            //this._email = email;
            //this._phone = phone;
            Console.WriteLine(string.Format("Calling constructor with param1:{0} param2:{1} phone:{2}", name, email,phone));
        }

        public void samplemethod1()
        {
            Console.WriteLine("This is sample method 1");
        }
    }
}
