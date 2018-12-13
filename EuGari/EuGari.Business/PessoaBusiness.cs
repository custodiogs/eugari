using EuGari.Domain;
using EuGari.Domain.Contracts.Reporitories;
using System.Collections.Generic;

namespace EuGari.Business
{
    public class PessoaBusiness
    {
        private IPessoaRepository _pessoaRepository;
        public PessoaBusiness(IPessoaRepository pessoaRepository)
        {
            _pessoaRepository = pessoaRepository;
        }

        public IEnumerable<Pessoa> ListarPessoas()
        {
            return _pessoaRepository.ListarPessoas();
        }

    }
}
