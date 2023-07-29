namespace SalesAd.Application.UseCases.Announcement.GetByOwnerAnnouncementUseCase
{
    public interface IGetByOwnerAnnouncementUseCase
    {
        Task<IList<GetByOwnerAnnouncementResultModel>?> Execute(Guid ownerId);
    }
}