using MongoDB.Driver;
using pokeMongo.Domain;

namespace pokeMongo.Infra
{
    public class Repository<T> : IRepository<T> where T : IClassDomain
    {

        public readonly IMongoCollection<T> context;

        public Repository(MongoDbSettings _database, string collection)
        {
            var client = new MongoClient(_database.ConnectionString);
            var dataBase = client.GetDatabase(_database.DatabaseName);
            context = dataBase.GetCollection<T>(collection);
        }

        public Task Create(T body)
        {
            context.InsertOne(body);
            return Task.CompletedTask;
        }

        public async Task<T> Find(string id)
        {
            return (T)await context.FindAsync(id);
        }
    }
}
