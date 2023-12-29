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
  public DbSet<TeamList> TeamLists { get; set; }
//  public DbSet<Category> Categories { get; set; }
 }
}