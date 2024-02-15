using Microsoft.EntityFrameworkCore;
using TodoList.Models;

namespace TodoList.API
{
public class TodoDbContext : DbContext
 {
    public TodoDbContext(DbContextOptions<TodoDbContext> options) : base(options) { }
    public DbSet<ToDoItem> ToDoItems { get; set; }
 }
 public class ToDoItem
{
    public int Id { get; set; }
    public string? TaskName { get; set; } // This is the TaskName property
    public bool IsComplete { get; set; }
    public DateTime? CompletedDate { get; set; }
}

}