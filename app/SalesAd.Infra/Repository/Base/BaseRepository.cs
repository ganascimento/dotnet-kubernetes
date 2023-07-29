using Microsoft.EntityFrameworkCore;
using SalesAd.Domain.Entities.Base;
using SalesAd.Domain.Interfaces.Repository.Base;
using SalesAd.Infra.Context;

namespace SalesAd.Infra.Repository.Base
{
    public class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly DataContext _dataContext;
        private readonly DbSet<TEntity> _dbSet;

        public BaseRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
            _dbSet = dataContext.Set<TEntity>();
        }

        public async Task<TEntity?> GetAsync(Guid id) =>
            await _dbSet.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);

        public async Task<IEnumerable<TEntity>> GetAllAsync() =>
            await _dbSet.AsNoTracking().ToListAsync();

        public async Task<IEnumerable<TEntity>> GetAllAsync(Guid id, int skip, int take = 10) =>
            await _dbSet.AsNoTracking().Skip(skip * take).Take(take).ToListAsync();

        public async Task<TEntity> InsertAsync(TEntity entity)
        {
            _dbSet.Add(entity);
            await _dataContext.SaveChangesAsync();
            return entity;
        }

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            entity.SetUpdateAtNow();
            _dataContext.Update(entity).State = EntityState.Modified;
            await _dataContext.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(TEntity entity)
        {
            _dataContext.Update(entity).State = EntityState.Deleted;
            await _dataContext.SaveChangesAsync();
        }
    }
}