using Moq;
using SalesAd.Application.UseCases.Announcement.UpdateAnnouncementUseCase;
using SalesAd.Domain.Entities;
using SalesAd.UnitTests.Application.Announcement.Fake;

namespace SalesAd.UnitTests.Application.Announcement;

public class UpdateAnnouncementUseCaseTest : BaseApplicationTest
{
    private readonly UpdateAnnouncementUseCase _useCase;

    public UpdateAnnouncementUseCaseTest()
    {
        _useCase = new UpdateAnnouncementUseCase(_announcementRepository.Object);
    }

    [Fact]
    public async Task Execute_Success()
    {
        var resultModel = AnnouncementFake.Build;
        var updateModel = new UpdateAnnouncementModel
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
            Id = resultModel.Id
        };
        _announcementRepository.Setup(x => x.GetAsync(resultModel!.Id)).Returns(Task.FromResult(resultModel));

        await _useCase.Execute(updateModel);

        _announcementRepository.Verify(v => v.UpdateAsync(resultModel!), Times.Exactly(1));
    }

    [Fact]
    public async Task Execute_Not_Found()
    {
        var resultModel = AnnouncementFake.Build!;
        var updateModel = new UpdateAnnouncementModel
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
            Id = resultModel.Id
        };
        _announcementRepository.Setup(x => x.GetAsync(resultModel.Id)).Returns(Task.FromResult<AnnouncementEntity?>(null));

        await _useCase.Execute(updateModel);

        _announcementRepository.Verify(v => v.GetAsync(resultModel.Id), Times.Exactly(1));
        _announcementRepository.Verify(v => v.UpdateAsync(resultModel), Times.Exactly(0));
    }
}