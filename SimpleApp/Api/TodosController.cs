using Microsoft.AspNetCore.Mvc;
using SimpleApp.Core.Interfaces;
using SimpleApp.Core.Models;

namespace SimpleApp.Api
{
    [Route("api/todos")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        private readonly IRepository<TodoItem> _repository;

        public TodosController(IRepository<TodoItem> repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult All()
        {
            var result = _repository.List();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            if (id <= 0)
            {
                return BadRequest();
            }
            else
            {
                var result = _repository.GetById(id);
                if (null == result)
                {
                    return NotFound();
                }
                return Ok(result);
            }
        }

        [HttpPost]
        public IActionResult Add(TodoItem model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else
            {
                _repository.Insert(model);
            }
            return Ok();
        }

        [HttpPut]
        public IActionResult Edit(TodoItem model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else
            {
                _repository.Update(model);
            }
            return Ok();
        }

        [HttpDelete]
        public IActionResult Remove(TodoItem model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else
            {
                _repository.Delete(model);
            }
            return Ok();
        }
    }
}