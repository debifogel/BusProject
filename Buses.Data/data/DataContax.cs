
using Buses.Core.classes;
using Buses.Data.data;
using Microsoft.EntityFrameworkCore;

public class DataContext: DbContext,IData
{
    public DbSet<Bus> buses  { get; set; }

    public DbSet<Street> streets { get; set; }

    public DbSet<Station> stations { get; set; }
//    public DataContext(DbContextOptions<DataContext> options)
//: base(options) { }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Bus327860508_db");
    }

}