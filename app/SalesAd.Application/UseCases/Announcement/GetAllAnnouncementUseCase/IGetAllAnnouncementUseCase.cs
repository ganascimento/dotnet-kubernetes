namespace SalesAd.Application.UseCases.Announcement.GetAllAnnouncementUseCase
{
    public interface IGetAllAnnouncementUseCase
    {
        Task<IList<GetAllAnnouncementResultModel>> Execute();
    }
}