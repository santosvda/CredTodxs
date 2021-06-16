using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CredTodxs.Domain;
using CredTodxs.Repository.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CredTodxs.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OfertaController : ControllerBase
    {
        private readonly IOfertaRepository _OfertaRepository;

        public OfertaController(IOfertaRepository OfertaRepository)
        {
            _OfertaRepository = OfertaRepository;

        }
        [HttpGet]
        public ActionResult<IEnumerable<string>> Post(Oferta model)
        {
            try
            {
                var user = _OfertaRepository.PostOferta(model);
                return Ok(model);
            }
            catch (System.Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco Dados Falhou");
            }
        }
    }
}