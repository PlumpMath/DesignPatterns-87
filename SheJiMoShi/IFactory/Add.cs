namespace IFactory
{
    /// <summary>
    /// 加法操作类
    /// </summary>
    public class Add : Operator
    {
        public override double GetResult()
        {
            return numberA + numberB;
        }
    }
}
