namespace SalesAd.Application.UseCases.Announcement.RemoveAnnouncementUseCase
{
    public interface IRemoveAnnouncementUseCase
    {
        Task Execute(Guid announcementId);
    }
}