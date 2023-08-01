using Moq;
using SalesAd.Application.UseCases.Owner.UpdateOwnerUseCase;
using SalesAd.Domain.Entities;
using SalesAd.UnitTests.Infra.Fake;

namespace SalesAd.UnitTests.Application.Owner;

public class UpdateOwnerUseCaseTest : BaseApplicationTest
{
    private readonly UpdateOwnerUseCase _useCase;

    public UpdateOwnerUseCaseTest()
    {
        _useCase = new UpdateOwnerUseCase(_ownerRepository.Object);
    }

    [Fact]
    public async Task Execute_Success()
    {
        var resultModel = OwnerFake.Build;
        var updateModel = new UpdateOwnerModel
        {
            BirthDate = resultModel!.BirthDate,
            Name = resultModel.Name,
            Phone = resultModel.Phone.ToString(),
            Id = resultModel.Id
        };
        _ownerRepository.Setup(x => x.GetAsync(resultModel!.Id)).Returns(Task.FromResult(resultModel));

        await _useCase.Execute(updateModel);

        _ownerRepository.Verify(v => v.UpdateAsync(resultModel!), Times.Exactly(1));
    }

    [Fact]
    public async Task Execute_Not_Found()
    {
        var resultModel = OwnerFake.Build;
        var updateModel = new UpdateOwnerModel
        {
            BirthDate = resultModel!.BirthDate,
            Name = resultModel.Name,
            Phone = resultModel.Phone.ToString(),
            Id = resultModel.Id
        };
        _ownerRepository.Setup(x => x.GetAsync(resultModel.Id)).Returns(Task.FromResult<OwnerEntity?>(null));

        await _useCase.Execute(updateModel);

        _ownerRepository.Verify(v => v.GetAsync(updateModel.Id), Times.Exactly(1));
        _ownerRepository.Verify(v => v.UpdateAsync(resultModel!), Times.Exactly(0));
    }
}