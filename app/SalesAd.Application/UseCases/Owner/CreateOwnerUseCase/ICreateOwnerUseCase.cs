namespace SalesAd.Application.UseCases.Owner.CreateOwnerUseCase
{
    public interface ICreateOwnerUseCase
    {
        Task Execute(CreateOwnerModel model);
    }
}