namespace IFactory
{
    public abstract class Operator
    {
        public double numberA;
        public double numberB;

        public virtual double GetResult()
        {
            return 0;
        }
    }
}
