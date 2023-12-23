namespace carvedrock.bl.principles.Solid.DependencyInversion.Interfaces
{
    public interface IDatabase
    {
        public void Connect();
        public void Insert();
        public void Update(int id);
        public void Delete();
        public object[] Select();
        public object Select(int id);

    }
}
