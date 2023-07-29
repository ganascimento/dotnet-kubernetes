using SalesAd.Domain.Entities;
using SalesAd.Domain.Interfaces.Repository;

namespace SalesAd.Application.UseCases.Announcement.GetByIdAnnouncementUseCase
{
    public class GetByIdAnnouncementUseCase : IGetByIdAnnouncementUseCase
    {
        private readonly IAnnouncementRepository _announcementRepository;

        public GetByIdAnnouncementUseCase(IAnnouncementRepository announcementRepository)
        {
            _announcementRepository = announcementRepository;
        }

        public async Task<GetByIdAnnouncementResultModel?> Execute(Guid announcementId)
        {
            var result = await _announcementRepository.GetAsync(announcementId);
            if (result == null) return null;
            return ParseModel(result);
        }

        private GetByIdAnnouncementResultModel ParseModel(AnnouncementEntity entity) =>
            new GetByIdAnnouncementResultModel
            {
                Id = entity.Id,
                Country = entity.Address.Country,
                Neighborhood = entity.Address.Neighborhood,
                Number = entity.Address.Number,
                OwnerId = entity.OwnerId,
                Size = entity.Size,
                State = entity.Address.State,
                StreetName = entity.Address.StreetName,
                Type = (short)entity.Type,
                Value = entity.Value,
                ZipCode = entity.Address.ZipCode,
                Description = entity.Description,
                RoomsNumber = entity.RoomsNumber
            };
    }
}