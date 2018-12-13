using EuGari.Domain;
using EuGari.Domain.Contracts.Reporitories;
using EuGari.Infra.DataContext;
using EuGari.Infra.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EuGari.Api.Controllers
{
    [Authorize]
    public class PessoaController : ApiController
    {
        PessoaRepository _repository = new PessoaRepository(new MyDataContext());  
        public PessoaController()
        {

        }

        // GET api/listarpessoas
        [HttpGet]        
        [AllowAnonymous]
        public IHttpActionResult ListarPessoas()
        {
            var pessoas = _repository.ListarPessoas();
            if (pessoas.Count()==0) return NotFound();

            return Ok(_repository.ListarPessoas().ToList());
        }
    }
}
