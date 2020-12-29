using Microsoft.EntityFrameworkCore;
using TodoService.Models.ItemParts;
using TodoService.Models.ListParts;

namespace TodoService.Models.Context
{
    public class TodoDbContext : DbContext
    {
        public DbSet<TodoList> TodoLists { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<ItemPart> ItemParts { get; set; }
        public DbSet<ListPart> ListParts { get; set; }

        protected TodoDbContext()
        {
        }

        public TodoDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // ItemParts
            modelBuilder.Entity<SelectPart>();
            modelBuilder.Entity<TextPart>();
            
            // ListParts
            modelBuilder.Entity<BoundListPart>();
            
            base.OnModelCreating(modelBuilder);
        }
    }
}