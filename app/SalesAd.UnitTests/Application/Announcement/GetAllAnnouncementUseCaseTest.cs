using Moq;
using SalesAd.Application.UseCases.Announcement.GetAllAnnouncementUseCase;
using SalesAd.Domain.Entities;
using SalesAd.UnitTests.Application.Announcement.Fake;

namespace SalesAd.UnitTests.Application.Announcement;

public class GetAllAnnouncementUseCaseTest : BaseApplicationTest
{
    private readonly GetAllAnnouncementUseCase _useCase;

    public GetAllAnnouncementUseCaseTest()
    {
        _useCase = new GetAllAnnouncementUseCase(_announcementRepository.Object);
    }

    [Fact]
    public async Task Execute_Success()
    {
        var resultModel = new List<AnnouncementEntity>
        {
            AnnouncementFake.Build!,
            AnnouncementFake.Build!,
        };
        _announcementRepository.Setup(x => x.GetAllAsync()).Returns(Task.FromResult(resultModel.AsEnumerable()));

        var result = await _useCase.Execute();

        _announcementRepository.Verify(v => v.GetAllAsync(), Times.Exactly(1));
        Assert.Equal(result.Count, 2);
    }
}