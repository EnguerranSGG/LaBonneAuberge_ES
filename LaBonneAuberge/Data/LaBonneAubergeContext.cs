using LaBonneAuberge.Models;
using Microsoft.EntityFrameworkCore;

namespace LaBonneAuberge.Data
{
public class LaBonneAubergeContext : DbContext
{
public DbSet<FeedBackModel> FeedBacks { get; set; }
public LaBonneAubergeContext(DbContextOptions<LaBonneAubergeContext> options) :
base(options)
{
}
}
}