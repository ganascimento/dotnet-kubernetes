using SalesAd.Domain.Entities;
using SalesAd.Domain.Interfaces.Repository;

namespace SalesAd.Application.UseCases.Announcement.GetAllAnnouncementUseCase
{
    public class GetAllAnnouncementUseCase : IGetAllAnnouncementUseCase
    {
        private readonly IAnnouncementRepository _announcementRepository;

        public GetAllAnnouncementUseCase(IAnnouncementRepository announcementRepository)
        {
            _announcementRepository = announcementRepository;
        }

        public async Task<IList<GetAllAnnouncementResultModel>> Execute()
        {
            var result = await _announcementRepository.GetAllAsync();
            return result.Select(x => ParseModel(x)).ToList();
        }

        private GetAllAnnouncementResultModel ParseModel(AnnouncementEntity entity) =>
            new GetAllAnnouncementResultModel
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