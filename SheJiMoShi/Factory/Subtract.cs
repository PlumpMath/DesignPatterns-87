namespace Factory
{
    /// <summary>
    /// 减法操作类 继承自Operat
    /// </summary>
    class Subtract:Operat
    {
        /// <summary>
        /// 重写父类方法
        /// </summary>
        /// <returns></returns>
        public override double GetResult()
        {
            return NumberA - NumberB;
        }
    }
}
