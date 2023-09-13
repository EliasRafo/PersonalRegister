using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personalregister
{
    internal class Employee
    {
        private string employeeName { set; get; }
        private int employeeSalary { set; get; }
        public Employee(string _employeeName, int _employeeSalary) //Class constructor
        {
            employeeName = _employeeName;
            employeeSalary = _employeeSalary;
        }

        public string DisplayEmployee() 
        {
            string result = string.Format("Employee name: {0}, Employee salary: {1}", employeeName, employeeSalary);
            return result; 
        }
    }
}
