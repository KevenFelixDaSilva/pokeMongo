using MongoDB.Driver;
using pokeMongo.Domain;

namespace pokeMongo.Infra
{
    public class PessoaRepository : Repository<Pessoa>, IRepository<Pessoa>
    {
        public PessoaRepository(MongoDbSettings _database) : base(_database,"pessoas")
        {
        }
    }
}
