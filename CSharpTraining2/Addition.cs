using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining2
{
   public class Addition
    {
        static void Main()
        {
            Addition obj = new Addition();
            // string output = obj.Add(1, 2);
            // Console.WriteLine(output);

            // obj.AddWithVoid(1, 2);

            string info = obj.StudentData(100, "Rama");
            Console.WriteLine(info);

            Console.ReadLine();
        }

        public string Add(int a, int b)
        {
            int value = a + b;
            return Convert.ToString(value);
        }
        public void AddWithVoid(int a, int b)
        {
            int value = a + b;
            Console.WriteLine(value);
        }

        public string StudentData(int id, string name)
        {
            string studentInfo = string.Format("student id {0} , name {1}", id.ToString(), name);
            return studentInfo;
        }
    }
}
