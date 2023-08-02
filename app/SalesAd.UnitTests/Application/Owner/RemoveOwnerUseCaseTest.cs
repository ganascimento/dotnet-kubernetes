using Moq;
using SalesAd.Application.UseCases.Owner.RemoveOwnerUseCase;
using SalesAd.Domain.Entities;
using SalesAd.UnitTests.Infra.Fake;

namespace SalesAd.UnitTests.Application.Owner;

public class RemoveOwnerUseCaseTest : BaseApplicationTest
{
    private readonly RemoveOwnerUseCase _useCase;

    public RemoveOwnerUseCaseTest()
    {
        _useCase = new RemoveOwnerUseCase(_ownerRepository.Object);
    }

    [Fact(DisplayName = "Should remove owner")]
    public async Task Execute_Success()
    {
        var resultModel = OwnerFake.Build;
        _ownerRepository.Setup(x => x.GetAsync(resultModel!.Id)).Returns(Task.FromResult(resultModel));

        await _useCase.Execute(resultModel!.Id);

        _ownerRepository.Verify(v => v.DeleteAsync(resultModel!), Times.Exactly(1));
    }

    [Fact(DisplayName = "Should return null when it finds the owner")]
    public async Task Execute_Not_Found()
    {
        var ownerId = Guid.NewGuid();
        _ownerRepository.Setup(x => x.GetAsync(ownerId)).Returns(Task.FromResult<OwnerEntity?>(null));

        await _useCase.Execute(ownerId);

        _ownerRepository.Verify(v => v.GetAsync(ownerId), Times.Exactly(1));
        _ownerRepository.Verify(v => v.DeleteAsync(OwnerFake.Build!), Times.Exactly(0));
    }
}