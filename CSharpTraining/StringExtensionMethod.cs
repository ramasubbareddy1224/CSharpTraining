using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
    /*
     * 1. class should be static
     * 2. we should use this keyword
     */ 
    public static class StringExtensionMethod
    {
        public static int WhiteSpaceCount(this string name)
        {
            int count = 0;
            char[] charArray = name.ToCharArray();
            foreach (var item in charArray)
            {
                if (item == ' ')
                {
                    count++;
                }
            }
            return count;
        }
    }
}
