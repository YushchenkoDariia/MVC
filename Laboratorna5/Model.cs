using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorna5
{
    public class CalculatorModel
    {
        public double FirstNumber { get; set; }
        public double SecondNumber { get; set; }
        public string Operation { get; set; }

        public double Calculate()
        {
            switch (Operation)
            {
                case "+":
                    return FirstNumber + SecondNumber;
                case "-":
                    return FirstNumber - SecondNumber;
                case "*":
                    return FirstNumber * SecondNumber;
                case "/":
                    if (SecondNumber != 0)
                        return FirstNumber / SecondNumber;
                    else
                        throw new DivideByZeroException("Division by zero is not allowed.");
                default:
                    throw new InvalidOperationException("Invalid operation");
            }
        }
    }
}
