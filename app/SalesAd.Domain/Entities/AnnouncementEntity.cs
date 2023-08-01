using SalesAd.Domain.Entities.Base;
using SalesAd.Domain.VO;
using SalesAd.Domain.Enums;
using SalesAd.Domain.Interfaces;

namespace SalesAd.Domain.Entities
{
    public class AnnouncementEntity : BaseEntity, IAggregateRoot
    {
        // Test Constructor
        public AnnouncementEntity() : base(Guid.NewGuid(), null, null) { }

        private AnnouncementEntity(Guid id) : base(id, null, null) { }

        public AnnouncementEntity(
            Guid id,
            decimal value,
            int size,
            AnnouncementTypeEnum type,
            Guid ownerId,
            Address? address = null,
            string? description = null,
            short? roomsNumber = null,
            DateTime? createdAt = null,
            DateTime? updatedAt = null) : base(id, createdAt, updatedAt)
        {
            this.Value = value;
            this.Size = size;
            this.Type = type;
            this.Address = address;
            this.OwnerId = ownerId;
            this.Description = description;
            this.RoomsNumber = roomsNumber;
            ValidateEntity();
        }

        public string? Description { get; private set; }
        public short? RoomsNumber { get; private set; }
        public decimal Value { get; private set; }
        public int Size { get; private set; }
        public Address? Address { get; private set; }
        public AnnouncementTypeEnum Type { get; private set; }
        public Guid OwnerId { get; private set; }
        public virtual OwnerEntity Owner { get; set; }

        public void Update(
            decimal value,
            int size,
            AnnouncementTypeEnum type,
            Address address,
            string? description = null,
            short? roomsNumber = null)
        {
            this.Value = value;
            this.Size = size;
            this.Type = type;
            this.Address = address;
            this.Description = description;
            this.RoomsNumber = roomsNumber;
            ValidateEntity();
        }

        private void ValidateEntity()
        {
            AssertionConcern.AssertArgumentNotNull(Value, "Value is required!");
            AssertionConcern.AssertArgumentMinValue(Value, 1, "Minimun value is 1!");
            AssertionConcern.AssertArgumentNotNull(Size, "Size is required!");
            AssertionConcern.AssertArgumentNotNull(Type, "Type is required!");
            AssertionConcern.AssertArgumentRange((int)Type, 0, 2, "Type value is allow between 0 and 2!");
            AssertionConcern.AssertArgumentLength(Description, 500, "Max char is 500!");
        }
    }
}