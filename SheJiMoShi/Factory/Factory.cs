namespace Factory
{
    /// <summary>
    /// 工厂类
    /// </summary>
    class Factory
    {
        /// <summary>
        /// 通过判断操作符来返回要实例化的操作方法
        /// </summary>
        /// <param name="flag"></param>
        /// <returns></returns>
        public static Operat GetOperat(string flag)
        {
            switch (flag)
            {
                case "+":
                    return new Add();
                case "-":
                    return new Subtract();
                default:
                    return null;
                    
            }
        }
    }
}
