using Microsoft.EntityFrameworkCore;
using Todo.Models;

namespace Todo.Data
{
    public class ApiDbContext :DbContext
    {
        public virtual DbSet<ItemData> Items { get; set; }
        public ApiDbContext(DbContextOptions<ApiDbContext> options )
            :base(options)
        {
            
        }
    }
} 