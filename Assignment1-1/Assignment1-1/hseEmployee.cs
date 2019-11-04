using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_1
{
    class hseEmployee
    {
        private String empName;
        private int empNumber;
        private String empType;
        private int empYrsService;
        private double empSalary;
        private static int count = 100;

        public hseEmployee()
        {
            this.empName = "A. N. Other";
            this.empNumber = count;
            this.empType = "Standard";
            this.empYrsService = 0;
            this.empSalary = 30000;
            count += 100;
        }
        public hseEmployee(String empName, String empType, int empYrsService, double empSalary)
        {
            this.empName = empName;
            this.empNumber = count;
            this.empType = empType;
            this.empYrsService = empYrsService;
            this.empSalary = empSalary;
            count += 100;
        }

        public String EmpName
        {
            get { return empName; }
            set { empName = value; }
        }

        public int EmpNumber
        {
            get { return empNumber; }
        }

        public String EmpType
        {
            get { return empType; }
            set { empType = value; }
        }

        public int EmpYrsService
        {
            get { return empYrsService; }
            set { empYrsService = value; }
        }

        public double EmpSalary
        {
            get { return empSalary; }
            set { empSalary = value; }
        }

        public override string ToString()
        {
            return "Emp Name: " + this.empName +  "\nEmp Number: " + this.empNumber + "\nEmp Type: " + this.empType + "\nEmp Yrs Service: " + this.empYrsService + "\nEmp Salary: " + this.empSalary;
        }






    }
}
