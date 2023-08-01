using Moq;
using SalesAd.Application.UseCases.Announcement.RemoveAnnouncementUseCase;
using SalesAd.Domain.Entities;
using SalesAd.UnitTests.Application.Announcement.Fake;

namespace SalesAd.UnitTests.Application.Announcement;

public class RemoveAnnouncementUseCaseTest : BaseApplicationTest
{
    private readonly RemoveAnnouncementUseCase _useCase;

    public RemoveAnnouncementUseCaseTest()
    {
        _useCase = new RemoveAnnouncementUseCase(_announcementRepository.Object);
    }

    [Fact]
    public async Task Execute_Success()
    {
        var resultModel = AnnouncementFake.Build;
        _announcementRepository.Setup(x => x.GetAsync(resultModel!.Id)).Returns(Task.FromResult(resultModel));

        await _useCase.Execute(resultModel!.Id);

        _announcementRepository.Verify(v => v.DeleteAsync(resultModel!), Times.Exactly(1));
    }

    [Fact]
    public async Task Execute_Not_Found()
    {
        var resultModel = AnnouncementFake.Build!;
        _announcementRepository.Setup(x => x.GetAsync(resultModel.Id)).Returns(Task.FromResult<AnnouncementEntity?>(null));

        await _useCase.Execute(resultModel.Id);

        _announcementRepository.Verify(v => v.GetAsync(resultModel.Id), Times.Exactly(1));
        _announcementRepository.Verify(v => v.DeleteAsync(resultModel), Times.Exactly(0));
    }
}