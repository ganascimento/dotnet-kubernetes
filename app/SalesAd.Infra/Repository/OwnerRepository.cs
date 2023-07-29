using Microsoft.EntityFrameworkCore;
using SalesAd.Domain.Entities;
using SalesAd.Domain.Interfaces.Repository;
using SalesAd.Infra.Context;
using SalesAd.Infra.Repository.Base;

namespace SalesAd.Infra.Repository
{
    public class OwnerRepository : BaseRepository<OwnerEntity>, IOwnerRepository
    {
        public OwnerRepository(DataContext dataContext) : base(dataContext) { }
    }
}