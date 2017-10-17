using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining2
{
    class StringBuilderExample
    {
        public void PrintData()
        {

            string s = "pragim";
            s += "tech";
            Console.WriteLine(s);

            StringBuilder builder = new StringBuilder();
            builder.Append("pragim");
            builder.Append("tech");
           
            Console.WriteLine(builder.ToString());
        }
    }
}
