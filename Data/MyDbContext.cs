using BlazorServerAppBasicCrudSample.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerAppBasicCrudSample.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options)
            : base(options)
        { }
        
        public DbSet<Customer> Customer { get; set; }
    }
}