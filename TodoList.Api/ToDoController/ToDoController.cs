using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TodoList.API;

namespace TodoList.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ToDoItemsController : ControllerBase
    {
        private readonly TodoDbContext _context;

        public ToDoItemsController(TodoDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ToDoItem>>> GetIncompleteToDoItems()
        {
            return await _context.ToDoItems.Where(t => t.CompletedDate == null).ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ToDoItem>> GetToDoItem(int id)
        {
            var toDoItem = await _context.ToDoItems.FindAsync(id);
            if (toDoItem == null)
            {
                return NotFound();
            }
            return toDoItem;
        }

        [HttpPost]
        public async Task<ActionResult<ToDoItem>> CreateToDoItem(ToDoItem toDoItem)
        {
            _context.ToDoItems.Add(toDoItem);
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetToDoItem", new { id = toDoItem.Id }, toDoItem);
        }

        [HttpPost("{id}/complete")]
        public async Task<IActionResult> CompleteToDoItem(int id)
        {
            var toDoItem = await _context.ToDoItems.FindAsync(id);
            if (toDoItem == null)
            {
                return NotFound();
            }
            toDoItem.CompletedDate = DateTime.Now;
            _context.Entry(toDoItem).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}