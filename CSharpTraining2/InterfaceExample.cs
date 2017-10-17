using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining2
{
    public class Base
    {

    }
    public class Base2
    {

    }
    public interface Interface1
    {
        void DisplayMessage();
        void ShowName();
    }

    public interface Interface2
    {
        string Name { get; set; }
        void DisplayMessage();
    }

    public interface Interface3 : Interface1, Interface2
    {

    }

    public class ClassImplement : Interface1, Interface2
    {
        public string Name { get; set; }

        //public void Display2Messge()
        //{
        //    Console.WriteLine("This is Display2 Message");
        //}
        //void DisplayMessage()
        //{
        //    Console.WriteLine("Interface Example");
        //}

        void Interface1.DisplayMessage()
        {
            Console.WriteLine("Interface Example");
        }
        void Interface2.DisplayMessage()
        {
            Console.WriteLine("Interface2 Example");
        }

        public void ShowName()
        {
            Name = "Rama";
            Console.WriteLine("This is Interface Example written by:" + Name);
        }
    }

}
