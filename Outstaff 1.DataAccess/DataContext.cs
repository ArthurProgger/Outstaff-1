using Microsoft.EntityFrameworkCore;
using Outstaff_1.DataAccess.Models;

namespace Outstaff_1.DataAccess;

public sealed class DataContext(DbContextOptions<DataContext> options) : DbContext(options)
{
    public DbSet<Model1Model> Model1Collection { get; set; }
}