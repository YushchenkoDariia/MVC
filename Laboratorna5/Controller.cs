using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorna5
{
    public class CalculatorController
    {
        private CalculatorModel _model;

        public CalculatorController(CalculatorModel model)
        {
            _model = model;
        }

        public void SetFirstNumber(double number)
        {
            _model.FirstNumber = number;
        }

        public void SetSecondNumber(double number)
        {
            _model.SecondNumber = number;
        }

        public void SetOperation(string operation)
        {
            _model.Operation = operation;
        }

        public double GetResult()
        {
            return _model.Calculate();
        }
    }


}
