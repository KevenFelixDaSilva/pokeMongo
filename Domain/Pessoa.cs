using System;

namespace pokeMongo.Domain
{
    public class Pessoa
    {
        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public string Endereco { get; private set; }

        public Pessoa(Guid _Id, string _Nome, string _Endereco)
        {
            Id = _Id;
            Nome = _Nome;
            Endereco = _Endereco;
        }
    }
}
