namespace TestTask.Server.DAL.Context
{
    public interface IDataInitializer
    {
        void Initialize(DatabaseContext context);
    }
}