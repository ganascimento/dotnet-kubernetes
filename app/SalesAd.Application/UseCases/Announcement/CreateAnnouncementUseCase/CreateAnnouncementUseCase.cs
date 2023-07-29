using SalesAd.Domain.Entities;
using SalesAd.Domain.Enums;
using SalesAd.Domain.Interfaces.Repository;
using SalesAd.Domain.VO;

namespace SalesAd.Application.UseCases.Announcement.CreateAnnouncementUseCase
{
    public class CreateAnnouncementUseCase : ICreateAnnouncementUseCase
    {
        private readonly IAnnouncementRepository _announcementRepository;

        public CreateAnnouncementUseCase(IAnnouncementRepository announcementRepository)
        {
            _announcementRepository = announcementRepository;
        }

        public async Task Execute(CreateAnnouncementModel model)
        {
            var address = new Address(
                model.StreetName,
                model.ZipCode,
                model.Neighborhood,
                model.State,
                model.Country,
                model.Number
            );

            var entity = new AnnouncementEntity(
                Guid.NewGuid(),
                model.Value,
                model.Size,
                (AnnouncementTypeEnum)model.Type,
                model.OwnerId,
                description: model.Description,
                roomsNumber: model.RoomsNumber,
                address: address
            );

            await _announcementRepository.InsertAsync(entity);
        }
    }
}