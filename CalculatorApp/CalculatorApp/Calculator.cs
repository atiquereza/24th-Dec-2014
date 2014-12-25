using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    class Calculator
    {
        public int firstNumber;
        public int secondNumber;
        public int result;

        public string add(Calculator aCalculator)
        {
            return Convert.ToString(aCalculator.firstNumber + aCalculator.secondNumber);

        }
        public string substract(Calculator aCalculator)
        {
            return Convert.ToString(aCalculator.firstNumber - aCalculator.secondNumber);

        }
        public string multiply(Calculator aCalculator)
        {
            return Convert.ToString(aCalculator.firstNumber * aCalculator.secondNumber);

        }
        public string divide(Calculator aCalculator)
        {
            return Convert.ToString(aCalculator.firstNumber / aCalculator.secondNumber);

        }
    }
}
