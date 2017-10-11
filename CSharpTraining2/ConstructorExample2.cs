using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining2
{
    class ConstructorExample2
    {
        int idlocal ;
        string namelocal;

        public ConstructorExample2()
        {
            idlocal = 0;
            namelocal = "student";
        }

        public ConstructorExample2(int id, string name)
        {
            idlocal = id;
            namelocal = name;
        }

        public void PrintStudentDetails()
        {
            Console.WriteLine("student id:" + idlocal);
            Console.WriteLine("student name:" + namelocal);
        }
    }
}
