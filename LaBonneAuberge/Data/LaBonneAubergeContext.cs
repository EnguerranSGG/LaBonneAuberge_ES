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
  public DbSet<Menu> Menus { get; set; }
  public DbSet<Category> Categories { get; set; }

  public DbSet<FeedBackModel> FeedBacks { get; set; }
  public DbSet<TeamList> TeamLists { get; set; }
 }
}
