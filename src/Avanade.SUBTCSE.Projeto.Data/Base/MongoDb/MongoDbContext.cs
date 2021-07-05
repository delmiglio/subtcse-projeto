using Avanade.SUBTCSE.Projeto.Domain.Base.Repository.MongoDb;
using MongoDB.Driver;

namespace Avanade.SUBTCSE.Projeto.Data.Base.MongoDb
{
    public class MongoDbContext : IMongoDbContext
    {
        public IMongoCollection<TEntity> GetCollection<TEntity>(string collection)
        {
            throw new System.NotImplementedException();
        }
    }
}
