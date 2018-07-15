using NukeNetCMS.Data.Infrastructure;
using NukeNetCMS.Model.Models;

namespace NukeNetCMS.Data.Repositories
{
    public interface IPaymentTransactionRepository : IRepository<PaymentTransaction>
    {
    }

    public class PaymentTransactionRepository : RepositoryBase<PaymentTransaction>, IPaymentTransactionRepository
    {
        public PaymentTransactionRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}