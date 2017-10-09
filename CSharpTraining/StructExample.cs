using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
   public struct StructExample
    {
        public int ID;
        public string Name;
        public string Email;

        public void AssignValues()
        {
            ID = 2;
            Name = "student2";
            Email = "student2@gmail.com";
        }
    }
}
