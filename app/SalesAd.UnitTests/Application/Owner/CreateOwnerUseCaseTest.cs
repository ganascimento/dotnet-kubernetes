using Moq;
using SalesAd.Application.UseCases.Owner.CreateOwnerUseCase;
using SalesAd.Domain.Entities;
using SalesAd.UnitTests.Infra.Fake;

namespace SalesAd.UnitTests.Application.Owner;

public class CreateOwnerUseCaseTest : BaseApplicationTest
{
    private readonly CreateOwnerUseCase _useCase;

    public CreateOwnerUseCaseTest()
    {
        _useCase = new CreateOwnerUseCase(_ownerRepository.Object);
    }

    [Fact]
    public async Task Execute_Success()
    {
        var resultModel = OwnerFake.Build!;
        var createMode = new CreateOwnerModel
        {
            BirthDate = resultModel.BirthDate,
            Email = resultModel.Email.ToString(),
            Name = resultModel.Name,
            Phone = resultModel.Phone.ToString()
        };

        await _useCase.Execute(createMode);

        _ownerRepository.Verify(v => v.InsertAsync(It.IsAny<OwnerEntity>()), Times.Exactly(1));
    }
}