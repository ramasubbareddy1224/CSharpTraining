using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
   public partial class PartialEmployee
    {
        public int Id { get; set; }
        public string EmployeeName { get; set; }
        public int EmployeeCount { get; private set; }

        public int GetEmployeeCount()
        {
            EmployeeCount = 100;
            return EmployeeCount;
        }
    }
}
