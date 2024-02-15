namespace TodoList.Models;

public class ToDoItem
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public DateTime? CompletedDate { get; set; }
    public string? TaskName { get; set; }
}
