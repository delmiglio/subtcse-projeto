using System.Threading.Tasks;

namespace Avanade.SUBTCSE.Projeto.Domain.Base.Repository
{
    // Aonde Entity Herde de BaseEntity
    public interface IBaseRepository<TEntity, TId> where TEntity : BaseEntity<TId>
    {
        Task<TEntity> Add(TEntity entity);

        Task<TEntity> FindById(TId id);
    }
}
