using Moq;
using SalesAd.Application.UseCases.Announcement.GetByOwnerAnnouncementUseCase;
using SalesAd.Domain.Entities;
using SalesAd.UnitTests.Application.Announcement.Fake;

namespace SalesAd.UnitTests.Application.Announcement;

public class GetByOwnerAnnouncementUseCaseTest : BaseApplicationTest
{
    private readonly GetByOwnerAnnouncementUseCase _useCase;

    public GetByOwnerAnnouncementUseCaseTest()
    {
        _useCase = new GetByOwnerAnnouncementUseCase(_announcementRepository.Object);
    }

    [Fact(DisplayName = "Should return all registers when find by owner id")]
    public async Task Execute_Success()
    {
        var resultModel = new List<AnnouncementEntity>
        {
            AnnouncementFake.Build!,
            AnnouncementFake.Build!,
        };
        var ownerId = Guid.NewGuid();
        _announcementRepository.Setup(x => x.GetByOwnerAsync(ownerId)).Returns(Task.FromResult(resultModel.AsEnumerable()));

        var result = await _useCase.Execute(ownerId);

        _announcementRepository.Verify(v => v.GetByOwnerAsync(ownerId), Times.Exactly(1));
        Assert.NotNull(result);
        Assert.Equal(result.Count, 2);
    }

    [Fact(DisplayName = "Should return null when find")]
    public async Task Execute_Not_Found()
    {
        var ownerId = Guid.NewGuid();
        _announcementRepository.Setup(x => x.GetByOwnerAsync(ownerId)).Returns(Task.FromResult<IEnumerable<AnnouncementEntity>?>(null));

        var result = await _useCase.Execute(ownerId);

        _announcementRepository.Verify(v => v.GetByOwnerAsync(ownerId), Times.Exactly(1));
        Assert.Null(result);
    }
}