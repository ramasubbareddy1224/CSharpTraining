using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
   public class StringBuilderExp
    {
        public string GetString()
        {
            StringBuilder sb = new StringBuilder("Hello");
            sb.Append("Pragim");
            sb.Append("Tech");
            return sb.ToString();
        }
        public bool IsEmployeePermanent()
        {
            return true;
        }
        
    }
}
