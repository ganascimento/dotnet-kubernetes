using SalesAd.Domain.Interfaces.Repository;

namespace SalesAd.Application.UseCases.Owner.UpdateOwnerUseCase
{
    public class UpdateOwnerUseCase : IUpdateOwnerUseCase
    {
        private readonly IOwnerRepository _ownerRepository;

        public UpdateOwnerUseCase(IOwnerRepository ownerRepository)
        {
            _ownerRepository = ownerRepository;
        }

        public async Task Execute(UpdateOwnerModel model)
        {
            var entity = await _ownerRepository.GetAsync(model.Id);

            if (entity == null) return;
            entity.Update(model.Name, model.BirthDate, model.Phone);

            await this._ownerRepository.UpdateAsync(entity);
        }
    }
}