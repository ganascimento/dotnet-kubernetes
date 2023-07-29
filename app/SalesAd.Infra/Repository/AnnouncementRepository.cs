using Microsoft.EntityFrameworkCore;
using SalesAd.Domain.Entities;
using SalesAd.Domain.Interfaces.Repository;
using SalesAd.Infra.Context;
using SalesAd.Infra.Repository.Base;

namespace SalesAd.Infra.Repository
{
    public class AnnouncementRepository : BaseRepository<AnnouncementEntity>, IAnnouncementRepository
    {
        private readonly DbSet<OwnerEntity> _dbSet;

        public AnnouncementRepository(DataContext dataContext) : base(dataContext)
        {
            _dbSet = dataContext.Set<OwnerEntity>();
        }

        public async Task<IEnumerable<AnnouncementEntity>?> GetByOwnerAsync(Guid ownerId)
        {
            var result = await _dbSet
                .AsNoTracking()
                .Include(x => x.Announcements)
                .FirstOrDefaultAsync(x => x.Id == ownerId);
            if (result == null) return null;

            return result.Announcements;
        }
    }
}