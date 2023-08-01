using Moq;
using SalesAd.Application.UseCases.Announcement.CreateAnnouncementUseCase;
using SalesAd.Domain.Entities;
using SalesAd.UnitTests.Application.Announcement.Fake;

namespace SalesAd.UnitTests.Application.Announcement;

public class CreateAnnouncementUseCaseTest : BaseApplicationTest
{
    private readonly CreateAnnouncementUseCase _useCase;

    public CreateAnnouncementUseCaseTest()
    {
        _useCase = new CreateAnnouncementUseCase(_announcementRepository.Object);
    }

    [Fact]
    public async Task Execute_Success()
    {
        var resultModel = AnnouncementFake.Build;
        var createModel = new CreateAnnouncementModel
        {
            Description = resultModel.Description,
            RoomsNumber = resultModel.RoomsNumber,
            Value = resultModel.Value,
            Size = resultModel.Size,
            Type = (short)resultModel.Type,
            StreetName = resultModel.Address.StreetName,
            ZipCode = resultModel.Address.ZipCode,
            Neighborhood = resultModel.Address.Neighborhood,
            Number = resultModel.Address.Number,
            State = resultModel.Address.State,
            Country = resultModel.Address.Country,
            OwnerId = resultModel.OwnerId,
        };

        await _useCase.Execute(createModel);

        _announcementRepository.Verify(v => v.InsertAsync(It.IsAny<AnnouncementEntity>()), Times.Exactly(1));
    }
}