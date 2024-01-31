using MongoDB.Driver;
using pokeMongo.Domain;
using pokeMongo.Infra;

namespace pokeMongo.Endpoints
{
    public static class PessoaRequest
    {
        private static MongoDbContext context { get; set; }
        //private HttpRequest body { get; set; }

        //public PessoaRequest(MongoDbContext _context, HttpRequest _body)
        //{
        //    this.context = _context;
        //    this.body = _body;
        //}

        public static Task Find(string name)
        {
            var result = context.GetCollection<Pessoa>("pessoas");
            var x = result.FindAsync<Pessoa>(name);
            return x;
        }
    }
}
