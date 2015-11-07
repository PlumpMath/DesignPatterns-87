namespace Strategy
{
    class Context
    {
        public Operat oper { get; set; }

        public Context(string flag)
        {
            switch (flag)
            {
                case "+":
                    oper=new Add();
                    break;
                case "-":
                    oper=new Subtract();
                    break;
            }

            
        }


        public double GetResult(double numberA, double numberB)
        {
            oper.NumberA = numberA;
            oper.NumberB = numberB;
           return oper.GetResult();
        }
    }
}
