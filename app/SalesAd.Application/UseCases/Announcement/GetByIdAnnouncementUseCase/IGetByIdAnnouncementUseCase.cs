namespace SalesAd.Application.UseCases.Announcement.GetByIdAnnouncementUseCase
{
    public interface IGetByIdAnnouncementUseCase
    {
        Task<GetByIdAnnouncementResultModel?> Execute(Guid announcementId);
    }
}