namespace SalesAd.Application.UseCases.Owner.ActiveOwnerUseCase
{
    public interface IActiveOwnerUseCase
    {
        Task Execute(Guid ownerId);
    }
}