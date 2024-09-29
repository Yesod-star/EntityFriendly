using EntityFriendlyBack.Data.ValueObjects;
using EntityFriendlyBack.Repository;
using Microsoft.AspNetCore.Mvc;

namespace EntityFriendlyBack.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ToDoListController : ControllerBase
    {
        private IToDoListRepository _repository;

        public ToDoListController(IToDoListRepository repository)
        {
            _repository = repository ?? throw new
                ArgumentNullException(nameof(repository));
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ToDoListVO>>> FindAll()
        {
            var products = await _repository.FindAll();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ToDoListVO>> FindById(long id)
        {
            var product = await _repository.FindById(id);
            if (product == null) return NotFound();
            return Ok(product);
        }

        [HttpPost]
        public async Task<ActionResult<ToDoListVO>> Create([FromBody] ToDoListVO vo)
        {
            if (vo == null) return BadRequest();
            var product = await _repository.Create(vo);
            return Ok(product);
        }

        [HttpPut]
        public async Task<ActionResult<ToDoListVO>> Update([FromBody] ToDoListVO vo)
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
