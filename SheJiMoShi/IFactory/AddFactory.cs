namespace IFactory
{
    class AddFactory:IFactory
    {
        public Operator CreateOperator()
        {
            return new Add();
        }
    }
}
