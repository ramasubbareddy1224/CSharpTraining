using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining2
{
    public class ArrayExample2
    {
        public int PrintStudentMarks()
        {
            int[] marks = new int[5];
            int total = 0;
            Console.WriteLine("Enter first student five subject marks");


            //marks[0] = Convert.ToInt32(Console.ReadLine());
            //marks[1] = Convert.ToInt32(Console.ReadLine());
            //marks[2] = Convert.ToInt32(Console.ReadLine());
            //marks[3] = Convert.ToInt32(Console.ReadLine());
            //marks[4] = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < marks.Length; i++)
            {
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }



            foreach (int item in marks)
            {
                //  0+10;    10
                // 10 + 20; 30
                // 30 +30 ; 60
                total = total + item;
            }

            return total;
        }

    }
}
