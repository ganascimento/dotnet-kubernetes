using Bogus;
using SalesAd.Application.UseCases.Owner.CreateOwnerUseCase;

namespace SalesAd.UnitTests.Api.Owner.Fake;

public static class CreateOwnerModelFake
{
    public static CreateOwnerModel Build = new Faker<CreateOwnerModel>()
        .RuleFor(u => u.Name, f => f.Name.FullName())
        .RuleFor(u => u.Phone, f => f.Phone.PhoneNumber("## #####-####"))
        .RuleFor(u => u.Email, f => f.Internet.Email(f.Person.FirstName))
        .RuleFor(u => u.BirthDate, f => f.Date.Between(new DateTime(1950, 01, 01), new DateTime(2020, 01, 01)))
        .Generate();
}