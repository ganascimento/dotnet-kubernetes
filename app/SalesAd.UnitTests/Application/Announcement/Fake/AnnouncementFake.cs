using Bogus;
using SalesAd.Domain.Entities;
using SalesAd.Domain.Enums;

namespace SalesAd.UnitTests.Application.Announcement.Fake;

public class AnnouncementFake
{
    public static AnnouncementEntity? Build = new Faker<AnnouncementEntity>()
        .RuleFor(u => u.Id, Guid.NewGuid())
        .RuleFor(u => u.Description, f => f.Name.JobTitle())
        .RuleFor(u => u.OwnerId, Guid.NewGuid())
        .RuleFor(u => u.Value, new Random().Next(10000, 1000000))
        .RuleFor(u => u.Type, AnnouncementTypeEnum.House)
        .RuleFor(u => u.Size, new Random().Next(100, 1000))
        .RuleFor(u => u.RoomsNumber, (short)new Random().Next(1, 20))
        .RuleFor(u => u.Address, f => new Domain.VO.Address(f.Address.StreetName(), f.Address.ZipCode(), f.Address.StreetName(), f.Address.StateAbbr(), f.Address.Country(), 0));
}