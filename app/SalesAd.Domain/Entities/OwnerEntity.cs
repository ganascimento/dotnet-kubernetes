using SalesAd.Domain.Entities.Base;
using SalesAd.Domain.Interfaces;
using SalesAd.Domain.VO;

namespace SalesAd.Domain.Entities
{
    public class OwnerEntity : BaseEntity, IAggregateRoot
    {
        private OwnerEntity(Guid id) : base(id, null, null)
        {

        }

        public OwnerEntity(
            Guid id,
            string name,
            DateTime birthDate,
            string phone,
            string email,
            bool active = true,
            DateTime? createdAt = null,
            DateTime? updatedAt = null) : base(id, createdAt, updatedAt)
        {
            this.Name = name;
            this.BirthDate = birthDate;
            this.Phone = phone;
            this.Email = email;
            this.Active = active;
            ValidateEntity();
        }

        public string Name { get; private set; }
        public DateTime BirthDate { get; private set; }
        public Phone Phone { get; private set; }
        public Email Email { get; private set; }
        public bool Active { get; private set; }
        public virtual List<AnnouncementEntity>? Announcements { get; private set; }

        public void SetActive() => this.Active = true;

        public void Update(string name, DateTime birthDate, string phone)
        {
            this.Name = name;
            this.BirthDate = birthDate;
            this.Phone = phone;
            ValidateEntity();
        }

        private void ValidateEntity()
        {
            AssertionConcern.AssertArgumentNotEmpty(Name, "Name is required!");
            AssertionConcern.AssertArgumentLength(Name, 150, "Max char is 150!");
            AssertionConcern.AssertArgumentNotNull(BirthDate, "BirthDate is required!");
        }
    }
}