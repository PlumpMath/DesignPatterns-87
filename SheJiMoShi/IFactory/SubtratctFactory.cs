namespace IFactory
{
    class SubtratctFactory:IFactory
    {
        public Operator CreateOperator()
        {
          return  new Subtract();
        }
    }
}
