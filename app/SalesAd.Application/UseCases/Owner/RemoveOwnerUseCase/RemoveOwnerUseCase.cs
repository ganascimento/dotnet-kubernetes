using SalesAd.Domain.Interfaces.Repository;

namespace SalesAd.Application.UseCases.Owner.RemoveOwnerUseCase
{
    public class RemoveOwnerUseCase : IRemoveOwnerUseCase
    {
        private readonly IOwnerRepository _ownerRepository;

        public RemoveOwnerUseCase(IOwnerRepository ownerRepository)
        {
            _ownerRepository = ownerRepository;
        }

        public async Task Execute(Guid ownerId)
        {
            var entity = await _ownerRepository.GetAsync(ownerId);

            if (entity == null) return;

            await _ownerRepository.DeleteAsync(entity);
        }
    }
}