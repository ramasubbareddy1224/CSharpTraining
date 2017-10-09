using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
    public class BaseEmployee { }
    public interface IEmployee
    {
        int Count { get; set; }
        int EmployeeCount();
        int EmpoyeeConsultants();
    }
    public interface IEmployeeV2
    {
        void EmployeeRole();
    }

    public class ContractEmployeeInterface : BaseEmployee,IEmployee, IEmployeeV2
    {
        public int Count { get; set; }

        public int EmployeeCount()
        {
            Count = 50;
            return Count;
        }

        public void EmployeeRole()
        {
            Console.WriteLine("Designing Role");
        }

        public int EmpoyeeConsultants()
        {
            return 50;
        }
    }
    public class PermanentEmployeeInterface : IEmployee,IEmployeeV2
    {
        public int Count { get; set; }

        public int EmployeeCount()
        {
            Count = 100;
            return Count;
        }

        public void EmployeeRole()
        {
            Console.WriteLine("Technical Documentation Role");
        }

        public int EmpoyeeConsultants()
        {
            return 50;
        }
    }
    public enum EmployeeType
    {
        Permenent = 10,
        Contract
    }
}
