using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
    class GenericListExample : IArrayMethods
    {
        public void DisplayCollectionItems()
        {
           

            GenericEmployee empObj = new GenericEmployee();
            empObj.Id = 1;
            empObj.Name = "Student 1";
            empObj.Email = "student1@gmail.com";

            GenericEmployee emp2Obj = new GenericEmployee();
            emp2Obj.Id = 2;
            emp2Obj.Name = "Student 2";
            emp2Obj.Email = "student2@gmail.com";

            GenericEmployee emp3Obj = new GenericEmployee()
            {
                Id = 3,
                Name = "student 3",
                Email = "student3@gmail.com"

            };

            List<GenericEmployee> ListObj = new List<GenericEmployee>();
            ListObj.Add(empObj);
            ListObj.Add(emp2Obj);
            ListObj.Add(emp3Obj);

            Console.WriteLine("using forloop");
            for (int i = 0; i < ListObj.Count; i++)
            {
                Console.WriteLine(string.Format("employee details Id:{0},Name:{1},Email:{2}", ListObj[i].Id, ListObj[i].Name, ListObj[i].Email));
            }

            Console.WriteLine("Using foreach loop");
            foreach (GenericEmployee item in ListObj)
            {
                //var obj = item as string;

                //if (item is string)
                //{
                //    Console.WriteLine("True");
                //}

                Console.WriteLine(string.Format("employee details Id:{0},Name:{1},Email:{2}", item.Id, item.Name, item.Email));

            }

        }
    }
}
