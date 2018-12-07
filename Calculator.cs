using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculator
    {
        public double  firstNumber { get; set; }
        public double secondNumber { get; set; }
        public string Operation { get; set; }

        public double Calc(string symbol)
        {
            double resault = 0;
            if (symbol == "+")
                 resault = firstNumber + secondNumber;

            else if (symbol == "-")
                resault = firstNumber - secondNumber;
            else if (symbol == "x")
                resault = firstNumber * secondNumber;
            else if (symbol == "/")
                resault = firstNumber / secondNumber;
            else if (symbol == "%")
                resault = firstNumber % secondNumber;
            

            return resault;

        }
    }
}
