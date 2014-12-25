using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeSalaryApp
{
    public partial class Form1 : Form
    {
        SalaryCalc aSalaryCalc=new SalaryCalc();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            aSalaryCalc.name = nameTextBox.Text;
            aSalaryCalc.basicSalary = Convert.ToInt32(basicTextBox.Text);
            aSalaryCalc.houseRentPct = Convert.ToInt32(houseRentTextBox.Text);
            aSalaryCalc.medicalPct = Convert.ToInt32(medicalTextBox.Text);
            aSalaryCalc.salaryCalc(aSalaryCalc);
        }
    }
}
