namespace Problem_3
{
    internal class PrimitiveCalculation
    {
        public void ChangeStrategy(char @operator)
        {
            this.strategy = this.possibleStrategies[@operator];
        }

        public int PerformCalculation(int firstOperand, int secondOperand)
        {
            return this.strategy.Calculate(firstOperand, secondOperand);
        }
    }
}
