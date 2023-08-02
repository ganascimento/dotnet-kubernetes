using Moq;
using SalesAd.Application.UseCases.Owner.ActiveOwnerUseCase;
using SalesAd.Domain.Entities;
using SalesAd.UnitTests.Infra.Fake;

namespace SalesAd.UnitTests.Application.Owner;

public class ActiveOwnerUseCaseTest : BaseApplicationTest
{
    private readonly ActiveOwnerUseCase _useCase;

    public ActiveOwnerUseCaseTest()
    {
        _useCase = new ActiveOwnerUseCase(_ownerRepository.Object);
    }

    [Fact(DisplayName = "Should active the owner")]
    public async Task Execute_Success()
    {
        var resultModel = OwnerFake.Build;
        _ownerRepository.Setup(x => x.GetAsync(resultModel!.Id)).Returns(Task.FromResult(resultModel));

        await _useCase.Execute(resultModel!.Id);

        _ownerRepository.Verify(v => v.UpdateAsync(resultModel!), Times.Exactly(1));
    }

    [Fact(DisplayName = "Should return null when find owner")]
    public async Task Execute_Not_Found()
    {
        var resultModel = OwnerFake.Build!;
        _ownerRepository.Setup(x => x.GetAsync(resultModel.Id)).Returns(Task.FromResult<OwnerEntity?>(null));

        await _useCase.Execute(resultModel.Id);

        _ownerRepository.Verify(v => v.GetAsync(resultModel.Id), Times.Exactly(1));
        _ownerRepository.Verify(v => v.UpdateAsync(resultModel), Times.Exactly(0));
    }
}