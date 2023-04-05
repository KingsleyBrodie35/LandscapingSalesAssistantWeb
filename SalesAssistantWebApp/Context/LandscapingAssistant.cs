using Microsoft.EntityFrameworkCore;
using SalesAssistantWebApp.Models;

namespace SalesAssistantWebApp.Context
{
    public class LandscapingAssistantDB : DbContext
    {
        public DbSet<Paver> Pavers { get; set; }
        public DbSet<RetainingWall> RetainingWalls { get; set; }
        public LandscapingAssistantDB(DbContextOptions<LandscapingAssistantDB> context) : base(context) { }

        public void createData()
        {
            Paver p = new Paver(0, "Quadro", "Porous concrete paver", "Adbri Masonry", "400x400x40mm", true, 8.29, "Charcoal", "grey", "quadroCharcoal.jpg");
            Paver p1 = new Paver(0, "Quadro", "Porous concrete paver", "Adbri Masonry", "400x400x40mm", true, 8.29, "Oatmeal", "beige", "quadroOatmeal.jpg");
            Paver p2 = new Paver(0, "Bluestone Sawn", "Natural Bluestone", "SAI Stone", "800x400x20mm", false, 20.00, "BlueOcean", "grey", "BluestoneSawn800x400x20.jpg");
            Paver p3 = new Paver(0, "Classic Travertine", "Natural Travertine", "SAI Stone", "600x400x12mm", false, 21.00, "Classic", "beige", "travertine610x406x12.jpg");
            RetainingWall r = new RetainingWall(1, "Versa Wall", "400x200x220mm", "Splitface finish interlocking block", 10.00, 1200, true, "Oatmeal", "beige", "versaWallOatmeal.jpg");
            RetainingWall r1 = new RetainingWall(1, "Mini Wall", "182x182x125mm", "small stackable block", 4.00, 600, true, "oatmeal", "beige", "miniWallOatmeal.jpg");
            Pavers.Add(p);
            Pavers.Add(p1);
            Pavers.Add(p2);
            Pavers.Add(p3);
            RetainingWalls.Add(r);
            RetainingWalls.Add(r1);
            //SaveChanges();
        }

    }

}

