namespace SalesAd.Domain.Entities.Base
{
    public abstract class BaseEntity
    {
        public BaseEntity(Guid id, DateTime? createdAt, DateTime? updatedAt)
        {
            this.Id = id;
            this.CreatedAt = createdAt == null ? DateTime.UtcNow : (DateTime)createdAt;
            this.UpdatedAt = updatedAt == null ? DateTime.UtcNow : (DateTime)updatedAt;
        }

        public Guid Id { get; private set; }
        public DateTime? CreatedAt { get; private set; }
        public DateTime? UpdatedAt { get; private set; }

        public void SetUpdateAtNow() => this.UpdatedAt = DateTime.UtcNow;

        private void ValidateEntity()
        {
            AssertionConcern.AssertArgumentNotNull(Id, "Id is required!");
        }
    }
}