using BlazorApp.Server.Interfaces;
using BlazorApp.Shared.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FazendaController : ControllerBase
    {
        private readonly IFazenda _IFazenda;

        public FazendaController(IFazenda iFazenda)
        {
            _IFazenda = iFazenda;
        }

        [HttpGet]
        public async Task<List<Fazenda>> Get()
        {
            return await Task.FromResult(_IFazenda.ListaFazendas());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Fazenda Fazenda = _IFazenda.RetornaFazendaPorId(id);
            if (Fazenda != null)
            {
                return Ok(Fazenda);
            }
            return NotFound();
        }

        [HttpPost]
        public void Post(Fazenda Fazenda)
        {
            _IFazenda.AdicionaFazenda(Fazenda);
        }

        [HttpPut]
        public void Put(Fazenda Fazenda)
        {
            _IFazenda.AtualizaFazenda(Fazenda);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _IFazenda.DeletaFazenda(id);
            return Ok();
        }
    }
}
