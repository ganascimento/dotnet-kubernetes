using SalesAd.Domain.Enums;
using SalesAd.Domain.Interfaces.Repository;
using SalesAd.Domain.VO;

namespace SalesAd.Application.UseCases.Announcement.UpdateAnnouncementUseCase
{
    public class UpdateAnnouncementUseCase : IUpdateAnnouncementUseCase
    {
        private readonly IAnnouncementRepository _announcementRepository;

        public UpdateAnnouncementUseCase(IAnnouncementRepository announcementRepository)
        {
            _announcementRepository = announcementRepository;
        }

        public async Task Execute(UpdateAnnouncementModel model)
        {
            var entity = await _announcementRepository.GetAsync(model.Id);

            if (entity == null) return;

            var address = new Address(
                model.StreetName,
                model.ZipCode,
                model.Neighborhood,
                model.State,
                model.Country,
                model.Number
            );

            entity.Update(
                model.Value,
                model.Size,
                (AnnouncementTypeEnum)model.Type,
                address,
                model.Description,
                model.RoomsNumber
            );

            await _announcementRepository.UpdateAsync(entity);
        }
    }
}