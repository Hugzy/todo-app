using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TodoService.Models;

namespace TodoService.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class ListController : ControllerBase
    {
        private readonly ILogger<ListController> _logger;
        private readonly Services.TodoService _service;
        
        public ListController(ILogger<ListController> logger, Services.TodoService service)
        {
            _logger = logger;
            _service = service;
        }
        
        [HttpGet("{id}")]
        public async Task<ActionResult<TodoList>> Get(Guid id)
        {
            _logger.LogInformation("Get: " + id );
            return Ok(_service.Get(id));
        }

        [HttpPost]
        public async Task<ActionResult<TodoList>> Post([FromBody] TodoList list)
        {
            _logger.LogInformation("Post List: " + list.Name);
            var createResult = _service.Create(list);
            return Ok(createResult);
        }

        [HttpPut]
        public async Task<ActionResult<TodoList>> Put([FromBody] TodoList list)
        {
            _logger.LogInformation("Put List: " + list.Name);
            var updateResult = _service.Update(list);
            return Ok(updateResult);
        }

        [HttpDelete]
        public async Task<ActionResult<TodoList>> Delete([FromBody] TodoList list)
        {
            _logger.LogInformation("Delete List: " + list.Name);
            _service.Delete(list);
            return Ok();
        }
    }
}