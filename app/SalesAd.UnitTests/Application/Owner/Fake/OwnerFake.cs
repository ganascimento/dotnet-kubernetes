using SalesAd.Domain.Entities;
using Bogus;

namespace SalesAd.UnitTests.Infra.Fake;

public static class OwnerFake
{
    public static OwnerEntity? Build = new Faker<OwnerEntity>()
        .RuleFor(u => u.Id, Guid.NewGuid())
        .RuleFor(u => u.Name, f => f.Name.FullName())
        .RuleFor(u => u.BirthDate, f => f.Date.Between(new DateTime(1950, 01, 01), new DateTime(2020, 01, 01)))
        .RuleFor(u => u.Phone, f => f.Phone.PhoneNumber("## #####-####"))
        .RuleFor(u => u.Email, f => f.Internet.Email(f.Person.FirstName))
        .RuleFor(u => u.Active, true)
        .RuleFor(u => u.CreatedAt, DateTime.Now)
        .RuleFor(u => u.UpdatedAt, DateTime.Now)
        .Generate();
}