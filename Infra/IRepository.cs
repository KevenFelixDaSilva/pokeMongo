using pokeMongo.Domain;

namespace pokeMongo.Infra
{
    public interface IRepository<T>
    {
        Task Create(T body);
        Task<T> Find(string id);
    }
}
