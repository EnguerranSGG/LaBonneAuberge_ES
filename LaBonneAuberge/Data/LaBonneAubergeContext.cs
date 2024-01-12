using LaBonneAuberge.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace LaBonneAuberge.Data;

public class LaBonneAubergeContext : IdentityDbContext<IdentityUser>
{
    public LaBonneAubergeContext(DbContextOptions<LaBonneAubergeContext> options) :
   base(options)
    {
    }

    public DbSet<Menu> Menus { get; set; }
    public DbSet<Category> Categories { get; set; }

    public DbSet<FeedBackModel> FeedBacks { get; set; }
    public DbSet<TeamList> TeamLists { get; set; }
    public DbSet<Reservation> Reservations { get; set; }

    public DbSet<Contact> Contact { get; set; }  

    //public DbSet<AspNetUsers> AspNetUsers { get; set; } 
}

