namespace NukeNetCMS.Data.Infrastructure
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}