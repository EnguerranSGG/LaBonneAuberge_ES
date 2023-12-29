using LaBonneAuberge.Models;
using Microsoft.EntityFrameworkCore;
namespace LaBonneAuberge.Data
{
 public class LaBonneAubergeContext : DbContext
 {
 public LaBonneAubergeContext(DbContextOptions<LaBonneAubergeContext> options) :
base(options)
 {
 }
  public DbSet<Menu> Menus { get; set; } = default!;
//  public DbSet<Category> Categories { get; set; }
 }
}
