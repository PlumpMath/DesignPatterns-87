namespace Factory
{
    /// <summary>
    /// 加运算
    /// </summary>
    class Add : Operat
    {
        /// <summary>
        /// 重写父类获取结果方法
        /// </summary>
        /// <returns></returns>
        public override double GetResult()
        {
            return NumberA + NumberB;
        }
    }
}
