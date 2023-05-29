using Microsoft.EntityFrameworkCore;

namespace ProjectTennis.Models;
public class TodoContext : DbContext
{
    public TodoContext(DbContextOptions<TodoContext> options)
        : base(options) 
    {
    }
    public DbSet<tennis> TodoItems { get; set; } = null!;
}