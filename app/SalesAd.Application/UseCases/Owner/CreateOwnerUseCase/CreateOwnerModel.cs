namespace SalesAd.Application.UseCases.Owner.CreateOwnerUseCase
{
    public sealed class CreateOwnerModel
    {
        public required string Name { get; set; }
        public required DateTime BirthDate { get; set; }
        public required string Phone { get; set; }
        public required string Email { get; set; }
    }
}