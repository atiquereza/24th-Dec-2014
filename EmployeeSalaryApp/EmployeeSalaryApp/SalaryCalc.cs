using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeSalaryApp
{
    class SalaryCalc
    {
        public string name;
        public int basicSalary;
        public int houseRentPct;
        public int medicalPct;

        public void salaryCalc(SalaryCalc oneSalaryCalc)
        {
            double a = basicSalary + (basicSalary*houseRentPct/100) + (basicSalary*medicalPct/100);
            MessageBox.Show(oneSalaryCalc.name+" Your Total Salary is: "+a);

        }

    }
}
