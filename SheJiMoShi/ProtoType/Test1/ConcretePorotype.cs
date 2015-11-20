namespace ProtoType.Test1
{
    class ConcretePorotype:ProtoType
    {
        public override ProtoType Clone()
        {
            return (ProtoType) this.MemberwiseClone();//浅表复制，值类型复制具体的值，引用类型复制引用！
        }

        public ConcretePorotype(string id) : base(id)
        {
        }

        public new string Idd()
        {
            return "ConcretePrototype";
        }
    }
}
