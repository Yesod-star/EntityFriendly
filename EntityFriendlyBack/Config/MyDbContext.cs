using EntityFriendlyBack.Model;
using Microsoft.EntityFrameworkCore;
using System.Xml;

public class MyDbContext : DbContext
{
    public MyDbContext()
    {
    }

    public DbSet<ToDoList> ToDoList { get; set; }
}
