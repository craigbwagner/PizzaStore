namespace PizzaStore.Db;
using Microsoft.EntityFrameworkCore;

public record Pizza
{
  public int Id {get; set;}
  public string ? Name { get; set; }
  public string? Description { get; set; }
}

public class PizzaDb : DbContext
{
  public PizzaDB(DbContextOptions options) : base(options) { }
  public DbSet<Pizza> Pizzas { get; set; } = null!;
}
