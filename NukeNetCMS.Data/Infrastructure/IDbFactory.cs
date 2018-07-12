using System;

namespace NukeNetCMS.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        NukeNetCmsDbContext Init();
    }
}