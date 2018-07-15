using NukeNetCMS.Data.Infrastructure;
using NukeNetCMS.Data.Repositories;
using NukeNetCMS.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NukeNetCMS.Service
{
    public interface IAdvertisingService
    {
        Advertising Add(Advertising advertising);
        void Update(Advertising advertising);
        Advertising Delete(Advertising advertising);
        Advertising GetByID(int id);
        IEnumerable<Advertising> GetAllPaging(int page, int size, out int totalRow);
    }

    public class AdvertisingService : IAdvertisingService
    {
        private IAdvertisingRepository _advertisingRepository;
        private IUnitOfWork _unitOfWork;

        public AdvertisingService(IAdvertisingRepository advertisingRepository, IUnitOfWork unitOfWork)
        {
            this._advertisingRepository = advertisingRepository;
            this._unitOfWork = unitOfWork;
        }

        public Advertising Add(Advertising advertising)
        {
            return _advertisingRepository.Add(advertising);
        }

        public Advertising Delete(Advertising advertising)
        {
            return _advertisingRepository.Delete(advertising);
        }

        public IEnumerable<Advertising> GetAllPaging(int page, int size, out int totalRow)
        {
            return _advertisingRepository.GetMultiPaging(null, out totalRow, page, size, new string[] { });
        }

        public Advertising GetByID(int id)
        {
            return _advertisingRepository.GetSingleById(id);
        }

        public void Update(Advertising advertising)
        {
            _advertisingRepository.Update(advertising);
        }
    }
}
