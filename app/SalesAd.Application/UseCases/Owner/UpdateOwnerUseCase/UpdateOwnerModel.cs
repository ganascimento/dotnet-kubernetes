namespace SalesAd.Application.UseCases.Owner.UpdateOwnerUseCase
{
    public sealed class UpdateOwnerModel
    {
        public required Guid Id { get; set; }
        public required string Name { get; set; }
        public required DateTime BirthDate { get; set; }
        public required string Phone { get; set; }
    }
}