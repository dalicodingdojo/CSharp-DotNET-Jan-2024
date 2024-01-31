#pragma warning disable CS8618
using Microsoft.EntityFrameworkCore;

namespace EFCoreLecture.Models;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options){}

    // Database tables must be added (Declared) Here : 
    public DbSet<Album> Albums {get;set;}
    // public DbSet<User> Users {get; set;}
}