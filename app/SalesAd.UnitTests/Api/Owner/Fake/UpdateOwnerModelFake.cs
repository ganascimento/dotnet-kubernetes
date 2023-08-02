using Bogus;
using SalesAd.Application.UseCases.Owner.UpdateOwnerUseCase;

namespace SalesAd.UnitTests.Api.Owner.Fake;

public static class UpdateOwnerModelFake
{
    public static UpdateOwnerModel Build = new Faker<UpdateOwnerModel>()
        .RuleFor(u => u.Id, Guid.NewGuid())
        .RuleFor(u => u.Name, f => f.Name.FullName())
        .RuleFor(u => u.Phone, f => f.Phone.PhoneNumber("## #####-####"))
        .RuleFor(u => u.BirthDate, f => f.Date.Between(new DateTime(1950, 01, 01), new DateTime(2020, 01, 01)))
        .Generate();
}