using System;
using Microsoft.EntityFrameworkCore;

namespace ProductAPI.Models
{
    public class TodoContextcs : DbContext
    {
        public TodoContextcs(DbContextOptions<TodoContextcs> options) : base(options)
        {

        }

        public DbSet<TodoItem> todoItems { get; set; }
    }
}
