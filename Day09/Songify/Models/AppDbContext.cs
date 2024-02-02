#pragma warning disable CS8618

using Microsoft.EntityFrameworkCore;

namespace Songify.Models;


public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options){}

    // Our Database Tables 
    public DbSet<User> Users { get; set; }
    public DbSet<Album> Albums { get; set; }
}