using SalesAd.Domain.Entities;
using SalesAd.Domain.Interfaces.Repository;

namespace SalesAd.Application.UseCases.Owner.CreateOwnerUseCase
{
    public class CreateOwnerUseCase : ICreateOwnerUseCase
    {
        private readonly IOwnerRepository _ownerRepository;

        public CreateOwnerUseCase(IOwnerRepository ownerRepository)
        {
            _ownerRepository = ownerRepository;
        }

        public async Task Execute(CreateOwnerModel model)
        {
            var entity = new OwnerEntity(Guid.NewGuid(), model.Name, model.BirthDate, model.Phone, model.Email);

            await _ownerRepository.InsertAsync(entity);
        }
    }
}