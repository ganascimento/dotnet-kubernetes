namespace SalesAd.Application.UseCases.Owner.UpdateOwnerUseCase
{
    public interface IUpdateOwnerUseCase
    {
        Task Execute(UpdateOwnerModel model);
    }
}