using SalesAd.Domain.Interfaces.Repository;

namespace SalesAd.Application.UseCases.Announcement.RemoveAnnouncementUseCase
{
    public class RemoveAnnouncementUseCase : IRemoveAnnouncementUseCase
    {
        private readonly IAnnouncementRepository _announcementRepository;

        public RemoveAnnouncementUseCase(IAnnouncementRepository announcementRepository)
        {
            _announcementRepository = announcementRepository;
        }

        public async Task Execute(Guid announcementId)
        {
            var entity = await _announcementRepository.GetAsync(announcementId);

            if (entity == null) return;
            await _announcementRepository.DeleteAsync(entity);
        }
    }
}