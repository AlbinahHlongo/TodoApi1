using Microsoft.EntityFrameworkCore.InMemory;
using Microsoft.EntityFrameworkCore;
//using System.Data;
//using System.Data.SqlTypes;
//using Microsoft.EntityFrameworkCore.Infrastructure;

namespace TodoApi.Models
{
    public class TodoContext : DbContext

    {
        public TodoContext(DbContextOptions<TodoContext> options): base(options)
        {
        }

        public DbSet<TodoItem> TodoItems { get; set; } = null!;
    }
}
