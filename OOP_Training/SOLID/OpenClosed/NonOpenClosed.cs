namespace OOP_Training.SOLID.OpenClosed
{
    public class NonOpenClosedCalculator
    {
        public decimal Calculate(CalculateMethod method, decimal firstNum, decimal secondNum)
        {
            switch (method)
            {
                case CalculateMethod.Add:
                    return firstNum + secondNum;

                case CalculateMethod.Minus:
                    return firstNum - secondNum;

                default:
                    return 0;
            }
        }
    }
}