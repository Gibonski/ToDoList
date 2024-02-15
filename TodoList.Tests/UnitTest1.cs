using TodoList.Models;


namespace TodoList.Tests;

public class ToDoItemTests
{
    [Fact]
    public void FirstTask()
    {
        var x = new ToDoItem { TaskName = "Backend Assignment" };
        x.TaskName = "Clean Bedroom";
        Assert.Equal("Clean Bedroom", x.TaskName);
    }
    [Fact]
    public void SecondTask()
    {
        var x = new ToDoItem { TaskName = "Watch Coding Video" };
        x.TaskName = "Call My Mum";
        Assert.Equal("Call My Mum", x.TaskName);
    }
    [Fact]
    public void ThirdTask()
    {
        var x = new ToDoItem { TaskName = "Complete Mql5 Code" };
        x.TaskName = "Fund Forex Account";
        Assert.Equal("Fund Forex Account", x.TaskName);
    }
    [Fact]
    public void FourthTask()
    {
        var x = new ToDoItem { TaskName = "Go To Gym" };
        x.TaskName = "Grocery Shopping";
        Assert.Equal("rocery Shopping", x.TaskName);
    }
    

    
}