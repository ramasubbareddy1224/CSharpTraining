using System;
using System.Text;

namespace CSharpTraining3
{
    class StringBuilderExample
    {
        public void PrintData()
        {
          
            string s = "pragim";
            s += " tech";
            s = s.Replace("tech", "technology");
            Console.WriteLine("using string:"+s);

            StringBuilder obj = new StringBuilder();
            obj.Append("pragim");
            obj.Append(" technology");
            Console.WriteLine("using stringbuilder:"+obj.ToString());


        }
    }
}
