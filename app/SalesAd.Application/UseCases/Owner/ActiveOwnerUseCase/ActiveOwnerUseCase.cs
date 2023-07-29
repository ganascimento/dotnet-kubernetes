using SalesAd.Domain.Interfaces.Repository;

namespace SalesAd.Application.UseCases.Owner.ActiveOwnerUseCase
{
    public class ActiveOwnerUseCase : IActiveOwnerUseCase
    {
        private readonly IOwnerRepository _ownerRepository;

        public ActiveOwnerUseCase(IOwnerRepository ownerRepository)
        {
            _ownerRepository = ownerRepository;
        }

        public async Task Execute(Guid ownerId)
        {
            var entity = await _ownerRepository.GetAsync(ownerId);

            if (entity == null) return;
            entity.SetActive();

            await _ownerRepository.UpdateAsync(entity);
        }
    }
}