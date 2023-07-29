namespace SalesAd.Application.UseCases.Announcement.UpdateAnnouncementUseCase
{
    public interface IUpdateAnnouncementUseCase
    {
        Task Execute(UpdateAnnouncementModel model);
    }
}