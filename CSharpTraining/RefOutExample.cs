using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
    public class RefOutExample
    {
        public void PrintItems()
        {
            int i =10 ;
            Console.WriteLine("before calculate :" + i);

          //  Calculate(i);
            CalculateRef(ref i);
            Console.WriteLine("after calculate" + i);
        }

        private void Calculate(int i)
        {
            i = 20;
        }

        public void CalculateRef(ref int i)
        {
           i = 20;
        }
    }
}
