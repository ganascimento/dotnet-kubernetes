namespace SalesAd.Application.UseCases.Announcement.UpdateAnnouncementUseCase
{
    public class UpdateAnnouncementModel
    {
        public required Guid Id { get; set; }
        public string? Description { get; set; }
        public short? RoomsNumber { get; set; }
        public required decimal Value { get; set; }
        public required int Size { get; set; }
        public required short Type { get; set; }
        public required string StreetName { get; set; }
        public required string ZipCode { get; set; }
        public required string Neighborhood { get; set; }
        public required int? Number { get; set; }
        public required string State { get; set; }
        public required string Country { get; set; }
    }
}