using Avanade.SUBTCSE.Projeto.Domain;
using Avanade.SUBTCSE.Projeto.Domain.Base.Repository;
using MongoDB.Driver;
using System.Threading.Tasks;

namespace Avanade.SUBTCSE.Projeto.Data.Base
{
    public abstract class BaseRepository<TEntity, TId> : IBaseRepository<TEntity, TId> where TEntity : BaseEntity<TId>
    {
        private readonly IMongoCollection<TEntity> _collection;
        public virtual async Task<TEntity> Add(TEntity entity)
        {
            await _collection.InsertOneAsync(entity);

            return entity;
        }

        public virtual Task<TEntity> FindById(TId id)
        {
            throw new System.NotImplementedException();
        }
    }
}
