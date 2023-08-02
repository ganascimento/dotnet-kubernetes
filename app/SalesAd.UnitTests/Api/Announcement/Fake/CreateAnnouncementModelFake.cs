using Bogus;
using SalesAd.Application.UseCases.Announcement.CreateAnnouncementUseCase;
using SalesAd.Domain.Enums;

namespace SalesAd.UnitTests.Api.Announcement.Fake;

public static class CreateAnnouncementModelFake
{
    public static CreateAnnouncementModel Build = new Faker<CreateAnnouncementModel>()
        .RuleFor(u => u.Description, f => f.Name.JobTitle())
        .RuleFor(u => u.RoomsNumber, (short)new Random().Next(1, 20))
        .RuleFor(u => u.Value, new Random().Next(10000, 1000000))
        .RuleFor(u => u.Size, new Random().Next(100, 1000))
        .RuleFor(u => u.Type, (short)AnnouncementTypeEnum.House)
        .RuleFor(u => u.StreetName, f => f.Address.StreetName())
        .RuleFor(u => u.ZipCode, f => f.Address.ZipCode())
        .RuleFor(u => u.Neighborhood, f => f.Address.StreetName())
        .RuleFor(u => u.Number, 0)
        .RuleFor(u => u.State, f => f.Address.StateAbbr())
        .RuleFor(u => u.Country, f => f.Address.Country())
        .RuleFor(u => u.OwnerId, Guid.NewGuid())
        .Generate();
}