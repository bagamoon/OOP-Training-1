using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Training.SOLID.OpenClosed
{
    public class OpenClosedCalculator
    {
        public decimal Calculate(CalculateMethod method, decimal firstNum, decimal secondNum)
        {
            ICalculator calculator = GetCalculator(method);

            return calculator.Calculate(firstNum, secondNum);
        }

        private ICalculator GetCalculator(CalculateMethod method)
        {
            switch (method)
            {
                case CalculateMethod.Add:
                    return new AddCalculator();

                case CalculateMethod.Minus:
                    return new MinusCalculator();

                default:
                    return null;
            }
        }
    }

    interface ICalculator
    {
        decimal Calculate(decimal firstNum, decimal secondNum);
    }

    class MinusCalculator : ICalculator
    {
        public decimal Calculate(decimal firstNum, decimal secondNum)
        {
            return firstNum - secondNum;
        }
    }

    class AddCalculator : ICalculator
    {
        public decimal Calculate(decimal firstNum, decimal secondNum)
        {
            return firstNum + secondNum;
        }
    }
}
