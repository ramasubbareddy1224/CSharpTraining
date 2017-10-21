using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining2
{
    class RefOutExample
    {

        public void Execute()
        {
            int i = 10;  
            Console.WriteLine("before:" + i);
            PassValue(out i);
            Console.WriteLine("after:" + i);
            PassRef(ref i);
        }

        private void PassValue(out int i)  
        {
            i = 20;  // mandatory to assign value
        }

        private void PassRef(ref int i)
        {
            i = 20;
        }
    }
}
