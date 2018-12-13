using System.Collections.Generic;

namespace EuGari.Domain.Contracts.Reporitories
{
    public interface IPessoaRepository
    {
        Pessoa Get(int id);
        IEnumerable<Pessoa> ListarPessoas();
        //void Create(Pessoa pessoa);
        //void Update(Pessoa pessoa);
        //void Delete(Pessoa pessoa);

    }
}
