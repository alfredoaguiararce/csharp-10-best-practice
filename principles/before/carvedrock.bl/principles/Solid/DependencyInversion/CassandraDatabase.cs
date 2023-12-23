using carvedrock.bl.principles.Solid.DependencyInversion.Interfaces;

namespace carvedrock.bl.principles.Solid.DependencyInversion
{
    internal class CassandraDatabase : IDatabase
    {
        public void Connect()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Insert()
        {
            throw new NotImplementedException();
        }

        public object[] Select()
        {
            throw new NotImplementedException();
        }

        public object Select(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(int id)
        {
            throw new NotImplementedException();
        }
    }
}
