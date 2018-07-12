namespace NukeNetCMS.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private NukeNetCmsDbContext dbContext;

        public NukeNetCmsDbContext Init()
        {
            return dbContext ?? (dbContext = new NukeNetCmsDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
            {
                dbContext.Dispose();
            }
        }
    }
}