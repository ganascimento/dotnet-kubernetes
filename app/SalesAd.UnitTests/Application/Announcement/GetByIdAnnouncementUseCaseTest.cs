using Moq;
using SalesAd.Application.UseCases.Announcement.GetByIdAnnouncementUseCase;
using SalesAd.Domain.Entities;
using SalesAd.UnitTests.Application.Announcement.Fake;

namespace SalesAd.UnitTests.Application.Announcement;

public class GetByIdAnnouncementUseCaseTest : BaseApplicationTest
{
    private readonly GetByIdAnnouncementUseCase _useCase;

    public GetByIdAnnouncementUseCaseTest()
    {
        _useCase = new GetByIdAnnouncementUseCase(_announcementRepository.Object);
    }

    [Fact]
    public async Task Execute_Success()
    {
        var resultModel = AnnouncementFake.Build;
        _announcementRepository.Setup(x => x.GetAsync(resultModel!.Id)).Returns(Task.FromResult(resultModel));

        var result = await _useCase.Execute(resultModel!.Id);

        _announcementRepository.Verify(v => v.GetAsync(resultModel.Id), Times.Exactly(1));
        Assert.NotNull(result);
        Assert.Equal(result.Id, resultModel.Id);
    }

    [Fact]
    public async Task Execute_Not_Found()
    {
        var resultModel = AnnouncementFake.Build!;
        _announcementRepository.Setup(x => x.GetAsync(resultModel.Id)).Returns(Task.FromResult<AnnouncementEntity?>(null));

        var result = await _useCase.Execute(resultModel.Id);

        _announcementRepository.Verify(v => v.GetAsync(resultModel.Id), Times.Exactly(1));
        Assert.Null(result);
    }
}