using ListaAfazeres.Data.ValueObjects;
using ListaAfazeres.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ListaAfazeres.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class PessoaController : ControllerBase
    {
        private IPessoaRepository _repository;

        public PessoaController(IPessoaRepository repository)
        {
            _repository = repository ?? throw new
                ArgumentNullException(nameof(repository));
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PessoaVO>>> FindAll()
        {
            var products = await _repository.FindAll();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PessoaVO>> FindById(long id)
        {
            var product = await _repository.FindById(id);
            if (product == null) return NotFound();
            return Ok(product);
        }

        [HttpPost]
        public async Task<ActionResult<PessoaVO>> Create([FromBody] PessoaVO vo)
        {
            if (vo == null) return BadRequest();
            var product = await _repository.Create(vo);
            return Ok(product);
        }

        [HttpPut]
        public async Task<ActionResult<PessoaVO>> Update([FromBody] PessoaVO vo)
        {
            if (vo == null) return BadRequest();
            var product = await _repository.Update(vo);
            return Ok(product);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(long id)
        {
            var status = await _repository.Delete(id);
            if (!status) return BadRequest();
            return Ok(status);
        }
    }
}
