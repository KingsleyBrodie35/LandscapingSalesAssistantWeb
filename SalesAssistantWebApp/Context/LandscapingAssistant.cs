using Microsoft.EntityFrameworkCore;
using SalesAssistantWebApp.Models;

namespace SalesAssistantWebApp.Context
{
    public class LandscapingAssistantDB : DbContext
    {
        public DbSet<Paver> Pavers { get; set; }
        public DbSet<RetainingWall> RetainingWalls { get; set; }
        public LandscapingAssistantDB(DbContextOptions<LandscapingAssistantDB> context) : base(context) { }

       
    }

}

