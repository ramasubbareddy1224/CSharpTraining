using System;
using System.Collections;
using System.Collections.Generic;


namespace CSharpTraining3
{
    class GenericListExample
    {
        public void PrintData()
        {
            int[] intarray = new int[5];

            List<int> objintList = new List<int>();
            objintList.Add(100);
            objintList.Add(200);
            objintList.Add(30);

            Console.WriteLine("using foreach");
            foreach (var item in objintList)
            {
                Console.WriteLine(item);
            }

            List<string> objstringList = new List<string>();
            objstringList.Add("rama");
            objstringList.Add("krishna");

        }

        public void PrintEmpoyees()
        {
            List<Employee> obj = new List<Employee>();

            Employee emp1 = new Employee();
            emp1.ID = 100;
            emp1.Name = "rama";
            emp1.Email = "rama@gmail.com";

            obj.Add(emp1);

            Employee emp2 = new Employee()
            {
                ID = 200,
                Name = "rama2",
                Email = "rama2@gmail.com"
            };

            obj.Add(emp2);


            Console.WriteLine("using foreach");
            foreach (Employee item in obj)
            {
                Console.WriteLine(string.Format("ID:{0}, Name:{1}", item.ID, item.Name));
            }


        }
    }
    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
