using SalesAd.Domain.Entities;
using SalesAd.Domain.Interfaces.Repository;

namespace SalesAd.Application.UseCases.Announcement.GetByOwnerAnnouncementUseCase
{
    public class GetByOwnerAnnouncementUseCase : IGetByOwnerAnnouncementUseCase
    {
        private readonly IAnnouncementRepository _announcementRepository;

        public GetByOwnerAnnouncementUseCase(IAnnouncementRepository announcementRepository)
        {
            _announcementRepository = announcementRepository;
        }

        public async Task<IList<GetByOwnerAnnouncementResultModel>?> Execute(Guid ownerId)
        {
            var result = await _announcementRepository.GetByOwnerAsync(ownerId);
            if (result == null) return null;

            return result.Select(x => ParseModel(x)).ToList();
        }

        private GetByOwnerAnnouncementResultModel ParseModel(AnnouncementEntity entity) =>
            new GetByOwnerAnnouncementResultModel
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