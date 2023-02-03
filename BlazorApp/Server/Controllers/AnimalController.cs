using BlazorApp.Server.Interfaces;
using BlazorApp.Shared.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalController : ControllerBase
    {
        private readonly IAnimal _Ianimal;

        public AnimalController(IAnimal ianimal)
        {
            _Ianimal = ianimal;
        }

        [HttpGet]
        public async Task<List<Animal>> Get()
        {
            return await Task.FromResult(_Ianimal.ListaAnimais());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Animal animal = _Ianimal.RetornaAnimalPorId(id);
            if (animal != null)
            {
                return Ok(animal);
            }
            return NotFound();
        }

        [HttpPost]
        public void Post(Animal animal)
        {
            _Ianimal.AdicionaAnimal(animal);
        }

        [HttpPut]
        public void Put(Animal animal)
        {
            _Ianimal.AtualizaAnimal(animal);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _Ianimal.DeletaAnimal(id);
            return Ok();
        }
    }
}
