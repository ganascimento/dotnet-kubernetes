namespace SalesAd.Application.UseCases.Owner.RemoveOwnerUseCase
{
    public interface IRemoveOwnerUseCase
    {
        Task Execute(Guid ownerId);
    }
}