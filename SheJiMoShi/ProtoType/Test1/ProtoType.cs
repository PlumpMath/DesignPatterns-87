namespace ProtoType.Test1
{
  abstract class ProtoType
  {
      private string Id;

      protected ProtoType(string id)
      {
          this.Id = id;
      }

      public string Idd()
      {
          return Id;
      }

      public abstract ProtoType Clone();
  }
}
