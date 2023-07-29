namespace SalesAd.Application.UseCases.Announcement.CreateAnnouncementUseCase
{
    public interface ICreateAnnouncementUseCase
    {
        Task Execute(CreateAnnouncementModel model);
    }
}