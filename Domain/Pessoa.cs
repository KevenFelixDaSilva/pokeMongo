using System;

namespace pokeMongo.Domain
{
    public class Pessoa : IClassDomain
    {
        private Guid _Id { get; set; }
        public string Nome { get; set; }

        public Pessoa(string nome) 
        { 
            _Id = Guid.NewGuid();
            Nome = nome;
        }
    }

    public interface IClassDomain { }

}
