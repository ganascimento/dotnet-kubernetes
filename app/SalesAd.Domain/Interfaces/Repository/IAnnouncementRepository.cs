using System.Threading.Tasks;
using SalesAd.Domain.Entities;
using SalesAd.Domain.Interfaces.Repository.Base;

namespace SalesAd.Domain.Interfaces.Repository
{
    public interface IAnnouncementRepository : IRepository<AnnouncementEntity>
    {
        Task<IEnumerable<AnnouncementEntity>?> GetByOwnerAsync(Guid ownerId);
    }
}