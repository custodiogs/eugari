using System;
using System.Collections.Generic;
using EuGari.Domain;
using EuGari.Domain.Contracts.Reporitories;
using EuGari.Infra.DataContext;

namespace EuGari.Infra.Repositories
{
    public class PessoaRepository : Repository<Pessoa>, IPessoaRepository
    {
        public PessoaRepository(MyDataContext context)
            : base(context)
        {
        }
        public new Pessoa Get(int id)
        {
            return _ctx.Set<Pessoa>().Find(id);
        }

        public IEnumerable<Pessoa> ListarPessoas()
        {
            return _ctx.Pessoa;
        }
    }
}
