using MongoDB.Driver;

namespace Avanade.SUBTCSE.Projeto.Domain.Base.Repository.MongoDb
{
    public interface IMongoDbContext
    {
        IMongoCollection<TEntity> GetCollection<TEntity>(string collection);
    }
}
