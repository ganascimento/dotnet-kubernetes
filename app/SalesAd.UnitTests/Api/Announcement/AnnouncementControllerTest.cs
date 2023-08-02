using Moq;
using SalesAd.Api.Controllers;
using SalesAd.Application.UseCases.Announcement.CreateAnnouncementUseCase;
using SalesAd.Application.UseCases.Announcement.GetAllAnnouncementUseCase;
using SalesAd.Application.UseCases.Announcement.GetByIdAnnouncementUseCase;
using SalesAd.Application.UseCases.Announcement.GetByOwnerAnnouncementUseCase;
using SalesAd.Application.UseCases.Announcement.RemoveAnnouncementUseCase;
using SalesAd.Application.UseCases.Announcement.UpdateAnnouncementUseCase;
using SalesAd.UnitTests.Api.Announcement.Fake;

namespace SalesAd.UnitTests.Api.Announcement;

public class AnnouncementControllerTest
{
    private readonly AnnouncementController _controller;
    private readonly Mock<IGetAllAnnouncementUseCase> _getAllAnnouncementUseCase;
    private readonly Mock<IGetByIdAnnouncementUseCase> _getByIdAnnouncementUseCase;
    private readonly Mock<IGetByOwnerAnnouncementUseCase> _getByOwnerAnnouncementUseCase;
    private readonly Mock<ICreateAnnouncementUseCase> _createAnnouncementUseCase;
    private readonly Mock<IUpdateAnnouncementUseCase> _updateAnnouncementUseCase;
    private readonly Mock<IRemoveAnnouncementUseCase> _removeAnnouncementUseCase;

    public AnnouncementControllerTest()
    {
        _getAllAnnouncementUseCase = new Mock<IGetAllAnnouncementUseCase>();
        _getByIdAnnouncementUseCase = new Mock<IGetByIdAnnouncementUseCase>();
        _getByOwnerAnnouncementUseCase = new Mock<IGetByOwnerAnnouncementUseCase>();
        _createAnnouncementUseCase = new Mock<ICreateAnnouncementUseCase>();
        _updateAnnouncementUseCase = new Mock<IUpdateAnnouncementUseCase>();
        _removeAnnouncementUseCase = new Mock<IRemoveAnnouncementUseCase>();
        _controller = new AnnouncementController(
            _getAllAnnouncementUseCase.Object,
            _getByIdAnnouncementUseCase.Object,
            _getByOwnerAnnouncementUseCase.Object,
            _createAnnouncementUseCase.Object,
            _updateAnnouncementUseCase.Object,
            _removeAnnouncementUseCase.Object);
    }

    [Fact(DisplayName = "Should get all registers")]
    public async Task GetAllAsync_Success()
    {
        _getAllAnnouncementUseCase
            .Setup(s => s.Execute())
            .ReturnsAsync(new List<GetAllAnnouncementResultModel>());

        await _controller.GetAllAsync();

        _getAllAnnouncementUseCase.Verify(v => v.Execute(), Times.Exactly(1));
    }

    [Fact(DisplayName = "Should get register by id")]
    public async Task GetByIdAsync_Success()
    {
        var announcementId = Guid.NewGuid();
        _getByIdAnnouncementUseCase
            .Setup(s => s.Execute(announcementId));

        await _controller.GetByIdAsync(announcementId);

        _getByIdAnnouncementUseCase.Verify(v => v.Execute(announcementId), Times.Exactly(1));
    }

    [Fact(DisplayName = "Should get registers by owner id")]
    public async Task GetByOwnerAsync_Success()
    {
        var ownerId = Guid.NewGuid();
        _getByOwnerAnnouncementUseCase
            .Setup(s => s.Execute(ownerId));

        await _controller.GetByOwnerAsync(ownerId);

        _getByOwnerAnnouncementUseCase.Verify(v => v.Execute(ownerId), Times.Exactly(1));
    }

    [Fact(DisplayName = "Should create new register")]
    public async Task CreateAsync_Success()
    {
        var createData = CreateAnnouncementModelFake.Build;
        _createAnnouncementUseCase
            .Setup(s => s.Execute(createData));

        await _controller.CreateAsync(createData);

        _createAnnouncementUseCase.Verify(v => v.Execute(createData), Times.Exactly(1));
    }

    [Fact(DisplayName = "Should update register")]
    public async Task UpdateAsync_Success()
    {
        var updateData = UpdateAnnouncementModelFake.Build;
        _updateAnnouncementUseCase
            .Setup(s => s.Execute(updateData));

        await _controller.UpdateAsync(updateData);

        _updateAnnouncementUseCase.Verify(v => v.Execute(updateData), Times.Exactly(1));
    }

    [Fact(DisplayName = "Should remove register")]
    public async Task RemoveAsync_Success()
    {
        var announcementId = Guid.NewGuid();
        _removeAnnouncementUseCase
            .Setup(s => s.Execute(announcementId));

        await _controller.RemoveAsync(announcementId);

        _removeAnnouncementUseCase.Verify(v => v.Execute(announcementId), Times.Exactly(1));
    }

}

