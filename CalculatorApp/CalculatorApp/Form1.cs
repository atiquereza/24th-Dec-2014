using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        Calculator oneCalculator=new Calculator();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            oneCalculator.firstNumber = Convert.ToInt32(firstTextBox.Text);
            oneCalculator.secondNumber = Convert.ToInt32(secondTextBox.Text);
            resultTextBox.Text = oneCalculator.add(oneCalculator);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            oneCalculator.firstNumber = Convert.ToInt32(firstTextBox.Text);
            oneCalculator.secondNumber = Convert.ToInt32(secondTextBox.Text);
            resultTextBox.Text = oneCalculator.substract(oneCalculator);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            oneCalculator.firstNumber = Convert.ToInt32(firstTextBox.Text);
            oneCalculator.secondNumber = Convert.ToInt32(secondTextBox.Text);
            resultTextBox.Text = oneCalculator.multiply(oneCalculator);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            oneCalculator.firstNumber = Convert.ToInt32(firstTextBox.Text);
            oneCalculator.secondNumber = Convert.ToInt32(secondTextBox.Text);
            resultTextBox.Text = oneCalculator.divide(oneCalculator);
        }
    }
}
