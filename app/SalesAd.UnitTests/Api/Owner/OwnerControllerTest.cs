using Moq;
using SalesAd.Api.Controllers;
using SalesAd.Application.UseCases.Owner.ActiveOwnerUseCase;
using SalesAd.Application.UseCases.Owner.CreateOwnerUseCase;
using SalesAd.Application.UseCases.Owner.RemoveOwnerUseCase;
using SalesAd.Application.UseCases.Owner.UpdateOwnerUseCase;
using SalesAd.UnitTests.Api.Owner.Fake;

namespace SalesAd.UnitTests.Api.Owner;

public class OwnerControllerTest
{
    private readonly OwnerController _controller;
    private readonly Mock<IActiveOwnerUseCase> _activeOwnerUseCaseMock;
    private readonly Mock<ICreateOwnerUseCase> _createOwnerUseCaseMock;
    private readonly Mock<IUpdateOwnerUseCase> _updateOwnerUseCaseMock;
    private readonly Mock<IRemoveOwnerUseCase> _removeOwnerUseCaseMock;

    public OwnerControllerTest()
    {
        _activeOwnerUseCaseMock = new Mock<IActiveOwnerUseCase>();
        _createOwnerUseCaseMock = new Mock<ICreateOwnerUseCase>();
        _updateOwnerUseCaseMock = new Mock<IUpdateOwnerUseCase>();
        _removeOwnerUseCaseMock = new Mock<IRemoveOwnerUseCase>();
        _controller = new OwnerController(
            _activeOwnerUseCaseMock.Object,
            _createOwnerUseCaseMock.Object,
            _updateOwnerUseCaseMock.Object,
            _removeOwnerUseCaseMock.Object);
    }

    [Fact(DisplayName = "Should create new owner")]
    public async Task CreateAsync_Success()
    {
        var createData = CreateOwnerModelFake.Build;
        _createOwnerUseCaseMock
            .Setup(s => s.Execute(createData));

        await _controller.CreateAsync(createData);

        _createOwnerUseCaseMock.Verify(v => v.Execute(createData), Times.Exactly(1));
    }

    [Fact(DisplayName = "Should update owner")]
    public async Task UpdateAsync_Success()
    {
        var updateData = UpdateOwnerModelFake.Build;
        _updateOwnerUseCaseMock
            .Setup(s => s.Execute(updateData));

        await _controller.UpdateAsync(updateData);

        _updateOwnerUseCaseMock.Verify(v => v.Execute(updateData), Times.Exactly(1));
    }

    [Fact(DisplayName = "Should remove owner")]
    public async Task RemoveAsync_Success()
    {
        var ownerId = Guid.NewGuid();

        _removeOwnerUseCaseMock
            .Setup(s => s.Execute(ownerId));

        await _controller.RemoveAsync(ownerId);

        _removeOwnerUseCaseMock.Verify(v => v.Execute(ownerId), Times.Exactly(1));
    }

    [Fact(DisplayName = "Should active owner")]
    public async Task ActiveAsync_Success()
    {
        var ownerId = Guid.NewGuid();

        _activeOwnerUseCaseMock
            .Setup(s => s.Execute(ownerId));

        await _controller.ActiveAsync(ownerId);

        _activeOwnerUseCaseMock.Verify(v => v.Execute(ownerId), Times.Exactly(1));
    }
}