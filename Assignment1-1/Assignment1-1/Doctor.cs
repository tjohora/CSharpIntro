using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_1
{
    class Doctor : hseEmployee
    {
        public Doctor() : base()
        {
            EmpName = "Dr. A. N. Other";
            EmpType = "Doctor";
            EmpYrsService = 0;
            EmpSalary = 110000;
        }

        public Doctor(String empName, String empType, int empYrsService, double empSalary) : base()
        {
            EmpName = empName;
            EmpType = empType;
            EmpYrsService = empYrsService;
            EmpSalary = empSalary;
        }



    }
}
