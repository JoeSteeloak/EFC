using Microsoft.EntityFrameworkCore;
using EFC.Models;

namespace EFC.Data;

public class BookDbContext : DbContext {
    public BookDbContext(DbContextOptions<BookDbContext> options) : base(options) { }

    public DbSet<BookModel> Books { get; set; }

    public DbSet<UserModel> Users { get; set; }

}